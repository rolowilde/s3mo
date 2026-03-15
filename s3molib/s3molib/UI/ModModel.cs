using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ns;

namespace s3molib
{
    public class ModModel
    {
        public string FolderPath { get; private set; }
        public string Name { get; private set; }
        public bool Enabled { get; private set; }
        public int Priority { get; private set; }

        public List<PackageModel> PackageModels => new List<PackageModel>(_packageModelLookup.Values);

        public bool TryGetPackageModel(string name, out PackageModel packageModel) => _packageModelLookup.TryGetValue(name, out packageModel);
        private Dictionary<string, PackageModel> _packageModelLookup = new Dictionary<string, PackageModel>();

        public List<ModModel> ConflictingModModels => new List<ModModel>(_conflictingModModels);
        private HashSet<ModModel> _conflictingModModels = new HashSet<ModModel>();

        public ModModel(string path)
        {
            FolderPath = path;
            Name = Path.GetFileName(path);

            string[] files = Directory.GetFiles(path, "*.package");

            foreach (string filePath in files)
            {
                PackageModel packageModel = new PackageModel(this, filePath);
                _packageModelLookup.Add(packageModel.Name, packageModel);
            }
        }

        public void Update(string name, bool enabled, int priority)
        {
            if (!Name.Equals(name))
            {
                FolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Mods\\{name}");

                foreach (PackageModel packageModel in _packageModelLookup.Values)
                    packageModel.Update(Path.Combine(FolderPath, $"{packageModel.Name}"));
            }

            Name = name;
            Enabled = enabled;
            Priority = priority;
        }

        public static void FastCheckConflict(ProfileModel profileModel)
        {
            List<ModModel> modModels = profileModel.ModModels;
            modModels.Sort(new ModModelComparer(ModModelComparer.SortBy.Priority));

            for (int i = 0; i < modModels.Count - 1; i++)
            {
                ModModel modModel = modModels[i];

                for (int j = i + 1; j < modModels.Count; j++)
                {
                    ModModel otherModModel = modModels[j];

                    if (PackageModel.FastCheckConflict(modModel, otherModModel))
                    {
                        modModel._conflictingModModels.Add(otherModModel);
                        otherModModel._conflictingModModels.Add(modModel);
                        continue;
                    }
                }
            }
        }

        public void CheckConflicts(ModModel otherModModel)
        {
            foreach (PackageModel packageModel in this._packageModelLookup.Values)
            {
                foreach (PackageModel otherPackageModel in otherModModel._packageModelLookup.Values)
                {
                    packageModel.CheckConflicts(otherPackageModel);
                }
            }
        }

    }

    public class ModModelComparer : IComparer<ModModel>
    {
        public enum SortBy
        {
            Name,
            Priority
        }

        private SortBy _mode = SortBy.Priority;

        public ModModelComparer(SortBy mode)
        {
            _mode = mode;
        }

        public int Compare(ModModel x, ModModel y)
        {
            switch (_mode)
            {
                case SortBy.Name:
                    return x.Name.CompareTo(y.Name);

                case SortBy.Priority:
                    return x.Priority.CompareTo(y.Priority);

                default:
                    return x.Priority.CompareTo(y.Priority);
            }
        }
    }
}
