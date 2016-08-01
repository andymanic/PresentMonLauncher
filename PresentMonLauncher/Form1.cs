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
        String textstring = "";
        String timetext = "";
        String delaytext = "";
        int delaynum = 0;
        int timenum = 0;
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
            if (delay.Text != "")
            {
                delaynum = Convert.ToInt32(delay.Text);
                delaynum = delaynum * 1000;
                delaytext = Convert.ToString(delaynum);
                textstring = textstring + " -delay " + delay.Text;
            }
            if (time.Text != "")
            {
                timenum = Convert.ToInt32(time.Text);
                timenum = timenum * 1000;
                timetext = Convert.ToString(timenum);
                textstring = textstring + " -timed " + time.Text;
            }
            if (flags.Text != "")
            {
                textstring = textstring + " " + flags.Text;
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\PresentMonLauncher\PresentMon64.exe";
            startInfo.Arguments = textstring;

            try
            {
                Process.Start(startInfo);
            }
            catch(Win32Exception ex)
            {
                MessageBox.Show("The program could not find PresentMon64.exe, please place it C:\\PresentMonLauncher");
            }
        }

        private void Simple_CheckedChanged(object sender, EventArgs e)
        {
            textstring = textstring + " -simple";
        }

        private void nocsv_CheckedChanged(object sender, EventArgs e)
        {
            textstring = textstring + " -no_csv";
        }

        private void process_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            textstring = "-process_name " + Convert.ToString(process_list.SelectedItem);
            currentflags.Text = Convert.ToString(process_list.SelectedItem);
        }            

        private void flags_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void delay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void time_TextChanged(object sender, EventArgs e)
        {
                           
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
            }
        }
    }
}
