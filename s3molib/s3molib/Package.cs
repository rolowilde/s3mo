using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3molib
{
    public class Package
    {
        private const uint Magic = 1179664964; // 0x46504244 FPBD
        private const uint Major = 2;
        private const uint Minor = 0;
        private const uint IndexVersion = 3;

        public string FilePath { get; private set; }
        public void ChangePath(string path) => FilePath = path;
        public uint IndexCount { get; private set; }
        public uint IndexLength { get; private set; }
        public uint IndexPosition { get; private set; }


        /// <summary> Read-only. Returns a cloned list of the actual list. Adding or removing items to this will not do anything.</summary>
        public List<ResourceEntry> ResourceEntries => new List<ResourceEntry>(_resourceEntries);
        private List<ResourceEntry> _resourceEntries = new List<ResourceEntry>();


        /// <summary>Create a new blank package at path</summary>
        /// <param name="writeExtra">Write some extra bytes so s3pe can open the file.</param>
        public static Package New(string path, bool writeExtra = false)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));

            if (Path.GetFileName(path) == "")
                throw new Exception("Need filename to create file");

            if (Path.GetExtension(path) != ".package")
                Path.ChangeExtension(path, ".package");

            //Logger.Log($"Creating new package '{Path.GetFileName(path)}' at {Path.GetDirectoryName(path)}");

            FileStream stream = new FileStream(path, FileMode.Create);
            BinaryWriter w = new BinaryWriter(stream);

            w.Write(Magic);
            w.Write(Major);
            w.Write(Minor);
            stream.Position = 60; // 0x3C
            w.Write(IndexVersion);
            w.Write(96); // 0x60
            w.Write(new byte[28]);

            Package package = null;

            if (writeExtra) // Exactly same file as blank package generated from s3pe
            {
                w.Write(7);
                w.Write(new byte[12]);
                stream.Position = 44; // 0x2C
                w.Write(16);
                package = new Package(path, 0, 16, 96);
            }
            else
                package = new Package(path, 0, 0, 96);

            w.Flush();
            stream.Close();
            return package;
        }

        /// <summary>Load the package at path</summary>
        public static Package Load(string path)
        {
            if (!File.Exists(path))
                throw new Exception($"File does not exists - {path}");
            if (Path.GetExtension(path) != ".package")
                throw new Exception($"File is not a package file - {path}");
            if (new FileInfo(path).Length < 96)
                throw new Exception($"File header size is smaller than '96' bytes - {path}");

            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryReader r = new BinaryReader(stream);

            List<byte> unknown = new List<byte>();
            uint magic = r.ReadUInt32();
            uint major = r.ReadUInt32();
            uint minor = r.ReadUInt32();
            unknown.AddRange(r.ReadBytes(24));
            uint indexCount = r.ReadUInt32();
            unknown.AddRange(r.ReadBytes(4));
            uint indexLength = r.ReadUInt32();
            unknown.AddRange(r.ReadBytes(12));
            uint indexVersion = r.ReadUInt32();
            uint indexPosition = r.ReadUInt32();
            unknown.AddRange(r.ReadBytes(28));

            if (magic != Magic)
                throw new Exception($"File magic does not match DBPF - {path}");
            if (major != Major)
                Logger.LogWarning($"File major '{major}' does not match '${Major}' - {path}");
            if (minor != Minor)
                Logger.LogWarning($"File minor '{minor}' does not match $'{Minor}' - {path}");
            if (indexVersion != IndexVersion)
                Logger.LogWarning($"File index version '{indexVersion}' does not match '{IndexVersion}' - {path}");
            if (indexPosition == 0)
                Logger.LogWarning($"File does not have index position - {path}");

            foreach (byte b in unknown)
                if (b != 0)
                    Logger.LogWarning($"File contains non-zero unused byte(s) - {path}");

            stream.Position = indexPosition;
            uint bitFlag = r.ReadUInt32(); // bitflag used to indicate common entries, reducing entries for each resources

            int commonCount = 0;

            if ((bitFlag & 0x01) != 0) // 0001 - Type
                commonCount += 1;
            if ((bitFlag & 0x02) != 0) // 0010 - Group
                commonCount += 1;
            if ((bitFlag & 0x04) != 0) // 0100 - First half of Instance ID
                commonCount += 1;
            if ((bitFlag & 0x08) != 0) // 1000 - ?? Probably second half of Instance ID
                commonCount += 1;

            if (indexLength != (4 + commonCount * 4 + ((32 - commonCount * 4) * indexCount)))
                throw new Exception($"File index length '{indexLength}' does not match expected value of '{4 + commonCount * 4 + ((32 - commonCount * 4) * indexCount)}' - {path}");

            uint[] common = new uint[commonCount];

            for (int i = 0; i < commonCount; i++)
                common[i] = r.ReadUInt32();

            int c = 0;
            Package package = new Package(path, indexCount, indexLength, indexPosition);

            for (int i = 0; i < indexCount; i++)
            {
                uint type = (bitFlag & 0x01) != 0 ? common[c++] : r.ReadUInt32();
                uint group = (bitFlag & 0x02) != 0 ? common[c++] : r.ReadUInt32();
                uint id1 = (bitFlag & 0x04) != 0 ? common[c++] : r.ReadUInt32();
                uint id2 = r.ReadUInt32();
                uint chunkOffset = r.ReadUInt32();
                uint fileSize = r.ReadUInt32();
                uint memSize = r.ReadUInt32();
                ushort compressed = r.ReadUInt16();
                ushort unknown2 = r.ReadUInt16();

                c = 0;
                package._resourceEntries.Add(new ResourceEntry(package, type, group, id1, id2, chunkOffset, fileSize, memSize, compressed, unknown2));
            }

            stream.Close();
            return package;
        }

        /// <summary>Merge source packages into one package, or more if the package exceeds the file size limit, and save them at the directory path.</summary>
        /// <returns>True if successful. False if failed.</returns>
        public static bool Merge(string directoryPath, IEnumerable<Package> source, uint fileSizeLimit = 1000000000, Action<int> progress = null)
        {
            if (File.Exists(directoryPath))
                directoryPath = Path.GetDirectoryName(directoryPath);

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            int mergedCount = 1;
            Package package = Package.New(Path.Combine(directoryPath, $"Merge{mergedCount++}.package"));
            HashSet<string> resourceKeys = new HashSet<string>();

            FileStream stream = new FileStream(package.FilePath, FileMode.Open, FileAccess.Write, FileShare.Read);
            BinaryWriter w = new BinaryWriter(stream);
            stream.Position = package.IndexPosition;

            for (int i = source.Count() - 1; i >= 0; i--)
            {
                Package importPackage = source.ElementAt(i);
                progress?.Invoke(i);
                //Logger.Log($"Merging {Path.GetFileName(importPackage.FilePath)} into {Path.GetFileName(package.FilePath)}.");
                foreach (ResourceEntry re in importPackage.ResourceEntries)
                {
                    if (!resourceKeys.Add(re.ToString()) || re.Type == 0x73e93eeb || re.Type == 0x0166038c) // 0x73e93eeb: sims3pack manifest, 0x0166038c: namemap
                        continue;

                    if (stream.Position >= fileSizeLimit)
                    {
                        package.IndexPosition = (uint)stream.Position;
                        package.WriteIndex(w);
                        package.WriteHeader(stream, w);
                        w.Flush();
                        stream.Close();

                        package = Package.New(Path.Combine(directoryPath, $"Merge{mergedCount++}.package"));
                        stream = new FileStream(package.FilePath, FileMode.Open, FileAccess.Write, FileShare.None);
                        w = new BinaryWriter(stream);
                        stream.Position = package.IndexPosition;
                    }

                    byte[] data = importPackage.GetRawData(re);
                    if (data == null)
                        throw new Exception($"Unable to obtain data from {Path.GetFileName(importPackage.FilePath)}");

                    package._resourceEntries.Add(new ResourceEntry(importPackage, re.Type, re.Group, re.ID1, re.ID2, (uint)stream.Position, re.FileSize, re.MemSize, re.Compressed, re.Unknown2));
                    w.Write(data, 0, (int)re.FileSize);
                }
            }

            package.IndexPosition = (uint)stream.Position;
            package.WriteIndex(w);
            package.WriteHeader(stream, w);
            w.Close();
            stream.Close();

            //Logger.Log("Merge Process finished");
            return true;
        }

        private void WriteIndex(BinaryWriter writer)
        {
            writer.Write(0);

            foreach (var r in _resourceEntries)
            {
                writer.Write(r.Type);
                writer.Write(r.Group);
                writer.Write(r.ID1);
                writer.Write(r.ID2);
                writer.Write(r.ChunkOffset);
                writer.Write(r.FileSize | 0x80000000);
                writer.Write(r.MemSize);
                writer.Write(r.Compressed);
                writer.Write(r.Unknown2);
            }
        }

        private void WriteHeader(FileStream stream, BinaryWriter writer)
        {
            IndexCount = (uint)_resourceEntries.Count;
            IndexLength = 4 + IndexCount * 32;

            stream.Position = 36; // 0x24
            writer.Write(IndexCount);
            stream.Position = 44; // 0x2C
            writer.Write(IndexLength);
            stream.Position = 64; // 0x40
            writer.Write(IndexPosition);
        }

        public byte[] GetRawData(ResourceEntry resourceEntry)
        {
            if (!File.Exists(FilePath))
                throw new Exception($"File does not exist anymore since the last time it was opened - {FilePath}");
            if (!_resourceEntries.Contains(resourceEntry))
                throw new Exception($"File does not contain resource entry the last time it was opened, try call Package.Open() again'{resourceEntry}' - {FilePath}");

            int offset = (int)resourceEntry.ChunkOffset;
            int length = (int)resourceEntry.FileSize;

            byte[] data = new byte[length];

            using (FileStream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                stream.Position = offset;
                stream.Read(data, 0, data.Length);
                return data;
            }
        }

        public byte[] GetUncompressedData(ResourceEntry resourceEntry)
        {
            byte[] data = GetRawData(resourceEntry);

            if (resourceEntry.FileSize != resourceEntry.MemSize)
            {
                MemoryStream stream = new MemoryStream(data);
                data = s3pi.Package.Compression.UncompressStream(stream, (int)resourceEntry.FileSize, (int)resourceEntry.MemSize);
                stream.Close();
            }
            return data;
        }

        private Package(string path, uint indexCount, uint indexLength, uint indexPosition)
        {
            IndexCount = indexCount;
            IndexLength = indexLength;
            IndexPosition = indexPosition;
            FilePath = path;
        }

        /// <param name="ownResourceEntry">Resource entry that belongs to this package.</param>
        public bool HasConflictingResourceEntry(ResourceEntry resourceEntry, out ResourceEntry ownResourceEntry) =>
            (ownResourceEntry = _resourceEntries.Find(r =>
                r.Type.Equals(resourceEntry.Type) &&
                r.Group.Equals(resourceEntry.Group) &&
                r.Instance.Equals(resourceEntry.Instance))) != null;


        public bool AddResourceEntry(ResourceEntry resourceEntry, bool replaceConflicting = true)
        {
            if (HasConflictingResourceEntry(resourceEntry, out ResourceEntry ownResourceEntry))
            {
                if (replaceConflicting)
                {
                    Logger.LogDebug($"Conflicting resouce key '{resourceEntry.ToString()}', it will be replaced by the latter. '{Path.GetFileName(FilePath)}'    '{Path.GetFileName(resourceEntry.Package.FilePath)}'");
                    _resourceEntries.Remove(ownResourceEntry);
                }
                else
                {
                    Logger.LogDebug($"Conflicting resouce key '{resourceEntry.ToString()}', the latter will be rejected. '{Path.GetFileName(FilePath)}'    '{Path.GetFileName(resourceEntry.Package.FilePath)}'");
                    return false;
                }
            }
            _resourceEntries.Add(resourceEntry);
            return true;
        }

        public bool RemoveResourceEntry(ResourceEntry resourceEntry)
        {
            if (_resourceEntries.Remove(resourceEntry))
                return true;

            Logger.LogDebug($"Package does not contain resource entry - {FilePath}");
            return false;
        }

        /// <summary>Checks for conflicts with other package.</summary>
        /// <returns>True if conflicting. False if not conflicting.</returns>
        /// <param name="conflictedOtherResourceEntries">Resource entries from packages that conflict with this instance.</param>> 
        /// <param name="fastCheck">Returns true directly immediately after a conflict is found</param>
        public bool IsConflictingWith(Package package, out List<ResourceEntry> conflictedResourceEntries, out List<ResourceEntry> conflictedOtherResourceEntries, bool fastCheck = false)
        {
            conflictedResourceEntries = new List<ResourceEntry>();
            conflictedOtherResourceEntries = new List<ResourceEntry>();
            foreach (var otherR in package.ResourceEntries)
            {
                if (HasConflictingResourceEntry(otherR, out ResourceEntry ownR) && ownR.Type != 0x0166038C && ownR.Type != 0x73E93EEB)
                {
                    if (fastCheck)
                        return true;

                    conflictedResourceEntries.Add(ownR);
                    conflictedOtherResourceEntries.Add(otherR);
                    //Logger.LogDebug($"Conflict '{ownR.ToString()}'    '{Path.GetFileName(FilePath)}'    '{Path.GetFileName(package.FilePath)}'");
                }
            }
            return (conflictedOtherResourceEntries.Count > 0);
        }

    }
}