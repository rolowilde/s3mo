using System;
using System.Collections.Generic;
using System.IO;

namespace s3molib
{
    public static class Ini
    {
        /// <summary>Read the entire ini file from path and provides dictionary of key and values.</summary>
        /// <returns>True if successful. False otherwise.</returns>
        public static bool Read(string path, out Dictionary<string, string> keyValues)
        {
            keyValues = new Dictionary<string, string>();

            if (!File.Exists(path))
            {
                Logger.LogError($"File not found at {path}");
                keyValues = null;
                return false;
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                int e = line.IndexOf('=');

                if (e < 0)
                    continue;

                keyValues.Add(line.Substring(0, e), line.Substring(e + 1));
            }

            return true;
        }

        /// <summary>Try to find a value in ini file from path with the provided key.</summary>
        /// <returns>True if value is found. False otherwise.</returns>
        //public static bool Read(string path, string key, out string value)
        //{
        //    value = null;
        //    return Read(path, out var kvp) ? kvp.TryGetValue(key, out value) : false;
        //}

        /// <summary>Writes a list of keys and values into an ini file in path.</summary>
        /// <returns>True if successful. False otherwise.</returns>
        public static bool Write(string path, List<KeyValuePair<string, string>> keyValues)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                try
                { Directory.CreateDirectory(Path.GetDirectoryName(path)); }
                catch (Exception ex)
                { Logger.LogError(ex.ToString()); return false; }
            }

            string[] existingLines = new string[0];

            if (File.Exists(path))
                existingLines = File.ReadAllLines(path);

            StreamWriter w = new StreamWriter(path);

            if (existingLines.Length > 0)
            {
                foreach (string line in existingLines)
                {
                    int e = line.IndexOf('=');

                    if (e < 0)
                        continue;

                    if (!line.Substring(0, e).Equals(keyValues[0].Key))
                        continue;

                    w.WriteLine($"{keyValues[0].Key}={keyValues[0].Value}");
                    keyValues.Remove(keyValues[0]);
                }
            }

            foreach (var kvp in keyValues)
                w.WriteLine($"{kvp.Key}={kvp.Value}");

            w.Close();
            w.BaseStream.Close();
            return true;
        }

        /// <summary>Write a key and value into an ini file in path.</summary>
        /// <returns>True if successful. False otherwise.</returns>
        //public static bool Write(string path, string key, string value) => Write(path, new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>(key, value) });
    }
}
