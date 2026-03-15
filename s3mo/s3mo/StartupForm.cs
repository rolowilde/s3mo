using Microsoft.Win32;
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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            string? gamePath = GetGamePath("SOFTWARE\\WOW6432Node\\Sims\\The Sims 3");

            if (gamePath == null)
                gamePath = GetGamePath("SOFTWARE\\WOW6432Node\\Sims(Steam)\\The Sims 3");

            string? documentPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Electronic Arts\\The Sims 3");

            if (gamePath != null && File.Exists(gamePath))
                gamePathTextBox.Text = gamePath;
            if (Directory.Exists(documentPath))
                documentsTextBox.Text = documentPath;
        }

        private string? GetGamePath(string registryPath)
        {
            RegistryKey? registryKey = Registry.LocalMachine.OpenSubKey(registryPath);

            if (registryKey != null)
            {
                string? obj = registryKey.GetValue("exepath") as string;

                if (obj != null )
                    return obj;
            }
            return null;
        }

        private void gamePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Sims 3 Executables|Sims3Launcher.exe;Sims3LauncherW.exe;TS3.exe;TS3W.exe;|All Executables|*.exe";
            if (dialog.ShowDialog() == DialogResult.OK)
                gamePathTextBox.Text = dialog.FileName;
        }

        private void documentsButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                documentsTextBox.Text = dialog.SelectedPath;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Settings.SetSettings("GameExecutablePath", gamePathTextBox.Text);
            Settings.SetSettings("DocumentsFolderPath", documentsTextBox.Text);
            Settings.WriteSettings();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
