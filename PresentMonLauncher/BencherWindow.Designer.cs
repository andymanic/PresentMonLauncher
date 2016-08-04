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
            this.file_listbox.Size = new System.Drawing.Size(482, 160);
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
            // 
            // save_results_button
            // 
            this.save_results_button.Location = new System.Drawing.Point(504, 117);
            this.save_results_button.Name = "save_results_button";
            this.save_results_button.Size = new System.Drawing.Size(93, 23);
            this.save_results_button.TabIndex = 14;
            this.save_results_button.Text = "Save";
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
            // BencherWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 225);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BencherWindow";
            this.ShowIcon = false;
            this.Text = "Bencher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BencherWindow_FormClosed);
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
  }
}