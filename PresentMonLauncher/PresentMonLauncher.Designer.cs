namespace PresentMonLauncher
{
    partial class PresentMonLauncher
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
      this.launch = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.Simple = new System.Windows.Forms.CheckBox();
      this.nocsv = new System.Windows.Forms.CheckBox();
      this.process_list = new System.Windows.Forms.CheckedListBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.flags = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.currentflags = new System.Windows.Forms.Label();
      this.refresh = new System.Windows.Forms.Button();
      this.openfolder = new System.Windows.Forms.Button();
      this.label18 = new System.Windows.Forms.Label();
      this.bencher = new System.Windows.Forms.Button();
      this.label19 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel3 = new System.Windows.Forms.LinkLabel();
      this.argument = new System.Windows.Forms.Label();
      this.scroll = new System.Windows.Forms.CheckBox();
      this.config_label = new System.Windows.Forms.Label();
      this.config_dropdown = new System.Windows.Forms.ComboBox();
      this.save_config_button = new System.Windows.Forms.Button();
      this.load_config_button = new System.Windows.Forms.Button();
      this.delay_updown = new System.Windows.Forms.NumericUpDown();
      this.time_updown = new System.Windows.Forms.NumericUpDown();
      this.exclude = new System.Windows.Forms.CheckBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.delay_updown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.time_updown)).BeginInit();
      this.SuspendLayout();
      // 
      // launch
      // 
      this.launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.launch.Location = new System.Drawing.Point(12, 244);
      this.launch.Name = "launch";
      this.launch.Size = new System.Drawing.Size(148, 45);
      this.launch.TabIndex = 0;
      this.launch.Text = "Run PresentMon";
      this.toolTip1.SetToolTip(this.launch, "Click to run the PresentMon Benchmarking application, once you\'ve selected the pr" +
        "ocess.");
      this.launch.UseVisualStyleBackColor = true;
      this.launch.Click += new System.EventHandler(this.launch_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(722, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(165, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Available Flags:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(724, 42);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(246, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "-output_file [path]: override the default output path.";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(724, 68);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(325, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "-etl_file [path]: consume events from an ETL file instead of real-time.";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(724, 94);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(317, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "-exclude_dropped: exclude dropped presents from the csv output.";
      // 
      // Simple
      // 
      this.Simple.AutoSize = true;
      this.Simple.Location = new System.Drawing.Point(12, 195);
      this.Simple.Name = "Simple";
      this.Simple.Size = new System.Drawing.Size(57, 17);
      this.Simple.TabIndex = 7;
      this.Simple.Text = "Simple";
      this.toolTip1.SetToolTip(this.Simple, "Select to disable advanced tracking. Try this if you encounter crashes.");
      this.Simple.UseVisualStyleBackColor = true;
      // 
      // nocsv
      // 
      this.nocsv.AutoSize = true;
      this.nocsv.Location = new System.Drawing.Point(87, 195);
      this.nocsv.Name = "nocsv";
      this.nocsv.Size = new System.Drawing.Size(99, 17);
      this.nocsv.TabIndex = 8;
      this.nocsv.Text = "No CSV Output";
      this.nocsv.UseVisualStyleBackColor = true;
      // 
      // process_list
      // 
      this.process_list.CheckOnClick = true;
      this.process_list.FormattingEnabled = true;
      this.process_list.Location = new System.Drawing.Point(12, 35);
      this.process_list.Name = "process_list";
      this.process_list.ScrollAlwaysVisible = true;
      this.process_list.Size = new System.Drawing.Size(706, 154);
      this.process_list.Sorted = true;
      this.process_list.TabIndex = 9;
      this.toolTip1.SetToolTip(this.process_list, "Available processes.");
      this.process_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.process_list_ItemCheck);
      this.process_list.SelectedIndexChanged += new System.EventHandler(this.process_list_SelectedIndexChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(7, 212);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(71, 25);
      this.label7.TabIndex = 11;
      this.label7.Text = "Flags:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(7, 5);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(390, 25);
      this.label8.TabIndex = 12;
      this.label8.Text = "Select the process you want to capture:";
      // 
      // flags
      // 
      this.flags.Location = new System.Drawing.Point(75, 215);
      this.flags.Name = "flags";
      this.flags.Size = new System.Drawing.Size(643, 20);
      this.flags.TabIndex = 13;
      this.toolTip1.SetToolTip(this.flags, "The flags to use.");
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(724, 151);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(269, 13);
      this.label9.TabIndex = 15;
      this.label9.Text = "Dropped: boolean indicator. 1 = dropped, 0 = displayed.";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(722, 120);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(270, 25);
      this.label10.TabIndex = 14;
      this.label10.Text = "CSV Column Explanations:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(724, 174);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(382, 13);
      this.label11.TabIndex = 16;
      this.label11.Text = "MsBetweenPresents: time between this Present() API call and the previous one.";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(724, 198);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(352, 26);
      this.label12.TabIndex = 17;
      this.label12.Text = "MsBetweenDisplayChange: time between when this frame was displayed,\r\nand previous" +
    " was displayed.";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(724, 236);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(272, 13);
      this.label13.TabIndex = 18;
      this.label13.Text = "MsInPresentAPI: time spent inside the Present() API call.";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(725, 263);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(381, 13);
      this.label14.TabIndex = 19;
      this.label14.Text = "MsUntilRenderComplete: time between present start and GPU work completion.";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.Location = new System.Drawing.Point(725, 291);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(306, 13);
      this.label15.TabIndex = 20;
      this.label15.Text = "MsUntilDisplayed: time between present start and frame display.";
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(166, 252);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(110, 25);
      this.label16.TabIndex = 21;
      this.label16.Text = "Delay (s): ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(377, 252);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(96, 25);
      this.label4.TabIndex = 23;
      this.label4.Text = "Time (s):";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.Location = new System.Drawing.Point(412, 328);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(92, 13);
      this.label17.TabIndex = 25;
      this.label17.Text = "Selected process:";
      // 
      // currentflags
      // 
      this.currentflags.AutoSize = true;
      this.currentflags.Location = new System.Drawing.Point(510, 328);
      this.currentflags.Name = "currentflags";
      this.currentflags.Size = new System.Drawing.Size(0, 13);
      this.currentflags.TabIndex = 26;
      // 
      // refresh
      // 
      this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.refresh.Location = new System.Drawing.Point(580, 5);
      this.refresh.Name = "refresh";
      this.refresh.Size = new System.Drawing.Size(138, 25);
      this.refresh.TabIndex = 27;
      this.refresh.Text = "Refresh List";
      this.toolTip1.SetToolTip(this.refresh, "Click to refresh the list of active processes.");
      this.refresh.UseVisualStyleBackColor = true;
      this.refresh.Click += new System.EventHandler(this.refresh_Click);
      // 
      // openfolder
      // 
      this.openfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.openfolder.Location = new System.Drawing.Point(580, 244);
      this.openfolder.Name = "openfolder";
      this.openfolder.Size = new System.Drawing.Size(138, 45);
      this.openfolder.TabIndex = 28;
      this.openfolder.Text = "Open Folder";
      this.toolTip1.SetToolTip(this.openfolder, "Open in Windows Explorer.");
      this.openfolder.UseVisualStyleBackColor = true;
      this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.Location = new System.Drawing.Point(797, 316);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(309, 45);
      this.label18.TabIndex = 29;
      this.label18.Text = "Created by Andrew from TechteamGB\r\nPresentMon created by Intel and available here" +
    "\r\nBencher tool created by Jim from AdoredTV";
      this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // bencher
      // 
      this.bencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bencher.Location = new System.Drawing.Point(12, 295);
      this.bencher.Name = "bencher";
      this.bencher.Size = new System.Drawing.Size(189, 45);
      this.bencher.TabIndex = 30;
      this.bencher.Text = "View Results";
      this.toolTip1.SetToolTip(this.bencher, "Click to open the bencher application. You can load the CSV files and see Min/Max" +
        "/AVG FPS, and create graphable result files.");
      this.bencher.UseVisualStyleBackColor = true;
      this.bencher.Click += new System.EventHandler(this.bencher_Click);
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Location = new System.Drawing.Point(12, 344);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(200, 13);
      this.label19.TabIndex = 31;
      this.label19.Text = "Hint: Enter your file names without \".csv\"";
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel1.Location = new System.Drawing.Point(1017, 316);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(89, 15);
      this.linkLabel1.TabIndex = 32;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "TechteamGB";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel2.Location = new System.Drawing.Point(1070, 331);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(36, 15);
      this.linkLabel2.TabIndex = 33;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "here";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // linkLabel3
      // 
      this.linkLabel3.AutoSize = true;
      this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.linkLabel3.Location = new System.Drawing.Point(1038, 346);
      this.linkLabel3.Name = "linkLabel3";
      this.linkLabel3.Size = new System.Drawing.Size(68, 15);
      this.linkLabel3.TabIndex = 34;
      this.linkLabel3.TabStop = true;
      this.linkLabel3.Text = "AdoredTV";
      this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
      // 
      // argument
      // 
      this.argument.AutoSize = true;
      this.argument.Location = new System.Drawing.Point(519, 327);
      this.argument.Name = "argument";
      this.argument.Size = new System.Drawing.Size(0, 13);
      this.argument.TabIndex = 35;
      // 
      // scroll
      // 
      this.scroll.AutoSize = true;
      this.scroll.Location = new System.Drawing.Point(210, 195);
      this.scroll.Name = "scroll";
      this.scroll.Size = new System.Drawing.Size(88, 17);
      this.scroll.TabIndex = 36;
      this.scroll.Text = "Scroll Toggle";
      this.scroll.UseVisualStyleBackColor = true;
      // 
      // config_label
      // 
      this.config_label.AutoSize = true;
      this.config_label.Location = new System.Drawing.Point(203, 298);
      this.config_label.Name = "config_label";
      this.config_label.Size = new System.Drawing.Size(40, 13);
      this.config_label.TabIndex = 37;
      this.config_label.Text = "Config:";
      // 
      // config_dropdown
      // 
      this.config_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.config_dropdown.FormattingEnabled = true;
      this.config_dropdown.Location = new System.Drawing.Point(249, 295);
      this.config_dropdown.Name = "config_dropdown";
      this.config_dropdown.Size = new System.Drawing.Size(316, 21);
      this.config_dropdown.TabIndex = 38;
      this.toolTip1.SetToolTip(this.config_dropdown, "Select a config. (From Program Dir/Config)");
      this.config_dropdown.SelectedIndexChanged += new System.EventHandler(this.config_dropdown_SelectedIndexChanged);
      // 
      // save_config_button
      // 
      this.save_config_button.Location = new System.Drawing.Point(249, 323);
      this.save_config_button.Name = "save_config_button";
      this.save_config_button.Size = new System.Drawing.Size(75, 23);
      this.save_config_button.TabIndex = 39;
      this.save_config_button.Text = "Save Config";
      this.toolTip1.SetToolTip(this.save_config_button, "Save your current selected variables as a preset in the Program Dir/Config folder" +
        ".");
      this.save_config_button.UseVisualStyleBackColor = true;
      this.save_config_button.Click += new System.EventHandler(this.save_config_button_Click);
      // 
      // load_config_button
      // 
      this.load_config_button.Location = new System.Drawing.Point(331, 323);
      this.load_config_button.Name = "load_config_button";
      this.load_config_button.Size = new System.Drawing.Size(75, 23);
      this.load_config_button.TabIndex = 40;
      this.load_config_button.Text = "Load Config";
      this.toolTip1.SetToolTip(this.load_config_button, "Manually load a saved preset.");
      this.load_config_button.UseVisualStyleBackColor = true;
      this.load_config_button.Click += new System.EventHandler(this.load_config_button_Click);
      // 
      // delay_updown
      // 
      this.delay_updown.Location = new System.Drawing.Point(271, 256);
      this.delay_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.delay_updown.Name = "delay_updown";
      this.delay_updown.Size = new System.Drawing.Size(100, 20);
      this.delay_updown.TabIndex = 41;
      this.delay_updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.delay_updown, "Input the number of seconds to wait before benching. (Maximum: 1000)");
      // 
      // time_updown
      // 
      this.time_updown.Location = new System.Drawing.Point(470, 256);
      this.time_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.time_updown.Name = "time_updown";
      this.time_updown.Size = new System.Drawing.Size(95, 20);
      this.time_updown.TabIndex = 42;
      this.time_updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.toolTip1.SetToolTip(this.time_updown, "Set the duration of benching. (Max: 1000)");
      // 
      // exclude
      // 
      this.exclude.AutoSize = true;
      this.exclude.Location = new System.Drawing.Point(331, 195);
      this.exclude.Name = "exclude";
      this.exclude.Size = new System.Drawing.Size(152, 17);
      this.exclude.TabIndex = 43;
      this.exclude.Text = "Exclude Dropped Presents";
      this.exclude.UseVisualStyleBackColor = true;
      // 
      // PresentMonLauncher
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1108, 366);
      this.Controls.Add(this.exclude);
      this.Controls.Add(this.time_updown);
      this.Controls.Add(this.delay_updown);
      this.Controls.Add(this.load_config_button);
      this.Controls.Add(this.save_config_button);
      this.Controls.Add(this.config_dropdown);
      this.Controls.Add(this.config_label);
      this.Controls.Add(this.scroll);
      this.Controls.Add(this.argument);
      this.Controls.Add(this.linkLabel3);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label19);
      this.Controls.Add(this.bencher);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.openfolder);
      this.Controls.Add(this.refresh);
      this.Controls.Add(this.currentflags);
      this.Controls.Add(this.label17);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label16);
      this.Controls.Add(this.label15);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.flags);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.process_list);
      this.Controls.Add(this.nocsv);
      this.Controls.Add(this.Simple);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.launch);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "PresentMonLauncher";
      this.ShowIcon = false;
      this.Text = "PresentMonLauncher";
      ((System.ComponentModel.ISupportInitialize)(this.delay_updown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.time_updown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Simple;
        private System.Windows.Forms.CheckBox nocsv;
        private System.Windows.Forms.CheckedListBox process_list;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label currentflags;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button openfolder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button bencher;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label argument;
        private System.Windows.Forms.CheckBox scroll;
    private System.Windows.Forms.Label config_label;
    private System.Windows.Forms.ComboBox config_dropdown;
    private System.Windows.Forms.Button save_config_button;
    private System.Windows.Forms.Button load_config_button;
    private System.Windows.Forms.NumericUpDown delay_updown;
    private System.Windows.Forms.NumericUpDown time_updown;
    private System.Windows.Forms.CheckBox exclude;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

