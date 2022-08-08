namespace DoAn_QLTV
{
    partial class frmPhieuNhapSach
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
            this.dgvThongTinPN = new System.Windows.Forms.DataGridView();
            this.grbThongTinPM = new System.Windows.Forms.GroupBox();
            this.cmbMaNCC = new System.Windows.Forms.ComboBox();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNhanVienLapPM = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.lblMaDGPM = new System.Windows.Forms.Label();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnThemPN = new System.Windows.Forms.Button();
            this.btnKhongLuuPN = new System.Windows.Forms.Button();
            this.btnThoatfrmPN = new System.Windows.Forms.Button();
            this.btnLuuPN = new System.Windows.Forms.Button();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.nHACUNGCAPTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.NHACUNGCAPTableAdapter();
            this.nHANVIENTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPN)).BeginInit();
            this.grbThongTinPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.pnlChucNangDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinPN
            // 
            this.dgvThongTinPN.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPN.Location = new System.Drawing.Point(292, 12);
            this.dgvThongTinPN.Name = "dgvThongTinPN";
            this.dgvThongTinPN.RowHeadersWidth = 51;
            this.dgvThongTinPN.Size = new System.Drawing.Size(308, 221);
            this.dgvThongTinPN.TabIndex = 27;
            this.dgvThongTinPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinPN_CellContentClick);
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.cmbMaNCC);
            this.grbThongTinPM.Controls.Add(this.cmbMaNV);
            this.grbThongTinPM.Controls.Add(this.lblNhanVienLapPM);
            this.grbThongTinPM.Controls.Add(this.txtMaPN);
            this.grbThongTinPM.Controls.Add(this.lblMaDGPM);
            this.grbThongTinPM.Controls.Add(this.lblMaPN);
            this.grbThongTinPM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinPM.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinPM.Name = "grbThongTinPM";
            this.grbThongTinPM.Size = new System.Drawing.Size(276, 124);
            this.grbThongTinPM.TabIndex = 26;
            this.grbThongTinPM.TabStop = false;
            this.grbThongTinPM.Text = "Thông tin phiếu nhập";
            // 
            // cmbMaNCC
            // 
            this.cmbMaNCC.DataSource = this.nHACUNGCAPBindingSource;
            this.cmbMaNCC.DisplayMember = "TenNCC";
            this.cmbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNCC.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaNCC.FormattingEnabled = true;
            this.cmbMaNCC.Location = new System.Drawing.Point(126, 95);
            this.cmbMaNCC.Name = "cmbMaNCC";
            this.cmbMaNCC.Size = new System.Drawing.Size(125, 23);
            this.cmbMaNCC.TabIndex = 3;
            this.cmbMaNCC.ValueMember = "MaNCC";
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // dOAnQLTVDataSet1
            // 
            this.dOAnQLTVDataSet1.DataSetName = "DOAnQLTVDataSet1";
            this.dOAnQLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.DataSource = this.nHANVIENBindingSource;
            this.cmbMaNV.DisplayMember = "TenNV";
            this.cmbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(126, 60);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(125, 23);
            this.cmbMaNV.TabIndex = 2;
            this.cmbMaNV.ValueMember = "MaNV";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // lblNhanVienLapPM
            // 
            this.lblNhanVienLapPM.AutoSize = true;
            this.lblNhanVienLapPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienLapPM.Location = new System.Drawing.Point(13, 62);
            this.lblNhanVienLapPM.Name = "lblNhanVienLapPM";
            this.lblNhanVienLapPM.Size = new System.Drawing.Size(99, 16);
            this.lblNhanVienLapPM.TabIndex = 11;
            this.lblNhanVienLapPM.Text = "Nhân viên lập:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(126, 30);
            this.txtMaPN.MaxLength = 24;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(125, 21);
            this.txtMaPN.TabIndex = 1;
            // 
            // lblMaDGPM
            // 
            this.lblMaDGPM.AutoSize = true;
            this.lblMaDGPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDGPM.Location = new System.Drawing.Point(14, 97);
            this.lblMaDGPM.Name = "lblMaDGPM";
            this.lblMaDGPM.Size = new System.Drawing.Size(98, 16);
            this.lblMaDGPM.TabIndex = 6;
            this.lblMaDGPM.Text = "Nhà cung cấp:";
            // 
            // lblMaPN
            // 
            this.lblMaPN.AutoSize = true;
            this.lblMaPN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPN.Location = new System.Drawing.Point(6, 32);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(106, 16);
            this.lblMaPN.TabIndex = 3;
            this.lblMaPN.Text = "Mã phiếu nhập:";
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangDG.Controls.Add(this.btnThemPN);
            this.pnlChucNangDG.Controls.Add(this.btnKhongLuuPN);
            this.pnlChucNangDG.Controls.Add(this.btnThoatfrmPN);
            this.pnlChucNangDG.Controls.Add(this.btnLuuPN);
            this.pnlChucNangDG.Controls.Add(this.btnXoaPN);
            this.pnlChucNangDG.Controls.Add(this.btnSuaPN);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(3, 157);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(285, 59);
            this.pnlChucNangDG.TabIndex = 25;
            // 
            // btnThemPN
            // 
            this.btnThemPN.Location = new System.Drawing.Point(0, 0);
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.Size = new System.Drawing.Size(75, 24);
            this.btnThemPN.TabIndex = 13;
            this.btnThemPN.Text = "Thêm";
            this.btnThemPN.UseVisualStyleBackColor = true;
            this.btnThemPN.Click += new System.EventHandler(this.btnThemPN_Click);
            // 
            // btnKhongLuuPN
            // 
            this.btnKhongLuuPN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuPN.Location = new System.Drawing.Point(99, 30);
            this.btnKhongLuuPN.Name = "btnKhongLuuPN";
            this.btnKhongLuuPN.Size = new System.Drawing.Size(85, 24);
            this.btnKhongLuuPN.TabIndex = 18;
            this.btnKhongLuuPN.Text = "Không Lưu";
            this.btnKhongLuuPN.UseVisualStyleBackColor = true;
            this.btnKhongLuuPN.Click += new System.EventHandler(this.btnKhongLuuPN_Click);
            // 
            // btnThoatfrmPN
            // 
            this.btnThoatfrmPN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatfrmPN.Location = new System.Drawing.Point(208, 29);
            this.btnThoatfrmPN.Name = "btnThoatfrmPN";
            this.btnThoatfrmPN.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmPN.TabIndex = 14;
            this.btnThoatfrmPN.Text = "Thoát";
            this.btnThoatfrmPN.UseVisualStyleBackColor = true;
            this.btnThoatfrmPN.Click += new System.EventHandler(this.btnThoatfrmPN_Click);
            // 
            // btnLuuPN
            // 
            this.btnLuuPN.Location = new System.Drawing.Point(0, 30);
            this.btnLuuPN.Name = "btnLuuPN";
            this.btnLuuPN.Size = new System.Drawing.Size(75, 24);
            this.btnLuuPN.TabIndex = 17;
            this.btnLuuPN.Text = "Lưu";
            this.btnLuuPN.UseVisualStyleBackColor = true;
            this.btnLuuPN.Click += new System.EventHandler(this.btnLuuPN_Click);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.Location = new System.Drawing.Point(99, 0);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(75, 24);
            this.btnXoaPN.TabIndex = 15;
            this.btnXoaPN.Text = "Xóa";
            this.btnXoaPN.UseVisualStyleBackColor = true;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.Location = new System.Drawing.Point(208, 0);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPN.TabIndex = 16;
            this.btnSuaPN.Text = "Sửa";
            this.btnSuaPN.UseVisualStyleBackColor = true;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click);
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhapSach
            // 
            this.AcceptButton = this.btnLuuPN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoatfrmPN;
            this.ClientSize = new System.Drawing.Size(598, 230);
            this.Controls.Add(this.dgvThongTinPN);
            this.Controls.Add(this.grbThongTinPM);
            this.Controls.Add(this.pnlChucNangDG);
            this.Name = "frmPhieuNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Nhập Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPhieuNhapSach_FormClosing);
            this.Load += new System.EventHandler(this.frmPhieuNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPN)).EndInit();
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.pnlChucNangDG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinPN;
        private System.Windows.Forms.GroupBox grbThongTinPM;
        private System.Windows.Forms.ComboBox cmbMaNCC;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label lblNhanVienLapPM;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label lblMaDGPM;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button btnThemPN;
        private System.Windows.Forms.Button btnKhongLuuPN;
        private System.Windows.Forms.Button btnThoatfrmPN;
        private System.Windows.Forms.Button btnLuuPN;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Button btnSuaPN;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private DOAnQLTVDataSet1TableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DOAnQLTVDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}