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
  public partial class BencherWindow : Form
  {
    // Storage for the results
    double
      min_fps = -1,
      max_fps = -1,
      ave_fps = -1;

    // Storage for the data.
    List<double>
      cumulative_time,
      present_milliseconds,
      present_fps;

    string
      backup_dir = @"C:\PresentMonLauncher\";

    bool manual_file;

    // Contains the directory where the program is.
    string min_max_avg_filename = @"\MinMaxAvg.txt";

    string[] min_max_avg;


    public BencherWindow()
    {
      InitializeComponent();
      directory_label.Text += "" + Directory.GetCurrentDirectory();
      backup_dir = Directory.GetCurrentDirectory();
      refreshList();
    }


    public void runBencher(bool loaded = false, string file_name = "null")
    {
      // This is an invalid use case which should not be encountered ever.
      if ((!loaded && file_name != "null") || (loaded && file_name == "null"))
        return;

      // If no index is selected, do nothing.
      if (file_listbox.SelectedIndex == -1)
        return;

      cumulative_time = new List<double>();
      present_milliseconds = new List<double>();
      present_fps = new List<double>();

      // Read data
      StreamReader read_stream = (!loaded)
        ? new StreamReader(file_listbox.SelectedItem.ToString())
        : new StreamReader(File.OpenRead(file_name));

      // Gotta use up the label line.
      string line = read_stream.ReadLine();
      string[] values;

      while (!read_stream.EndOfStream)
      {
        line = read_stream.ReadLine();
        values = line.Split(',');
        if (values.Length < 11)
        {
          MessageBox.Show("Invalid CSV (not enough columns). Either broken or in error.");
          return;
        }
        double temp = 0;
        double.TryParse(values[10], out temp);
        present_milliseconds.Add(temp);
        present_fps.Add(1000 / temp);
        double.TryParse(values[9], out temp);
        cumulative_time.Add(temp);
      }
      read_stream.Close();

      // Determine statistics.
      ave_fps = present_fps.Count / cumulative_time.Last<double>();
      min_fps = present_fps.Min();
      max_fps = present_fps.Max();
    }


    public void saveInfo()
    {
      // If someone clicks save before the bencher has been run (the only case where
      //   fps values would be -1), bump out.
      if (min_fps == -1 || max_fps == -1 || ave_fps == -1)
        return;

      if (file_listbox.SelectedIndex == -1)
        return;

      status_label.Text = "Saving data.";

      // Building the run info, Ex: RX 480, ROTTR, 1920x1080
      // Depending on user input.
      // The game name is extracted from the beginning of the file they're using
      // If it's titled something else (for example, from Loading a file manually) it 
      //   will use the first word.
      string run_info = "";

      if (!string.IsNullOrEmpty(gpu_textbox.Text))
        run_info += gpu_textbox.Text + ", ";

      run_info += file_listbox.SelectedItem.ToString().Split(' ')[0];

      if (!string.IsNullOrEmpty(resolution_textbox.Text))
        run_info += ", " + resolution_textbox.Text;

      min_max_avg = new string[5] { "\n", run_info, "Minimum: " + min_fps, "Maximum: " + max_fps, "\nAverage: " + ave_fps + "\n\n" };

      // Writes the date to the MinMaxAvg.txt file.
      File.AppendAllLines(Directory.GetCurrentDirectory() + min_max_avg_filename, min_max_avg);
      status_label.Text = "Saved to MinMaxAvg.txt";

      SaveFileDialog sfdialog = new SaveFileDialog();
      sfdialog.Filter = "Comma Separated Values|*.csv";
      sfdialog.Title = "Save Cumulative Time, Frametimes, and FPS Data";
      sfdialog.FileName = Path.GetFileNameWithoutExtension(file_listbox.SelectedItem.ToString()) + "-results.csv";

      string save_to = "";

      DialogResult save_cancel = sfdialog.ShowDialog();
      if (save_cancel == DialogResult.OK)
        save_to = sfdialog.FileName;
      else
        return;

      status_label.Text = "Saving run data.";

      if (File.Exists(save_to))
        File.Delete(save_to);

      using (FileStream fs = File.Open(save_to, FileMode.Create))
      {
        StreamWriter write_stream = new StreamWriter(fs);
      
        int count = 0;
        foreach (double value in present_milliseconds)
        {
          write_stream.WriteLine(cumulative_time[count].ToString() + ',' + value.ToString() + ',' + present_fps[count].ToString());
          count++;
        }

        write_stream.Close();
      }
      status_label.Text = "File saved.";
      refreshList();
    }


    public void refreshList()
    {
      file_listbox.Items.Clear();

      string[] file_list = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.csv");

      // This will alphabetize the files (hopefully).
      file_list = file_list.OrderBy(n => n).ToArray();

      foreach (string val in file_list)
        file_listbox.Items.Add(val);
    }


    private void file_listbox_SelectedIndexChanged(object sender, EventArgs e)
    {
      status_label.Text = "Processing.";
      runBencher();
      status_label.Text = "Ready.";
      min_fps_label.Text = "Min FPS: " + min_fps.ToString();
      max_fps_label.Text = "Max FPS: " + max_fps.ToString();
      average_fps_label.Text = "Av. FPS: " + ave_fps.ToString();
    }


    private void refresh_list_button_Click(object sender, EventArgs e)
    {
      file_listbox.Items.Clear();

      string[] file_list = Directory.GetFiles(Directory.GetCurrentDirectory(),"*.csv");

      // This will alphabetize the files (hopefully).
      file_list = file_list.OrderBy(n => n).ToArray();

      foreach (string val in file_list)
        file_listbox.Items.Add(val);
    }

    private void file_listbox_DoubleClick(object sender, EventArgs e)
    {
      if (file_listbox.SelectedIndex != -1)
        Process.Start(file_listbox.SelectedItem.ToString());
    }

    private void open_folder_button_Click(object sender, EventArgs e)
     =>  Process.Start(Directory.GetCurrentDirectory().ToString());

    private void save_results_button_Click(object sender, EventArgs e)
     => saveInfo();


    private void BencherWindow_FormClosed(object sender, FormClosedEventArgs e)
     => Directory.SetCurrentDirectory(backup_dir);


    private void load_manually_button_Click(object sender, EventArgs e)
    {
      // Create dialog info.
      OpenFileDialog ofdialog = new OpenFileDialog();
      ofdialog.Filter = "Comma Separated Values|*.csv";
      ofdialog.Title = "Open PresentMon Data";

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

      status_label.Text = "Loaded manual file.";
      manual_file = true;

      runBencher(true, open_file);
    }


    private void change_directory_button_Click(object sender, EventArgs e)
    {
      // Prompt them for a new folder to look in.
      FolderBrowserDialog folder_browser = new FolderBrowserDialog();

      // Store the button click (if they clicked OK, Cancel, et al.)
      DialogResult diag_result = folder_browser.ShowDialog();

      if (diag_result == DialogResult.Cancel)
        return;

      Directory.SetCurrentDirectory(folder_browser.SelectedPath);

      refreshList();
    }
  }
}
