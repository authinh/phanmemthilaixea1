namespace PhanMemQuanLy.MenuForm.QuanLy.CauHoi
{
    partial class AddNewQuestion
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbCauHoi = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ans4 = new System.Windows.Forms.CheckBox();
            this.ans3 = new System.Windows.Forms.CheckBox();
            this.ans2 = new System.Windows.Forms.CheckBox();
            this.ans1 = new System.Windows.Forms.CheckBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbCauHoi
            // 
            this.pbCauHoi.Location = new System.Drawing.Point(12, 46);
            this.pbCauHoi.Name = "pbCauHoi";
            this.pbCauHoi.Size = new System.Drawing.Size(545, 399);
            this.pbCauHoi.TabIndex = 16;
            this.pbCauHoi.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(482, 474);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(535, 451);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(32, 17);
            this.ans4.TabIndex = 10;
            this.ans4.Text = "4";
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(376, 451);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(32, 17);
            this.ans3.TabIndex = 11;
            this.ans3.Text = "3";
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(163, 451);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(32, 17);
            this.ans2.TabIndex = 12;
            this.ans2.Text = "2";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(12, 451);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(32, 17);
            this.ans1.TabIndex = 13;
            this.ans1.Text = "1";
            this.ans1.UseVisualStyleBackColor = true;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(12, 12);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(128, 23);
            this.btnSelectImage.TabIndex = 17;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // AddNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 508);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbCauHoi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Name = "AddNewQuestion";
            this.Text = "Add New Question";
            this.Load += new System.EventHandler(this.AddNewQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbCauHoi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ans4;
        private System.Windows.Forms.CheckBox ans3;
        private System.Windows.Forms.CheckBox ans2;
        private System.Windows.Forms.CheckBox ans1;
        private System.Windows.Forms.Button btnSelectImage;
    }
}