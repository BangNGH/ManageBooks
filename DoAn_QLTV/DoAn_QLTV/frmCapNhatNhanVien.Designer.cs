using System.Windows.Forms;

namespace DoAn_QLTV
{
    partial class frmCapNhatNhanVien
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
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnThoatFrmCapNhatNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.pnlChucNangNV = new System.Windows.Forms.Panel();
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.txtChucVuNV = new System.Windows.Forms.TextBox();
            this.lblChucVuNV = new System.Windows.Forms.Label();
            this.cmbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblGioiTinhNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgaySinhNV = new System.Windows.Forms.Label();
            this.lblSDTNV = new System.Windows.Forms.Label();
            this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
            this.btnKhongLuuNV = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.pnlChucNangNV.SuspendLayout();
            this.grbThongTinNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).BeginInit();
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
            this.menuStrip2.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.menuStrip2.Size = new System.Drawing.Size(645, 47);
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
            this.tsCapnhatnhanvien.Enabled = false;
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
            this.tsLichsumuontra.Size = new System.Drawing.Size(163, 22);
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
            // btnThemNV
            // 
            this.btnThemNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(3, 0);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 24);
            this.btnThemNV.TabIndex = 13;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnThoatFrmCapNhatNV
            // 
            this.btnThoatFrmCapNhatNV.Location = new System.Drawing.Point(532, 0);
            this.btnThoatFrmCapNhatNV.Name = "btnThoatFrmCapNhatNV";
            this.btnThoatFrmCapNhatNV.Size = new System.Drawing.Size(75, 24);
            this.btnThoatFrmCapNhatNV.TabIndex = 14;
            this.btnThoatFrmCapNhatNV.Text = "Thoát";
            this.btnThoatFrmCapNhatNV.UseVisualStyleBackColor = true;
            this.btnThoatFrmCapNhatNV.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(110, 0);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 24);
            this.btnXoaNV.TabIndex = 15;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(210, 0);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 24);
            this.btnSuaNV.TabIndex = 16;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Location = new System.Drawing.Point(315, 0);
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.Size = new System.Drawing.Size(75, 24);
            this.btnLuuNV.TabIndex = 17;
            this.btnLuuNV.Text = "Lưu";
            this.btnLuuNV.UseVisualStyleBackColor = true;
            this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
            // 
            // pnlChucNangNV
            // 
            this.pnlChucNangNV.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangNV.Controls.Add(this.btnKhongLuuNV);
            this.pnlChucNangNV.Controls.Add(this.btnThemNV);
            this.pnlChucNangNV.Controls.Add(this.btnThoatFrmCapNhatNV);
            this.pnlChucNangNV.Controls.Add(this.btnLuuNV);
            this.pnlChucNangNV.Controls.Add(this.btnXoaNV);
            this.pnlChucNangNV.Controls.Add(this.btnSuaNV);
            this.pnlChucNangNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangNV.Location = new System.Drawing.Point(14, 239);
            this.pnlChucNangNV.Name = "pnlChucNangNV";
            this.pnlChucNangNV.Size = new System.Drawing.Size(619, 24);
            this.pnlChucNangNV.TabIndex = 18;
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinNV.Controls.Add(this.dtpNgaySinhNV);
            this.grbThongTinNV.Controls.Add(this.txtChucVuNV);
            this.grbThongTinNV.Controls.Add(this.lblChucVuNV);
            this.grbThongTinNV.Controls.Add(this.cmbGioiTinhNV);
            this.grbThongTinNV.Controls.Add(this.txtSDTNV);
            this.grbThongTinNV.Controls.Add(this.txtTenNV);
            this.grbThongTinNV.Controls.Add(this.txtMaNV);
            this.grbThongTinNV.Controls.Add(this.lblTenNV);
            this.grbThongTinNV.Controls.Add(this.lblGioiTinhNV);
            this.grbThongTinNV.Controls.Add(this.lblMaNV);
            this.grbThongTinNV.Controls.Add(this.lblNgaySinhNV);
            this.grbThongTinNV.Controls.Add(this.lblSDTNV);
            this.grbThongTinNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNV.Location = new System.Drawing.Point(86, 60);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(494, 157);
            this.grbThongTinNV.TabIndex = 20;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Cập Nhật Thông Tin Nhân viên";
            this.grbThongTinNV.Enter += new System.EventHandler(this.grbThongTinNV_Enter);
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(346, 24);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(100, 21);
            this.dtpNgaySinhNV.TabIndex = 15;
            // 
            // txtChucVuNV
            // 
            this.txtChucVuNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtChucVuNV.Location = new System.Drawing.Point(346, 118);
            this.txtChucVuNV.Name = "txtChucVuNV";
            this.txtChucVuNV.Size = new System.Drawing.Size(100, 21);
            this.txtChucVuNV.TabIndex = 14;
            // 
            // lblChucVuNV
            // 
            this.lblChucVuNV.AutoSize = true;
            this.lblChucVuNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChucVuNV.Location = new System.Drawing.Point(253, 121);
            this.lblChucVuNV.Name = "lblChucVuNV";
            this.lblChucVuNV.Size = new System.Drawing.Size(61, 16);
            this.lblChucVuNV.TabIndex = 13;
            this.lblChucVuNV.Text = "Chức Vụ";
            this.lblChucVuNV.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // cmbGioiTinhNV
            // 
            this.cmbGioiTinhNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbGioiTinhNV.FormattingEnabled = true;
            this.cmbGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.cmbGioiTinhNV.Location = new System.Drawing.Point(108, 114);
            this.cmbGioiTinhNV.Name = "cmbGioiTinhNV";
            this.cmbGioiTinhNV.Size = new System.Drawing.Size(100, 23);
            this.cmbGioiTinhNV.TabIndex = 12;
            this.cmbGioiTinhNV.SelectedIndexChanged += new System.EventHandler(this.cmbGioiTinhNV_SelectedIndexChanged);
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtSDTNV.Location = new System.Drawing.Point(346, 72);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(100, 21);
            this.txtSDTNV.TabIndex = 10;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTenNV.Location = new System.Drawing.Point(108, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 21);
            this.txtTenNV.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtMaNV.Location = new System.Drawing.Point(108, 30);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 21);
            this.txtMaNV.TabIndex = 8;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(12, 75);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(71, 16);
            this.lblTenNV.TabIndex = 6;
            this.lblTenNV.Text = "Họ và Tên";
            this.lblTenNV.Click += new System.EventHandler(this.lblTenNV_Click);
            // 
            // lblGioiTinhNV
            // 
            this.lblGioiTinhNV.AutoSize = true;
            this.lblGioiTinhNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinhNV.Location = new System.Drawing.Point(12, 114);
            this.lblGioiTinhNV.Name = "lblGioiTinhNV";
            this.lblGioiTinhNV.Size = new System.Drawing.Size(66, 16);
            this.lblGioiTinhNV.TabIndex = 4;
            this.lblGioiTinhNV.Text = "Giới tính:";
            this.lblGioiTinhNV.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(12, 30);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(97, 16);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Mã nhân viên:";
            this.lblMaNV.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNgaySinhNV
            // 
            this.lblNgaySinhNV.AutoSize = true;
            this.lblNgaySinhNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinhNV.Location = new System.Drawing.Point(254, 27);
            this.lblNgaySinhNV.Name = "lblNgaySinhNV";
            this.lblNgaySinhNV.Size = new System.Drawing.Size(76, 16);
            this.lblNgaySinhNV.TabIndex = 5;
            this.lblNgaySinhNV.Text = "Ngày Sinh:";
            // 
            // lblSDTNV
            // 
            this.lblSDTNV.AutoSize = true;
            this.lblSDTNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDTNV.Location = new System.Drawing.Point(254, 75);
            this.lblSDTNV.Name = "lblSDTNV";
            this.lblSDTNV.Size = new System.Drawing.Size(80, 16);
            this.lblSDTNV.TabIndex = 7;
            this.lblSDTNV.Text = "Điện Thoại:";
            this.lblSDTNV.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvThongTinNV
            // 
            this.dgvThongTinNV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNV.Location = new System.Drawing.Point(0, 303);
            this.dgvThongTinNV.Name = "dgvThongTinNV";
            this.dgvThongTinNV.RowHeadersWidth = 51;
            this.dgvThongTinNV.Size = new System.Drawing.Size(645, 183);
            this.dgvThongTinNV.TabIndex = 22;
            this.dgvThongTinNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNV_CellContentClick);
            this.dgvThongTinNV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNV_CellContentClick);
            // 
            // btnKhongLuuNV
            // 
            this.btnKhongLuuNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuNV.Location = new System.Drawing.Point(416, 1);
            this.btnKhongLuuNV.Name = "btnKhongLuuNV";
            this.btnKhongLuuNV.Size = new System.Drawing.Size(94, 23);
            this.btnKhongLuuNV.TabIndex = 23;
            this.btnKhongLuuNV.Text = "Không Lưu";
            this.btnKhongLuuNV.UseVisualStyleBackColor = true;
            // 
            // frmCapNhatNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(645, 574);
            this.Controls.Add(this.dgvThongTinNV);
            this.Controls.Add(this.grbThongTinNV);
            this.Controls.Add(this.pnlChucNangNV);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCapNhatNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhân Viên";
            this.Load += new System.EventHandler(this.frmCapNhatNhanVien_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnlChucNangNV.ResumeLayout(false);
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
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
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThoatFrmCapNhatNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnLuuNV;
        private System.Windows.Forms.Panel pnlChucNangNV;
        private System.Windows.Forms.GroupBox grbThongTinNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblGioiTinhNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblNgaySinhNV;
        private System.Windows.Forms.Label lblSDTNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cmbGioiTinhNV;
        private DataGridView dgvThongTinNV;
        private TextBox txtChucVuNV;
        private Label lblChucVuNV;
        private DateTimePicker dtpNgaySinhNV;
        private Button btnKhongLuuNV;
    }
}

