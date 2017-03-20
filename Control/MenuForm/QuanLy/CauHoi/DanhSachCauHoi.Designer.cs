namespace PhanMemQuanLy.MenuForm.QuanLy.CauHoi
{
    partial class DanhSachCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachCauHoi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbCauHoi = new System.Windows.Forms.PictureBox();
            this.dataCauHoi = new System.Windows.Forms.DataGridView();
            this.ans1 = new System.Windows.Forms.CheckBox();
            this.ans2 = new System.Windows.Forms.CheckBox();
            this.ans3 = new System.Windows.Forms.CheckBox();
            this.ans4 = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCauHoi
            // 
            this.pbCauHoi.Image = ((System.Drawing.Image)(resources.GetObject("pbCauHoi.Image")));
            this.pbCauHoi.Location = new System.Drawing.Point(438, 19);
            this.pbCauHoi.Name = "pbCauHoi";
            this.pbCauHoi.Size = new System.Drawing.Size(555, 399);
            this.pbCauHoi.TabIndex = 0;
            this.pbCauHoi.TabStop = false;
            // 
            // dataCauHoi
            // 
            this.dataCauHoi.AllowUserToAddRows = false;
            this.dataCauHoi.AllowUserToDeleteRows = false;
            this.dataCauHoi.AllowUserToOrderColumns = true;
            this.dataCauHoi.AllowUserToResizeColumns = false;
            this.dataCauHoi.AllowUserToResizeRows = false;
            this.dataCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCauHoi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataCauHoi.Location = new System.Drawing.Point(12, 19);
            this.dataCauHoi.MultiSelect = false;
            this.dataCauHoi.Name = "dataCauHoi";
            this.dataCauHoi.ReadOnly = true;
            this.dataCauHoi.RowHeadersVisible = false;
            this.dataCauHoi.ShowEditingIcon = false;
            this.dataCauHoi.Size = new System.Drawing.Size(420, 399);
            this.dataCauHoi.TabIndex = 1;
            this.dataCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCauHoi_CellClick);
            // 
            // ans1
            // 
            this.ans1.AutoCheck = false;
            this.ans1.AutoSize = true;
            this.ans1.Location = new System.Drawing.Point(438, 424);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(32, 17);
            this.ans1.TabIndex = 2;
            this.ans1.Text = "1";
            this.ans1.UseVisualStyleBackColor = true;
            // 
            // ans2
            // 
            this.ans2.AutoCheck = false;
            this.ans2.AutoSize = true;
            this.ans2.Location = new System.Drawing.Point(589, 424);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(32, 17);
            this.ans2.TabIndex = 2;
            this.ans2.Text = "2";
            this.ans2.UseVisualStyleBackColor = true;
            // 
            // ans3
            // 
            this.ans3.AutoCheck = false;
            this.ans3.AutoSize = true;
            this.ans3.Location = new System.Drawing.Point(802, 424);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(32, 17);
            this.ans3.TabIndex = 2;
            this.ans3.Text = "3";
            this.ans3.UseVisualStyleBackColor = true;
            // 
            // ans4
            // 
            this.ans4.AutoCheck = false;
            this.ans4.AutoSize = true;
            this.ans4.Location = new System.Drawing.Point(961, 424);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(32, 17);
            this.ans4.TabIndex = 2;
            this.ans4.Text = "4";
            this.ans4.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add new a question";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DanhSachCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 457);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.dataCauHoi);
            this.Controls.Add(this.pbCauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DanhSachCauHoi";
            this.ShowIcon = false;
            this.Text = "Danh Sách Câu Hỏi";
            ((System.ComponentModel.ISupportInitialize)(this.pbCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCauHoi;
        private System.Windows.Forms.DataGridView dataCauHoi;
        private System.Windows.Forms.CheckBox ans1;
        private System.Windows.Forms.CheckBox ans2;
        private System.Windows.Forms.CheckBox ans3;
        private System.Windows.Forms.CheckBox ans4;
        private System.Windows.Forms.Button btnAdd;
    }
}