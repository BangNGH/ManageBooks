namespace DoAn_QLTV
{
    partial class frmLapPhieuPhat
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
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnThemPP = new System.Windows.Forms.Button();
            this.btnKhongLuuPP = new System.Windows.Forms.Button();
            this.btnThoatfrmLapPhieuPhat = new System.Windows.Forms.Button();
            this.btnLuuPP = new System.Windows.Forms.Button();
            this.btnXoaPP = new System.Windows.Forms.Button();
            this.btnSuaPP = new System.Windows.Forms.Button();
            this.dgvThongTinPP = new System.Windows.Forms.DataGridView();
            this.grbThongTinPM = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblMucPhi = new System.Windows.Forms.Label();
            this.cmbMaNV = new System.Windows.Forms.ComboBox();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaPP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaSach = new System.Windows.Forms.ComboBox();
            this.cTPHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaPM = new System.Windows.Forms.ComboBox();
            this.lblMaCTPM = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.cT_PHIEUMUONTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.CT_PHIEUMUONTableAdapter();
            this.nHANVIENTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.NHANVIENTableAdapter();
            this.pnlChucNangDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPP)).BeginInit();
            this.grbThongTinPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUMUONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangDG.Controls.Add(this.btnThemPP);
            this.pnlChucNangDG.Controls.Add(this.btnKhongLuuPP);
            this.pnlChucNangDG.Controls.Add(this.btnThoatfrmLapPhieuPhat);
            this.pnlChucNangDG.Controls.Add(this.btnLuuPP);
            this.pnlChucNangDG.Controls.Add(this.btnXoaPP);
            this.pnlChucNangDG.Controls.Add(this.btnSuaPP);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(1, 175);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(581, 26);
            this.pnlChucNangDG.TabIndex = 34;
            // 
            // btnThemPP
            // 
            this.btnThemPP.Location = new System.Drawing.Point(0, 0);
            this.btnThemPP.Name = "btnThemPP";
            this.btnThemPP.Size = new System.Drawing.Size(75, 26);
            this.btnThemPP.TabIndex = 13;
            this.btnThemPP.Text = "Thêm";
            this.btnThemPP.UseVisualStyleBackColor = true;
            this.btnThemPP.Click += new System.EventHandler(this.btnThemPP_Click);
            // 
            // btnKhongLuuPP
            // 
            this.btnKhongLuuPP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuPP.Location = new System.Drawing.Point(386, -1);
            this.btnKhongLuuPP.Name = "btnKhongLuuPP";
            this.btnKhongLuuPP.Size = new System.Drawing.Size(99, 27);
            this.btnKhongLuuPP.TabIndex = 18;
            this.btnKhongLuuPP.Text = "Không Lưu";
            this.btnKhongLuuPP.UseVisualStyleBackColor = true;
            this.btnKhongLuuPP.Click += new System.EventHandler(this.btnKhongLuuPP_Click);
            // 
            // btnThoatfrmLapPhieuPhat
            // 
            this.btnThoatfrmLapPhieuPhat.Location = new System.Drawing.Point(503, 0);
            this.btnThoatfrmLapPhieuPhat.Name = "btnThoatfrmLapPhieuPhat";
            this.btnThoatfrmLapPhieuPhat.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmLapPhieuPhat.TabIndex = 14;
            this.btnThoatfrmLapPhieuPhat.Text = "Thoát";
            this.btnThoatfrmLapPhieuPhat.UseVisualStyleBackColor = true;
            this.btnThoatfrmLapPhieuPhat.Click += new System.EventHandler(this.btnThoatfrmLapPhieuPhat_Click);
            // 
            // btnLuuPP
            // 
            this.btnLuuPP.Location = new System.Drawing.Point(288, -1);
            this.btnLuuPP.Name = "btnLuuPP";
            this.btnLuuPP.Size = new System.Drawing.Size(75, 27);
            this.btnLuuPP.TabIndex = 17;
            this.btnLuuPP.Text = "Lưu";
            this.btnLuuPP.UseVisualStyleBackColor = true;
            this.btnLuuPP.Click += new System.EventHandler(this.btnLuuPP_Click);
            // 
            // btnXoaPP
            // 
            this.btnXoaPP.Location = new System.Drawing.Point(99, 0);
            this.btnXoaPP.Name = "btnXoaPP";
            this.btnXoaPP.Size = new System.Drawing.Size(75, 26);
            this.btnXoaPP.TabIndex = 15;
            this.btnXoaPP.Text = "Xóa";
            this.btnXoaPP.UseVisualStyleBackColor = true;
            this.btnXoaPP.Click += new System.EventHandler(this.btnXoaPP_Click);
            // 
            // btnSuaPP
            // 
            this.btnSuaPP.Location = new System.Drawing.Point(195, 0);
            this.btnSuaPP.Name = "btnSuaPP";
            this.btnSuaPP.Size = new System.Drawing.Size(75, 26);
            this.btnSuaPP.TabIndex = 16;
            this.btnSuaPP.Text = "Sửa";
            this.btnSuaPP.UseVisualStyleBackColor = true;
            this.btnSuaPP.Click += new System.EventHandler(this.btnSuaPP_Click);
            // 
            // dgvThongTinPP
            // 
            this.dgvThongTinPP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPP.Location = new System.Drawing.Point(1, 211);
            this.dgvThongTinPP.Name = "dgvThongTinPP";
            this.dgvThongTinPP.RowHeadersWidth = 51;
            this.dgvThongTinPP.Size = new System.Drawing.Size(580, 326);
            this.dgvThongTinPP.TabIndex = 33;
            this.dgvThongTinPP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinCTPM_CellContentClick);
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.textBox2);
            this.grbThongTinPM.Controls.Add(this.lblMucPhi);
            this.grbThongTinPM.Controls.Add(this.cmbMaNV);
            this.grbThongTinPM.Controls.Add(this.lblMaNV);
            this.grbThongTinPM.Controls.Add(this.txtMaPP);
            this.grbThongTinPM.Controls.Add(this.label1);
            this.grbThongTinPM.Controls.Add(this.cmbMaSach);
            this.grbThongTinPM.Controls.Add(this.cmbMaPM);
            this.grbThongTinPM.Controls.Add(this.lblMaCTPM);
            this.grbThongTinPM.Controls.Add(this.lblTenSach);
            this.grbThongTinPM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinPM.Location = new System.Drawing.Point(43, 12);
            this.grbThongTinPM.Name = "grbThongTinPM";
            this.grbThongTinPM.Size = new System.Drawing.Size(506, 157);
            this.grbThongTinPM.TabIndex = 32;
            this.grbThongTinPM.TabStop = false;
            this.grbThongTinPM.Text = "Thông tin phiếu phạt";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.textBox2.Location = new System.Drawing.Point(384, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 29;
            // 
            // lblMucPhi
            // 
            this.lblMucPhi.AutoSize = true;
            this.lblMucPhi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucPhi.Location = new System.Drawing.Point(297, 79);
            this.lblMucPhi.Name = "lblMucPhi";
            this.lblMucPhi.Size = new System.Drawing.Size(64, 16);
            this.lblMucPhi.TabIndex = 28;
            this.lblMucPhi.Text = "Phí phạt:";
            // 
            // cmbMaNV
            // 
            this.cmbMaNV.DataSource = this.nHANVIENBindingSource;
            this.cmbMaNV.DisplayMember = "TenNV";
            this.cmbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNV.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaNV.FormattingEnabled = true;
            this.cmbMaNV.Location = new System.Drawing.Point(384, 32);
            this.cmbMaNV.Name = "cmbMaNV";
            this.cmbMaNV.Size = new System.Drawing.Size(116, 23);
            this.cmbMaNV.TabIndex = 26;
            this.cmbMaNV.ValueMember = "MaNV";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // dOAnQLTVDataSet1
            // 
            this.dOAnQLTVDataSet1.DataSetName = "DOAnQLTVDataSet1";
            this.dOAnQLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(262, 32);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(99, 16);
            this.lblMaNV.TabIndex = 27;
            this.lblMaNV.Text = "Nhân viên lập:";
            // 
            // txtMaPP
            // 
            this.txtMaPP.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtMaPP.Location = new System.Drawing.Point(119, 32);
            this.txtMaPP.Name = "txtMaPP";
            this.txtMaPP.Size = new System.Drawing.Size(116, 21);
            this.txtMaPP.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã phiếu phạt:";
            // 
            // cmbMaSach
            // 
            this.cmbMaSach.DataSource = this.cTPHIEUMUONBindingSource;
            this.cmbMaSach.DisplayMember = "MaSach";
            this.cmbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSach.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaSach.FormattingEnabled = true;
            this.cmbMaSach.Location = new System.Drawing.Point(119, 111);
            this.cmbMaSach.Name = "cmbMaSach";
            this.cmbMaSach.Size = new System.Drawing.Size(116, 23);
            this.cmbMaSach.TabIndex = 4;
            // 
            // cTPHIEUMUONBindingSource
            // 
            this.cTPHIEUMUONBindingSource.DataMember = "CT_PHIEUMUON";
            this.cTPHIEUMUONBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // cmbMaPM
            // 
            this.cmbMaPM.DataSource = this.cTPHIEUMUONBindingSource;
            this.cmbMaPM.DisplayMember = "MaPM";
            this.cmbMaPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPM.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaPM.FormattingEnabled = true;
            this.cmbMaPM.Location = new System.Drawing.Point(119, 70);
            this.cmbMaPM.Name = "cmbMaPM";
            this.cmbMaPM.Size = new System.Drawing.Size(116, 23);
            this.cmbMaPM.TabIndex = 1;
            // 
            // lblMaCTPM
            // 
            this.lblMaCTPM.AutoSize = true;
            this.lblMaCTPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTPM.Location = new System.Drawing.Point(-3, 72);
            this.lblMaCTPM.Name = "lblMaCTPM";
            this.lblMaCTPM.Size = new System.Drawing.Size(112, 16);
            this.lblMaCTPM.TabIndex = 23;
            this.lblMaCTPM.Text = "Mã phiếu mượn:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(41, 111);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(68, 16);
            this.lblTenSach.TabIndex = 11;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // cT_PHIEUMUONTableAdapter
            // 
            this.cT_PHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // frmLapPhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 537);
            this.Controls.Add(this.pnlChucNangDG);
            this.Controls.Add(this.dgvThongTinPP);
            this.Controls.Add(this.grbThongTinPM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLapPhieuPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Phạt";
            this.Load += new System.EventHandler(this.frmLapPhieuPhat_Load);
            this.pnlChucNangDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPP)).EndInit();
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPHIEUMUONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button btnThemPP;
        private System.Windows.Forms.Button btnKhongLuuPP;
        private System.Windows.Forms.Button btnThoatfrmLapPhieuPhat;
        private System.Windows.Forms.Button btnLuuPP;
        private System.Windows.Forms.Button btnXoaPP;
        private System.Windows.Forms.Button btnSuaPP;
        private System.Windows.Forms.DataGridView dgvThongTinPP;
        private System.Windows.Forms.GroupBox grbThongTinPM;
        private System.Windows.Forms.ComboBox cmbMaSach;
        private System.Windows.Forms.ComboBox cmbMaPM;
        private System.Windows.Forms.Label lblMaCTPM;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtMaPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblMucPhi;
        private System.Windows.Forms.ComboBox cmbMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource cTPHIEUMUONBindingSource;
        private DOAnQLTVDataSet1TableAdapters.CT_PHIEUMUONTableAdapter cT_PHIEUMUONTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DOAnQLTVDataSet1TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
    }
}