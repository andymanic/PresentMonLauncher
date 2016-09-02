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
            this.Simple = new System.Windows.Forms.CheckBox();
            this.nocsv = new System.Windows.Forms.CheckBox();
            this.process_list = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.outputfile = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.currentflags = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.openfolder = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.bencher = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.argument = new System.Windows.Forms.Label();
            this.scroll = new System.Windows.Forms.CheckBox();
            this.config_dropdown = new System.Windows.Forms.ComboBox();
            this.save_config_button = new System.Windows.Forms.Button();
            this.load_config_button = new System.Windows.Forms.Button();
            this.delay_updown = new System.Windows.Forms.NumericUpDown();
            this.time_updown = new System.Windows.Forms.NumericUpDown();
            this.exclude = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.etlbutton = new System.Windows.Forms.Button();
            this.etlfile = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.outputcheck = new System.Windows.Forms.CheckBox();
            this.etlcheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.delay_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_updown)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch.Location = new System.Drawing.Point(494, 173);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(143, 45);
            this.launch.TabIndex = 0;
            this.launch.Text = "Run PresentMon";
            this.toolTip1.SetToolTip(this.launch, "Click to run the PresentMon Benchmarking application, once you\'ve selected the pr" +
        "ocess.");
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // Simple
            // 
            this.Simple.AutoSize = true;
            this.Simple.Location = new System.Drawing.Point(12, 206);
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
            this.nocsv.Location = new System.Drawing.Point(125, 206);
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
            this.process_list.Size = new System.Drawing.Size(385, 154);
            this.process_list.TabIndex = 9;
            this.toolTip1.SetToolTip(this.process_list, "Available processes.");
            this.process_list.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.process_list_ItemCheck);
            this.process_list.SelectedIndexChanged += new System.EventHandler(this.process_list_SelectedIndexChanged);
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
            // outputfile
            // 
            this.outputfile.Location = new System.Drawing.Point(12, 275);
            this.outputfile.Name = "outputfile";
            this.outputfile.Size = new System.Drawing.Size(329, 20);
            this.outputfile.TabIndex = 13;
            this.toolTip1.SetToolTip(this.outputfile, "The flags to use.");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(265, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Delay (s): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Time (s):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(412, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Selected process:";
            // 
            // currentflags
            // 
            this.currentflags.AutoSize = true;
            this.currentflags.Location = new System.Drawing.Point(510, 42);
            this.currentflags.Name = "currentflags";
            this.currentflags.Size = new System.Drawing.Size(0, 13);
            this.currentflags.TabIndex = 26;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(415, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(95, 25);
            this.refresh.TabIndex = 27;
            this.refresh.Text = "Refresh List";
            this.toolTip1.SetToolTip(this.refresh, "Click to refresh the list of active processes.");
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // openfolder
            // 
            this.openfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openfolder.Location = new System.Drawing.Point(513, 12);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(95, 25);
            this.openfolder.TabIndex = 28;
            this.openfolder.Text = "Open Folder";
            this.toolTip1.SetToolTip(this.openfolder, "Open in Windows Explorer.");
            this.openfolder.UseVisualStyleBackColor = true;
            this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(411, 294);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(226, 52);
            this.label18.TabIndex = 29;
            this.label18.Text = "Created by Andrew from TechteamGB\r\nPresentMon by Intel available here\r\nBencher to" +
    "ol by Jim from AdoredTV\r\nProgram re-written by Daniel Holtzclaw";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bencher
            // 
            this.bencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bencher.Location = new System.Drawing.Point(494, 226);
            this.bencher.Name = "bencher";
            this.bencher.Size = new System.Drawing.Size(143, 45);
            this.bencher.TabIndex = 30;
            this.bencher.Text = "Analyze Results";
            this.toolTip1.SetToolTip(this.bencher, "Click to open the bencher application. You can load the CSV files and see Min/Max" +
        "/AVG FPS, and create graphable result files.");
            this.bencher.UseVisualStyleBackColor = true;
            this.bencher.Click += new System.EventHandler(this.bencher_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(557, 294);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TechteamGB";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(605, 307);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(32, 13);
            this.linkLabel2.TabIndex = 33;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "here";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(574, 320);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(63, 13);
            this.linkLabel3.TabIndex = 34;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "AdoredTV";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // argument
            // 
            this.argument.AutoSize = true;
            this.argument.Location = new System.Drawing.Point(519, 41);
            this.argument.Name = "argument";
            this.argument.Size = new System.Drawing.Size(0, 13);
            this.argument.TabIndex = 35;
            // 
            // scroll
            // 
            this.scroll.AutoSize = true;
            this.scroll.Location = new System.Drawing.Point(12, 229);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(88, 17);
            this.scroll.TabIndex = 36;
            this.scroll.Text = "Scroll Toggle";
            this.scroll.UseVisualStyleBackColor = true;
            // 
            // config_dropdown
            // 
            this.config_dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.config_dropdown.FormattingEnabled = true;
            this.config_dropdown.Location = new System.Drawing.Point(13, 16);
            this.config_dropdown.Name = "config_dropdown";
            this.config_dropdown.Size = new System.Drawing.Size(193, 21);
            this.config_dropdown.TabIndex = 38;
            this.toolTip1.SetToolTip(this.config_dropdown, "Select a config. (From Program Dir/Config)");
            this.config_dropdown.SelectedIndexChanged += new System.EventHandler(this.config_dropdown_SelectedIndexChanged);
            // 
            // save_config_button
            // 
            this.save_config_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_config_button.Location = new System.Drawing.Point(13, 49);
            this.save_config_button.Name = "save_config_button";
            this.save_config_button.Size = new System.Drawing.Size(89, 35);
            this.save_config_button.TabIndex = 39;
            this.save_config_button.Text = "Save";
            this.toolTip1.SetToolTip(this.save_config_button, "Save your current selected variables as a preset in the Program Dir/Config folder" +
        ".");
            this.save_config_button.UseVisualStyleBackColor = true;
            this.save_config_button.Click += new System.EventHandler(this.save_config_button_Click);
            // 
            // load_config_button
            // 
            this.load_config_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_config_button.Location = new System.Drawing.Point(114, 49);
            this.load_config_button.Name = "load_config_button";
            this.load_config_button.Size = new System.Drawing.Size(92, 35);
            this.load_config_button.TabIndex = 40;
            this.load_config_button.Text = "Load";
            this.toolTip1.SetToolTip(this.load_config_button, "Manually load a saved preset.");
            this.load_config_button.UseVisualStyleBackColor = true;
            this.load_config_button.Click += new System.EventHandler(this.load_config_button_Click);
            // 
            // delay_updown
            // 
            this.delay_updown.Location = new System.Drawing.Point(339, 206);
            this.delay_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delay_updown.Name = "delay_updown";
            this.delay_updown.Size = new System.Drawing.Size(58, 20);
            this.delay_updown.TabIndex = 41;
            this.delay_updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.delay_updown, "Input the number of seconds to wait before benching. (Maximum: 1000)");
            // 
            // time_updown
            // 
            this.time_updown.Location = new System.Drawing.Point(339, 232);
            this.time_updown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.time_updown.Name = "time_updown";
            this.time_updown.Size = new System.Drawing.Size(58, 20);
            this.time_updown.TabIndex = 42;
            this.time_updown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.time_updown, "Set the duration of benching. (Max: 1000)");
            // 
            // exclude
            // 
            this.exclude.AutoSize = true;
            this.exclude.Location = new System.Drawing.Point(125, 229);
            this.exclude.Name = "exclude";
            this.exclude.Size = new System.Drawing.Size(108, 17);
            this.exclude.TabIndex = 43;
            this.exclude.Text = "Exclude Dropped";
            this.exclude.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 25);
            this.button1.TabIndex = 46;
            this.button1.Text = "...";
            this.toolTip1.SetToolTip(this.button1, "Open in Windows Explorer.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etlbutton
            // 
            this.etlbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etlbutton.Location = new System.Drawing.Point(345, 320);
            this.etlbutton.Name = "etlbutton";
            this.etlbutton.Size = new System.Drawing.Size(52, 25);
            this.etlbutton.TabIndex = 49;
            this.etlbutton.Text = "...";
            this.toolTip1.SetToolTip(this.etlbutton, "Open in Windows Explorer.");
            this.etlbutton.UseVisualStyleBackColor = true;
            this.etlbutton.Click += new System.EventHandler(this.etlbutton_Click);
            // 
            // etlfile
            // 
            this.etlfile.Location = new System.Drawing.Point(12, 324);
            this.etlfile.Name = "etlfile";
            this.etlfile.Size = new System.Drawing.Size(329, 20);
            this.etlfile.TabIndex = 47;
            this.toolTip1.SetToolTip(this.etlfile, "The flags to use.");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(85, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 20);
            this.button3.TabIndex = 50;
            this.button3.Text = "?";
            this.toolTip1.SetToolTip(this.button3, "Open in Windows Explorer.");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(73, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 20);
            this.button4.TabIndex = 51;
            this.button4.Text = "?";
            this.toolTip1.SetToolTip(this.button4, "Open in Windows Explorer.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(538, 333);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(102, 13);
            this.linkLabel4.TabIndex = 44;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Daniel Holtzclaw";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // outputcheck
            // 
            this.outputcheck.AutoSize = true;
            this.outputcheck.Location = new System.Drawing.Point(12, 252);
            this.outputcheck.Name = "outputcheck";
            this.outputcheck.Size = new System.Drawing.Size(80, 17);
            this.outputcheck.TabIndex = 45;
            this.outputcheck.Text = "Output File:";
            this.outputcheck.UseVisualStyleBackColor = true;
            // 
            // etlcheck
            // 
            this.etlcheck.AutoSize = true;
            this.etlcheck.Location = new System.Drawing.Point(12, 301);
            this.etlcheck.Name = "etlcheck";
            this.etlcheck.Size = new System.Drawing.Size(65, 17);
            this.etlcheck.TabIndex = 48;
            this.etlcheck.Text = "ETL File";
            this.etlcheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(6, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 157);
            this.panel1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Presets";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.config_dropdown);
            this.panel2.Controls.Add(this.save_config_button);
            this.panel2.Controls.Add(this.load_config_button);
            this.panel2.Location = new System.Drawing.Point(410, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 93);
            this.panel2.TabIndex = 55;
            // 
            // PresentMonLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.etlbutton);
            this.Controls.Add(this.etlcheck);
            this.Controls.Add(this.etlfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputcheck);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.exclude);
            this.Controls.Add(this.time_updown);
            this.Controls.Add(this.delay_updown);
            this.Controls.Add(this.scroll);
            this.Controls.Add(this.argument);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bencher);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.openfolder);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.currentflags);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.outputfile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.process_list);
            this.Controls.Add(this.nocsv);
            this.Controls.Add(this.Simple);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PresentMonLauncher";
            this.ShowIcon = false;
            this.Text = "PresentMonLauncher V0.7A";
            ((System.ComponentModel.ISupportInitialize)(this.delay_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_updown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launch;
        private System.Windows.Forms.CheckBox Simple;
        private System.Windows.Forms.CheckBox nocsv;
        private System.Windows.Forms.CheckedListBox process_list;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox outputfile;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label currentflags;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button openfolder;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button bencher;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.Label argument;
        private System.Windows.Forms.CheckBox scroll;
    private System.Windows.Forms.ComboBox config_dropdown;
    private System.Windows.Forms.Button save_config_button;
    private System.Windows.Forms.Button load_config_button;
    private System.Windows.Forms.NumericUpDown delay_updown;
    private System.Windows.Forms.NumericUpDown time_updown;
    private System.Windows.Forms.CheckBox exclude;
    private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.CheckBox outputcheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button etlbutton;
        private System.Windows.Forms.CheckBox etlcheck;
        private System.Windows.Forms.TextBox etlfile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}

