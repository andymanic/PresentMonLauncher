using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PresentMonLauncher
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }

        private void frm_About_Load(object sender, EventArgs e)
        {
            lbl_Version.Text = "Version " + Program.VersionNumber.ToString();
            string str_About = "file://" + Application.StartupPath + @"\about.html";
            Uri about = new Uri(str_About);
            browser_About.Url = about;

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_ProjectPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link_ProjectPage.Text);
        }

        private void lnk_ProjectEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:"+lnk_ProjectEmail.Text);
        }

    }
}
