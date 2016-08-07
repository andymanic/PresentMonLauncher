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

// From Daniel to Chris: Thanks for your suggestions!

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

    // Contains the directory where the program is.
    string min_max_avg_filename = @"\MinMaxAvg.txt";

    string[] min_max_avg;

    bool manual_file = false;

    // Initializing the window. All goes here.
    public BencherWindow()
    {
      InitializeComponent();
      directory_label.Text += Directory.GetCurrentDirectory();
      backup_dir = Directory.GetCurrentDirectory();
      refreshList();
    }


    public void runBencher(bool loaded = false, string file_name = "null")
    {
      // This is an invalid use case which should not be encountered ever.
      if ((!loaded && file_name != "null") || (loaded && file_name == "null"))
        return;

      // If no index is selected and no file is loaded, do nothing.
      if (file_listbox.SelectedIndex == -1 && !loaded)
      {
        MessageBox.Show("Please select a file or load one in.");
        return;
      }

      // Instantiate new lists.
      cumulative_time = new List<double>();
      present_milliseconds = new List<double>();
      present_fps = new List<double>();

      // Read data
      StreamReader read_stream = (!loaded)
        ? new StreamReader(Directory.GetCurrentDirectory() + '\\' + file_listbox.SelectedItem.ToString() + ".csv")
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

        double.TryParse(values[9], out temp);
        cumulative_time.Add(temp);

        double.TryParse(values[10], out temp);
        present_milliseconds.Add(temp);
        present_fps.Add(1000 / temp);
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

      if (file_listbox.SelectedIndex == -1 && !manual_file)
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

      // Grab the first word.
      run_info += file_listbox.SelectedItem.ToString().Split(' ')[0];

      if (!string.IsNullOrEmpty(resolution_textbox.Text))
        run_info += ", " + resolution_textbox.Text;

      min_max_avg = new string[5] { "\n", run_info, "Minimum: " + min_fps, "Maximum: " + max_fps, "\nAverage: " + ave_fps + "\n\n" };

      // Writes the date to the MinMaxAvg.txt file.
      File.AppendAllLines(Directory.GetCurrentDirectory() + min_max_avg_filename, min_max_avg);
      status_label.Text = "Saved to MinMaxAvg.txt";

      // Create and prepare the safe file dialog,
      SaveFileDialog sfdialog = new SaveFileDialog();
      sfdialog.Filter = "Comma Separated Values|*.csv";
      sfdialog.Title = "Save Cumulative Time, Frametimes, and FPS Data";
      sfdialog.FileName = Path.GetFileNameWithoutExtension(file_listbox.SelectedItem.ToString()) + "-results.csv";

      // Variable for storing the directory.
      string save_to = "";

      // Prompt user action.
      DialogResult save_cancel = sfdialog.ShowDialog();

      // Process user action.
      if (save_cancel == DialogResult.OK)
        save_to = sfdialog.FileName;
      else
        return;

      status_label.Text = "Saving run data.";

      // Prepare for overwriting.
      if (File.Exists(save_to))
        File.Delete(save_to);

      // Write to file.
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

      status_label.Text = (manual_file) ? "Manually selected file saved." : "File saved.";

      refreshList();
    }


    public void refreshList()
    {
      // Clear out old items.
      file_listbox.Items.Clear();

      // Get all new ones.
      string[] file_list = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.csv");

      // Add them to the file list.
      foreach (string val in file_list)
        file_listbox.Items.Add(Path.GetFileNameWithoutExtension(val));

      this.toolTip1.SetToolTip(this.directory_label, Directory.GetCurrentDirectory());
    }


    private void file_listbox_SelectedIndexChanged(object sender, EventArgs e)
    {
      status_label.Text = "Processing.";

      // Run the data.
      runBencher();

      // Update strings.
      status_label.Text = "Ready.";
      min_fps_label.Text = "Min FPS: " + min_fps.ToString();
      max_fps_label.Text = "Max FPS: " + max_fps.ToString();
      average_fps_label.Text = "Av. FPS: " + ave_fps.ToString();

      manual_file = false;

      status_label.Text = (manual_file) ? "Manual file ready to save." : "Ready to save.";
    }


    private void refresh_list_button_Click(object sender, EventArgs e)
      => refreshList();


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

      runBencher(true, open_file);

      manual_file = true;
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

      directory_label.Text = "Current Directory: " + Directory.GetCurrentDirectory();

      refreshList();
    }
  }
}
