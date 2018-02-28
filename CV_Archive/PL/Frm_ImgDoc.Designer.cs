namespace CV_Archive.PL
{
    partial class Frm_ImgDoc
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
            this.btnExport = new System.Windows.Forms.Button();
            this.txtIMGid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelectOne = new System.Windows.Forms.Button();
            this.btnFirstIMG = new System.Windows.Forms.Button();
            this.btnNextIMG = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(446, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(163, 23);
            this.btnExport.TabIndex = 33;
            this.btnExport.Text = "تصدير صورة المستند";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtIMGid
            // 
            this.txtIMGid.Location = new System.Drawing.Point(91, 7);
            this.txtIMGid.Name = "txtIMGid";
            this.txtIMGid.ReadOnly = true;
            this.txtIMGid.Size = new System.Drawing.Size(94, 20);
            this.txtIMGid.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "رقم المعرف : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 809);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "حذف هذه الصورة";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(415, 780);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "حفظ الصورة";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelectOne
            // 
            this.btnSelectOne.Location = new System.Drawing.Point(502, 780);
            this.btnSelectOne.Name = "btnSelectOne";
            this.btnSelectOne.Size = new System.Drawing.Size(107, 23);
            this.btnSelectOne.TabIndex = 28;
            this.btnSelectOne.Text = "اختيار صورة جديدة";
            this.btnSelectOne.UseVisualStyleBackColor = true;
            this.btnSelectOne.Click += new System.EventHandler(this.btnSelectOne_Click);
            // 
            // btnFirstIMG
            // 
            this.btnFirstIMG.Location = new System.Drawing.Point(17, 780);
            this.btnFirstIMG.Name = "btnFirstIMG";
            this.btnFirstIMG.Size = new System.Drawing.Size(95, 23);
            this.btnFirstIMG.TabIndex = 27;
            this.btnFirstIMG.Text = "الصورة الاولى";
            this.btnFirstIMG.UseVisualStyleBackColor = true;
            this.btnFirstIMG.Click += new System.EventHandler(this.btnFirstIMG_Click);
            // 
            // btnNextIMG
            // 
            this.btnNextIMG.Location = new System.Drawing.Point(118, 780);
            this.btnNextIMG.Name = "btnNextIMG";
            this.btnNextIMG.Size = new System.Drawing.Size(90, 23);
            this.btnNextIMG.TabIndex = 26;
            this.btnNextIMG.Text = "الصورة التالية";
            this.btnNextIMG.UseVisualStyleBackColor = true;
            this.btnNextIMG.Click += new System.EventHandler(this.btnNextIMG_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(14, 34);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(595, 740);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 25;
            this.picImage.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(349, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(91, 23);
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Frm_ImgDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 835);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.txtIMGid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectOne);
            this.Controls.Add(this.btnFirstIMG);
            this.Controls.Add(this.btnNextIMG);
            this.Controls.Add(this.picImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ImgDoc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "صورة المستندات";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtIMGid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelectOne;
        private System.Windows.Forms.Button btnFirstIMG;
        private System.Windows.Forms.Button btnNextIMG;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnPrint;
    }
}