using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.IO;

// From Daniel to Chris: Thanks for your suggestions!

namespace PresentMonLauncher
{
    public partial class BencherWindow : Form
    {
        #region Form Variables
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

        Dictionary<string, BenchFile> fileList = new Dictionary<string, BenchFile>();
        #endregion

        #region Initialize Window
        // Initializing the window. All goes here.
        public BencherWindow()
        {
            InitializeComponent();
            directory_label.Text += Directory.GetCurrentDirectory();
            backup_dir = Directory.GetCurrentDirectory();
            refreshList();
            ReadHWInfo();
        }
        #endregion

        #region Custom Functions
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
                ? new StreamReader(fileList[file_listbox.SelectedItem.ToString()].Path)
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

            if (present_fps.Count > 0)
            {
                // Determine statistics.
                ave_fps = present_fps.Count / cumulative_time.Last<double>();
                min_fps = present_fps.Min();
                max_fps = present_fps.Max();
            }
            else
                MessageBox.Show("Invalid file submitted. Check contents.");
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

            if (!string.IsNullOrEmpty(cmb_GPUs.Text))
                run_info += cmb_GPUs.Text.Trim() + ", ";

            // Grab the first word.
            run_info += file_listbox.SelectedItem.ToString().Split(' ')[0];

            if (!string.IsNullOrEmpty(cmb_Resolutions.Text))
                run_info += cmb_Resolutions.Text.Trim() + ", ";

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
            fileList.Clear();
            file0.Items.Clear();
            file1.Items.Clear();
            file2.Items.Clear();
            file3.Items.Clear();
            file4.Items.Clear();
            file5.Items.Clear();

            // Get all new ones.
            string[] file_list = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.csv");
            // Add them to the file list.
            foreach (string val in file_list)
            {
                if (!val.EndsWith("-results.csv"))
                {
                    string fileNameNoExtension = Path.GetFileNameWithoutExtension(val);
                    file_listbox.Items.Add(fileNameNoExtension);
                    fileList.Add(fileNameNoExtension, new BenchFile(val, false));
                    file0.Items.Add(fileNameNoExtension);
                    file1.Items.Add(fileNameNoExtension);
                    file2.Items.Add(fileNameNoExtension);
                    file3.Items.Add(fileNameNoExtension);
                    file4.Items.Add(fileNameNoExtension);
                    file5.Items.Add(fileNameNoExtension);
                }
            }

            this.toolTip1.SetToolTip(this.directory_label, Directory.GetCurrentDirectory());
        }
        #endregion

