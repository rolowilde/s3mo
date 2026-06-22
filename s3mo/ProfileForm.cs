using s3molib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s3mo
{
    public partial class ProfileForm : Form
    {
        private string _currentProfile;
        Dictionary<string, string> _profileLookUp = new Dictionary<string, string>();

        public ProfileForm(string currentProfile)
        {
            _currentProfile = currentProfile;
            InitializeComponent();
        }


        private void ProfileForm_Load(object sender, EventArgs e)
        {
            string profileFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Profiles");
            string[] profilePaths = Directory.GetDirectories(profileFolderPath);

            foreach (string path in profilePaths)
            {
                string name = Path.GetFileName(path);
                _profileLookUp.Add(name, path);
                listBox.Items.Add(name);
            }

            if (!_profileLookUp.ContainsKey(_currentProfile))
            {
                string currentProfilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Profiles\\{_currentProfile}");
                try
                { Directory.CreateDirectory(currentProfilePath); }
                catch (Exception ex)
                {
                    MessageBox.Show($"Current profile {_currentProfile} doesn't exists in profiles folder and couldn't create new directory for it - {ex.Message}",
                    "Error creating directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                _profileLookUp.Add(_currentProfile, currentProfilePath);
                listBox.Items.Add(_currentProfile);
            }

        }

        private string PromptEnterProfileName()
        {
            string newProfile = null!;
            TextBoxForm form = new TextBoxForm("Enter profile name:", (s) =>
            {
                if (!Helper.CheckValidFolderName(s))
                {
                    MessageBox.Show("Invalid folder name.");
                    return false;
                }
                if (_profileLookUp.ContainsKey(s))
                {
                    MessageBox.Show("Profile already existed.");
                    return false;
                }

                string newPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Profiles\\{s}");

                if (Directory.Exists(newPath))
                {
                    MessageBox.Show("Profile folder already existed."); // This should never happens
                    return false;
                }

                try
                {
                    Directory.CreateDirectory(newPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Couldn't create directory.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                listBox.Items.Add(s);
                _profileLookUp.Add(s, newPath);
                newProfile = s;

                return true;
            });

            this.Enabled = false;
            form.FormClosed += (s, e) => this.Enabled = true;
            form.ShowDialog();
            return newProfile;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            PromptEnterProfileName();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
                return;

            string selected = listBox.SelectedItem.ToString()!;

            if (selected.Equals(_currentProfile))
            {
                MessageBox.Show("Please switch to another profile before removing this profile.");
                return;
            }

            DialogResult r = MessageBox.Show($"Delete {selected} permanently?", "Delete profile", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.No)
                return;

            try
            {
                Directory.Delete(_profileLookUp[selected], true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not delete folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _profileLookUp.Remove(selected);
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
                return;

            string newProfile = PromptEnterProfileName();

            if (newProfile == null)
                return;

            string selected = listBox.SelectedItem.ToString()!;
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string sourceModListPath = Path.Combine(exePath, $"Profiles\\{selected}\\modlist.txt");
            string newModlistPath = Path.Combine(exePath, $"Profiles\\{newProfile}\\modlist.txt");

            try
            {
                File.Copy(sourceModListPath, newModlistPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not copy 'modlist.txt'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
