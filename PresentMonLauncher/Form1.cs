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
            // This will alphabetize the processes.
            processlist = processlist.OrderBy(n => n.ProcessName).ToArray();
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
            if (!String.IsNullOrEmpty(delay.Text))
            {
                try
                {
                    delaynum = Convert.ToInt32(delay.Text);
                    delaynum = delaynum * 1000;
                    delaytext = Convert.ToString(delaynum);
                    textstring = textstring + " -delay " + delay.Text;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Source: " + exception.Source + "\nMessage: " + exception.Message);
                }
            }
            if (!String.IsNullOrEmpty(time.Text))
            {
                timenum = Convert.ToInt32(time.Text);
                timenum = timenum * 1000;
                timetext = Convert.ToString(timenum);
                textstring = textstring + " -timed " + time.Text;
            }
            if (!String.IsNullOrEmpty(flags.Text))
            {
                textstring = textstring + " " + flags.Text;
            }
            if (!textstring.Contains("-output_file") && process_list.CheckedItems.Count > 0)
            {
                textstring +=
                  (" -output_file \"" + process_list.SelectedItem.ToString()
                  + DateTime.Now.Day.ToString() + '-'
                  + DateTime.Now.Hour.ToString() + '-'
                  + DateTime.Now.Minute.ToString() + ".csv\"");
            }

            if (nocsv.Checked)
            {
                textstring = textstring + " -no_csv";
            }
            if (Simple.Checked)
            {
                textstring = textstring + " -simple";
            }
            if (scroll.Checked)
            {
                textstring = textstring + " -scroll_toggle";
            }
            if (process_list.SelectedIndex == -1)
            {
                textstring = textstring + " " + flags.Text;
                MessageBox.Show("Please select a process to trace.");
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void Simple_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void nocsv_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void process_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            textstring = "-process_name " + Convert.ToString(process_list.SelectedItem)+ ".exe";
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
            // This will alphabetize the processes.
            processlist = processlist.OrderBy(n => n.ProcessName).ToArray();
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

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void scroll_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
