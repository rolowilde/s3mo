using System;
using System.Collections.Generic;
using System.IO;

namespace s3molib
{
    public class ProfileModel
    {
        private string _exePath;
        public List<ModModel> ModModels => new List<ModModel>(_modModelLookup.Values);

        public ModModel GetModModel(string modName) => _modModelLookup[modName];
        private Dictionary<string, ModModel> _modModelLookup = new Dictionary<string, ModModel>();

        public ProfileModel()
        {
            _exePath = AppDomain.CurrentDomain.BaseDirectory;
            string modFolderPath = Path.Combine(_exePath, "Mods");
            if (!Directory.Exists(modFolderPath))
                Directory.CreateDirectory(modFolderPath);

            string profileFolderPath = Path.Combine(_exePath, "Profiles");
            if (!Directory.Exists(profileFolderPath))
                Directory.CreateDirectory(profileFolderPath);

            string[] modsPaths = Directory.GetDirectories(modFolderPath);

            foreach (string path in modsPaths)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                _modModelLookup.Add(name, new ModModel(path));
            }
        }

        /// <summary>Read modlist.txt and populate modModelLookup based on the mod order, then save a new modlist.txt</summary>
        public void Setup(string profileName)
        {
            string profilePath = Path.Combine(_exePath, $"Profiles\\{profileName}");
            if (!Directory.Exists(profilePath))
                Directory.CreateDirectory(profilePath);

            FileStream stream = null;

            string modListPath = Path.Combine(_exePath, $"Profiles\\{profileName}\\modlist.txt");
            if (!File.Exists(modListPath))
                stream = File.Create(modListPath);
            else
                stream = new FileStream(modListPath, FileMode.Open, FileAccess.Read, FileShare.Read);

            StreamReader r = new StreamReader(stream);
            List<string> lines = new List<string>();

            while (!r.EndOfStream)
                lines.Add(r.ReadLine());

            r.Close();
            stream.Close();

            List<string> remainingMods = new List<string>(_modModelLookup.Keys);
            int i = 0;

            foreach (string line in lines)
            {
                string modName = line.Substring(1);

                if (!remainingMods.Contains(modName))
                    continue;

                bool enabled = line.Substring(0, 1).Equals("+") ? true : false;
                _modModelLookup[modName].Update(modName, enabled, i++);
                remainingMods.Remove(modName);
            }

            foreach (string remainingMod in remainingMods)
                _modModelLookup[remainingMod].Update(remainingMod, false, i++);

            Save(profileName);
        }

        public void CheckModModelConflicts() => ModModel.FastCheckConflict(this);

        public void CheckPackageConflicts()
        {
            foreach (ModModel modModel in _modModelLookup.Values)
                PackageModel.CheckConflictsInModModel(modModel);
        }

        public void CheckDetailedConflicts()
        {
            List<ModModel> conflictingModModels = new List<ModModel>(_modModelLookup.Values).FindAll(m => m.ConflictingModModels.Count > 0);
            conflictingModModels.Sort(new ModModelComparer(ModModelComparer.SortBy.Priority));

            for (int i = 0; i < conflictingModModels.Count - 1; i++)
            {
                ModModel modModel = conflictingModModels[i];

                for (int j = i + 1; j < conflictingModModels.Count; j++)
                {
                    ModModel otherModModel = conflictingModModels[j];
                    modModel.CheckConflicts(otherModModel);
                }
            }
        }

        public void Save(string profileName)
        {
            string profilePath = Path.Combine(_exePath, $"Profiles\\{profileName}");
            if (!Directory.Exists(profilePath))
                Directory.CreateDirectory(profilePath);

            FileStream stream = null;

            string modListPath = Path.Combine(_exePath, $"Profiles\\{profileName}\\modlist.txt");
            stream = new FileStream(modListPath, FileMode.Create, FileAccess.Write, FileShare.None);

            StreamWriter w = new StreamWriter(stream);
            List<ModModel> allModModels = new List<ModModel>(_modModelLookup.Values);
            allModModels.Sort(new ModModelComparer(ModModelComparer.SortBy.Priority));

            foreach (ModModel mod in allModModels)
                w.WriteLine((mod.Enabled ? "+" : "-") + mod.Name);

            w.Close();
            stream.Close();
        }

        public void RenameMod(string oldName, string newName)
        {
            if (oldName.Equals(newName))
                return;

            ModModel mod = _modModelLookup[oldName];
            mod.Update(newName, mod.Enabled, mod.Priority);

            string modsFolderPath = Path.Combine(_exePath, "Mods");
            Directory.Move(Path.Combine(modsFolderPath, oldName), Path.Combine(modsFolderPath, newName));

            _modModelLookup.Remove(oldName);
            _modModelLookup.Add(newName, mod);

            string profilesFolderPath = Path.Combine(_exePath, "Profiles");
            string[] profiles = Directory.GetDirectories(profilesFolderPath);

            foreach (string path in profiles)
            {
                string modListPath = Path.Combine(path, "modlist.txt");

                if (!File.Exists(modListPath))
                    continue;

                string[] lines = File.ReadAllLines(modListPath);

                int i = Array.FindIndex(lines, l => l.Substring(1).Equals(oldName));
                lines[i] = lines[i].Substring(0, 1) + newName;

                File.WriteAllLines(modListPath, lines);
            }
        }

        public string CreateEmptyMod()
        {
            string path = Path.Combine(_exePath, $"Mods\\New Mod");
            if (Directory.Exists(path))
            {
                int i = 1;
                while (Directory.Exists(Path.Combine(_exePath, $"Mods\\New Mod ({i})"))) { i++; }
                path = Path.Combine(_exePath, $"Mods\\New Mod ({i})");
            }
            Directory.CreateDirectory(path);
            string modName = Path.GetFileName(path);

            ModModel modModel = new ModModel(path);
            modModel.Update(modName, false, _modModelLookup.Count);
            _modModelLookup.Add(modName, modModel);
            return modName;
        }

        public void DeleteMod(string modName)
        {
            ModModel modModel = _modModelLookup[modName];
            Directory.Delete(modModel.FolderPath, true);

            _modModelLookup.Remove(modName);
        }

    }
}
