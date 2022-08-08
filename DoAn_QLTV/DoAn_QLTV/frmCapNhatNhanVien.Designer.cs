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
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnThoatfrmNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnLuuNV = new System.Windows.Forms.Button();
            this.pnlChucNangNV = new System.Windows.Forms.Panel();
            this.btnKhongLuuNV = new System.Windows.Forms.Button();
            this.grbThongTinNV = new System.Windows.Forms.GroupBox();
            this.txtChucVuNV = new System.Windows.Forms.TextBox();
            this.lblChucVuNV = new System.Windows.Forms.Label();
            this.cmbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblGioiTinhNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblNgaySinhNV = new System.Windows.Forms.Label();
            this.lblSDTNV = new System.Windows.Forms.Label();
            this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
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
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(0, 0);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(90, 24);
            this.btnThemNV.TabIndex = 13;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnThoatfrmNV
            // 
            this.btnThoatfrmNV.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatfrmNV.Location = new System.Drawing.Point(507, 1);
            this.btnThoatfrmNV.Name = "btnThoatfrmNV";
            this.btnThoatfrmNV.Size = new System.Drawing.Size(75, 23);
            this.btnThoatfrmNV.TabIndex = 16;
            this.btnThoatfrmNV.Text = "Thoát";
            this.btnThoatfrmNV.UseVisualStyleBackColor = true;
            this.btnThoatfrmNV.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(108, 0);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 24);
            this.btnXoaNV.TabIndex = 14;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(207, 1);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNV.TabIndex = 15;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Location = new System.Drawing.Point(309, 0);
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
            this.pnlChucNangNV.Controls.Add(this.btnThemNV);
            this.pnlChucNangNV.Controls.Add(this.btnKhongLuuNV);
            this.pnlChucNangNV.Controls.Add(this.btnThoatfrmNV);
            this.pnlChucNangNV.Controls.Add(this.btnLuuNV);
            this.pnlChucNangNV.Controls.Add(this.btnXoaNV);
            this.pnlChucNangNV.Controls.Add(this.btnSuaNV);
            this.pnlChucNangNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangNV.Location = new System.Drawing.Point(12, 188);
            this.pnlChucNangNV.Name = "pnlChucNangNV";
            this.pnlChucNangNV.Size = new System.Drawing.Size(596, 26);
            this.pnlChucNangNV.TabIndex = 7;
            // 
            // btnKhongLuuNV
            // 
            this.btnKhongLuuNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuNV.Location = new System.Drawing.Point(396, 0);
            this.btnKhongLuuNV.Name = "btnKhongLuuNV";
            this.btnKhongLuuNV.Size = new System.Drawing.Size(94, 24);
            this.btnKhongLuuNV.TabIndex = 18;
            this.btnKhongLuuNV.Text = "Không Lưu";
            this.btnKhongLuuNV.UseVisualStyleBackColor = true;
            this.btnKhongLuuNV.Click += new System.EventHandler(this.btnKhongLuuNV_Click);
            // 
            // grbThongTinNV
            // 
            this.grbThongTinNV.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinNV.Controls.Add(this.txtChucVuNV);
            this.grbThongTinNV.Controls.Add(this.lblChucVuNV);
            this.grbThongTinNV.Controls.Add(this.cmbGioiTinhNV);
            this.grbThongTinNV.Controls.Add(this.dtpNgaySinhNV);
            this.grbThongTinNV.Controls.Add(this.txtSDTNV);
            this.grbThongTinNV.Controls.Add(this.txtTenNV);
            this.grbThongTinNV.Controls.Add(this.txtMaNV);
            this.grbThongTinNV.Controls.Add(this.lblTenNV);
            this.grbThongTinNV.Controls.Add(this.lblGioiTinhNV);
            this.grbThongTinNV.Controls.Add(this.lblMaNV);
            this.grbThongTinNV.Controls.Add(this.lblNgaySinhNV);
            this.grbThongTinNV.Controls.Add(this.lblSDTNV);
            this.grbThongTinNV.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinNV.Location = new System.Drawing.Point(56, 12);
            this.grbThongTinNV.Name = "grbThongTinNV";
            this.grbThongTinNV.Size = new System.Drawing.Size(494, 157);
            this.grbThongTinNV.TabIndex = 20;
            this.grbThongTinNV.TabStop = false;
            this.grbThongTinNV.Text = "Thông Tin Nhân Viên";
            this.grbThongTinNV.Enter += new System.EventHandler(this.grbThongTinNV_Enter);
            // 
            // txtChucVuNV
            // 
            this.txtChucVuNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtChucVuNV.Location = new System.Drawing.Point(360, 119);
            this.txtChucVuNV.Name = "txtChucVuNV";
            this.txtChucVuNV.Size = new System.Drawing.Size(100, 21);
            this.txtChucVuNV.TabIndex = 6;
            // 
            // lblChucVuNV
            // 
            this.lblChucVuNV.AutoSize = true;
            this.lblChucVuNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChucVuNV.Location = new System.Drawing.Point(268, 124);
            this.lblChucVuNV.Name = "lblChucVuNV";
            this.lblChucVuNV.Size = new System.Drawing.Size(65, 16);
            this.lblChucVuNV.TabIndex = 13;
            this.lblChucVuNV.Text = "Chức Vụ:";
            this.lblChucVuNV.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbGioiTinhNV
            // 
            this.cmbGioiTinhNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbGioiTinhNV.FormattingEnabled = true;
            this.cmbGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.cmbGioiTinhNV.Location = new System.Drawing.Point(115, 119);
            this.cmbGioiTinhNV.Name = "cmbGioiTinhNV";
            this.cmbGioiTinhNV.Size = new System.Drawing.Size(100, 23);
            this.cmbGioiTinhNV.TabIndex = 5;
            // 
            // dtpNgaySinhNV
            // 
            this.dtpNgaySinhNV.CustomFormat = "MM/dd/yyyy";
            this.dtpNgaySinhNV.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhNV.Location = new System.Drawing.Point(360, 27);
            this.dtpNgaySinhNV.Name = "dtpNgaySinhNV";
            this.dtpNgaySinhNV.Size = new System.Drawing.Size(100, 23);
            this.dtpNgaySinhNV.TabIndex = 2;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtSDTNV.Location = new System.Drawing.Point(360, 71);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(100, 21);
            this.txtSDTNV.TabIndex = 4;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTenNV.Location = new System.Drawing.Point(115, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 21);
            this.txtTenNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(115, 30);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 21);
            this.txtMaNV.TabIndex = 1;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(51, 72);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(52, 16);
            this.lblTenNV.TabIndex = 6;
            this.lblTenNV.Text = "Họ tên:";
            // 
            // lblGioiTinhNV
            // 
            this.lblGioiTinhNV.AutoSize = true;
            this.lblGioiTinhNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinhNV.Location = new System.Drawing.Point(37, 119);
            this.lblGioiTinhNV.Name = "lblGioiTinhNV";
            this.lblGioiTinhNV.Size = new System.Drawing.Size(66, 16);
            this.lblGioiTinhNV.TabIndex = 4;
            this.lblGioiTinhNV.Text = "Giới tính:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(6, 30);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(97, 16);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblNgaySinhNV
            // 
            this.lblNgaySinhNV.AutoSize = true;
            this.lblNgaySinhNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinhNV.Location = new System.Drawing.Point(257, 30);
            this.lblNgaySinhNV.Name = "lblNgaySinhNV";
            this.lblNgaySinhNV.Size = new System.Drawing.Size(76, 16);
            this.lblNgaySinhNV.TabIndex = 5;
            this.lblNgaySinhNV.Text = "Ngày Sinh:";
            // 
            // lblSDTNV
            // 
            this.lblSDTNV.AutoSize = true;
            this.lblSDTNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDTNV.Location = new System.Drawing.Point(257, 71);
            this.lblSDTNV.Name = "lblSDTNV";
            this.lblSDTNV.Size = new System.Drawing.Size(76, 16);
            this.lblSDTNV.TabIndex = 7;
            this.lblSDTNV.Text = "Điện thoại:";
            // 
            // dgvThongTinNV
            // 
            this.dgvThongTinNV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNV.Location = new System.Drawing.Point(0, 256);
            this.dgvThongTinNV.Name = "dgvThongTinNV";
            this.dgvThongTinNV.RowHeadersWidth = 51;
            this.dgvThongTinNV.Size = new System.Drawing.Size(620, 233);
            this.dgvThongTinNV.TabIndex = 21;
            this.dgvThongTinNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNV_CellContentClick);
            // 
            // frmCapNhatNhanVien
            // 
            this.AcceptButton = this.btnLuuNV;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.CancelButton = this.btnThoatfrmNV;
            this.ClientSize = new System.Drawing.Size(620, 489);
            this.Controls.Add(this.dgvThongTinNV);
            this.Controls.Add(this.grbThongTinNV);
            this.Controls.Add(this.pnlChucNangNV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatNhanVien_Load);
            this.pnlChucNangNV.ResumeLayout(false);
            this.grbThongTinNV.ResumeLayout(false);
            this.grbThongTinNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Trangchu;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnThoatfrmNV;
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
        private System.Windows.Forms.DateTimePicker dtpNgaySinhNV;
        private System.Windows.Forms.ComboBox cmbGioiTinhNV;
        private System.Windows.Forms.DataGridView dgvThongTinNV;
        private System.Windows.Forms.Button btnKhongLuuNV;
        private System.Windows.Forms.TextBox txtChucVuNV;
        private System.Windows.Forms.Label lblChucVuNV;
    }
}

