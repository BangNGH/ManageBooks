namespace DoAn_QLTV
{
    partial class frmLapPhieuMuon_Tra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuMuon_Tra));
            this.dgvThongTinPM = new System.Windows.Forms.DataGridView();
            this.grbThongTinPM = new System.Windows.Forms.GroupBox();
            this.cmbMaDG = new System.Windows.Forms.ComboBox();
            this.dOCGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNhanVienLapPM = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lblMaDGPM = new System.Windows.Forms.Label();
            this.lblMaPM = new System.Windows.Forms.Label();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.btnKhongLuuPM = new System.Windows.Forms.Button();
            this.btnThoatfrmPM = new System.Windows.Forms.Button();
            this.btnLuuPM = new System.Windows.Forms.Button();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnSuaPM = new System.Windows.Forms.Button();
            this.nHANVIENTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.NHANVIENTableAdapter();
            this.dOCGIATableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.DOCGIATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPM)).BeginInit();
            this.grbThongTinPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.pnlChucNangDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinPM
            // 
            this.dgvThongTinPM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPM.Location = new System.Drawing.Point(302, 0);
            this.dgvThongTinPM.Name = "dgvThongTinPM";
            this.dgvThongTinPM.RowHeadersWidth = 51;
            this.dgvThongTinPM.Size = new System.Drawing.Size(308, 225);
            this.dgvThongTinPM.TabIndex = 24;
            this.dgvThongTinPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinPM_CellContentClick);
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.cmbMaDG);
            this.grbThongTinPM.Controls.Add(this.cmbMaNV);
            this.grbThongTinPM.Controls.Add(this.lblNhanVienLapPM);
            this.grbThongTinPM.Controls.Add(this.txtMaPM);
            this.grbThongTinPM.Controls.Add(this.lblMaDGPM);
            this.grbThongTinPM.Controls.Add(this.lblMaPM);
            this.grbThongTinPM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinPM.Location = new System.Drawing.Point(22, 12);
            this.grbThongTinPM.Name = "grbThongTinPM";
            this.grbThongTinPM.Size = new System.Drawing.Size(276, 124);
            this.grbThongTinPM.TabIndex = 23;
            this.grbThongTinPM.TabStop = false;
            this.grbThongTinPM.Text = "Thông Tin Phiếu Mượn-Trả";
            // 
            // cmbMaDG
            // 
            this.cmbMaDG.DataSource = this.dOCGIABindingSource;
            this.cmbMaDG.DisplayMember = "TenDG";
            this.cmbMaDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaDG.FormattingEnabled = true;
            this.cmbMaDG.Location = new System.Drawing.Point(126, 95);
            this.cmbMaDG.Name = "cmbMaDG";
            this.cmbMaDG.Size = new System.Drawing.Size(125, 23);
            this.cmbMaDG.TabIndex = 3;
            this.cmbMaDG.ValueMember = "MaDG";
            // 
            // dOCGIABindingSource
            // 
            this.dOCGIABindingSource.DataMember = "DOCGIA";
            this.dOCGIABindingSource.DataSource = this.dOAnQLTVDataSet1;
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
            this.lblNhanVienLapPM.Location = new System.Drawing.Point(21, 62);
            this.lblNhanVienLapPM.Name = "lblNhanVienLapPM";
            this.lblNhanVienLapPM.Size = new System.Drawing.Size(99, 16);
            this.lblNhanVienLapPM.TabIndex = 11;
            this.lblNhanVienLapPM.Text = "Nhân viên lập:";
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(136, 30);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(88, 21);
            this.txtMaPM.TabIndex = 1;
            // 
            // lblMaDGPM
            // 
            this.lblMaDGPM.AutoSize = true;
            this.lblMaDGPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDGPM.Location = new System.Drawing.Point(59, 95);
            this.lblMaDGPM.Name = "lblMaDGPM";
            this.lblMaDGPM.Size = new System.Drawing.Size(59, 16);
            this.lblMaDGPM.TabIndex = 6;
            this.lblMaDGPM.Text = "Độc giả:";
            // 
            // lblMaPM
            // 
            this.lblMaPM.AutoSize = true;
            this.lblMaPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPM.Location = new System.Drawing.Point(6, 32);
            this.lblMaPM.Name = "lblMaPM";
            this.lblMaPM.Size = new System.Drawing.Size(112, 16);
            this.lblMaPM.TabIndex = 3;
            this.lblMaPM.Text = "Mã phiếu mượn:";
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangDG.Controls.Add(this.btnThemPM);
            this.pnlChucNangDG.Controls.Add(this.btnKhongLuuPM);
            this.pnlChucNangDG.Controls.Add(this.btnThoatfrmPM);
            this.pnlChucNangDG.Controls.Add(this.btnLuuPM);
            this.pnlChucNangDG.Controls.Add(this.btnXoaPM);
            this.pnlChucNangDG.Controls.Add(this.btnSuaPM);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(13, 157);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(285, 59);
            this.pnlChucNangDG.TabIndex = 22;
            // 
            // btnThemPM
            // 
            this.btnThemPM.Location = new System.Drawing.Point(0, 0);
            this.btnThemPM.Name = "btnThemPM";
            this.btnThemPM.Size = new System.Drawing.Size(75, 24);
            this.btnThemPM.TabIndex = 13;
            this.btnThemPM.Text = "Thêm";
            this.btnThemPM.UseVisualStyleBackColor = true;
            this.btnThemPM.Click += new System.EventHandler(this.btnThemPM_Click);
            // 
            // btnKhongLuuPM
            // 
            this.btnKhongLuuPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuPM.Location = new System.Drawing.Point(99, 30);
            this.btnKhongLuuPM.Name = "btnKhongLuuPM";
            this.btnKhongLuuPM.Size = new System.Drawing.Size(85, 24);
            this.btnKhongLuuPM.TabIndex = 18;
            this.btnKhongLuuPM.Text = "Không Lưu";
            this.btnKhongLuuPM.UseVisualStyleBackColor = true;
            this.btnKhongLuuPM.Click += new System.EventHandler(this.btnKhongLuuPM_Click);
            // 
            // btnThoatfrmPM
            // 
            this.btnThoatfrmPM.Location = new System.Drawing.Point(208, 29);
            this.btnThoatfrmPM.Name = "btnThoatfrmPM";
            this.btnThoatfrmPM.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmPM.TabIndex = 14;
            this.btnThoatfrmPM.Text = "Thoát";
            this.btnThoatfrmPM.UseVisualStyleBackColor = true;
            this.btnThoatfrmPM.Click += new System.EventHandler(this.btnThoatfrmPM_Click);
            // 
            // btnLuuPM
            // 
            this.btnLuuPM.Location = new System.Drawing.Point(0, 30);
            this.btnLuuPM.Name = "btnLuuPM";
            this.btnLuuPM.Size = new System.Drawing.Size(75, 24);
            this.btnLuuPM.TabIndex = 17;
            this.btnLuuPM.Text = "Lưu";
            this.btnLuuPM.UseVisualStyleBackColor = true;
            this.btnLuuPM.Click += new System.EventHandler(this.btnLuuPM_Click);
            // 
            // btnXoaPM
            // 
            this.btnXoaPM.Location = new System.Drawing.Point(99, 0);
            this.btnXoaPM.Name = "btnXoaPM";
            this.btnXoaPM.Size = new System.Drawing.Size(75, 24);
            this.btnXoaPM.TabIndex = 15;
            this.btnXoaPM.Text = "Xóa";
            this.btnXoaPM.UseVisualStyleBackColor = true;
            this.btnXoaPM.Click += new System.EventHandler(this.btnXoaPM_Click);
            // 
            // btnSuaPM
            // 
            this.btnSuaPM.Location = new System.Drawing.Point(208, 0);
            this.btnSuaPM.Name = "btnSuaPM";
            this.btnSuaPM.Size = new System.Drawing.Size(75, 23);
            this.btnSuaPM.TabIndex = 16;
            this.btnSuaPM.Text = "Sửa";
            this.btnSuaPM.UseVisualStyleBackColor = true;
            this.btnSuaPM.Click += new System.EventHandler(this.btnSuaPM_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // dOCGIATableAdapter
            // 
            this.dOCGIATableAdapter.ClearBeforeFill = true;
            // 
            // frmLapPhieuMuon_Tra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 224);
            this.Controls.Add(this.dgvThongTinPM);
            this.Controls.Add(this.grbThongTinPM);
            this.Controls.Add(this.pnlChucNangDG);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLapPhieuMuon_Tra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Mượn Trả";
            this.Load += new System.EventHandler(this.frmLapPhieuMuon_Tra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPM)).EndInit();
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOCGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.pnlChucNangDG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinPM;
        private System.Windows.Forms.GroupBox grbThongTinPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblMaDGPM;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button btnThemPM;
        private System.Windows.Forms.Button btnKhongLuuPM;
        private System.Windows.Forms.Button btnThoatfrmPM;
        private System.Windows.Forms.Button btnLuuPM;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Button btnSuaPM;
        private System.Windows.Forms.Label lblNhanVienLapPM;
        private System.Windows.Forms.ComboBox cmbMaDG;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DOAnQLTVDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource dOCGIABindingSource;
        private DOAnQLTVDataSet1TableAdapters.DOCGIATableAdapter dOCGIATableAdapter;
    }
}