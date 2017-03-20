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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDetail = new System.Windows.Forms.Button();
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
            this.ExamStatus});
            this.data.Location = new System.Drawing.Point(12, 42);
            this.data.Name = "data";
            this.data.RowHeadersVisible = false;
            this.data.Size = new System.Drawing.Size(670, 215);
            this.data.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(174, 12);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            // 
            // DanhSachExams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 261);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.data);
            this.Name = "DanhSachExams";
            this.Text = "Danh sách kỳ thi";
            this.Load += new System.EventHandler(this.DanhSachExams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExamStatus;
        private System.Windows.Forms.Button btnDetail;
    }
}