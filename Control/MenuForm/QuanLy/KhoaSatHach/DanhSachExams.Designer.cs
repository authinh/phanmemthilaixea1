namespace PhanMemQuanLy.MenuForm.QuanLy.KhoaSatHach
{
    partial class DanhSachExams
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
            this.data = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamID,
            this.ExamTitle,
            this.ExamMark,
            this.ExamDateTime,
            this.ExamTime,
            this.ExamStatus,
            this.update,
            this.Column1});
            this.data.Location = new System.Drawing.Point(16, 52);
            this.data.Margin = new System.Windows.Forms.Padding(4);
            this.data.Name = "data";
            this.data.RowHeadersVisible = false;
            this.data.Size = new System.Drawing.Size(1110, 265);
            this.data.TabIndex = 0;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 15);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ExamID
            // 
            this.ExamID.DataPropertyName = "ExamID";
            this.ExamID.HeaderText = "ID";
            this.ExamID.Name = "ExamID";
            this.ExamID.ReadOnly = true;
            this.ExamID.Width = 50;
            // 
            // ExamTitle
            // 
            this.ExamTitle.DataPropertyName = "ExamTitle";
            this.ExamTitle.HeaderText = "Title";
            this.ExamTitle.Name = "ExamTitle";
            this.ExamTitle.ReadOnly = true;
            this.ExamTitle.Width = 200;
            // 
            // ExamMark
            // 
            this.ExamMark.DataPropertyName = "ExamMark";
            this.ExamMark.HeaderText = "Mark";
            this.ExamMark.Name = "ExamMark";
            this.ExamMark.ReadOnly = true;
            // 
            // ExamDateTime
            // 
            this.ExamDateTime.DataPropertyName = "ExamDateTime";
            this.ExamDateTime.HeaderText = "Date";
            this.ExamDateTime.Name = "ExamDateTime";
            this.ExamDateTime.ReadOnly = true;
            // 
            // ExamTime
            // 
            this.ExamTime.DataPropertyName = "ExamTime";
            this.ExamTime.HeaderText = "Time";
            this.ExamTime.Name = "ExamTime";
            this.ExamTime.ReadOnly = true;
            // 
            // ExamStatus
            // 
            this.ExamStatus.DataPropertyName = "ExamStatus";
            this.ExamStatus.HeaderText = "Status";
            this.ExamStatus.Name = "ExamStatus";
            this.ExamStatus.ReadOnly = true;
            // 
            // update
            // 
            this.update.HeaderText = "";
            this.update.Name = "update";
            this.update.Text = "update";
            this.update.ToolTipText = "update";
            this.update.UseColumnTextForButtonValue = true;
            this.update.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.ToolTipText = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 50;
            // 
            // DanhSachExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 321);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.data);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachExams";
            this.Text = "Danh sách kỳ thi";
            this.Load += new System.EventHandler(this.DanhSachExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExamStatus;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}