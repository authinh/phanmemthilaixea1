namespace PhanMemQuanLy
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHinh = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhoaHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThiSinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCaoThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKiemTraCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuQuanLy,
            this.menuBaoCao,
            this.menuTroGiup});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(584, 24);
            this.menuTop.TabIndex = 0;
            this.menuTop.Text = "menuStrip1";
            // 
            // menuHeThong
            // 
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCauHinh,
            this.MenuThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(69, 20);
            this.menuHeThong.Text = "Hệ thống";
            // 
            // menuCauHinh
            // 
            this.menuCauHinh.Name = "menuCauHinh";
            this.menuCauHinh.Size = new System.Drawing.Size(122, 22);
            this.menuCauHinh.Text = "Cấu hình";
            // 
            // MenuThoat
            // 
            this.MenuThoat.Name = "MenuThoat";
            this.MenuThoat.Size = new System.Drawing.Size(122, 22);
            this.MenuThoat.Text = "Thoát";
            this.MenuThoat.Click += new System.EventHandler(this.MenuThoat_Click);
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhoaHoc,
            this.menuThiSinh,
            this.menuCauHoi});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.menuQuanLy.Text = "Quản lý";
            // 
            // menuKhoaHoc
            // 
            this.menuKhoaHoc.Name = "menuKhoaHoc";
            this.menuKhoaHoc.Size = new System.Drawing.Size(205, 22);
            this.menuKhoaHoc.Text = "Danh sách khóa sát hạch";
            this.menuKhoaHoc.Click += new System.EventHandler(this.menuKhoaHoc_Click);
            // 
            // menuThiSinh
            // 
            this.menuThiSinh.Name = "menuThiSinh";
            this.menuThiSinh.Size = new System.Drawing.Size(205, 22);
            this.menuThiSinh.Text = "Danh sách thí sinh";
            this.menuThiSinh.Click += new System.EventHandler(this.menuThiSinh_Click);
            // 
            // menuCauHoi
            // 
            this.menuCauHoi.Name = "menuCauHoi";
            this.menuCauHoi.Size = new System.Drawing.Size(205, 22);
            this.menuCauHoi.Text = "Danh sách câu hỏi";
            this.menuCauHoi.Click += new System.EventHandler(this.menuCauHoi_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBaoCaoThongKe});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.menuBaoCao.Text = "Báo cáo";
            // 
            // menuBaoCaoThongKe
            // 
            this.menuBaoCaoThongKe.Name = "menuBaoCaoThongKe";
            this.menuBaoCaoThongKe.Size = new System.Drawing.Size(193, 22);
            this.menuBaoCaoThongKe.Text = "Xem báo cáo thống kê";
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGioiThieu,
            this.menuKiemTraCapNhat});
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(63, 20);
            this.menuTroGiup.Text = "Trợ giúp";
            // 
            // menuGioiThieu
            // 
            this.menuGioiThieu.Name = "menuGioiThieu";
            this.menuGioiThieu.Size = new System.Drawing.Size(167, 22);
            this.menuGioiThieu.Text = "Giới thiệu";
            this.menuGioiThieu.Click += new System.EventHandler(this.menuGioiThieu_Click);
            // 
            // menuKiemTraCapNhat
            // 
            this.menuKiemTraCapNhat.Enabled = false;
            this.menuKiemTraCapNhat.Name = "menuKiemTraCapNhat";
            this.menuKiemTraCapNhat.Size = new System.Drawing.Size(167, 22);
            this.menuKiemTraCapNhat.Text = "Kiểm tra cập nhật";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuTop;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý thi lái xe A1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuCauHinh;
        private System.Windows.Forms.ToolStripMenuItem MenuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem menuKhoaHoc;
        private System.Windows.Forms.ToolStripMenuItem menuThiSinh;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCaoThongKe;
        private System.Windows.Forms.ToolStripMenuItem menuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem menuKiemTraCapNhat;
        private System.Windows.Forms.ToolStripMenuItem menuCauHoi;
    }
}