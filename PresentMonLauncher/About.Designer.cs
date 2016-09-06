namespace PresentMonLauncher
{
    partial class frm_About
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.link_ProjectPage = new System.Windows.Forms.LinkLabel();
            this.lbl_Issues = new System.Windows.Forms.Label();
            this.lbl_OtherIssues = new System.Windows.Forms.Label();
            this.lnk_ProjectEmail = new System.Windows.Forms.LinkLabel();
            this.btn_OK = new System.Windows.Forms.Button();
            this.browser_About = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(13, 13);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(109, 13);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "PresentMonLauncher";
            // 
            // lbl_Version
            // 
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(13, 26);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(42, 13);
            this.lbl_Version.TabIndex = 1;
            this.lbl_Version.Text = "Version";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(25, 65);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(427, 13);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "A free, open source application for benchmarking GPU performance across multiple " +
    "APIs.";
            // 
            // link_ProjectPage
            // 
            this.link_ProjectPage.AutoSize = true;
            this.link_ProjectPage.Location = new System.Drawing.Point(83, 78);
            this.link_ProjectPage.Name = "link_ProjectPage";
            this.link_ProjectPage.Size = new System.Drawing.Size(281, 13);
            this.link_ProjectPage.TabIndex = 3;
            this.link_ProjectPage.TabStop = true;
            this.link_ProjectPage.Text = "http://www.github.com/Andymanic/PresentMonLauncher";
            this.link_ProjectPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_ProjectPage_LinkClicked);
            // 
            // lbl_Issues
            // 
            this.lbl_Issues.AutoSize = true;
            this.lbl_Issues.Location = new System.Drawing.Point(59, 112);
            this.lbl_Issues.Name = "lbl_Issues";
            this.lbl_Issues.Size = new System.Drawing.Size(348, 13);
            this.lbl_Issues.TabIndex = 4;
            this.lbl_Issues.Text = "Issues and Enhancements can be submitted on our Github project page.";
            // 
            // lbl_OtherIssues
            // 
            this.lbl_OtherIssues.AutoSize = true;
            this.lbl_OtherIssues.Location = new System.Drawing.Point(59, 125);
            this.lbl_OtherIssues.Name = "lbl_OtherIssues";
            this.lbl_OtherIssues.Size = new System.Drawing.Size(226, 13);
            this.lbl_OtherIssues.TabIndex = 5;
            this.lbl_OtherIssues.Text = "Other issues and questions can be directed to:";
            // 
            // lnk_ProjectEmail
            // 
            this.lnk_ProjectEmail.AutoSize = true;
            this.lnk_ProjectEmail.Location = new System.Drawing.Point(285, 125);
            this.lnk_ProjectEmail.Name = "lnk_ProjectEmail";
            this.lnk_ProjectEmail.Size = new System.Drawing.Size(122, 13);
            this.lnk_ProjectEmail.TabIndex = 6;
            this.lnk_ProjectEmail.TabStop = true;
            this.lnk_ProjectEmail.Text = "inbox@techteamgb.com";
            this.lnk_ProjectEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_ProjectEmail_LinkClicked);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(377, 424);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "&Ok";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // browser_About
            // 
            this.browser_About.Location = new System.Drawing.Point(28, 168);
            this.browser_About.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser_About.Name = "browser_About";
            this.browser_About.ScrollBarsEnabled = false;
            this.browser_About.Size = new System.Drawing.Size(424, 250);
            this.browser_About.TabIndex = 14;
            this.browser_About.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 452);
            this.Controls.Add(this.browser_About);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lnk_ProjectEmail);
            this.Controls.Add(this.lbl_OtherIssues);
            this.Controls.Add(this.lbl_Issues);
            this.Controls.Add(this.link_ProjectPage);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_About";
            this.ShowIcon = false;
            this.Text = "About PresentMonLauncher";
            this.Load += new System.EventHandler(this.frm_About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.LinkLabel link_ProjectPage;
        private System.Windows.Forms.Label lbl_Issues;
        private System.Windows.Forms.Label lbl_OtherIssues;
        private System.Windows.Forms.LinkLabel lnk_ProjectEmail;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.WebBrowser browser_About;
    }
}