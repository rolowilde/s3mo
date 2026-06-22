using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace s3molib
{
    public class Sims3Pack
    {
        public static bool Unpack(string path, string targetDirectoryPath)
        {
            if (!File.Exists(path))
                throw new Exception($"Sims3Pack file does not exists at {path}");

            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(stream);

            stream.Position = 4;
            string Magic = new String(r.ReadChars(7));
            if (!Magic.Equals("TS3Pack"))
                throw new Exception($"File is not a Sims3Pack. - {path}");

            stream.Position = 13;
            int xmlLength = r.ReadInt32();
            string xml = Encoding.UTF8.GetString(r.ReadBytes(xmlLength));

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml);
            string packName = xmlDocument.SelectSingleNode("/Sims3Package/DisplayName").InnerText;
            List<PackagedFile> packagedFiles = new List<PackagedFile>();

            foreach (XmlNode packaged in xmlDocument.SelectNodes("/Sims3Package/PackagedFile"))
            {
                PackagedFile packagedFile = new PackagedFile();

                foreach (XmlNode content in packaged)
                {
                    if (content.Name == "Name")
                        packagedFile.SetName(content.InnerText);
                    else if (content.Name == "Length")
                        packagedFile.SetLength(Int32.Parse(content.InnerText));
                    else if (content.Name == "Offset")
                        packagedFile.SetOffset(Int64.Parse(content.InnerText));
                }
                packagedFiles.Add(packagedFile);
            }

            if (!Directory.Exists(targetDirectoryPath))
            {
                try
                { Directory.CreateDirectory(targetDirectoryPath); }
                catch (Exception ex)
                { throw new Exception(ex.Message); }
            }

            long xmlOffset = 0x11 + xmlLength;

            foreach (PackagedFile packagedFile in packagedFiles)
            {
                Logger.Log($"Unpacking {Path.GetFileName(path)}: {packagedFile.Name}");
                stream.Position = xmlOffset + packagedFile.Offset;
                byte[] packageData = r.ReadBytes((int)packagedFile.Length);
                File.WriteAllBytes(Path.Combine(targetDirectoryPath, packagedFile.Name), packageData);
            }

            return true;
        }

    }
}
