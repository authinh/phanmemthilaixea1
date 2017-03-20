namespace PhanMemQuanLy.MenuForm.QuanLy.CauHoi
{
    partial class UpdateQuestion
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
            this.ans4 = new System.Windows.Forms.CheckBox();
            this.ans3 = new System.Windows.Forms.CheckBox();
            this.ans2 = new System.Windows.Forms.CheckBox();
            this.ans1 = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbCauHoi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // ans4
            // 
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(535, 417);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(32, 17);
            this.ans4.TabIndex = 3;
            this.ans4.Text = "4";
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(376, 417);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(32, 17);
            this.ans3.TabIndex = 4;
            this.ans3.Text = "3";
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans2
            // 
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(163, 417);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(32, 17);
            this.ans2.TabIndex = 5;
            this.ans2.Text = "2";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans1
            // 
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(12, 417);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(32, 17);
            this.ans1.TabIndex = 6;
            this.ans1.Text = "1";
            this.ans1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 440);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(482, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbCauHoi
            // 
            this.pbCauHoi.Location = new System.Drawing.Point(12, 12);
            this.pbCauHoi.Name = "pbCauHoi";
            this.pbCauHoi.Size = new System.Drawing.Size(545, 399);
            this.pbCauHoi.TabIndex = 9;
            this.pbCauHoi.TabStop = false;
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 472);
            this.Controls.Add(this.pbCauHoi);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Name = "UpdateQuestion";
            this.Text = "Update Question";
            ((System.ComponentModel.ISupportInitialize)(this.pbCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ans4;
        private System.Windows.Forms.CheckBox ans3;
        private System.Windows.Forms.CheckBox ans2;
        private System.Windows.Forms.CheckBox ans1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbCauHoi;
    }
}