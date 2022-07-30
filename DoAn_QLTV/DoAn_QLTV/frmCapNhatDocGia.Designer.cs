namespace DoAn_QLTV
{
    partial class frmCapNhatDocGia
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
            this.components = new System.ComponentModel.Container();
            this.Trangchu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTaotaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapnhatnhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapnhatdocgia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapnhatsach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCapnhattheloai = new System.Windows.Forms.ToolStripMenuItem();
            this.mượntrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMuontrasach = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsLichsumuontra = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmTácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemDG = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaDG = new System.Windows.Forms.Button();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnLuuDG = new System.Windows.Forms.Button();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.grbThongTinDG = new System.Windows.Forms.GroupBox();
            this.cmbGioiTinhDG = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinhDG = new System.Windows.Forms.DateTimePicker();
            this.txtSDTDG = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvThongTinDG = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            this.pnlChucNangDG.SuspendLayout();
            this.grbThongTinDG.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Trangchu
            // 
            this.Trangchu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Trangchu.Name = "contextMenuStrip1";
            this.Trangchu.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.mượntrảSáchToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(533, 47);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTaotaikhoan,
            this.tsDoimatkhau});
            this.hệThốngToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 7, 7, 7);
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // tsTaotaikhoan
            // 
            this.tsTaotaikhoan.Margin = new System.Windows.Forms.Padding(3);
            this.tsTaotaikhoan.Name = "tsTaotaikhoan";
            this.tsTaotaikhoan.Size = new System.Drawing.Size(145, 22);
            this.tsTaotaikhoan.Text = "Tạo tài khoản";
            // 
            // tsDoimatkhau
            // 
            this.tsDoimatkhau.Margin = new System.Windows.Forms.Padding(3);
            this.tsDoimatkhau.Name = "tsDoimatkhau";
            this.tsDoimatkhau.Size = new System.Drawing.Size(145, 22);
            this.tsDoimatkhau.Text = "Đổi mật khẩu";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCapnhatnhanvien,
            this.tsCapnhatdocgia,
            this.tsCapnhatsach,
            this.tsCapnhattheloai});
            this.danhMụcToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7);
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // tsCapnhatnhanvien
            // 
            this.tsCapnhatnhanvien.Margin = new System.Windows.Forms.Padding(3);
            this.tsCapnhatnhanvien.Name = "tsCapnhatnhanvien";
            this.tsCapnhatnhanvien.Size = new System.Drawing.Size(177, 22);
            this.tsCapnhatnhanvien.Text = "Cập nhật nhân viên";
            // 
            // tsCapnhatdocgia
            // 
            this.tsCapnhatdocgia.Margin = new System.Windows.Forms.Padding(3);
            this.tsCapnhatdocgia.Name = "tsCapnhatdocgia";
            this.tsCapnhatdocgia.Size = new System.Drawing.Size(177, 22);
            this.tsCapnhatdocgia.Text = "Cập nhật độc giả";
            this.tsCapnhatdocgia.Click += new System.EventHandler(this.tsCapnhatdocgia_Click);
            // 
            // tsCapnhatsach
            // 
            this.tsCapnhatsach.Margin = new System.Windows.Forms.Padding(3);
            this.tsCapnhatsach.Name = "tsCapnhatsach";
            this.tsCapnhatsach.Size = new System.Drawing.Size(177, 22);
            this.tsCapnhatsach.Text = "Cập nhật sách";
            // 
            // tsCapnhattheloai
            // 
            this.tsCapnhattheloai.Margin = new System.Windows.Forms.Padding(3);
            this.tsCapnhattheloai.Name = "tsCapnhattheloai";
            this.tsCapnhattheloai.Size = new System.Drawing.Size(177, 22);
            this.tsCapnhattheloai.Text = "Cập nhật thể loại";
            // 
            // mượntrảSáchToolStripMenuItem
            // 
            this.mượntrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMuontrasach});
            this.mượntrảSáchToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7);
            this.mượntrảSáchToolStripMenuItem.Name = "mượntrảSáchToolStripMenuItem";
            this.mượntrảSáchToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.mượntrảSáchToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.mượntrảSáchToolStripMenuItem.Text = "Mượn - Trả";
            this.mượntrảSáchToolStripMenuItem.Click += new System.EventHandler(this.mượntrảSáchToolStripMenuItem_Click);
            // 
            // tsMuontrasach
            // 
            this.tsMuontrasach.Margin = new System.Windows.Forms.Padding(3);
            this.tsMuontrasach.Name = "tsMuontrasach";
            this.tsMuontrasach.Size = new System.Drawing.Size(159, 22);
            this.tsMuontrasach.Text = "Mượn - Trả sách";
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLichsumuontra});
            this.báoCáoThốngKêToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7);
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // tsLichsumuontra
            // 
            this.tsLichsumuontra.Margin = new System.Windows.Forms.Padding(3);
            this.tsLichsumuontra.Name = "tsLichsumuontra";
            this.tsLichsumuontra.Size = new System.Drawing.Size(180, 22);
            this.tsLichsumuontra.Text = "Lịch sử mượn trả";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmSáchToolStripMenuItem,
            this.tìmKiếmNhânViênToolStripMenuItem,
            this.tìmKiếmTácGiảToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(68, 43);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tìmKiếmSáchToolStripMenuItem
            // 
            this.tìmKiếmSáchToolStripMenuItem.Name = "tìmKiếmSáchToolStripMenuItem";
            this.tìmKiếmSáchToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tìmKiếmSáchToolStripMenuItem.Text = "Tìm kiếm sách";
            // 
            // tìmKiếmNhânViênToolStripMenuItem
            // 
            this.tìmKiếmNhânViênToolStripMenuItem.Name = "tìmKiếmNhânViênToolStripMenuItem";
            this.tìmKiếmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tìmKiếmNhânViênToolStripMenuItem.Text = "Tìm kiếm nhân viên ";
            // 
            // tìmKiếmTácGiảToolStripMenuItem
            // 
            this.tìmKiếmTácGiảToolStripMenuItem.Name = "tìmKiếmTácGiảToolStripMenuItem";
            this.tìmKiếmTácGiảToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tìmKiếmTácGiảToolStripMenuItem.Text = "Tìm kiếm tác giả";
            // 
            // btnThemDG
            // 
            this.btnThemDG.Location = new System.Drawing.Point(3, 0);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(75, 23);
            this.btnThemDG.TabIndex = 13;
            this.btnThemDG.Text = "Thêm";
            this.btnThemDG.UseVisualStyleBackColor = true;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(411, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 21);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.Location = new System.Drawing.Point(112, 0);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDG.TabIndex = 15;
            this.btnXoaDG.Text = "Xóa";
            this.btnXoaDG.UseVisualStyleBackColor = true;
            this.btnXoaDG.Click += new System.EventHandler(this.btnXoaDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.Location = new System.Drawing.Point(218, 0);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDG.TabIndex = 16;
            this.btnSuaDG.Text = "Sửa";
            this.btnSuaDG.UseVisualStyleBackColor = true;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnLuuDG
            // 
            this.btnLuuDG.Location = new System.Drawing.Point(315, 0);
            this.btnLuuDG.Name = "btnLuuDG";
            this.btnLuuDG.Size = new System.Drawing.Size(75, 23);
            this.btnLuuDG.TabIndex = 17;
            this.btnLuuDG.Text = "Lưu";
            this.btnLuuDG.UseVisualStyleBackColor = true;
            this.btnLuuDG.Click += new System.EventHandler(this.btnLuuDG_Click);
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.Controls.Add(this.btnThemDG);
            this.pnlChucNangDG.Controls.Add(this.btnThoat);
            this.pnlChucNangDG.Controls.Add(this.btnLuuDG);
            this.pnlChucNangDG.Controls.Add(this.btnXoaDG);
            this.pnlChucNangDG.Controls.Add(this.btnSuaDG);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(15, 226);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(489, 24);
            this.pnlChucNangDG.TabIndex = 18;
            // 
            // grbThongTinDG
            // 
            this.grbThongTinDG.Controls.Add(this.cmbGioiTinhDG);
            this.grbThongTinDG.Controls.Add(this.dtpNgaySinhDG);
            this.grbThongTinDG.Controls.Add(this.txtSDTDG);
            this.grbThongTinDG.Controls.Add(this.txtTenDG);
            this.grbThongTinDG.Controls.Add(this.txtMaDG);
            this.grbThongTinDG.Controls.Add(this.lblTenDG);
            this.grbThongTinDG.Controls.Add(this.lblGioiTinh);
            this.grbThongTinDG.Controls.Add(this.lblMaDG);
            this.grbThongTinDG.Controls.Add(this.lblNgaySinh);
            this.grbThongTinDG.Controls.Add(this.label4);
            this.grbThongTinDG.Location = new System.Drawing.Point(15, 63);
            this.grbThongTinDG.Name = "grbThongTinDG";
            this.grbThongTinDG.Size = new System.Drawing.Size(494, 157);
            this.grbThongTinDG.TabIndex = 20;
            this.grbThongTinDG.TabStop = false;
            this.grbThongTinDG.Text = "Thông Tin Độc Giả";
            this.grbThongTinDG.Enter += new System.EventHandler(this.grbThongTinDG_Enter);
            // 
            // cmbGioiTinhDG
            // 
            this.cmbGioiTinhDG.FormattingEnabled = true;
            this.cmbGioiTinhDG.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.cmbGioiTinhDG.Location = new System.Drawing.Point(108, 119);
            this.cmbGioiTinhDG.Name = "cmbGioiTinhDG";
            this.cmbGioiTinhDG.Size = new System.Drawing.Size(121, 21);
            this.cmbGioiTinhDG.TabIndex = 12;
            // 
            // dtpNgaySinhDG
            // 
            this.dtpNgaySinhDG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhDG.Location = new System.Drawing.Point(346, 27);
            this.dtpNgaySinhDG.Name = "dtpNgaySinhDG";
            this.dtpNgaySinhDG.Size = new System.Drawing.Size(100, 20);
            this.dtpNgaySinhDG.TabIndex = 11;
            // 
            // txtSDTDG
            // 
            this.txtSDTDG.Location = new System.Drawing.Point(346, 71);
            this.txtSDTDG.Name = "txtSDTDG";
            this.txtSDTDG.Size = new System.Drawing.Size(100, 20);
            this.txtSDTDG.TabIndex = 10;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Location = new System.Drawing.Point(108, 72);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(100, 20);
            this.txtTenDG.TabIndex = 9;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(108, 30);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(100, 20);
            this.txtMaDG.TabIndex = 8;
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(12, 71);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Size = new System.Drawing.Size(94, 18);
            this.lblTenDG.TabIndex = 6;
            this.lblTenDG.Text = "Tên độc giả:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 119);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(70, 18);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDG.Location = new System.Drawing.Point(12, 29);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(90, 18);
            this.lblMaDG.TabIndex = 3;
            this.lblMaDG.Text = "Mã độc giả:";
            this.lblMaDG.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(257, 26);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(83, 18);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "SDT:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvThongTinDG);
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 265);
            this.panel1.TabIndex = 21;
            // 
            // dgvThongTinDG
            // 
            this.dgvThongTinDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDG.Location = new System.Drawing.Point(0, 0);
            this.dgvThongTinDG.Name = "dgvThongTinDG";
            this.dgvThongTinDG.Size = new System.Drawing.Size(533, 265);
            this.dgvThongTinDG.TabIndex = 0;
            this.dgvThongTinDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinDG_CellContentClick);
            // 
            // frmCapNhatDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(533, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbThongTinDG);
            this.Controls.Add(this.pnlChucNangDG);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCapNhatDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Độc Giả";
            this.Load += new System.EventHandler(this.frmCapNhatDocGia_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlChucNangDG.ResumeLayout(false);
            this.grbThongTinDG.ResumeLayout(false);
            this.grbThongTinDG.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Trangchu;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTaotaikhoan;
        private System.Windows.Forms.ToolStripMenuItem tsDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCapnhatnhanvien;
        private System.Windows.Forms.ToolStripMenuItem tsCapnhatsach;
        private System.Windows.Forms.ToolStripMenuItem tsCapnhattheloai;
        private System.Windows.Forms.ToolStripMenuItem mượntrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMuontrasach;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsLichsumuontra;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmTácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCapnhatdocgia;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnLuuDG;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.GroupBox grbThongTinDG;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvThongTinDG;
        private System.Windows.Forms.TextBox txtSDTDG;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhDG;
        private System.Windows.Forms.ComboBox cmbGioiTinhDG;
    }
}

