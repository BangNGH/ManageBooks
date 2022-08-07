namespace DoAn_QLTV
{
    partial class frmCTPN
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
            this.dgvThongTinCTPN = new System.Windows.Forms.DataGridView();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnThemCTPN = new System.Windows.Forms.Button();
            this.btnKhongLuuCTPN = new System.Windows.Forms.Button();
            this.btnThoatfrmCTPN = new System.Windows.Forms.Button();
            this.btnLuuCTPN = new System.Windows.Forms.Button();
            this.btnXoaCTPN = new System.Windows.Forms.Button();
            this.btnSuaCTPN = new System.Windows.Forms.Button();
            this.grbThongTinPM = new System.Windows.Forms.GroupBox();
            this.txtSLNhap = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.cmbMaPN = new System.Windows.Forms.ComboBox();
            this.lblMaCTPM = new System.Windows.Forms.Label();
            this.cmbMaSach = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.lblSLNhap = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.sACHTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.SACHTableAdapter();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.pHIEUNHAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUNHAPTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.PHIEUNHAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPN)).BeginInit();
            this.pnlChucNangDG.SuspendLayout();
            this.grbThongTinPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinCTPN
            // 
            this.dgvThongTinCTPN.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinCTPN.Location = new System.Drawing.Point(0, 222);
            this.dgvThongTinCTPN.Name = "dgvThongTinCTPN";
            this.dgvThongTinCTPN.RowHeadersWidth = 51;
            this.dgvThongTinCTPN.Size = new System.Drawing.Size(626, 314);
            this.dgvThongTinCTPN.TabIndex = 33;
            this.dgvThongTinCTPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinCTPN_CellContentClick);
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangDG.Controls.Add(this.btnThemCTPN);
            this.pnlChucNangDG.Controls.Add(this.btnKhongLuuCTPN);
            this.pnlChucNangDG.Controls.Add(this.btnThoatfrmCTPN);
            this.pnlChucNangDG.Controls.Add(this.btnLuuCTPN);
            this.pnlChucNangDG.Controls.Add(this.btnXoaCTPN);
            this.pnlChucNangDG.Controls.Add(this.btnSuaCTPN);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(31, 175);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(581, 26);
            this.pnlChucNangDG.TabIndex = 34;
            // 
            // btnThemCTPN
            // 
            this.btnThemCTPN.Location = new System.Drawing.Point(0, 0);
            this.btnThemCTPN.Name = "btnThemCTPN";
            this.btnThemCTPN.Size = new System.Drawing.Size(75, 26);
            this.btnThemCTPN.TabIndex = 13;
            this.btnThemCTPN.Text = "Thêm";
            this.btnThemCTPN.UseVisualStyleBackColor = true;
            this.btnThemCTPN.Click += new System.EventHandler(this.btnThemCTPN_Click);
            // 
            // btnKhongLuuCTPN
            // 
            this.btnKhongLuuCTPN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuCTPN.Location = new System.Drawing.Point(386, -1);
            this.btnKhongLuuCTPN.Name = "btnKhongLuuCTPN";
            this.btnKhongLuuCTPN.Size = new System.Drawing.Size(99, 27);
            this.btnKhongLuuCTPN.TabIndex = 18;
            this.btnKhongLuuCTPN.Text = "Không Lưu";
            this.btnKhongLuuCTPN.UseVisualStyleBackColor = true;
            this.btnKhongLuuCTPN.Click += new System.EventHandler(this.btnKhongLuuCTPN_Click);
            // 
            // btnThoatfrmCTPN
            // 
            this.btnThoatfrmCTPN.Location = new System.Drawing.Point(503, 0);
            this.btnThoatfrmCTPN.Name = "btnThoatfrmCTPN";
            this.btnThoatfrmCTPN.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmCTPN.TabIndex = 14;
            this.btnThoatfrmCTPN.Text = "Thoát";
            this.btnThoatfrmCTPN.UseVisualStyleBackColor = true;
            this.btnThoatfrmCTPN.Click += new System.EventHandler(this.btnThoatfrmCTPN_Click);
            // 
            // btnLuuCTPN
            // 
            this.btnLuuCTPN.Location = new System.Drawing.Point(288, -1);
            this.btnLuuCTPN.Name = "btnLuuCTPN";
            this.btnLuuCTPN.Size = new System.Drawing.Size(75, 27);
            this.btnLuuCTPN.TabIndex = 17;
            this.btnLuuCTPN.Text = "Lưu";
            this.btnLuuCTPN.UseVisualStyleBackColor = true;
            this.btnLuuCTPN.Click += new System.EventHandler(this.btnLuuCTPN_Click);
            // 
            // btnXoaCTPN
            // 
            this.btnXoaCTPN.Location = new System.Drawing.Point(99, 0);
            this.btnXoaCTPN.Name = "btnXoaCTPN";
            this.btnXoaCTPN.Size = new System.Drawing.Size(75, 26);
            this.btnXoaCTPN.TabIndex = 15;
            this.btnXoaCTPN.Text = "Xóa";
            this.btnXoaCTPN.UseVisualStyleBackColor = true;
            this.btnXoaCTPN.Click += new System.EventHandler(this.btnXoaCTPN_Click);
            // 
            // btnSuaCTPN
            // 
            this.btnSuaCTPN.Location = new System.Drawing.Point(195, 0);
            this.btnSuaCTPN.Name = "btnSuaCTPN";
            this.btnSuaCTPN.Size = new System.Drawing.Size(75, 26);
            this.btnSuaCTPN.TabIndex = 16;
            this.btnSuaCTPN.Text = "Sửa";
            this.btnSuaCTPN.UseVisualStyleBackColor = true;
            this.btnSuaCTPN.Click += new System.EventHandler(this.btnSuaCTPN_Click);
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.txtDonGia);
            this.grbThongTinPM.Controls.Add(this.txtSLNhap);
            this.grbThongTinPM.Controls.Add(this.lblDonGia);
            this.grbThongTinPM.Controls.Add(this.cmbMaPN);
            this.grbThongTinPM.Controls.Add(this.lblMaCTPM);
            this.grbThongTinPM.Controls.Add(this.cmbMaSach);
            this.grbThongTinPM.Controls.Add(this.lblSLNhap);
            this.grbThongTinPM.Controls.Add(this.lblTenSach);
            this.grbThongTinPM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinPM.Location = new System.Drawing.Point(71, 12);
            this.grbThongTinPM.Name = "grbThongTinPM";
            this.grbThongTinPM.Size = new System.Drawing.Size(467, 157);
            this.grbThongTinPM.TabIndex = 32;
            this.grbThongTinPM.TabStop = false;
            this.grbThongTinPM.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // txtSLNhap
            // 
            this.txtSLNhap.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtSLNhap.Location = new System.Drawing.Point(360, 35);
            this.txtSLNhap.Name = "txtSLNhap";
            this.txtSLNhap.Size = new System.Drawing.Size(101, 21);
            this.txtSLNhap.TabIndex = 25;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(245, 80);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(93, 16);
            this.lblDonGia.TabIndex = 24;
            this.lblDonGia.Text = "Đơn giá nhập";
            // 
            // cmbMaPN
            // 
            this.cmbMaPN.DataSource = this.pHIEUNHAPBindingSource;
            this.cmbMaPN.DisplayMember = "MaPN";
            this.cmbMaPN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPN.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaPN.FormattingEnabled = true;
            this.cmbMaPN.Location = new System.Drawing.Point(123, 35);
            this.cmbMaPN.Name = "cmbMaPN";
            this.cmbMaPN.Size = new System.Drawing.Size(101, 23);
            this.cmbMaPN.TabIndex = 1;
            // 
            // lblMaCTPM
            // 
            this.lblMaCTPM.AutoSize = true;
            this.lblMaCTPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTPM.Location = new System.Drawing.Point(3, 35);
            this.lblMaCTPM.Name = "lblMaCTPM";
            this.lblMaCTPM.Size = new System.Drawing.Size(106, 16);
            this.lblMaCTPM.TabIndex = 23;
            this.lblMaCTPM.Text = "Mã phiếu nhập:";
            // 
            // cmbMaSach
            // 
            this.cmbMaSach.DataSource = this.sACHBindingSource;
            this.cmbMaSach.DisplayMember = "TenSach";
            this.cmbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaSach.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaSach.FormattingEnabled = true;
            this.cmbMaSach.Location = new System.Drawing.Point(123, 73);
            this.cmbMaSach.Name = "cmbMaSach";
            this.cmbMaSach.Size = new System.Drawing.Size(101, 23);
            this.cmbMaSach.TabIndex = 3;
            this.cmbMaSach.ValueMember = "MaSach";
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
            // lblSLNhap
            // 
            this.lblSLNhap.AutoSize = true;
            this.lblSLNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLNhap.Location = new System.Drawing.Point(245, 35);
            this.lblSLNhap.Name = "lblSLNhap";
            this.lblSLNhap.Size = new System.Drawing.Size(106, 16);
            this.lblSLNhap.TabIndex = 20;
            this.lblSLNhap.Text = "Số lượng nhập:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(41, 80);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(68, 16);
            this.lblTenSach.TabIndex = 11;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtDonGia.Location = new System.Drawing.Point(360, 78);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(101, 21);
            this.txtDonGia.TabIndex = 26;
            // 
            // pHIEUNHAPBindingSource
            // 
            this.pHIEUNHAPBindingSource.DataMember = "PHIEUNHAP";
            this.pHIEUNHAPBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // pHIEUNHAPTableAdapter
            // 
            this.pHIEUNHAPTableAdapter.ClearBeforeFill = true;
            // 
            // frmCTPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 536);
            this.Controls.Add(this.pnlChucNangDG);
            this.Controls.Add(this.dgvThongTinCTPN);
            this.Controls.Add(this.grbThongTinPM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCTPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCTPN";
            this.Load += new System.EventHandler(this.frmCTPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPN)).EndInit();
            this.pnlChucNangDG.ResumeLayout(false);
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUNHAPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button btnThemCTPN;
        private System.Windows.Forms.Button btnKhongLuuCTPN;
        private System.Windows.Forms.Button btnThoatfrmCTPN;
        private System.Windows.Forms.Button btnLuuCTPN;
        private System.Windows.Forms.Button btnXoaCTPN;
        private System.Windows.Forms.Button btnSuaCTPN;
        private System.Windows.Forms.DataGridView dgvThongTinCTPN;
        private System.Windows.Forms.GroupBox grbThongTinPM;
        private System.Windows.Forms.ComboBox cmbMaPN;
        private System.Windows.Forms.Label lblMaCTPM;
        private System.Windows.Forms.ComboBox cmbMaSach;
        private System.Windows.Forms.Label lblSLNhap;
        private System.Windows.Forms.Label lblTenSach;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private DOAnQLTVDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.TextBox txtSLNhap;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.BindingSource pHIEUNHAPBindingSource;
        private DOAnQLTVDataSet1TableAdapters.PHIEUNHAPTableAdapter pHIEUNHAPTableAdapter;
    }
}