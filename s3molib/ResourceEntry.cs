using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace s3molib
{
    public class ResourceEntry
    {
        // From "s3pi Wrappers\TextResource\TextResources.txt"
        public static List<uint> TextTypes = new List<uint>()
        {
            0x024A0E52, // Spore UTF-8 with encoding bytes NameGeneration.package
            0x025C90A6, // Cascading Style Sheet
            0x025C95B6, // XML with encoding bytes -- <graph/>
            0x029E333B, // Audio controllers
            0x02C9EFF2, // Audio Submix
            0x024A0E52, // SimCity5 Config
            0x02FAC0B6, // Spore "Guide notes" from Text.package?
            0x0333406C, // XML with or without encoding bytes -- <base/> (with), various (without)
            0x03B33DDF, // XML without encoding bytes -- <base/>
            0x0604ABDA, // XML with encoding bytes -- <DreamTree/>
            0x0A98EAF0, // SimCity5 UI JavaScript Object
            0x1F886EAD, // Various configuration bits
            0x2B6CAB5F, // Spore Note in UI.package
            0x67771F5C, // SimCity5 UI JavaScript Object
            0x73E93EEB, // XML without encoding bytes -- <manifest/>
            0xA8D58BE5, // XML without encoding bytes -- <skills_store/>
            0xD4D9FBE5, // XML without encoding bytes -- <patternlist/>
            0xDD3223A7, // XML without encoding bytes -- <buff_store/>
            0xDD6233D6, // SimCity5 UI HTML
            0xE5105066, // ?
            0xE5105067, // XML without encoding bytes -- <RecipeMasterList_store/>
            0xE5105068, // ?
            0xF0FF5598 // Shortcut definitions
        };

        public Package Package { get; private set; }
        public uint Type { get; private set; }
        public uint Group { get; private set; }
        public uint ID1 { get; private set; }
        public uint ID2 { get; private set; }
        public ulong Instance { get; private set; }
        public uint ChunkOffset { get; private set; }
        public uint FileSize { get; private set; }
        public uint MemSize { get; private set; }
        public ushort Compressed { get; private set; }
        public ushort Unknown2 { get; private set; }
        public byte[] Data => (_data != null) ? _data : _data = Package.GetUncompressedData(this);
        private byte[] _data = null;

        public ResourceEntry(Package package, uint type, uint group, uint id1, uint id2, uint chunkOffset, uint fileSize, uint memSize, ushort compressed, ushort unknown2)
        {
            Package = package;
            Type = type;
            Group = group;
            ID1 = id1;
            ID2 = id2;
            Instance = (ulong)id1 << 32 | (ulong)id2;
            ChunkOffset = chunkOffset;
            FileSize = fileSize & 0x7fffffff;
            MemSize = memSize;
            Compressed = compressed;
            Unknown2 = unknown2;
        }

        public override string ToString()
        {
            return $"{Helper.UInt32ToHexString(Type)}-{Helper.UInt32ToHexString(Group)}-{Helper.UInt64ToHexString(Instance)}";
        }

        public string Decode()
        {
            string decoded = string.Empty;

            if (TextTypes.Contains(Type))
                decoded = Encoding.Default.GetString(Data);
            else if (Type == 0x0166038C)
                decoded = string.Join(Environment.NewLine, DecodeNameMap(this).Select(kvp => Helper.UInt64ToHexString(kvp.Key) + ": " + kvp.Value).ToArray());



            return decoded;
        }

        public static Dictionary<ulong, string> DecodeNameMap(ResourceEntry resourceEntry)
        {
            if (resourceEntry.Type != 0x0166038C)
                throw new Exception("Trying to decode non-NMAP resources.");

            Dictionary<ulong, string> nameMapLookup = new Dictionary<ulong, string>();

            MemoryStream stream = new MemoryStream(resourceEntry.Data);
            BinaryReader r = new BinaryReader(stream);

            r.ReadUInt32();
            uint count = r.ReadUInt32();

            for (int i = 0; i < count; i++)
            {
                ulong instance = r.ReadUInt64();
                uint charCount = r.ReadUInt32();
                string resourceName = Encoding.Default.GetString(r.ReadBytes((int)charCount));

                if (nameMapLookup.ContainsKey(instance))
                    nameMapLookup[instance] = resourceName;
                else
                    nameMapLookup.Add(instance, resourceName);
            }
            return nameMapLookup;
        }

    }
}
