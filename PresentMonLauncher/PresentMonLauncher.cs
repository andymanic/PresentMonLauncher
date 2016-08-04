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
    string textstring = "";
    //String timetext = "";
    //String delaytext = "";

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
    {}

    private void launch_Click(object sender, EventArgs e)
    {
            if (!string.IsNullOrEmpty(delay.Text))
            {
                // TryParse here will ensure that invalid input, say "1wvm-1j842" or such nonsense
                //   won't break the program. If it's invalid, delaynum will be set to 0.
                int.TryParse(delay.Text, out delaynum);
                delay.Text = delaynum.ToString(); //ToString() will do the same thing as Convert.ToString() but shorter.
                                                  // If the user input is invalid, it will change to zero upon launch_Click so there is visual feedback.
                textstring = textstring + " -delay " + delay.Text;
            }
            if (!string.IsNullOrEmpty(time.Text))
            {
                int.TryParse(time.Text, out timenum);
                time.Text = timenum.ToString();
                textstring = textstring + " -timed " + time.Text;
            }

            if (!string.IsNullOrEmpty(flags.Text))
            {
                textstring = textstring + " " + flags.Text;
            }


            if (!textstring.Contains("-output_file") && process_list.CheckedItems.Count > 0)
            {
                textstring +=
                (" -output_file \"" + process_list.SelectedItem.ToString()
                + DateTime.Now.Day.ToString() + '-'
                + DateTime.Now.Hour.ToString() + '-'
                + DateTime.Now.Minute.ToString() + '-'
                + DateTime.Now.Second.ToString() + ".csv\"");
            }

            if (nocsv.Checked)
                textstring = textstring + " -no_csv";

            if (Simple.Checked)
                textstring = textstring + " -simple";

            if (scroll.Checked)
                textstring = textstring + " -scroll_toggle";
      
            if (process_list.SelectedIndex == -1)
            {
                textstring = textstring + " " + flags.Text;
                MessageBox.Show("Please select a process to trace.");
                return; // Added return here to ensure that the program does not continue needlessly.
                // Props to whomever added this code block.
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\PresentMonLauncher\PresentMon64.exe";
            startInfo.Arguments = textstring;

            // Please re-examine this code block. It is likely that other exceptions can be thrown up other than Win32Exceptions
            try
            {
            Process.Start(startInfo);
            }
            catch (Win32Exception ex)
            {
            MessageBox.Show("The program could not find PresentMon64.exe, please place it C:\\PresentMonLauncher");
            MessageBox.Show(ex.ToString());
            }
            // v For catching miscellaneous random errors that may happen.
            catch (Exception ex)
            {
            MessageBox.Show("Source: " + ex.Source + "\nMessage: " + ex.Message);
            }
            textstring = "";
        }

    private void Simple_CheckedChanged(object sender, EventArgs e)
    {}

    private void nocsv_CheckedChanged(object sender, EventArgs e)
    {}

    private void process_list_SelectedIndexChanged(object sender, EventArgs e)
    {
      textstring = "-process_name " + Convert.ToString(process_list.SelectedItem) + ".exe";
      currentflags.Text = Convert.ToString(process_list.SelectedItem);
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
      //Process.Start("presentmonbencher.exe");
      BencherWindow bencher = new BencherWindow();
      bencher.Show();
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


    private void scroll_CheckedChanged(object sender, EventArgs e)
    {}


    // The purpose of this one's to check/uncheck appropriately and ensure only
    //   one item is visually checked.
    private void process_list_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      // If there's an item checked, else ignore.
      if (process_list.CheckedItems.Count == 1)
      {
        // Determine if unchecking on the basis of whether or not the item is already checked.
        bool unchecking = (e.CurrentValue == CheckState.Checked);

        // If unchecking,
        //  Ensure next one is unchecked.
        // else
        //  ensure that there's only one checked index.
        if (unchecking)
          e.NewValue = CheckState.Unchecked;

        else
        {
          // This involves delegates. If you don't know what it's doing, do not tamper.
          int item_index = process_list.CheckedIndices[0];
          process_list.ItemCheck -= process_list_ItemCheck;
          process_list.SetItemChecked(item_index, false);
          process_list.ItemCheck += process_list_ItemCheck;
        }
        return;
      }
    }
  }
}
