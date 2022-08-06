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
            this.lblMaCTPM = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTinhTrangSach = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.pHIEUMUONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUMUONTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.PHIEUMUONTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.SACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPM)).BeginInit();
            this.grbThongTinPM.SuspendLayout();
            this.pnlChucNangDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
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
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.comboBox3);
            this.grbThongTinPM.Controls.Add(this.comboBox2);
            this.grbThongTinPM.Controls.Add(this.lblMaCTPM);
            this.grbThongTinPM.Controls.Add(this.comboBox1);
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
            this.grbThongTinPM.Text = "Thông Tin Chi Tiết Phiếu Mượn";
            // 
            // lblMaCTPM
            // 
            this.lblMaCTPM.AutoSize = true;
            this.lblMaCTPM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCTPM.Location = new System.Drawing.Point(-3, 35);
            this.lblMaCTPM.Name = "lblMaCTPM";
            this.lblMaCTPM.Size = new System.Drawing.Size(112, 16);
            this.lblMaCTPM.TabIndex = 23;
            this.lblMaCTPM.Text = "Mã Phiếu Mượn:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hư hỏng",
            "Mất",
            "Nguyên vẹn"});
            this.comboBox1.Location = new System.Drawing.Point(123, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 23);
            this.comboBox1.TabIndex = 21;
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
            this.dtpNgayTra.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(361, 75);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(101, 21);
            this.dtpNgayTra.TabIndex = 18;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(123, 71);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(101, 21);
            this.dtpNgayMuon.TabIndex = 17;
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
            this.lblTenDG.Size = new System.Drawing.Size(84, 16);
            this.lblTenDG.TabIndex = 12;
            this.lblTenDG.Text = "Ngày Mượn:";
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
            this.pnlChucNangDG.Controls.Add(this.button1);
            this.pnlChucNangDG.Controls.Add(this.button2);
            this.pnlChucNangDG.Controls.Add(this.button3);
            this.pnlChucNangDG.Controls.Add(this.button4);
            this.pnlChucNangDG.Controls.Add(this.button5);
            this.pnlChucNangDG.Controls.Add(this.button6);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(29, 175);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(566, 26);
            this.pnlChucNangDG.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(386, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "Không Lưu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 17;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 15;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(195, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Sửa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.pHIEUMUONBindingSource;
            this.comboBox2.DisplayMember = "MaPM";
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 35);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 23);
            this.comboBox2.TabIndex = 24;
            // 
            // dOAnQLTVDataSet1
            // 
            this.dOAnQLTVDataSet1.DataSetName = "DOAnQLTVDataSet1";
            this.dOAnQLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUMUONBindingSource
            // 
            this.pHIEUMUONBindingSource.DataMember = "PHIEUMUON";
            this.pHIEUMUONBindingSource.DataSource = this.dOAnQLTVDataSet1;
            // 
            // pHIEUMUONTableAdapter
            // 
            this.pHIEUMUONTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.sACHBindingSource;
            this.comboBox3.DisplayMember = "TenSach";
            this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(361, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 23);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.ValueMember = "MaSach";
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.dOAnQLTVDataSet1;
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
            this.Text = "Chi Tiết Phiếu Mượn";
            this.Load += new System.EventHandler(this.frmCTPM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPM)).EndInit();
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            this.pnlChucNangDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUMUONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTinhTrangSach;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox2;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource pHIEUMUONBindingSource;
        private DOAnQLTVDataSet1TableAdapters.PHIEUMUONTableAdapter pHIEUMUONTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private DOAnQLTVDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}