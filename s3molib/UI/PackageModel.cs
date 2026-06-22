using System;
using System.Collections.Generic;
using System.IO;
using ns;

namespace s3molib
{
    public class PackageModel
    {
        /// <summary>Parent ModModel that owns this PackageModel</summary>
        public ModModel ModModel { get; private set; }
        public string FilePath { get; private set; }
        public string Name { get; private set; }
        public byte[] HashBytes { get; private set; }
        public void SetHash(byte[] hashBytes) => HashBytes = hashBytes;
        public Package Package
        {
            get
            {
                if (_package == null)
                {
                    if (!File.Exists(FilePath))
                        throw new Exception($"{Name} is not found in path {Path.GetDirectoryName(FilePath)}.");
                    _package = Package.Load(FilePath);
                }
                return _package;
            }
        }
        private Package _package = null;

        public List<PackageModel> ConflictingPackageModelsInModModel => new List<PackageModel>(_conflictingPackageModelsInModModel);
        private HashSet<PackageModel> _conflictingPackageModelsInModModel = new HashSet<PackageModel>();

        public List<string> GetConflictingResources() => new List<string>(_resourceOtherPackageModelsLookup.Keys);
        public List<PackageModel> GetConflictingPackageModelsByResource(string key) => _resourceOtherPackageModelsLookup[key];
        private Dictionary<string, List<PackageModel>> _resourceOtherPackageModelsLookup = new Dictionary<string, List<PackageModel>>();

        public PackageModel(ModModel modModel, string path)
        {
            ModModel = modModel;
            FilePath = path;
            Name = Path.GetFileName(path);
        }

        public void Update(string path)
        {
            FilePath = path;
            Name = Path.GetFileName(path);
            _package = null;
        }

        public static bool FastCheckConflict(ModModel modModel1, ModModel modModel2)
        {
            foreach (PackageModel packageModel in modModel1.PackageModels)
            {
                foreach (PackageModel otherPackageModel in modModel2.PackageModels)
                {
                    if (packageModel.Package.IsConflictingWith(otherPackageModel.Package, out _, out _, true))
                        return true;
                }
            }
            return false;
        }

        public static void CheckConflictsInModModel(ModModel modModel)
        {
            List<PackageModel> packageModels = modModel.PackageModels;
            packageModels.ForEach(p => p._conflictingPackageModelsInModModel.Clear());

            for (int i = 0; i < packageModels.Count - 1; i++)
            {
                PackageModel packageModel = packageModels[i];

                for (int j = i + 1; j < packageModels.Count; j++)
                {
                    PackageModel otherPackageModel = packageModels[j];

                    if (packageModel.Package.IsConflictingWith(otherPackageModel.Package, out _, out _, true))
                    {
                        packageModel._conflictingPackageModelsInModModel.Add(otherPackageModel);
                        otherPackageModel._conflictingPackageModelsInModModel.Add(packageModel);
                    }
                }
            }
        }

        public void CheckConflicts(PackageModel otherPackageModel)
        {
            // Might want to find a way to clear the dictionary before, if there's any bugs.
            // But shouldn't need to since refresh button creates new models and recalculate everything and this is just disposed.

            if (this.Package.IsConflictingWith(otherPackageModel.Package, out List<ResourceEntry> conflictingResourceEntries, out _, false))
            {
                foreach (ResourceEntry resourceEntry in conflictingResourceEntries)
                {
                    string resource = resourceEntry.ToString();

                    if (!this._resourceOtherPackageModelsLookup.ContainsKey(resource))
                        this._resourceOtherPackageModelsLookup.Add(resource, new List<PackageModel>() { otherPackageModel });
                    else
                        this._resourceOtherPackageModelsLookup[resource].Add(otherPackageModel);

                    if (!otherPackageModel._resourceOtherPackageModelsLookup.ContainsKey(resource))
                        otherPackageModel._resourceOtherPackageModelsLookup.Add(resource, new List<PackageModel>() { this });
                    else
                        otherPackageModel._resourceOtherPackageModelsLookup[resource].Add(this);
                }
            }
        }

    }
}
