namespace PresentMonLauncher
{
    partial class frm_Options
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage_Basic = new System.Windows.Forms.TabPage();
            this.groupbox_Hotkey = new System.Windows.Forms.GroupBox();
            this.lbl_Plus = new System.Windows.Forms.Label();
            this.chk_Win = new System.Windows.Forms.CheckBox();
            this.chk_Alt = new System.Windows.Forms.CheckBox();
            this.chk_Ctrl = new System.Windows.Forms.CheckBox();
            this.chk_Shift = new System.Windows.Forms.CheckBox();
            this.cmb_KeyValue = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabpage_Basic.SuspendLayout();
            this.groupbox_Hotkey.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage_Basic);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(257, 162);
            this.tabControl1.TabIndex = 0;
            // 
            // tabpage_Basic
            // 
            this.tabpage_Basic.Controls.Add(this.groupbox_Hotkey);
            this.tabpage_Basic.Location = new System.Drawing.Point(4, 22);
            this.tabpage_Basic.Name = "tabpage_Basic";
            this.tabpage_Basic.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_Basic.Size = new System.Drawing.Size(249, 136);
            this.tabpage_Basic.TabIndex = 0;
            this.tabpage_Basic.Text = "Basic";
            this.tabpage_Basic.UseVisualStyleBackColor = true;
            // 
            // groupbox_Hotkey
            // 
            this.groupbox_Hotkey.Controls.Add(this.lbl_Plus);
            this.groupbox_Hotkey.Controls.Add(this.chk_Win);
            this.groupbox_Hotkey.Controls.Add(this.chk_Alt);
            this.groupbox_Hotkey.Controls.Add(this.chk_Ctrl);
            this.groupbox_Hotkey.Controls.Add(this.chk_Shift);
            this.groupbox_Hotkey.Controls.Add(this.cmb_KeyValue);
            this.groupbox_Hotkey.Location = new System.Drawing.Point(6, 6);
            this.groupbox_Hotkey.Name = "groupbox_Hotkey";
            this.groupbox_Hotkey.Size = new System.Drawing.Size(232, 117);
            this.groupbox_Hotkey.TabIndex = 0;
            this.groupbox_Hotkey.TabStop = false;
            this.groupbox_Hotkey.Text = "Hotkey";
            // 
            // lbl_Plus
            // 
            this.lbl_Plus.AutoSize = true;
            this.lbl_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Plus.Location = new System.Drawing.Point(60, 40);
            this.lbl_Plus.Name = "lbl_Plus";
            this.lbl_Plus.Size = new System.Drawing.Size(25, 26);
            this.lbl_Plus.TabIndex = 5;
            this.lbl_Plus.Text = "+";
            // 
            // chk_Win
            // 
            this.chk_Win.AutoSize = true;
            this.chk_Win.Location = new System.Drawing.Point(6, 64);
            this.chk_Win.Name = "chk_Win";
            this.chk_Win.Size = new System.Drawing.Size(48, 17);
            this.chk_Win.TabIndex = 4;
            this.chk_Win.Text = "WIN";
            this.chk_Win.UseVisualStyleBackColor = true;
            // 
            // chk_Alt
            // 
            this.chk_Alt.AutoSize = true;
            this.chk_Alt.Location = new System.Drawing.Point(6, 40);
            this.chk_Alt.Name = "chk_Alt";
            this.chk_Alt.Size = new System.Drawing.Size(46, 17);
            this.chk_Alt.TabIndex = 3;
            this.chk_Alt.Text = "ALT";
            this.chk_Alt.UseVisualStyleBackColor = true;
            // 
            // chk_Ctrl
            // 
            this.chk_Ctrl.AutoSize = true;
            this.chk_Ctrl.Location = new System.Drawing.Point(6, 19);
            this.chk_Ctrl.Name = "chk_Ctrl";
            this.chk_Ctrl.Size = new System.Drawing.Size(54, 17);
            this.chk_Ctrl.TabIndex = 2;
            this.chk_Ctrl.Text = "CTRL";
            this.chk_Ctrl.UseVisualStyleBackColor = true;
            // 
            // chk_Shift
            // 
            this.chk_Shift.AutoSize = true;
            this.chk_Shift.Location = new System.Drawing.Point(6, 87);
            this.chk_Shift.Name = "chk_Shift";
            this.chk_Shift.Size = new System.Drawing.Size(47, 17);
            this.chk_Shift.TabIndex = 1;
            this.chk_Shift.Text = "Shift";
            this.chk_Shift.UseVisualStyleBackColor = true;
            // 
            // cmb_KeyValue
            // 
            this.cmb_KeyValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_KeyValue.FormattingEnabled = true;
            this.cmb_KeyValue.Location = new System.Drawing.Point(91, 45);
            this.cmb_KeyValue.Name = "cmb_KeyValue";
            this.cmb_KeyValue.Size = new System.Drawing.Size(121, 21);
            this.cmb_KeyValue.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(191, 201);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 236);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_Options";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frm_Options_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpage_Basic.ResumeLayout(false);
            this.groupbox_Hotkey.ResumeLayout(false);
            this.groupbox_Hotkey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage_Basic;
        private System.Windows.Forms.GroupBox groupbox_Hotkey;
        private System.Windows.Forms.Label lbl_Plus;
        private System.Windows.Forms.CheckBox chk_Win;
        private System.Windows.Forms.CheckBox chk_Alt;
        private System.Windows.Forms.CheckBox chk_Ctrl;
        private System.Windows.Forms.CheckBox chk_Shift;
        private System.Windows.Forms.ComboBox cmb_KeyValue;
        private System.Windows.Forms.Button btn_Save;
    }
}