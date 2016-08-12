namespace PresentMonLauncher
{
  partial class BencherWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.file_list_label = new System.Windows.Forms.Label();
            this.file_listbox = new System.Windows.Forms.ListBox();
            this.load_manually_button = new System.Windows.Forms.Button();
            this.directory_label = new System.Windows.Forms.Label();
            this.change_directory_button = new System.Windows.Forms.Button();
            this.min_fps_label = new System.Windows.Forms.Label();
            this.max_fps_label = new System.Windows.Forms.Label();
            this.average_fps_label = new System.Windows.Forms.Label();
            this.refresh_list_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.gpu_label = new System.Windows.Forms.Label();
            this.gpu_textbox = new System.Windows.Forms.TextBox();
            this.resolution_label = new System.Windows.Forms.Label();
            this.resolution_textbox = new System.Windows.Forms.TextBox();
            this.save_results_button = new System.Windows.Forms.Button();
            this.open_folder_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.charttitle = new System.Windows.Forms.TextBox();
            this.Series0 = new System.Windows.Forms.TextBox();
            this.Series1 = new System.Windows.Forms.TextBox();
            this.Series2 = new System.Windows.Forms.TextBox();
            this.Series5 = new System.Windows.Forms.TextBox();
            this.Series4 = new System.Windows.Forms.TextBox();
            this.Series3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChartSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.file0 = new System.Windows.Forms.ComboBox();
            this.file1 = new System.Windows.Forms.ComboBox();
            this.file2 = new System.Windows.Forms.ComboBox();
            this.file3 = new System.Windows.Forms.ComboBox();
            this.file4 = new System.Windows.Forms.ComboBox();
            this.file5 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_list_label
            // 
            this.file_list_label.AutoSize = true;
            this.file_list_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_list_label.Location = new System.Drawing.Point(13, 6);
            this.file_list_label.Name = "file_list_label";
            this.file_list_label.Size = new System.Drawing.Size(87, 18);
            this.file_list_label.TabIndex = 0;
            this.file_list_label.Text = "Select a file:";
            // 
            // file_listbox
            // 
            this.file_listbox.FormattingEnabled = true;
            this.file_listbox.Location = new System.Drawing.Point(16, 30);
            this.file_listbox.Name = "file_listbox";
            this.file_listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.file_listbox.Size = new System.Drawing.Size(482, 160);
            this.file_listbox.Sorted = true;
            this.file_listbox.TabIndex = 1;
            this.file_listbox.SelectedIndexChanged += new System.EventHandler(this.file_listbox_SelectedIndexChanged);
            this.file_listbox.DoubleClick += new System.EventHandler(this.file_listbox_DoubleClick);
            // 
            // load_manually_button
            // 
            this.load_manually_button.Location = new System.Drawing.Point(504, 58);
            this.load_manually_button.Name = "load_manually_button";
            this.load_manually_button.Size = new System.Drawing.Size(93, 23);
            this.load_manually_button.TabIndex = 2;
            this.load_manually_button.Text = "Load CSV";
            this.toolTip1.SetToolTip(this.load_manually_button, "Manually load a CSV file from outside the current directory.");
            this.load_manually_button.UseVisualStyleBackColor = true;
            this.load_manually_button.Click += new System.EventHandler(this.load_manually_button_Click);
            // 
            // directory_label
            // 
            this.directory_label.AutoSize = true;
            this.directory_label.Location = new System.Drawing.Point(218, 9);
            this.directory_label.Name = "directory_label";
            this.directory_label.Size = new System.Drawing.Size(92, 13);
            this.directory_label.TabIndex = 3;
            this.directory_label.Text = "Current Directory: ";
            // 
            // change_directory_button
            // 
            this.change_directory_button.Location = new System.Drawing.Point(151, 4);
            this.change_directory_button.Name = "change_directory_button";
            this.change_directory_button.Size = new System.Drawing.Size(61, 23);
            this.change_directory_button.TabIndex = 4;
            this.change_directory_button.Text = "Change";
            this.toolTip1.SetToolTip(this.change_directory_button, "Change the directory where the application looks for results files.");
            this.change_directory_button.UseVisualStyleBackColor = true;
            this.change_directory_button.Click += new System.EventHandler(this.change_directory_button_Click);
            // 
            // min_fps_label
            // 
            this.min_fps_label.AutoSize = true;
            this.min_fps_label.Location = new System.Drawing.Point(503, 143);
            this.min_fps_label.Name = "min_fps_label";
            this.min_fps_label.Size = new System.Drawing.Size(50, 13);
            this.min_fps_label.TabIndex = 5;
            this.min_fps_label.Text = "Min FPS:";
            // 
            // max_fps_label
            // 
            this.max_fps_label.AutoSize = true;
            this.max_fps_label.Location = new System.Drawing.Point(503, 164);
            this.max_fps_label.Name = "max_fps_label";
            this.max_fps_label.Size = new System.Drawing.Size(53, 13);
            this.max_fps_label.TabIndex = 6;
            this.max_fps_label.Text = "Max FPS:";
            // 
            // average_fps_label
            // 
            this.average_fps_label.AutoSize = true;
            this.average_fps_label.Location = new System.Drawing.Point(504, 184);
            this.average_fps_label.Name = "average_fps_label";
            this.average_fps_label.Size = new System.Drawing.Size(49, 13);
            this.average_fps_label.TabIndex = 7;
            this.average_fps_label.Text = "Av. FPS:";
            // 
            // refresh_list_button
            // 
            this.refresh_list_button.Location = new System.Drawing.Point(504, 29);
            this.refresh_list_button.Name = "refresh_list_button";
            this.refresh_list_button.Size = new System.Drawing.Size(93, 23);
            this.refresh_list_button.TabIndex = 8;
            this.refresh_list_button.Text = "Refresh";
            this.toolTip1.SetToolTip(this.refresh_list_button, "Refresh the list of available files.");
            this.refresh_list_button.UseVisualStyleBackColor = true;
            this.refresh_list_button.Click += new System.EventHandler(this.refresh_list_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(503, 203);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(38, 13);
            this.status_label.TabIndex = 9;
            this.status_label.Text = "Ready";
            // 
            // gpu_label
            // 
            this.gpu_label.AutoSize = true;
            this.gpu_label.Location = new System.Drawing.Point(13, 199);
            this.gpu_label.Name = "gpu_label";
            this.gpu_label.Size = new System.Drawing.Size(33, 13);
            this.gpu_label.TabIndex = 10;
            this.gpu_label.Text = "GPU:";
            // 
            // gpu_textbox
            // 
            this.gpu_textbox.Location = new System.Drawing.Point(52, 196);
            this.gpu_textbox.Name = "gpu_textbox";
            this.gpu_textbox.Size = new System.Drawing.Size(195, 20);
            this.gpu_textbox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.gpu_textbox, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // resolution_label
            // 
            this.resolution_label.AutoSize = true;
            this.resolution_label.Location = new System.Drawing.Point(253, 199);
            this.resolution_label.Name = "resolution_label";
            this.resolution_label.Size = new System.Drawing.Size(60, 13);
            this.resolution_label.TabIndex = 12;
            this.resolution_label.Text = "Resolution:";
            // 
            // resolution_textbox
            // 
            this.resolution_textbox.Location = new System.Drawing.Point(319, 196);
            this.resolution_textbox.Name = "resolution_textbox";
            this.resolution_textbox.Size = new System.Drawing.Size(179, 20);
            this.resolution_textbox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.resolution_textbox, "Type the resolution used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt");
            // 
            // save_results_button
            // 
            this.save_results_button.Location = new System.Drawing.Point(504, 117);
            this.save_results_button.Name = "save_results_button";
            this.save_results_button.Size = new System.Drawing.Size(93, 23);
            this.save_results_button.TabIndex = 14;
            this.save_results_button.Text = "Save";
            this.toolTip1.SetToolTip(this.save_results_button, "Save the results.");
            this.save_results_button.UseVisualStyleBackColor = true;
            this.save_results_button.Click += new System.EventHandler(this.save_results_button_Click);
            // 
            // open_folder_button
            // 
            this.open_folder_button.Location = new System.Drawing.Point(504, 87);
            this.open_folder_button.Name = "open_folder_button";
            this.open_folder_button.Size = new System.Drawing.Size(93, 23);
            this.open_folder_button.TabIndex = 15;
            this.open_folder_button.Text = "Open in Explorer";
            this.open_folder_button.UseVisualStyleBackColor = true;
            this.open_folder_button.Click += new System.EventHandler(this.open_folder_button_Click);
            // 
            // charttitle
            // 
            this.charttitle.Location = new System.Drawing.Point(358, 12);
            this.charttitle.Name = "charttitle";
            this.charttitle.Size = new System.Drawing.Size(111, 20);
            this.charttitle.TabIndex = 21;
            this.toolTip1.SetToolTip(this.charttitle, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // Series0
            // 
            this.Series0.Location = new System.Drawing.Point(62, 330);
            this.Series0.Name = "Series0";
            this.Series0.Size = new System.Drawing.Size(150, 20);
            this.Series0.TabIndex = 23;
            this.toolTip1.SetToolTip(this.Series0, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // Series1
            // 
            this.Series1.Location = new System.Drawing.Point(260, 330);
            this.Series1.Name = "Series1";
            this.Series1.Size = new System.Drawing.Size(150, 20);
            this.Series1.TabIndex = 25;
            this.toolTip1.SetToolTip(this.Series1, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // Series2
            // 
            this.Series2.Location = new System.Drawing.Point(464, 330);
            this.Series2.Name = "Series2";
            this.Series2.Size = new System.Drawing.Size(150, 20);
            this.Series2.TabIndex = 27;
            this.toolTip1.SetToolTip(this.Series2, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // Series5
            // 
            this.Series5.Location = new System.Drawing.Point(464, 399);
            this.Series5.Name = "Series5";
            this.Series5.Size = new System.Drawing.Size(150, 20);
            this.Series5.TabIndex = 33;
            this.toolTip1.SetToolTip(this.Series5, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // Series4
            // 
            this.Series4.Location = new System.Drawing.Point(260, 399);
            this.Series4.Name = "Series4";
            this.Series4.Size = new System.Drawing.Size(150, 20);
            this.Series4.TabIndex = 31;
            this.toolTip1.SetToolTip(this.Series4, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // Series3
            // 
            this.Series3.Location = new System.Drawing.Point(62, 399);
            this.Series3.Name = "Series3";
            this.Series3.Size = new System.Drawing.Size(150, 20);
            this.Series3.TabIndex = 29;
            this.toolTip1.SetToolTip(this.Series3, "Type the name of the GPU used to be saved with Min/Max/AVG FPS in MinMaxAVG.txt.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hint: This information is stored about the Min/Max/AVG FPS in the MinMaxAVG.txt f" +
    "ile.";
            // 
            // btn_ChartSelected
            // 
            this.btn_ChartSelected.Location = new System.Drawing.Point(486, 10);
            this.btn_ChartSelected.Name = "btn_ChartSelected";
            this.btn_ChartSelected.Size = new System.Drawing.Size(121, 23);
            this.btn_ChartSelected.TabIndex = 17;
            this.btn_ChartSelected.Text = "Graph selected files";
            this.btn_ChartSelected.UseVisualStyleBackColor = true;
            this.btn_ChartSelected.Click += new System.EventHandler(this.btn_ChartSelected_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Graphing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select the files you\'d like to graph";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(427, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Name:";
            // 
            // file0
            // 
            this.file0.FormattingEnabled = true;
            this.file0.Location = new System.Drawing.Point(62, 303);
            this.file0.Name = "file0";
            this.file0.Size = new System.Drawing.Size(150, 21);
            this.file0.TabIndex = 34;
            // 
            // file1
            // 
            this.file1.FormattingEnabled = true;
            this.file1.Location = new System.Drawing.Point(260, 303);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(150, 21);
            this.file1.TabIndex = 35;
            // 
            // file2
            // 
            this.file2.FormattingEnabled = true;
            this.file2.Location = new System.Drawing.Point(464, 303);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(150, 21);
            this.file2.TabIndex = 36;
            // 
            // file3
            // 
            this.file3.FormattingEnabled = true;
            this.file3.Location = new System.Drawing.Point(62, 372);
            this.file3.Name = "file3";
            this.file3.Size = new System.Drawing.Size(150, 21);
            this.file3.TabIndex = 37;
            // 
            // file4
            // 
            this.file4.FormattingEnabled = true;
            this.file4.Location = new System.Drawing.Point(260, 372);
            this.file4.Name = "file4";
            this.file4.Size = new System.Drawing.Size(150, 21);
            this.file4.TabIndex = 38;
            // 
            // file5
            // 
            this.file5.FormattingEnabled = true;
            this.file5.Location = new System.Drawing.Point(464, 372);
            this.file5.Name = "file5";
            this.file5.Size = new System.Drawing.Size(150, 21);
            this.file5.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Series 6:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Series 5:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Series 4:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Series 3:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Series 2:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Series 1:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_ChartSelected);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.charttitle);
            this.panel1.Location = new System.Drawing.Point(6, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 179);
            this.panel1.TabIndex = 46;
            // 
            // BencherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 438);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.file5);
            this.Controls.Add(this.file4);
            this.Controls.Add(this.file3);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.file0);
            this.Controls.Add(this.Series5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Series4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Series3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Series2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Series1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Series0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.open_folder_button);
            this.Controls.Add(this.save_results_button);
            this.Controls.Add(this.resolution_textbox);
            this.Controls.Add(this.resolution_label);
            this.Controls.Add(this.gpu_textbox);
            this.Controls.Add(this.gpu_label);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.refresh_list_button);
            this.Controls.Add(this.average_fps_label);
            this.Controls.Add(this.max_fps_label);
            this.Controls.Add(this.min_fps_label);
            this.Controls.Add(this.change_directory_button);
            this.Controls.Add(this.directory_label);
            this.Controls.Add(this.load_manually_button);
            this.Controls.Add(this.file_listbox);
            this.Controls.Add(this.file_list_label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BencherWindow";
            this.ShowIcon = false;
            this.Text = "Bencher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BencherWindow_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label file_list_label;
    private System.Windows.Forms.ListBox file_listbox;
    private System.Windows.Forms.Button load_manually_button;
    private System.Windows.Forms.Label directory_label;
    private System.Windows.Forms.Button change_directory_button;
    private System.Windows.Forms.Label min_fps_label;
    private System.Windows.Forms.Label max_fps_label;
    private System.Windows.Forms.Label average_fps_label;
    private System.Windows.Forms.Button refresh_list_button;
    private System.Windows.Forms.Label status_label;
    private System.Windows.Forms.Label gpu_label;
    private System.Windows.Forms.TextBox gpu_textbox;
    private System.Windows.Forms.Label resolution_label;
    private System.Windows.Forms.TextBox resolution_textbox;
    private System.Windows.Forms.Button save_results_button;
    private System.Windows.Forms.Button open_folder_button;
    private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChartSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox charttitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Series0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Series1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Series2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Series5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Series4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Series3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox file0;
        private System.Windows.Forms.ComboBox file1;
        private System.Windows.Forms.ComboBox file2;
        private System.Windows.Forms.ComboBox file3;
        private System.Windows.Forms.ComboBox file4;
        private System.Windows.Forms.ComboBox file5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
    }
}