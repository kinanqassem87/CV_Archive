namespace CV_Archive.PL
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAddDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsManagDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDocSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEnter,
            this.tsManagement,
            this.tsDocSearch,
            this.tsAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsEnter
            // 
            this.tsEnter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSignIn,
            this.tsSignOut,
            this.toolStripSeparator1,
            this.tsChangePassword,
            this.tsBackup});
            this.tsEnter.Name = "tsEnter";
            this.tsEnter.Size = new System.Drawing.Size(53, 20);
            this.tsEnter.Text = "الدخول";
            // 
            // tsSignIn
            // 
            this.tsSignIn.Name = "tsSignIn";
            this.tsSignIn.Size = new System.Drawing.Size(152, 22);
            this.tsSignIn.Text = "تسجيل الدخول";
            this.tsSignIn.Click += new System.EventHandler(this.tsSignIn_Click);
            // 
            // tsSignOut
            // 
            this.tsSignOut.Enabled = false;
            this.tsSignOut.Name = "tsSignOut";
            this.tsSignOut.Size = new System.Drawing.Size(152, 22);
            this.tsSignOut.Text = "تسجيل الخروج";
            this.tsSignOut.Click += new System.EventHandler(this.tsSignOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsChangePassword
            // 
            this.tsChangePassword.Enabled = false;
            this.tsChangePassword.Name = "tsChangePassword";
            this.tsChangePassword.Size = new System.Drawing.Size(152, 22);
            this.tsChangePassword.Text = "تغيير كلمة السر";
            this.tsChangePassword.Click += new System.EventHandler(this.tsChangePassword_Click);
            // 
            // tsManagement
            // 
            this.tsManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddDoc,
            this.tsManagDoc});
            this.tsManagement.Enabled = false;
            this.tsManagement.Name = "tsManagement";
            this.tsManagement.Size = new System.Drawing.Size(96, 20);
            this.tsManagement.Text = "إدارة المستندات";
            // 
            // tsAddDoc
            // 
            this.tsAddDoc.Name = "tsAddDoc";
            this.tsAddDoc.Size = new System.Drawing.Size(181, 22);
            this.tsAddDoc.Text = "اضافة مستند جديد";
            this.tsAddDoc.Click += new System.EventHandler(this.tsAddDoc_Click);
            // 
            // tsManagDoc
            // 
            this.tsManagDoc.Name = "tsManagDoc";
            this.tsManagDoc.Size = new System.Drawing.Size(181, 22);
            this.tsManagDoc.Text = "(تعديل / حذف) مستند";
            this.tsManagDoc.Click += new System.EventHandler(this.tsManagDoc_Click);
            // 
            // tsDocSearch
            // 
            this.tsDocSearch.Enabled = false;
            this.tsDocSearch.Name = "tsDocSearch";
            this.tsDocSearch.Size = new System.Drawing.Size(122, 20);
            this.tsDocSearch.Text = "البحث في المستندات";
            this.tsDocSearch.Click += new System.EventHandler(this.tsDocSearch_Click);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(79, 20);
            this.tsAbout.Text = "حول البرنامج";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CV_Archive.Properties.Resources.white_background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1105, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsBackup
            // 
            this.tsBackup.Enabled = false;
            this.tsBackup.Name = "tsBackup";
            this.tsBackup.Size = new System.Drawing.Size(152, 22);
            this.tsBackup.Text = "Bachup Data";
            this.tsBackup.Click += new System.EventHandler(this.tsBackup_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الواجهة الرئيسية";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsEnter;
        private System.Windows.Forms.ToolStripMenuItem tsSignIn;
        private System.Windows.Forms.ToolStripMenuItem tsSignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsManagement;
        private System.Windows.Forms.ToolStripMenuItem tsAddDoc;
        private System.Windows.Forms.ToolStripMenuItem tsManagDoc;
        private System.Windows.Forms.ToolStripMenuItem tsDocSearch;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsBackup;
    }
}