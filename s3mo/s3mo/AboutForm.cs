using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace s3mo
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            nameLabel.Text = "Sims 3 Mod Organizer " + Program.Version;
        }

        private void OpenLink(string url)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(url);
            startInfo.UseShellExecute = true;
            startInfo.Verb = "open";
            Process.Start(startInfo);
        }

        private void modOrganizerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://www.nexusmods.com/skyrim/mods/1334/");
        }

        private void modOrganizer2Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://www.nexusmods.com/skyrimspecialedition/mods/6194");
        }

        private void icon8Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://icons8.com/");
        }

        private void rrzeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://rrze-pp.github.io/rrze-icon-set/introduction.html");
        }

        private void s3pis3pe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://sourceforge.net/u/pljones/profile/");
        }

        private void kprojects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://code.google.com/archive/p/kprojects/");
        }
    }
}
