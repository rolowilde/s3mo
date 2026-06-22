using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s3mo
{
    public static class Settings
    {
        public static void SetSettings(string key, object value)
        {
            if (_settings.ContainsKey(key))
                _settings[key] = value;
            else
                _settings.Add(key, value);
        }
        public static bool TryGetSettings(string key, out string obj)
        {
            obj = null!;
            if (_settings.TryGetValue(key, out object? o))
            {
                obj = o.ToString()!;
                return true;
            }
            return false;
        }
        private static Dictionary<string, object> _settings = new Dictionary<string, object>();

        public static void ReadSettings()
        {
            _settings.Clear();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "s3mo.ini");

            if (!File.Exists(path))
                return;


            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                int i = line.IndexOf('=');

                if (i < 0)
                    continue;

                _settings.Add(line.Substring(0, i), line.Substring(i + 1));
            }
        }

        public static void WriteSettings()
        {
            List<string> lines = new List<string>();

            foreach (var kvp in _settings)
                lines.Add(kvp.Key + "=" + kvp.Value);

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "s3mo.ini");
            File.WriteAllLines(path, lines);
        }
    }
}
