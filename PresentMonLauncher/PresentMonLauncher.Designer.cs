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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresentMonLauncher));
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
            this.bencher = new System.Windows.Forms.Button();
            this.argument = new System.Windows.Forms.Label();
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
            this.outputcheck = new System.Windows.Forms.CheckBox();
            this.etlcheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menustrip_Title = new System.Windows.Forms.MenuStrip();
            this.menuitem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_About = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.delay_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_updown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menustrip_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // launch
            // 
            this.launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launch.Location = new System.Drawing.Point(498, 195);
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
            this.Simple.Location = new System.Drawing.Point(16, 228);
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
            this.nocsv.Location = new System.Drawing.Point(129, 228);
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
            this.process_list.Location = new System.Drawing.Point(16, 57);
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
            this.label8.Location = new System.Drawing.Point(11, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Select the process you want to capture:";
            // 
            // outputfile
            // 
            this.outputfile.Location = new System.Drawing.Point(16, 297);
            this.outputfile.Name = "outputfile";
            this.outputfile.Size = new System.Drawing.Size(329, 20);
            this.outputfile.TabIndex = 13;
            this.toolTip1.SetToolTip(this.outputfile, "The flags to use.");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(269, 226);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Delay (s): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Time (s):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(416, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Selected process:";
            // 
            // currentflags
            // 
            this.currentflags.AutoSize = true;
            this.currentflags.Location = new System.Drawing.Point(514, 64);
            this.currentflags.Name = "currentflags";
            this.currentflags.Size = new System.Drawing.Size(0, 13);
            this.currentflags.TabIndex = 26;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(419, 34);
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
            this.openfolder.Location = new System.Drawing.Point(517, 34);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(95, 25);
            this.openfolder.TabIndex = 28;
            this.openfolder.Text = "Open Folder";
            this.toolTip1.SetToolTip(this.openfolder, "Open in Windows Explorer.");
            this.openfolder.UseVisualStyleBackColor = true;
            this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
            // 
            // bencher
            // 
            this.bencher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bencher.Location = new System.Drawing.Point(498, 248);
            this.bencher.Name = "bencher";
            this.bencher.Size = new System.Drawing.Size(143, 45);
            this.bencher.TabIndex = 30;
            this.bencher.Text = "Analyze Results";
            this.toolTip1.SetToolTip(this.bencher, "Click to open the bencher application. You can load the CSV files and see Min/Max" +
        "/AVG FPS, and create graphable result files.");
            this.bencher.UseVisualStyleBackColor = true;
            this.bencher.Click += new System.EventHandler(this.bencher_Click);
            // 
            // argument
            // 
            this.argument.AutoSize = true;
            this.argument.Location = new System.Drawing.Point(523, 63);
            this.argument.Name = "argument";
            this.argument.Size = new System.Drawing.Size(0, 13);
            this.argument.TabIndex = 35;
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
            this.delay_updown.Location = new System.Drawing.Point(343, 228);
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
            this.time_updown.Location = new System.Drawing.Point(343, 254);
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
            this.exclude.Location = new System.Drawing.Point(5, 32);
            this.exclude.Name = "exclude";
            this.exclude.Size = new System.Drawing.Size(108, 17);
            this.exclude.TabIndex = 43;
            this.exclude.Text = "Exclude Dropped";
            this.exclude.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(349, 295);
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
            this.etlbutton.Location = new System.Drawing.Point(349, 342);
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
            this.etlfile.Location = new System.Drawing.Point(16, 346);
            this.etlfile.Name = "etlfile";
            this.etlfile.Size = new System.Drawing.Size(329, 20);
            this.etlfile.TabIndex = 47;
            this.toolTip1.SetToolTip(this.etlfile, "The flags to use.");
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(89, 273);
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
            this.button4.Location = new System.Drawing.Point(77, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 20);
            this.button4.TabIndex = 51;
            this.button4.Text = "?";
            this.toolTip1.SetToolTip(this.button4, "Open in Windows Explorer.");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // outputcheck
            // 
            this.outputcheck.AutoSize = true;
            this.outputcheck.Location = new System.Drawing.Point(16, 274);
            this.outputcheck.Name = "outputcheck";
            this.outputcheck.Size = new System.Drawing.Size(80, 17);
            this.outputcheck.TabIndex = 45;
            this.outputcheck.Text = "Output File:";
            this.outputcheck.UseVisualStyleBackColor = true;
            // 
            // etlcheck
            // 
            this.etlcheck.AutoSize = true;
            this.etlcheck.Location = new System.Drawing.Point(16, 323);
            this.etlcheck.Name = "etlcheck";
            this.etlcheck.Size = new System.Drawing.Size(65, 17);
            this.etlcheck.TabIndex = 48;
            this.etlcheck.Text = "ETL File";
            this.etlcheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Options";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exclude);
            this.panel1.Location = new System.Drawing.Point(10, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 157);
            this.panel1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 85);
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
            this.panel2.Location = new System.Drawing.Point(414, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 93);
            this.panel2.TabIndex = 55;
            // 
            // menustrip_Title
            // 
            this.menustrip_Title.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitem_File,
            this.menuitem_Tools,
            this.menuitem_Help});
            this.menustrip_Title.Location = new System.Drawing.Point(0, 0);
            this.menustrip_Title.Name = "menustrip_Title";
            this.menustrip_Title.Size = new System.Drawing.Size(650, 24);
            this.menustrip_Title.TabIndex = 56;
            this.menustrip_Title.Text = "menuStrip1";
            // 
            // menuitem_File
            // 
            this.menuitem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_Exit});
            this.menuitem_File.Name = "menuitem_File";
            this.menuitem_File.Size = new System.Drawing.Size(37, 20);
            this.menuitem_File.Text = "&File";
            // 
            // submenu_Exit
            // 
            this.submenu_Exit.Name = "submenu_Exit";
            this.submenu_Exit.Size = new System.Drawing.Size(92, 22);
            this.submenu_Exit.Text = "&Exit";
            this.submenu_Exit.Click += new System.EventHandler(this.submenu_Exit_Click);
            // 
            // menuitem_Tools
            // 
            this.menuitem_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_Options});
            this.menuitem_Tools.Name = "menuitem_Tools";
            this.menuitem_Tools.Size = new System.Drawing.Size(47, 20);
            this.menuitem_Tools.Text = "&Tools";
            // 
            // submenu_Options
            // 
            this.submenu_Options.Name = "submenu_Options";
            this.submenu_Options.Size = new System.Drawing.Size(116, 22);
            this.submenu_Options.Text = "&Options";
            this.submenu_Options.Click += new System.EventHandler(this.submenu_Options_Click);
            // 
            // menuitem_Help
            // 
            this.menuitem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_About});
            this.menuitem_Help.Name = "menuitem_Help";
            this.menuitem_Help.Size = new System.Drawing.Size(44, 20);
            this.menuitem_Help.Text = "&Help";
            // 
            // submenu_About
            // 
            this.submenu_About.Name = "submenu_About";
            this.submenu_About.Size = new System.Drawing.Size(107, 22);
            this.submenu_About.Text = "&About";
            this.submenu_About.Click += new System.EventHandler(this.submenu_About_Click);
            // 
            // PresentMonLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.etlbutton);
            this.Controls.Add(this.etlcheck);
            this.Controls.Add(this.etlfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputcheck);
            this.Controls.Add(this.time_updown);
            this.Controls.Add(this.delay_updown);
            this.Controls.Add(this.argument);
            this.Controls.Add(this.bencher);
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
            this.Controls.Add(this.menustrip_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menustrip_Title;
            this.MaximizeBox = false;
            this.Name = "PresentMonLauncher";
            this.Text = "PresentMonLauncher V0.9A";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresentMonLauncher_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.delay_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time_updown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menustrip_Title.ResumeLayout(false);
            this.menustrip_Title.PerformLayout();
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
        private System.Windows.Forms.Button bencher;
        private System.Windows.Forms.Label argument;
    private System.Windows.Forms.ComboBox config_dropdown;
    private System.Windows.Forms.Button save_config_button;
    private System.Windows.Forms.Button load_config_button;
    private System.Windows.Forms.NumericUpDown delay_updown;
    private System.Windows.Forms.NumericUpDown time_updown;
    private System.Windows.Forms.CheckBox exclude;
    private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.MenuStrip menustrip_Title;
        private System.Windows.Forms.ToolStripMenuItem menuitem_File;
        private System.Windows.Forms.ToolStripMenuItem submenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem menuitem_Tools;
        private System.Windows.Forms.ToolStripMenuItem submenu_Options;
        private System.Windows.Forms.ToolStripMenuItem menuitem_Help;
        private System.Windows.Forms.ToolStripMenuItem submenu_About;
    }
}

