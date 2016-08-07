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
using System.IO;

namespace PresentMonLauncher
{
  public partial class PresentMonLauncher : Form
  {
    string textstring = "";
    string workingdir = "";
    bool restoring = false;

    public PresentMonLauncher()
    {
      InitializeComponent();
      Process[] processlist = Process.GetProcesses();

      foreach (Process theprocess in processlist)
        process_list.Items.Add(theprocess.ProcessName);

      loadConfigs();
    }


    private void launch_Click(object sender, EventArgs e)
    {
      if (process_list.SelectedIndex == -1)
      {
        MessageBox.Show("Please select a process.");
        return;
      }

      textstring = "-process_name " + Convert.ToString(process_list.SelectedItem) + ".exe";

      /*if (!string.IsNullOrEmpty(delay.Text))
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
      }*/


      textstring += " -delay " + (int)delay_updown.Value;

      textstring += " -timed " + (int)time_updown.Value;

      if (!string.IsNullOrEmpty(flags.Text))
        textstring = textstring + " " + flags.Text;

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

      if (exclude.Checked)
        textstring += " -exclude_dropped ";

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

      // Without this reset the program will not reconfigure correctly.
      textstring = "";
    }


    private void process_list_SelectedIndexChanged(object sender, EventArgs e)
      => currentflags.Text = Convert.ToString(process_list.SelectedItem) + ".exe";


    private void refresh_Click(object sender, EventArgs e)
    {
      process_list.Items.Clear();

      Process[] processlist = Process.GetProcesses();

      foreach (Process theprocess in processlist)
        process_list.Items.Add(theprocess.ProcessName);
    }


    private void openfolder_Click(object sender, EventArgs e)
    {
      try
      {
            workingdir = Program.default_config_directory;
            Process.Start(Directory.GetCurrentDirectory().ToString());
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
      => Process.Start("http://youtube.com/techteamgb");


    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      =>  Process.Start("https://github.com/GameTechDev/PresentMon");


    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
      => Process.Start("http://youtube.com/adoredtv");


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


    private void save_config_button_Click(object sender, EventArgs e)
    {
      SaveFileDialog sfdialog = new SaveFileDialog();
      sfdialog.Filter = "Configuration File|*.cfg";
      sfdialog.Title = "Save Configuration Details";

      if (Directory.Exists(Path.Combine(Application.StartupPath, "config")))
         sfdialog.InitialDirectory = Path.Combine(Application.StartupPath, "config");

      string save_to = "";

      DialogResult save_cancel = sfdialog.ShowDialog();

      if (save_cancel == DialogResult.OK)
        save_to = sfdialog.FileName;
      else
        return;

      if (File.Exists(save_to))
        File.Delete(save_to);

      // Will overwrite.
      using (FileStream fs = File.Open(save_to, FileMode.Create))
      {
        StreamWriter write_stream = new StreamWriter(fs);

        if (process_list.SelectedIndex != -1)
          write_stream.WriteLine("Process: " + process_list.SelectedItem.ToString());

        if (Simple.Checked)
          write_stream.WriteLine("Simple: yes");

        if (nocsv.Checked)
          write_stream.WriteLine("NoCSV: yes");

        if (scroll.Checked)
          write_stream.WriteLine("Scroll: yes");

        if (exclude.Checked)
          write_stream.WriteLine("Exclude: yes");


        /*if (!string.IsNullOrEmpty(time.Text))
        {
          int temp;
          int.TryParse(time.Text, out temp);
          write_stream.WriteLine("Time: " + temp.ToString());
        }

        if (!string.IsNullOrEmpty(delay.Text))
        {
          int temp;
          int.TryParse(delay.Text, out temp);
          write_stream.WriteLine("Delay: " + temp.ToString());
        }*/

        if (time_updown.Value > 0)
          write_stream.WriteLine("Time: " + (int)time_updown.Value);

        if (delay_updown.Value > 0)
          write_stream.WriteLine("Delay: " + (int)time_updown.Value);

        if (!string.IsNullOrEmpty(flags.Text))
          write_stream.WriteLine("Flags: " + flags.Text);

        write_stream.Close();
      }

      loadConfigs();
    }


    private void load_config_button_Click(object sender, EventArgs e)
    {
      config_dropdown.SelectedIndex = -1;

      // Create dialog info.
      OpenFileDialog ofdialog = new OpenFileDialog();
      ofdialog.Filter = "Configuration File|*.cfg";
      ofdialog.Title = "Open Configuration File";

      if (Directory.Exists(Path.Combine(Application.StartupPath, "config")))
            ofdialog.InitialDirectory = Path.Combine(Application.StartupPath, "config");


      // Save user input data.
      string open_file = "";

      // Show open file dialog.
      DialogResult save_cancel = ofdialog.ShowDialog();

      // If "OK" then save file name,
      // Else exit function.
      if (save_cancel == DialogResult.OK)
        open_file = ofdialog.FileName;
      else
        return;

      displayCurrentConfig(open_file);
    }


    private void config_dropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (!restoring)
        if (config_dropdown.SelectedIndex != -1)
          displayCurrentConfig(Program.default_config_directory + config_dropdown.SelectedItem.ToString() + ".cfg");
    }


    public void loadConfigs()
    {
      config_dropdown.Items.Clear();

      string[] file_list = Directory.GetFiles(Program.default_config_directory, "*.cfg");

      // This will alphabetize the files (hopefully).
      file_list = file_list.OrderBy(n => n).ToArray();

      foreach (string val in file_list)
        config_dropdown.Items.Add(Path.GetFileNameWithoutExtension(val));
    }


    public void displayCurrentConfig(string filename)
    {
      StreamReader read_stream = new StreamReader(File.OpenRead(filename));
      string line;
      string[] values;

      while (!read_stream.EndOfStream)
      {
        line = read_stream.ReadLine();
        values = line.Split(new char[1] { ' ' }, 2);

        // Skip cases where it's defined but no value.
        if (values.Length < 2)
          continue;

        if (values[0] == "Process:")
        {
          if (process_list.Items.Contains(values[1]))
          {
            process_list.SetItemChecked(process_list.Items.IndexOf(values[1]), true);
            currentflags.Text = values[1] + ".exe";
            process_list.SelectedIndex = process_list.Items.IndexOf(values[1]);
          }
          else
            MessageBox.Show("Process in loaded configuation file not found. Please manually select it.");
        }

        else if (values[0] == "Simple:")
          Simple.Checked = (values[1] == "yes");

        else if (values[0] == "NoCSV:")
          nocsv.Checked = (values[1] == "yes");

        else if (values[0] == "Scroll:")
          scroll.Checked = (values[1] == "yes");

        else if (values[0] == "Flags:")
          flags.Text = values[1];

        else if (values[0] == "Exclude:")
          exclude.Checked = (values[1] == "yes");

        else if (values[0] == "Time:")
          time_updown.Value = Convert.ToDecimal(values[1]);

        else if (values[0] == "Delay:")
          delay_updown.Value = Convert.ToDecimal(values[1]);
        /*
        else if (values[0] == "Time:")
        {
          int temp;
          int.TryParse(values[1], out temp);
          time.Text = temp.ToString();
        }

        else if (values[0] == "Delay:")
        {
          int temp;
          int.TryParse(values[1], out temp);
          delay.Text = temp.ToString();
        }*/
      }

      read_stream.Close();

      restoring = true;

      int temp = config_dropdown.SelectedIndex;
      loadConfigs();
      config_dropdown.SelectedIndex = (config_dropdown.Items.Count >= temp -1) ? temp : -1;

      restoring = false;
    }
  }
}