        #region Event Handlers
        private void file_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (file_listbox.SelectedIndex != -1)
            {
                status_label.Text = "Processing.";

                // Run the data.
                runBencher();

                // Update strings.
                status_label.Text = "Ready.";
                min_fps_label.Text = "Min FPS: " + min_fps.ToString("##0.##");
                max_fps_label.Text = "Max FPS: " + max_fps.ToString("##0.##");
                average_fps_label.Text = "Avg. FPS: " + ave_fps.ToString("##0.##");

                manual_file = false;

                status_label.Text = (manual_file) ? "Manual file ready to save." : "Ready to save.";
            }

        }

        private void refresh_list_button_Click(object sender, EventArgs e)
            => refreshList();

        private void file_listbox_DoubleClick(object sender, EventArgs e)
        {
            if (file_listbox.SelectedIndex != -1)
                Process.Start(Directory.GetCurrentDirectory() + '\\' + file_listbox.SelectedItem.ToString() + ".csv");
        }

        private void open_folder_button_Click(object sender, EventArgs e)
            => Process.Start(Directory.GetCurrentDirectory().ToString());

        private void btn_ChartSelected_Click(object sender, EventArgs e)
        {
            // No point in continuing if the number of selected items exceeds what we support
            /*if (file_listbox.SelectedItems.Count > 6)
            {
                MessageBox.Show("Too many files selected.  Please limit to 6 items.");
                return;
            }*/
            if (file0.SelectedIndex == -1)
            {
                MessageBox.Show("No items selected, please select at least one file.");
                return;
            }
            if (charttitle.Text == "")
            {
                MessageBox.Show("Please enter a title");
                return;
            }

            for (int i = 0; i <= 5; i++)
            {
                string series = "Series" + i.ToString();
                string file = "file" + i.ToString();

                ComboBox cmb_t = this.Controls["file" + i] as ComboBox;
                TextBox txt_t = this.Controls["Series" + i] as TextBox;

                if (cmb_t.SelectedIndex != -1 && String.IsNullOrEmpty(txt_t.Text))
                {
                    txt_t.Text = cmb_t.SelectedItem.ToString();
                }

            }

            // Start building the chart
            Chart benchChart = new Chart();

            // Chart size and color
            benchChart.Width = 1024; benchChart.Height = 768;
            benchChart.BackColor = Color.White;

            // Chart title, font, and position
            benchChart.Titles.Add(charttitle.Text);
            benchChart.Titles[0].Font = new Font("Arial", 13);
            benchChart.Titles[0].Alignment = ContentAlignment.TopRight;

            // Add the GPU and Resolution, if present.  We'll eventually want to make this optional, I'm sure.
            if (!String.IsNullOrEmpty(cmb_GPUs.Text))
            {
                Title GPUResHeader = new Title();
                GPUResHeader.Font = new Font("Arial", 13);
                GPUResHeader.Alignment = ContentAlignment.TopCenter;
                GPUResHeader.Text += "GPU:  " + cmb_GPUs.Text + System.Environment.NewLine;

                if (!String.IsNullOrEmpty(cmb_Resolutions.Text))
                {
                    GPUResHeader.Text += "Resolution:  " + cmb_Resolutions.Text + System.Environment.NewLine;
                }

                benchChart.Titles.Add(GPUResHeader);
            }

            //  The chart object is just a container.  All chart "draws" need to go on a ChartArea object.  This includes the chart Legend.
            //  Multiple ChartAreas can go on the same Chart, if necessary
            ChartArea graphArea = new ChartArea("GraphArea");

            //  Chart labels
            graphArea.AxisX.Title = "Time (s)";
            graphArea.AxisY.Title = "FPS";

            // Set the data point interval on the X axis to something reasonable
            graphArea.AxisX.Interval = 5;

            // Make sure to trim the decimal places on the X axis
            graphArea.AxisX.LabelStyle.Format = "#";

            // Disable X axis grid lines
            graphArea.AxisX.MajorGrid.Enabled = false;

            //  Add a legend
            Legend graphLegend = new Legend("Legend");
            graphLegend.Title = "Benchmark";

            // Add the ChartArea and Legend to the Chart object
            benchChart.ChartAreas.Add(graphArea);
            benchChart.Legends.Add(graphLegend);

            List<string> paths = new List<string>();
            string[] colFileNames = { };

            List<string> fileselection = new List<string>();

            List<ComboBox> seriesBoxes = new List<ComboBox>();
            seriesBoxes.Add(file0);
            seriesBoxes.Add(file1);
            seriesBoxes.Add(file2);
            seriesBoxes.Add(file3);
            seriesBoxes.Add(file4);
            seriesBoxes.Add(file5);
            foreach (ComboBox cmb in seriesBoxes)
            {
                if (cmb.SelectedIndex != -1)
                {
                    fileselection.Add(cmb.SelectedItem.ToString());
                }

            }

            foreach (string item in fileselection)
            {
                paths.Add(fileList[item].Path);
            }

            colFileNames = paths.ToArray();

            string[] seriesname = { Series0.Text, Series1.Text, Series2.Text, Series3.Text, Series4.Text, Series5.Text };

            // Placeholder for color enumeration once we decide how to do this
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Purple, Color.Black };

            // This can and should probably be refactored with generic collections
            // Using the counter variable to track colors seems like it should be unnecessary
            for (int i = 0; i < colFileNames.Length; i++)
            {

                using (StreamReader sr = new StreamReader(File.OpenRead(colFileNames[i])))
                {

                    int frame = 0;
                    sr.ReadLine();

                    //  All of these operations happen on colFileNames[i] so that the chartArea sees them as individual series on the same chart
                    //  Fortunately, System.Windows.Forms.DataVisualization allows us to reference the graph1.Series[] array by name
                    //  Note that not all ChartTypes support multiple series


                    string SeriesName = seriesname[i];
                    benchChart.Series.Add(SeriesName);
                    benchChart.Series[SeriesName].ChartType = SeriesChartType.Line;
                    benchChart.Series[SeriesName].IsVisibleInLegend = true;

                    // Set the line width to 1px
                    benchChart.Series[SeriesName].BorderWidth = 1;

                    // Add this series and legend to the default ChartArea defined above
                    benchChart.Series[SeriesName].ChartArea = graphArea.Name;
                    benchChart.Series[SeriesName].Legend = graphLegend.Name;
                    benchChart.Series[SeriesName].Color = colors[i];

                    while (!sr.EndOfStream)
                    {
                        string[] values = sr.ReadLine().Split(',');
                        int FPS = 0;

                        frame++;
                        try
                        {
                            FPS = (int)(1000 / (Convert.ToDouble(values[10])));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        decimal Time = Convert.ToDecimal(values[9]);

                        //  Add Time and FPS as data points to the current (colFileNames[i]) series
                        benchChart.Series[SeriesName].Points.AddXY(Time, FPS);
                    }

                }
            }

            //  Save the chart to an Image.  It can also be displayed in a Window if we want.

            SaveFileDialog chartOutput = new SaveFileDialog();
            chartOutput.Title = "Select a file";
            chartOutput.AddExtension = true;
            chartOutput.DefaultExt = ".png";
            chartOutput.Filter = "PNG Image|*.png";
            chartOutput.FileName = "Benchmark.png";
            chartOutput.InitialDirectory = Application.StartupPath;

            DialogResult dr = chartOutput.ShowDialog();
            if (DialogResult.OK == dr)
            {
                benchChart.SaveImage(chartOutput.FileName, ChartImageFormat.Png);
            }

        }

        private void cmb_Resolutions_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (cmb_Resolutions.Items[e.Index].ToString().StartsWith("----"))
            {
                e.Graphics.DrawString(cmb_Resolutions.Items[e.Index].ToString(), new Font(this.Font, FontStyle.Bold), Brushes.Black, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString("  " + cmb_Resolutions.Items[e.Index].ToString(), new Font(this.Font, FontStyle.Regular), Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void cmb_GPUs_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (cmb_GPUs.Items[e.Index].ToString().StartsWith("----"))
            {
                e.Graphics.DrawString(cmb_GPUs.Items[e.Index].ToString(), new Font(this.Font, FontStyle.Bold), Brushes.Black, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString("  " + cmb_GPUs.Items[e.Index].ToString(), new Font(this.Font, FontStyle.Regular), Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void cmb_Resolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Resolutions.SelectedIndex != -1 && cmb_Resolutions.SelectedItem.ToString().StartsWith("----"))
            {
                cmb_Resolutions.SelectedIndex = -1;
            }
        }

        private void cmb_GPUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_GPUs.SelectedIndex != -1 && cmb_GPUs.SelectedItem.ToString().StartsWith("----"))
            {
                cmb_GPUs.SelectedIndex = -1;
            }
        }

        private void save_results_button_Click(object sender, EventArgs e)
            => saveInfo();

        private void BencherWindow_Load(object sender, EventArgs e)
        {

        }

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
            string fileNameNoExtension = string.Empty;
            // Show open file dialog.
            DialogResult save_cancel = ofdialog.ShowDialog();

            // If "OK" then save file name,
            // Else exit function.
            if (save_cancel == DialogResult.OK)
                open_file = ofdialog.FileName;
            else
                return;


            fileNameNoExtension = Path.GetFileNameWithoutExtension(open_file);

            if (file_listbox.Items.Contains(fileNameNoExtension))
            {
                MessageBox.Show("File already exists.  Please choose another file.");
                return;
            }

            fileList.Add(fileNameNoExtension, new BenchFile(open_file, true));
            file_listbox.Items.Add(fileNameNoExtension);

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
        public void ReadHWInfo()
        {
            string open_file = "";
            open_file = Path.Combine(Application.StartupPath) + "//HWInfo.txt";
            StreamReader read_stream = new StreamReader(File.OpenRead(open_file));
            string GPU;
            string res;
            string line;

            while (!read_stream.EndOfStream)
            {
                line = read_stream.ReadLine();
                if (line.Contains("DeviceName: "))
                {
                    GPU = line;
                    string GPUName = GPU.Replace("   DeviceName: ", string.Empty);
                    cmb_GPUs.Text = GPUName;
                }
                else if (line.Contains("VideoModeDescription: "))
                {
                    res = line;
                    string Resolution = res.Remove(0, 25);
                    char[] MyChar = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'c', 'o', 'l', 's', 'r', ' ' };
                    string restrim = Resolution.TrimEnd(MyChar);
                    char[] MyChar2 = { 'x', ' ' };
                    string resfinal = restrim.TrimEnd(MyChar2);
                    cmb_Resolutions.Text = resfinal;
                }
            }
        }



        #endregion
    }

    #region Custom Classes
    public class BenchFile
    {
        public string Path;
        public bool IsManuallyLoaded;

        public BenchFile()
        {
            this.Path = string.Empty;
            this.IsManuallyLoaded = false;
        }

        public BenchFile(string Path)
            : this()
        {
            this.Path = Path;
        }

        public BenchFile(string Path, bool IsManuallyLoaded)
        {
            this.Path = Path;
            this.IsManuallyLoaded = IsManuallyLoaded;
        }
    }

    #endregion
}