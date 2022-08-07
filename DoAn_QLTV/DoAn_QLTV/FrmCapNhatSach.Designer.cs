namespace DoAn_QLTV
{
    partial class frmCapNhatSach
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
            this.dgvThongTinSach = new System.Windows.Forms.DataGridView();
            this.pnlChucNangSach = new System.Windows.Forms.Panel();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnKhongLuuSach = new System.Windows.Forms.Button();
            this.btnThoatfrmSach = new System.Windows.Forms.Button();
            this.btnLuuSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.grbThongTinSach = new System.Windows.Forms.GroupBox();
            this.cmbMaKS = new System.Windows.Forms.ComboBox();
            this.kESACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.cmbMaNXB = new System.Windows.Forms.ComboBox();
            this.nHAXUATBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaTL = new System.Windows.Forms.ComboBox();
            this.tHELOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMaKeSach = new System.Windows.Forms.Label();
            this.lblNamXb = new System.Windows.Forms.Label();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblMaTL = new System.Windows.Forms.Label();
            this.lblTenTG = new System.Windows.Forms.Label();
            this.tHELOAITableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.THELOAITableAdapter();
            this.nHAXUATBANTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.NHAXUATBANTableAdapter();
            this.kESACHTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.KESACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).BeginInit();
            this.pnlChucNangSach.SuspendLayout();
            this.grbThongTinSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kESACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinSach
            // 
            this.dgvThongTinSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSach.Location = new System.Drawing.Point(-1, 290);
            this.dgvThongTinSach.Name = "dgvThongTinSach";
            this.dgvThongTinSach.RowHeadersWidth = 51;
            this.dgvThongTinSach.Size = new System.Drawing.Size(767, 314);
            this.dgvThongTinSach.TabIndex = 26;
            this.dgvThongTinSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinSach_CellContentClick);
            // 
            // pnlChucNangSach
            // 
            this.pnlChucNangSach.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangSach.Controls.Add(this.btnThemSach);
            this.pnlChucNangSach.Controls.Add(this.btnKhongLuuSach);
            this.pnlChucNangSach.Controls.Add(this.btnThoatfrmSach);
            this.pnlChucNangSach.Controls.Add(this.btnLuuSach);
            this.pnlChucNangSach.Controls.Add(this.btnXoaSach);
            this.pnlChucNangSach.Controls.Add(this.btnSuaSach);
            this.pnlChucNangSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangSach.Location = new System.Drawing.Point(74, 237);
            this.pnlChucNangSach.Name = "pnlChucNangSach";
            this.pnlChucNangSach.Size = new System.Drawing.Size(614, 24);
            this.pnlChucNangSach.TabIndex = 24;
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(0, 0);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(90, 24);
            this.btnThemSach.TabIndex = 13;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnKhongLuuSach
            // 
            this.btnKhongLuuSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuSach.Location = new System.Drawing.Point(409, 0);
            this.btnKhongLuuSach.Name = "btnKhongLuuSach";
            this.btnKhongLuuSach.Size = new System.Drawing.Size(94, 24);
            this.btnKhongLuuSach.TabIndex = 17;
            this.btnKhongLuuSach.Text = "Không Lưu";
            this.btnKhongLuuSach.UseVisualStyleBackColor = true;
            this.btnKhongLuuSach.Click += new System.EventHandler(this.btnKhongLuuSach_Click);
            // 
            // btnThoatfrmSach
            // 
            this.btnThoatfrmSach.Location = new System.Drawing.Point(526, 0);
            this.btnThoatfrmSach.Name = "btnThoatfrmSach";
            this.btnThoatfrmSach.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmSach.TabIndex = 18;
            this.btnThoatfrmSach.Text = "Thoát";
            this.btnThoatfrmSach.UseVisualStyleBackColor = true;
            this.btnThoatfrmSach.Click += new System.EventHandler(this.btnThoatfrmSach_Click);
            // 
            // btnLuuSach
            // 
            this.btnLuuSach.Location = new System.Drawing.Point(309, 1);
            this.btnLuuSach.Name = "btnLuuSach";
            this.btnLuuSach.Size = new System.Drawing.Size(75, 24);
            this.btnLuuSach.TabIndex = 16;
            this.btnLuuSach.Text = "Lưu";
            this.btnLuuSach.UseVisualStyleBackColor = true;
            this.btnLuuSach.Click += new System.EventHandler(this.btnLuuSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(108, 0);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(75, 24);
            this.btnXoaSach.TabIndex = 14;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(207, 1);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSach.TabIndex = 15;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // grbThongTinSach
            // 
            this.grbThongTinSach.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinSach.Controls.Add(this.cmbMaKS);
            this.grbThongTinSach.Controls.Add(this.cmbMaNXB);
            this.grbThongTinSach.Controls.Add(this.cmbMaTL);
            this.grbThongTinSach.Controls.Add(this.lblMaKeSach);
            this.grbThongTinSach.Controls.Add(this.lblNamXb);
            this.grbThongTinSach.Controls.Add(this.lblMaNXB);
            this.grbThongTinSach.Controls.Add(this.txtNamXB);
            this.grbThongTinSach.Controls.Add(this.txtTenTG);
            this.grbThongTinSach.Controls.Add(this.txtTenSach);
            this.grbThongTinSach.Controls.Add(this.txtMaSach);
            this.grbThongTinSach.Controls.Add(this.lblTenSach);
            this.grbThongTinSach.Controls.Add(this.lblMaSach);
            this.grbThongTinSach.Controls.Add(this.lblMaTL);
            this.grbThongTinSach.Controls.Add(this.lblTenTG);
            this.grbThongTinSach.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinSach.Location = new System.Drawing.Point(95, 12);
            this.grbThongTinSach.Name = "grbThongTinSach";
            this.grbThongTinSach.Size = new System.Drawing.Size(561, 207);
            this.grbThongTinSach.TabIndex = 27;
            this.grbThongTinSach.TabStop = false;
            this.grbThongTinSach.Text = "Thông Tin Sách";
            // 
            // cmbMaKS
            // 
            this.cmbMaKS.DataSource = this.kESACHBindingSource;
            this.cmbMaKS.DisplayMember = "ViTri";
            this.cmbMaKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKS.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaKS.FormattingEnabled = true;
            this.cmbMaKS.Location = new System.Drawing.Point(288, 168);
            this.cmbMaKS.Name = "cmbMaKS";
            this.cmbMaKS.Size = new System.Drawing.Size(100, 23);
            this.cmbMaKS.TabIndex = 7;
            this.cmbMaKS.ValueMember = "MaKeSach";
            // 
            // kESACHBindingSource
            // 
            this.kESACHBindingSource.DataMember = "KESACH";
            this.kESACHBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // dOAnQLTVDataSet1
            // 
            this.dOAnQLTVDataSet1.DataSetName = "DOAnQLTVDataSet1";
            this.dOAnQLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbMaNXB
            // 
            this.cmbMaNXB.DataSource = this.nHAXUATBANBindingSource;
            this.cmbMaNXB.DisplayMember = "TenNXB";
            this.cmbMaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNXB.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaNXB.FormattingEnabled = true;
            this.cmbMaNXB.Location = new System.Drawing.Point(424, 75);
            this.cmbMaNXB.Name = "cmbMaNXB";
            this.cmbMaNXB.Size = new System.Drawing.Size(116, 23);
            this.cmbMaNXB.TabIndex = 5;
            this.cmbMaNXB.ValueMember = "MaNXB";
            // 
            // nHAXUATBANBindingSource
            // 
            this.nHAXUATBANBindingSource.DataMember = "NHAXUATBAN";
            this.nHAXUATBANBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // cmbMaTL
            // 
            this.cmbMaTL.DataSource = this.tHELOAIBindingSource;
            this.cmbMaTL.DisplayMember = "TenTL";
            this.cmbMaTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaTL.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbMaTL.FormattingEnabled = true;
            this.cmbMaTL.Location = new System.Drawing.Point(424, 31);
            this.cmbMaTL.Name = "cmbMaTL";
            this.cmbMaTL.Size = new System.Drawing.Size(116, 23);
            this.cmbMaTL.TabIndex = 4;
            this.cmbMaTL.ValueMember = "MaTL";
            // 
            // tHELOAIBindingSource
            // 
            this.tHELOAIBindingSource.DataMember = "THELOAI";
            this.tHELOAIBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // lblMaKeSach
            // 
            this.lblMaKeSach.AutoSize = true;
            this.lblMaKeSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKeSach.Location = new System.Drawing.Point(183, 170);
            this.lblMaKeSach.Name = "lblMaKeSach";
            this.lblMaKeSach.Size = new System.Drawing.Size(82, 16);
            this.lblMaKeSach.TabIndex = 17;
            this.lblMaKeSach.Text = "Mã kệ sách:";
            // 
            // lblNamXb
            // 
            this.lblNamXb.AutoSize = true;
            this.lblNamXb.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXb.Location = new System.Drawing.Point(335, 122);
            this.lblNamXb.Name = "lblNamXb";
            this.lblNamXb.Size = new System.Drawing.Size(62, 16);
            this.lblNamXb.TabIndex = 16;
            this.lblNamXb.Text = "Năm XB:";
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNXB.Location = new System.Drawing.Point(336, 77);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(61, 16);
            this.lblMaNXB.TabIndex = 15;
            this.lblMaNXB.Text = "Mã NXB:";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamXB.Location = new System.Drawing.Point(424, 117);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(116, 21);
            this.txtNamXB.TabIndex = 6;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTenTG.Location = new System.Drawing.Point(138, 117);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(127, 21);
            this.txtTenTG.TabIndex = 3;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTenSach.Location = new System.Drawing.Point(138, 77);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(127, 21);
            this.txtTenSach.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(138, 33);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(127, 21);
            this.txtMaSach.TabIndex = 1;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(28, 75);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(68, 16);
            this.lblTenSach.TabIndex = 6;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(33, 33);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(63, 16);
            this.lblMaSach.TabIndex = 3;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // lblMaTL
            // 
            this.lblMaTL.AutoSize = true;
            this.lblMaTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTL.Location = new System.Drawing.Point(315, 33);
            this.lblMaTL.Name = "lblMaTL";
            this.lblMaTL.Size = new System.Drawing.Size(82, 16);
            this.lblMaTL.TabIndex = 5;
            this.lblMaTL.Text = "Mã thể loại:";
            // 
            // lblTenTG
            // 
            this.lblTenTG.AutoSize = true;
            this.lblTenTG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTG.Location = new System.Drawing.Point(14, 122);
            this.lblTenTG.Name = "lblTenTG";
            this.lblTenTG.Size = new System.Drawing.Size(82, 16);
            this.lblTenTG.TabIndex = 7;
            this.lblTenTG.Text = "Tên tác giả:";
            // 
            // tHELOAITableAdapter
            // 
            this.tHELOAITableAdapter.ClearBeforeFill = true;
            // 
            // nHAXUATBANTableAdapter
            // 
            this.nHAXUATBANTableAdapter.ClearBeforeFill = true;
            // 
            // kESACHTableAdapter
            // 
            this.kESACHTableAdapter.ClearBeforeFill = true;
            // 
            // frmCapNhatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(764, 684);
            this.Controls.Add(this.grbThongTinSach);
            this.Controls.Add(this.dgvThongTinSach);
            this.Controls.Add(this.pnlChucNangSach);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCapNhatSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Sách";
            this.Load += new System.EventHandler(this.frmCapNhatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).EndInit();
            this.pnlChucNangSach.ResumeLayout(false);
            this.grbThongTinSach.ResumeLayout(false);
            this.grbThongTinSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kESACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAXUATBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinSach;
        private System.Windows.Forms.Panel pnlChucNangSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnKhongLuuSach;
        private System.Windows.Forms.Button btnThoatfrmSach;
        private System.Windows.Forms.Button btnLuuSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.GroupBox grbThongTinSach;
        private System.Windows.Forms.Label lblMaKeSach;
        private System.Windows.Forms.Label lblNamXb;
        private System.Windows.Forms.Label lblMaNXB;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblMaTL;
        private System.Windows.Forms.Label lblTenTG;
        private System.Windows.Forms.ComboBox cmbMaNXB;
        private System.Windows.Forms.ComboBox cmbMaTL;
        private System.Windows.Forms.ComboBox cmbMaKS;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource tHELOAIBindingSource;
        private DOAnQLTVDataSet1TableAdapters.THELOAITableAdapter tHELOAITableAdapter;
        private System.Windows.Forms.BindingSource nHAXUATBANBindingSource;
        private DOAnQLTVDataSet1TableAdapters.NHAXUATBANTableAdapter nHAXUATBANTableAdapter;
        private System.Windows.Forms.BindingSource kESACHBindingSource;
        private DOAnQLTVDataSet1TableAdapters.KESACHTableAdapter kESACHTableAdapter;
    }
}