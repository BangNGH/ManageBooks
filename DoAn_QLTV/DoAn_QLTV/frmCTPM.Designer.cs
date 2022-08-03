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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPM));
            this.dgvThongTinCTPM = new System.Windows.Forms.DataGridView();
            this.grbThongTinPM = new System.Windows.Forms.GroupBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lblMaPM = new System.Windows.Forms.Label();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnThemPM = new System.Windows.Forms.Button();
            this.btnKhongLuuPM = new System.Windows.Forms.Button();
            this.btnThoatfrmPM = new System.Windows.Forms.Button();
            this.btnLuuPM = new System.Windows.Forms.Button();
            this.btnXoaPM = new System.Windows.Forms.Button();
            this.btnSuaPM = new System.Windows.Forms.Button();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblTinhTrangSach = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPM)).BeginInit();
            this.grbThongTinPM.SuspendLayout();
            this.pnlChucNangDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinCTPM
            // 
            this.dgvThongTinCTPM.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinCTPM.Location = new System.Drawing.Point(83, 247);
            this.dgvThongTinCTPM.Name = "dgvThongTinCTPM";
            this.dgvThongTinCTPM.RowHeadersWidth = 51;
            this.dgvThongTinCTPM.Size = new System.Drawing.Size(576, 314);
            this.dgvThongTinCTPM.TabIndex = 27;
            // 
            // grbThongTinPM
            // 
            this.grbThongTinPM.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinPM.Controls.Add(this.comboBox1);
            this.grbThongTinPM.Controls.Add(this.lblTinhTrangSach);
            this.grbThongTinPM.Controls.Add(this.dtpNgayTra);
            this.grbThongTinPM.Controls.Add(this.dtpNgayMuon);
            this.grbThongTinPM.Controls.Add(this.label1);
            this.grbThongTinPM.Controls.Add(this.lblTenDG);
            this.grbThongTinPM.Controls.Add(this.lblMaSach);
            this.grbThongTinPM.Controls.Add(this.txtMaSach);
            this.grbThongTinPM.Controls.Add(this.txtMaPM);
            this.grbThongTinPM.Controls.Add(this.lblMaPM);
            this.grbThongTinPM.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinPM.Location = new System.Drawing.Point(102, 12);
            this.grbThongTinPM.Name = "grbThongTinPM";
            this.grbThongTinPM.Size = new System.Drawing.Size(499, 157);
            this.grbThongTinPM.TabIndex = 26;
            this.grbThongTinPM.TabStop = false;
            this.grbThongTinPM.Text = "Thông Tin Chi Tiết Phiếu Mượn";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(268, 35);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(66, 16);
            this.lblMaSach.TabIndex = 11;
            this.lblMaSach.Text = "Mã Sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSach.Location = new System.Drawing.Point(361, 30);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 21);
            this.txtMaSach.TabIndex = 10;
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
            this.pnlChucNangDG.Location = new System.Drawing.Point(83, 199);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(596, 24);
            this.pnlChucNangDG.TabIndex = 25;
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
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(123, 71);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(101, 21);
            this.dtpNgayMuon.TabIndex = 17;
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
            // lblTinhTrangSach
            // 
            this.lblTinhTrangSach.AutoSize = true;
            this.lblTinhTrangSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrangSach.Location = new System.Drawing.Point(4, 130);
            this.lblTinhTrangSach.Name = "lblTinhTrangSach";
            this.lblTinhTrangSach.Size = new System.Drawing.Size(113, 16);
            this.lblTinhTrangSach.TabIndex = 20;
            this.lblTinhTrangSach.Text = "Tình trạng sách: ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hư hỏng",
            "Mất",
            "Nguyên vẹn"});
            this.comboBox1.Location = new System.Drawing.Point(123, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // frmCTPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(741, 573);
            this.Controls.Add(this.dgvThongTinCTPM);
            this.Controls.Add(this.grbThongTinPM);
            this.Controls.Add(this.pnlChucNangDG);
            this.Name = "frmCTPM";
            this.Text = "Chi Tiết Phiếu Mượn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTPM)).EndInit();
            this.grbThongTinPM.ResumeLayout(false);
            this.grbThongTinPM.PerformLayout();
            this.pnlChucNangDG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinCTPM;
        private System.Windows.Forms.GroupBox grbThongTinPM;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.Button btnThemPM;
        private System.Windows.Forms.Button btnKhongLuuPM;
        private System.Windows.Forms.Button btnThoatfrmPM;
        private System.Windows.Forms.Button btnLuuPM;
        private System.Windows.Forms.Button btnXoaPM;
        private System.Windows.Forms.Button btnSuaPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblTinhTrangSach;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}