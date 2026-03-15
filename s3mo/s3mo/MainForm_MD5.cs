using ns;
using s3molib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace s3mo
{
    partial class MainForm
    {
        private List<string> _modBuildInorderedHashStrings = new List<string>();
        private List<string> _modBuildOrderedHashStrings = new List<string>();

        private bool md5BackgroundWorker_restart = false;
        private bool validateBackgroundWorker_restart = false;

        private void ComputeMD5()
        {
            if (md5BackgroundWorker.IsBusy)
            {
                md5BackgroundWorker.CancelAsync();
                md5BackgroundWorker_restart = true;
            }
            else
                md5BackgroundWorker.RunWorkerAsync(_profileModel);
        }

        private void md5BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ComputeMergedBuildMD5();

            ProfileModel profileModel = (ProfileModel)e.Argument!;
            List<ModModel> modModels = profileModel.ModModels;
            modModels.Sort((m1, m2) => m1.Priority.CompareTo(m2.Priority));

            MD5 md5 = MD5.Create();

            foreach (ModModel modModel in modModels)
            {
                List<PackageModel> packageModels = modModel.PackageModels;
                packageModels.Sort((p1, p2) => StringLogicalComparer.Compare(p1.Name, p2.Name));

                foreach (PackageModel packageModel in packageModels)
                {
                    byte[] hashBytes;

                    try
                    {
                        using (FileStream fs = new FileStream(packageModel.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                            hashBytes = md5.ComputeHash(fs);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, $"Couldn't open {Path.GetFileNameWithoutExtension(packageModel.FilePath)} to compute hash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    packageModel.SetHash(hashBytes);
                }
            }
        }

        private void ComputeMergedBuildMD5()
        {
            _modBuildInorderedHashStrings.Clear();
            _modBuildOrderedHashStrings.Clear();

            if (!Settings.TryGetSettings("DocumentsFolderPath", out string sims3DocumentFolderPath))
                return;

            string packagesBinPath = Path.Combine(sims3DocumentFolderPath, "Mods\\ModBuilds\\Merge.bin");

            if (!File.Exists(packagesBinPath))
                return;

            FileStream stream = new FileStream(packagesBinPath, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader r = new BinaryReader(stream);

            while (stream.Position != stream.Length)
            {
                bool ordered = r.ReadBoolean();

                if (ordered)
                    _modBuildOrderedHashStrings.Add(Encoding.UTF8.GetString(r.ReadBytes(16)));
                else
                    _modBuildInorderedHashStrings.Add(Encoding.UTF8.GetString(r.ReadBytes(16)));
            }

            r.Close();
            stream.Close();

            return;
        }

        private void md5BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (md5BackgroundWorker_restart)
            {
                md5BackgroundWorker_restart = false;
                md5BackgroundWorker.RunWorkerAsync(_profileModel);
            }
            else
            {
                Logger.Log("Finished computing MD5.");
                ValidateModBuild();
            }
        }



        private void ValidateModBuild()
        {
            if (md5BackgroundWorker.IsBusy)
                return;

            if (validateBackgroundWorker.IsBusy)
            {
                validateBackgroundWorker.CancelAsync();
                validateBackgroundWorker_restart = true;
            }
            else
                validateBackgroundWorker.RunWorkerAsync(_profileModel);
        }

        private void validateBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_modBuildInorderedHashStrings.Count == 0 && _modBuildOrderedHashStrings.Count == 0)
            {
                e.Result = false;
                return;
            }

            ProfileModel profileModel = (ProfileModel)e.Argument!;
            List<ModModel> modModels = profileModel.ModModels.FindAll(m => m.Enabled);
            modModels.Sort((m1, m2) => m1.Priority.CompareTo(m2.Priority));
            List<string> modHashBytes = new List<string>();

            int j = 0;
            foreach (ModModel modModel in modModels)
            {
                List<PackageModel> packageModels = modModel.PackageModels;
                packageModels.Sort((p1, p2) => StringLogicalComparer.Compare(p1.Name, p2.Name));

                foreach (PackageModel packageModel in packageModels)
                {
                    if (packageModel.HashBytes == null)
                    {
                        e.Result = false;
                        return;
                    }
                    modHashBytes.Add(Encoding.UTF8.GetString(packageModel.HashBytes));
                    j++;
                }
            }

            if (modHashBytes.Count != _modBuildInorderedHashStrings.Count + _modBuildOrderedHashStrings.Count)
            {
                e.Result = false;
                return;
            }

            foreach (string inorderedHashString in _modBuildInorderedHashStrings)
            {
                if (modHashBytes.Contains(inorderedHashString)) // todo Speed can be improved
                    modHashBytes.Remove(inorderedHashString);
                else
                {
                    e.Result = false;
                    return;
                }
            }

            for (int i = 0; i < _modBuildOrderedHashStrings.Count; i++)
            {
                if (_modBuildOrderedHashStrings[i].Equals(modHashBytes[i]))
                    continue;


                e.Result = false;
                return;
            }
            e.Result = true;
        }

        private void validateBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (validateBackgroundWorker_restart)
            {
                validateBackgroundWorker_restart = false;
                validateBackgroundWorker.RunWorkerAsync(_profileModel);
            }
            else
            {
                bool result = (bool)e.Result!;

                if (!result)
                    warningButton.Enabled = true;
                else
                    warningButton.Enabled = false;

                //Logger.Log($"Merged build match = {result.ToString()}");
            }
        }

    }
}
