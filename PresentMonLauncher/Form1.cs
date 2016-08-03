//This program was created to be used alongside the PresentMon64.exe application which comes bundled in this installer package.
//I am re-distributing the PresentMon application free of charge with no claim to ownership or copyright
//I'm sure there was a billion and one better ways to write this application, but I'm not a professional programmer, I make videos for a living and am limited in programming ability.
//Please don't sue me if I do something wrong, I'm just an idiot trying to help so please contact inbox@techteamgb.com and I'll happily attempt to fix my mistakes... Thanks!

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

namespace PresentMonLauncher
{
    public partial class PresentMonLauncher : Form
    {

        public PresentMonLauncher()
        {
            InitializeComponent();
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                process_list.Items.Add(theprocess.ProcessName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void launch_Click(object sender, EventArgs e)
        {
            if (process_list.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a process to trace.");
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\PresentMonLauncher\PresentMon64.exe";
            startInfo.Arguments = buildArgumentString();

            try
            {
                Process.Start(startInfo);

            }
            catch(Win32Exception ex)
            {
                MessageBox.Show("The program could not find PresentMon64.exe, please place it C:\\PresentMonLauncher");
                MessageBox.Show(ex.ToString());
            }
        }

        private string buildArgumentString()
        {
            StringBuilder argString = new StringBuilder();

            if (Simple.Checked)
                argString.Append(" -simple");

            if (nocsv.Checked)
                argString.Append(" -no_csv");

            if (flags.Text != String.Empty)
                argString.Append(" " + flags.Text);

            if (nud_Delay.Value != 0)
                argString.Append(" -delay " + (nud_Delay.Value * 1000).ToString());

            if (nud_Duration.Value != 0)
                argString.Append(" -timed " + (nud_Duration.Value * 1000).ToString());

            if (scroll.Checked)
                argString.Append(" -scroll_toggle");

            argString.Append(" -process_name " + process_list.SelectedItem.ToString() + ".exe");

            return argString.ToString();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            process_list.Items.Clear();
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                process_list.Items.Add(theprocess.ProcessName);
            }
        }

        private void openfolder_Click(object sender, EventArgs e)
        {
            
            try
            {
                Process.Start("explorer.exe", @"C:\PresentMonLauncher");
            }
            catch (Win32Exception ex)
            {
                MessageBox.Show("The program done goofed. Not sure why, try opening the folder manually.");
                MessageBox.Show(ex.ToString());
            }
        }

        private void bencher_Click(object sender, EventArgs e)
        {
            Process.Start("presentmonbencher.exe");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://youtube.com/techteamgb");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/GameTechDev/PresentMon");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://youtube.com/adoredtv");
        }
    }
}
