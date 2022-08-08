namespace DoAn_QLTV
{
    partial class frmCTPM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPM));
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lblMaPM = new System.Windows.Forms.Label();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.btnKhongLuuPM = new System.Windows.Forms.Button();
            this.btnThoatfrmPM = new System.Windows.Forms.Button();
            this.btnLuuPM = new System.Windows.Forms.Button();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnSuaPM = new System.Windows.Forms.Button();
            this.dgvThongTinCTPM = new System.Windows.Forms.DataGridView();
            this.grbThongTinPM = new System.Windows.Forms.GroupBox();
            this.cmbTenSach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.cmbMaPM = new System.Windows.Forms.ComboBox();
            this.pHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMaCTPM = new System.Windows.Forms.Label();
            this.cmbTinhTrangSach = new System.Windows.Forms.ComboBox();
            this.lblTinhTrangSach = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnThemCTPM = new System.Windows.Forms.Button();
            this.btnKhongLuuCTPM = new System.Windows.Forms.Button();
            this.btnThoatfrmCTPM = new System.Windows.Forms.Button();
            this.btnLuuCTPM = new System.Windows.Forms.Button();
            this.btnXoaCTPM = new System.Windows.Forms.Button();
            this.btnSuaCTPM = new System.Windows.Forms.Button();
            this.pHIEUMUONTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.PHIEUMUONTableAdapter();
            this.sACHTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.SACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPM)).BeginInit();
            this.grbThongTinPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).BeginInit();
            this.pnlChucNangDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(124, 30);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(100, 21);
            this.txtMaPM.TabIndex = 8;
            // 
            // lblMaPM
            // 
            this.lblMaPM.AutoSize = true;
            this.lblMaPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPM.Location = new System.Drawing.Point(-3, 32);
            this.lblMaPM.Name = "lblMaPM";
            this.lblMaPM.Size = new System.Drawing.Size(112, 16);
            this.lblMaPM.TabIndex = 3;
            this.lblMaPM.Text = "Mã phiếu mượn:";
            // 
            // btnThemPM
            // 
            this.btnThemPM.Location = new System.Drawing.Point(0, 0);
            this.btnThemPM.Name = "btnThemPM";
            this.btnThemPM.Size = new System.Drawing.Size(90, 24);
            this.btnThemPM.TabIndex = 13;
            this.btnThemPM.Text = "Thêm";
            this.btnThemPM.UseVisualStyleBackColor = true;
            // 
            // btnKhongLuuPM
            // 
            this.btnKhongLuuPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuPM.Location = new System.Drawing.Point(409, 0);
            this.btnKhongLuuPM.Name = "btnKhongLuuPM";
            this.btnKhongLuuPM.Size = new System.Drawing.Size(94, 24);
            this.btnKhongLuuPM.TabIndex = 18;
            this.btnKhongLuuPM.Text = "Không Lưu";
            this.btnKhongLuuPM.UseVisualStyleBackColor = true;
            // 
            // btnThoatfrmPM
            // 
            this.btnThoatfrmPM.Location = new System.Drawing.Point(518, 0);
            this.btnThoatfrmPM.Name = "btnThoatfrmPM";
            this.btnThoatfrmPM.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmPM.TabIndex = 14;
            this.btnThoatfrmPM.Text = "Thoát";
            this.btnThoatfrmPM.UseVisualStyleBackColor = true;
            // 
            // btnLuuPM
            // 
            this.btnLuuPM.Location = new System.Drawing.Point(309, 1);
            this.btnLuuPM.Name = "btnLuuPM";
            this.btnLuuPM.Size = new System.Drawing.Size(75, 24);
            this.btnLuuPM.TabIndex = 17;
            this.btnLuuPM.Text = "Lưu";
            this.btnLuuPM.UseVisualStyleBackColor = true;
            // 
            // btnXoaPM
            // 
            this.btnXoaPM.Location = new System.Drawing.Point(108, 0);
            this.btnXoaPM.Name = "btnXoaPM";
            this.btnXoaPM.Size = new System.Drawing.Size(75, 24);
            this.btnXoaPM.TabIndex = 15;
            this.btnXoaPM.Text = "Xóa";
            this.btnXoaPM.UseVisualStyleBackColor = true;
            // 
            // btnSuaPM
            // 
            this.btnSuaPM.Location = new System.Drawing.Point(207, 1);
            this.btnSuaPM.Name = "btnSuaPM";
            this.btnSuaPM.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPM.TabIndex = 16;
            this.btnSuaPM.Text = "Sửa";
            this.btnSuaPM.UseVisualStyleBackColor = true;
            // 
            // dgvThongTinCTPM
            // 
            this.dgvThongTinCTPM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinCTPM.Location = new System.Drawing.Point(-2, 222);
            this.dgvThongTinCTPM.Name = "dgvThongTinCTPM";
            this.dgvThongTinCTPM.RowHeadersWidth = 51;
            this.dgvThongTinCTPM.Size = new System.Drawing.Size(626, 314);
            this.dgvThongTinCTPM.TabIndex = 30;
            this.dgvThongTinCTPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinCTPM_CellContentClick);
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.cmbTenSach);
            this.grbThongTinPM.Controls.Add(this.cmbMaPM);
            this.grbThongTinPM.Controls.Add(this.lblMaCTPM);
            this.grbThongTinPM.Controls.Add(this.cmbTinhTrangSach);
            this.grbThongTinPM.Controls.Add(this.lblTinhTrangSach);
            this.grbThongTinPM.Controls.Add(this.dtpNgayTra);
            this.grbThongTinPM.Controls.Add(this.dtpNgayMuon);
            this.grbThongTinPM.Controls.Add(this.label1);
            this.grbThongTinPM.Controls.Add(this.lblTenDG);
            this.grbThongTinPM.Controls.Add(this.lblTenSach);
            this.grbThongTinPM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinPM.Location = new System.Drawing.Point(69, 12);
            this.grbThongTinPM.Name = "grbThongTinPM";
            this.grbThongTinPM.Size = new System.Drawing.Size(467, 157);
            this.grbThongTinPM.TabIndex = 29;
            this.grbThongTinPM.TabStop = false;
            this.grbThongTinPM.Text = "Thông tin chi tiết phiếu mượn";
            // 
            // cmbTenSach
            // 
            this.cmbTenSach.DataSource = this.sACHBindingSource;
            this.cmbTenSach.DisplayMember = "TenSach";
            this.cmbTenSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenSach.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbTenSach.FormattingEnabled = true;
            this.cmbTenSach.Location = new System.Drawing.Point(346, 33);
            this.cmbTenSach.Name = "cmbTenSach";
            this.cmbTenSach.Size = new System.Drawing.Size(116, 23);
            this.cmbTenSach.TabIndex = 4;
            this.cmbTenSach.ValueMember = "MaSach";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // dOAnQLTVDataSet1
            // 
            this.dOAnQLTVDataSet1.DataSetName = "DOAnQLTVDataSet1";
            this.dOAnQLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaPM
            // 
            this.cmbMaPM.DataSource = this.pHIEUMUONBindingSource;
            this.cmbMaPM.DisplayMember = "MaPM";
            this.cmbMaPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPM.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaPM.FormattingEnabled = true;
            this.cmbMaPM.Location = new System.Drawing.Point(123, 35);
            this.cmbMaPM.Name = "cmbMaPM";
            this.cmbMaPM.Size = new System.Drawing.Size(101, 23);
            this.cmbMaPM.TabIndex = 1;
            // 
            // pHIEUMUONBindingSource
            // 
            this.pHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.pHIEUMUONBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // lblMaCTPM
            // 
            this.lblMaCTPM.AutoSize = true;
            this.lblMaCTPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTPM.Location = new System.Drawing.Point(-3, 35);
            this.lblMaCTPM.Name = "lblMaCTPM";
            this.lblMaCTPM.Size = new System.Drawing.Size(112, 16);
            this.lblMaCTPM.TabIndex = 23;
            this.lblMaCTPM.Text = "Mã phiếu mượn:";
            // 
            // cmbTinhTrangSach
            // 
            this.cmbTinhTrangSach.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbTinhTrangSach.FormattingEnabled = true;
            this.cmbTinhTrangSach.Items.AddRange(new object[] {
            "Hư hỏng",
            "Mất",
            "Nguyên vẹn"});
            this.cmbTinhTrangSach.Location = new System.Drawing.Point(123, 114);
            this.cmbTinhTrangSach.Name = "cmbTinhTrangSach";
            this.cmbTinhTrangSach.Size = new System.Drawing.Size(101, 23);
            this.cmbTinhTrangSach.TabIndex = 3;
            // 
            // lblTinhTrangSach
            // 
            this.lblTinhTrangSach.AutoSize = true;
            this.lblTinhTrangSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangSach.Location = new System.Drawing.Point(-4, 116);
            this.lblTinhTrangSach.Name = "lblTinhTrangSach";
            this.lblTinhTrangSach.Size = new System.Drawing.Size(113, 16);
            this.lblTinhTrangSach.TabIndex = 20;
            this.lblTinhTrangSach.Text = "Tình trạng sách: ";
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "MM/dd/yyyy";
            this.dtpNgayTra.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(346, 75);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(116, 21);
            this.dtpNgayTra.TabIndex = 5;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "MM/dd/yyyy";
            this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(123, 71);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(101, 21);
            this.dtpNgayMuon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hẹn Trả: ";
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(25, 75);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Size = new System.Drawing.Size(85, 16);
            this.lblTenDG.TabIndex = 12;
            this.lblTenDG.Text = "Ngày mượn:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(268, 35);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(68, 16);
            this.lblTenSach.TabIndex = 11;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangDG.Controls.Add(this.btnThemCTPM);
            this.pnlChucNangDG.Controls.Add(this.btnKhongLuuCTPM);
            this.pnlChucNangDG.Controls.Add(this.btnThoatfrmCTPM);
            this.pnlChucNangDG.Controls.Add(this.btnLuuCTPM);
            this.pnlChucNangDG.Controls.Add(this.btnXoaCTPM);
            this.pnlChucNangDG.Controls.Add(this.btnSuaCTPM);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(29, 175);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(581, 26);
            this.pnlChucNangDG.TabIndex = 31;
            // 
            // btnThemCTPM
            // 
            this.btnThemCTPM.Location = new System.Drawing.Point(0, 0);
            this.btnThemCTPM.Name = "btnThemCTPM";
            this.btnThemCTPM.Size = new System.Drawing.Size(75, 26);
            this.btnThemCTPM.TabIndex = 13;
            this.btnThemCTPM.Text = "Thêm";
            this.btnThemCTPM.UseVisualStyleBackColor = true;
            this.btnThemCTPM.Click += new System.EventHandler(this.btnThemCTPM_Click);
            // 
            // btnKhongLuuCTPM
            // 
            this.btnKhongLuuCTPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuCTPM.Location = new System.Drawing.Point(386, -1);
            this.btnKhongLuuCTPM.Name = "btnKhongLuuCTPM";
            this.btnKhongLuuCTPM.Size = new System.Drawing.Size(99, 27);
            this.btnKhongLuuCTPM.TabIndex = 18;
            this.btnKhongLuuCTPM.Text = "Không Lưu";
            this.btnKhongLuuCTPM.UseVisualStyleBackColor = true;
            this.btnKhongLuuCTPM.Click += new System.EventHandler(this.btnKhongLuuCTPM_Click);
            // 
            // btnThoatfrmCTPM
            // 
            this.btnThoatfrmCTPM.Location = new System.Drawing.Point(503, 0);
            this.btnThoatfrmCTPM.Name = "btnThoatfrmCTPM";
            this.btnThoatfrmCTPM.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmCTPM.TabIndex = 14;
            this.btnThoatfrmCTPM.Text = "Thoát";
            this.btnThoatfrmCTPM.UseVisualStyleBackColor = true;
            this.btnThoatfrmCTPM.Click += new System.EventHandler(this.btnThoatfrmCTPM_Click);
            // 
            // btnLuuCTPM
            // 
            this.btnLuuCTPM.Location = new System.Drawing.Point(288, -1);
            this.btnLuuCTPM.Name = "btnLuuCTPM";
            this.btnLuuCTPM.Size = new System.Drawing.Size(75, 27);
            this.btnLuuCTPM.TabIndex = 17;
            this.btnLuuCTPM.Text = "Lưu";
            this.btnLuuCTPM.UseVisualStyleBackColor = true;
            this.btnLuuCTPM.Click += new System.EventHandler(this.btnLuuCTPM_Click);
            // 
            // btnXoaCTPM
            // 
            this.btnXoaCTPM.Location = new System.Drawing.Point(99, 0);
            this.btnXoaCTPM.Name = "btnXoaCTPM";
            this.btnXoaCTPM.Size = new System.Drawing.Size(75, 26);
            this.btnXoaCTPM.TabIndex = 15;
            this.btnXoaCTPM.Text = "Xóa";
            this.btnXoaCTPM.UseVisualStyleBackColor = true;
            this.btnXoaCTPM.Click += new System.EventHandler(this.btnXoaCTPM_Click);
            // 
            // btnSuaCTPM
            // 
            this.btnSuaCTPM.Location = new System.Drawing.Point(195, 0);
            this.btnSuaCTPM.Name = "btnSuaCTPM";
            this.btnSuaCTPM.Size = new System.Drawing.Size(75, 26);
            this.btnSuaCTPM.TabIndex = 16;
            this.btnSuaCTPM.Text = "Sửa";
            this.btnSuaCTPM.UseVisualStyleBackColor = true;
            this.btnSuaCTPM.Click += new System.EventHandler(this.btnSuaCTPM_Click);
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmCTPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(622, 548);
            this.Controls.Add(this.pnlChucNangDG);
            this.Controls.Add(this.dgvThongTinCTPM);
            this.Controls.Add(this.grbThongTinPM);
            this.Name = "frmCTPM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Phiếu Mượn";
            this.Load += new System.EventHandler(this.frmCTPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPM)).EndInit();
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).EndInit();
            this.pnlChucNangDG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.Button btnThemPM;
        private System.Windows.Forms.Button btnKhongLuuPM;
        private System.Windows.Forms.Button btnThoatfrmPM;
        private System.Windows.Forms.Button btnLuuPM;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Button btnSuaPM;
        private System.Windows.Forms.DataGridView dgvThongTinCTPM;
        private System.Windows.Forms.GroupBox grbThongTinPM;
        private System.Windows.Forms.Label lblMaCTPM;
        private System.Windows.Forms.ComboBox cmbTinhTrangSach;
        private System.Windows.Forms.Label lblTinhTrangSach;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button btnThemCTPM;
        private System.Windows.Forms.Button btnKhongLuuCTPM;
        private System.Windows.Forms.Button btnThoatfrmCTPM;
        private System.Windows.Forms.Button btnLuuCTPM;
        private System.Windows.Forms.Button btnXoaCTPM;
        private System.Windows.Forms.Button btnSuaCTPM;
        private System.Windows.Forms.ComboBox cmbMaPM;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource pHIEUMUONBindingSource;
        private DOAnQLTVDataSet1TableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private System.Windows.Forms.ComboBox cmbTenSach;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private DOAnQLTVDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}