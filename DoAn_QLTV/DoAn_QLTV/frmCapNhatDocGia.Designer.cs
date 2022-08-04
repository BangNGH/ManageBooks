using System.Windows.Forms;

namespace DoAn_QLTV
{
    partial class frmCapNhatDocGia
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
            this.btnThemDG = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaDG = new System.Windows.Forms.Button();
            this.btnSuaDG = new System.Windows.Forms.Button();
            this.btnLuuDG = new System.Windows.Forms.Button();
            this.pnlChucNangDG = new System.Windows.Forms.Panel();
            this.btnKhongLuuDG = new System.Windows.Forms.Button();
            this.grbThongTinDG = new System.Windows.Forms.GroupBox();
            this.cmbGioiTinhDG = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinhDG = new System.Windows.Forms.DateTimePicker();
            this.txtSDTDG = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvThongTinDG = new System.Windows.Forms.DataGridView();
            this.pnlChucNangDG.SuspendLayout();
            this.grbThongTinDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Trangchu
            // 
            this.Trangchu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Trangchu.Name = "contextMenuStrip1";
            this.Trangchu.Size = new System.Drawing.Size(61, 4);
            // 
            // btnThemDG
            // 
            this.btnThemDG.Location = new System.Drawing.Point(0, 0);
            this.btnThemDG.Name = "btnThemDG";
            this.btnThemDG.Size = new System.Drawing.Size(90, 24);
            this.btnThemDG.TabIndex = 13;
            this.btnThemDG.Text = "Thêm";
            this.btnThemDG.UseVisualStyleBackColor = true;
            this.btnThemDG.Click += new System.EventHandler(this.btnThemDG_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(518, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 25);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaDG
            // 
            this.btnXoaDG.Location = new System.Drawing.Point(108, 0);
            this.btnXoaDG.Name = "btnXoaDG";
            this.btnXoaDG.Size = new System.Drawing.Size(75, 24);
            this.btnXoaDG.TabIndex = 15;
            this.btnXoaDG.Text = "Xóa";
            this.btnXoaDG.UseVisualStyleBackColor = true;
            this.btnXoaDG.Click += new System.EventHandler(this.btnXoaDG_Click);
            // 
            // btnSuaDG
            // 
            this.btnSuaDG.Location = new System.Drawing.Point(207, 1);
            this.btnSuaDG.Name = "btnSuaDG";
            this.btnSuaDG.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDG.TabIndex = 16;
            this.btnSuaDG.Text = "Sửa";
            this.btnSuaDG.UseVisualStyleBackColor = true;
            this.btnSuaDG.Click += new System.EventHandler(this.btnSuaDG_Click);
            // 
            // btnLuuDG
            // 
            this.btnLuuDG.Location = new System.Drawing.Point(309, 1);
            this.btnLuuDG.Name = "btnLuuDG";
            this.btnLuuDG.Size = new System.Drawing.Size(75, 24);
            this.btnLuuDG.TabIndex = 17;
            this.btnLuuDG.Text = "Lưu";
            this.btnLuuDG.UseVisualStyleBackColor = true;
            this.btnLuuDG.Click += new System.EventHandler(this.btnLuuDG_Click);
            // 
            // pnlChucNangDG
            // 
            this.pnlChucNangDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangDG.Controls.Add(this.btnThemDG);
            this.pnlChucNangDG.Controls.Add(this.btnKhongLuuDG);
            this.pnlChucNangDG.Controls.Add(this.btnThoat);
            this.pnlChucNangDG.Controls.Add(this.btnLuuDG);
            this.pnlChucNangDG.Controls.Add(this.btnXoaDG);
            this.pnlChucNangDG.Controls.Add(this.btnSuaDG);
            this.pnlChucNangDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangDG.Location = new System.Drawing.Point(12, 175);
            this.pnlChucNangDG.Name = "pnlChucNangDG";
            this.pnlChucNangDG.Size = new System.Drawing.Size(596, 24);
            this.pnlChucNangDG.TabIndex = 18;
            // 
            // btnKhongLuuDG
            // 
            this.btnKhongLuuDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuDG.Location = new System.Drawing.Point(409, 0);
            this.btnKhongLuuDG.Name = "btnKhongLuuDG";
            this.btnKhongLuuDG.Size = new System.Drawing.Size(94, 24);
            this.btnKhongLuuDG.TabIndex = 18;
            this.btnKhongLuuDG.Text = "Không Lưu";
            this.btnKhongLuuDG.UseVisualStyleBackColor = true;
            this.btnKhongLuuDG.Click += new System.EventHandler(this.btnKhongLuuDG_Click);
            // 
            // grbThongTinDG
            // 
            this.grbThongTinDG.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinDG.Controls.Add(this.cmbGioiTinhDG);
            this.grbThongTinDG.Controls.Add(this.dtpNgaySinhDG);
            this.grbThongTinDG.Controls.Add(this.txtSDTDG);
            this.grbThongTinDG.Controls.Add(this.txtTenDG);
            this.grbThongTinDG.Controls.Add(this.txtMaDG);
            this.grbThongTinDG.Controls.Add(this.lblTenDG);
            this.grbThongTinDG.Controls.Add(this.lblGioiTinh);
            this.grbThongTinDG.Controls.Add(this.lblMaDG);
            this.grbThongTinDG.Controls.Add(this.lblNgaySinh);
            this.grbThongTinDG.Controls.Add(this.label4);
            this.grbThongTinDG.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinDG.Location = new System.Drawing.Point(66, 12);
            this.grbThongTinDG.Name = "grbThongTinDG";
            this.grbThongTinDG.Size = new System.Drawing.Size(494, 157);
            this.grbThongTinDG.TabIndex = 20;
            this.grbThongTinDG.TabStop = false;
            this.grbThongTinDG.Text = "Thông Tin Độc Giả";
            this.grbThongTinDG.Enter += new System.EventHandler(this.grbThongTinDG_Enter);
            // 
            // cmbGioiTinhDG
            // 
            this.cmbGioiTinhDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmbGioiTinhDG.FormattingEnabled = true;
            this.cmbGioiTinhDG.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.cmbGioiTinhDG.Location = new System.Drawing.Point(108, 119);
            this.cmbGioiTinhDG.Name = "cmbGioiTinhDG";
            this.cmbGioiTinhDG.Size = new System.Drawing.Size(100, 23);
            this.cmbGioiTinhDG.TabIndex = 12;
            // 
            // dtpNgaySinhDG
            // 
            this.dtpNgaySinhDG.CustomFormat = "MM/dd/yyyy";
            this.dtpNgaySinhDG.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpNgaySinhDG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhDG.Location = new System.Drawing.Point(360, 27);
            this.dtpNgaySinhDG.Name = "dtpNgaySinhDG";
            this.dtpNgaySinhDG.Size = new System.Drawing.Size(100, 23);
            this.dtpNgaySinhDG.TabIndex = 11;
            this.dtpNgaySinhDG.ValueChanged += new System.EventHandler(this.dtpNgaySinhDG_ValueChanged);
            // 
            // txtSDTDG
            // 
            this.txtSDTDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtSDTDG.Location = new System.Drawing.Point(360, 71);
            this.txtSDTDG.Name = "txtSDTDG";
            this.txtSDTDG.Size = new System.Drawing.Size(100, 21);
            this.txtSDTDG.TabIndex = 10;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txtTenDG.Location = new System.Drawing.Point(108, 72);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(100, 21);
            this.txtTenDG.TabIndex = 9;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(108, 30);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(100, 21);
            this.txtMaDG.TabIndex = 8;
            // 
            // lblTenDG
            // 
            this.lblTenDG.AutoSize = true;
            this.lblTenDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDG.Location = new System.Drawing.Point(12, 72);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Size = new System.Drawing.Size(86, 16);
            this.lblTenDG.TabIndex = 6;
            this.lblTenDG.Text = "Tên độc giả:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 119);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(66, 16);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Click += new System.EventHandler(this.lblGioiTinh_Click);
            // 
            // lblMaDG
            // 
            this.lblMaDG.AutoSize = true;
            this.lblMaDG.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDG.Location = new System.Drawing.Point(12, 27);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(81, 16);
            this.lblMaDG.TabIndex = 3;
            this.lblMaDG.Text = "Mã độc giả:";
            this.lblMaDG.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(257, 30);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(76, 16);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Điện thoại:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvThongTinDG
            // 
            this.dgvThongTinDG.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDG.Location = new System.Drawing.Point(0, 231);
            this.dgvThongTinDG.Name = "dgvThongTinDG";
            this.dgvThongTinDG.RowHeadersWidth = 51;
            this.dgvThongTinDG.Size = new System.Drawing.Size(620, 314);
            this.dgvThongTinDG.TabIndex = 21;
            this.dgvThongTinDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinDG_CellContentClick);
            this.dgvThongTinDG.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinDG_CellContentDoubleClick);
            // 
            // frmCapNhatDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(620, 574);
            this.Controls.Add(this.dgvThongTinDG);
            this.Controls.Add(this.grbThongTinDG);
            this.Controls.Add(this.pnlChucNangDG);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCapNhatDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Độc Giả";
            this.Load += new System.EventHandler(this.frmCapNhatDocGia_Load);
            this.pnlChucNangDG.ResumeLayout(false);
            this.grbThongTinDG.ResumeLayout(false);
            this.grbThongTinDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Trangchu;
        private System.Windows.Forms.Button btnThemDG;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaDG;
        private System.Windows.Forms.Button btnSuaDG;
        private System.Windows.Forms.Button btnLuuDG;
        private System.Windows.Forms.Panel pnlChucNangDG;
        private System.Windows.Forms.GroupBox grbThongTinDG;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTDG;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhDG;
        private System.Windows.Forms.ComboBox cmbGioiTinhDG;
        private System.Windows.Forms.DataGridView dgvThongTinDG;
        private System.Windows.Forms.Button btnKhongLuuDG;
        
    }
}

