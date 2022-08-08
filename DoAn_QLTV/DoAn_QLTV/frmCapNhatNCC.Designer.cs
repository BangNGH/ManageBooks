namespace DoAn_QLTV
{
    partial class frmCapNhatNCC
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
            this.dgvThongTinNCC = new System.Windows.Forms.DataGridView();
            this.grbThongTinTL = new System.Windows.Forms.GroupBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblTenTL = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.pnlChucNangSach = new System.Windows.Forms.Panel();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnKhongLuuNCC = new System.Windows.Forms.Button();
            this.btnThoatfrmCapNhatNCC = new System.Windows.Forms.Button();
            this.btnLuuNCC = new System.Windows.Forms.Button();
            this.btnXoaNCC = new System.Windows.Forms.Button();
            this.btnSuaNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNCC)).BeginInit();
            this.grbThongTinTL.SuspendLayout();
            this.pnlChucNangSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinNCC
            // 
            this.dgvThongTinNCC.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNCC.Location = new System.Drawing.Point(320, -3);
            this.dgvThongTinNCC.Name = "dgvThongTinNCC";
            this.dgvThongTinNCC.RowHeadersWidth = 51;
            this.dgvThongTinNCC.Size = new System.Drawing.Size(267, 235);
            this.dgvThongTinNCC.TabIndex = 26;
            this.dgvThongTinNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinNCC_CellContentClick);
            // 
            // grbThongTinTL
            // 
            this.grbThongTinTL.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinTL.Controls.Add(this.txtMaNCC);
            this.grbThongTinTL.Controls.Add(this.txtTenNCC);
            this.grbThongTinTL.Controls.Add(this.lblTenTL);
            this.grbThongTinTL.Controls.Add(this.lblMaNCC);
            this.grbThongTinTL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinTL.Location = new System.Drawing.Point(22, 19);
            this.grbThongTinTL.Name = "grbThongTinTL";
            this.grbThongTinTL.Size = new System.Drawing.Size(213, 98);
            this.grbThongTinTL.TabIndex = 25;
            this.grbThongTinTL.TabStop = false;
            this.grbThongTinTL.Text = "Thông tin nhà cung cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(104, 30);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 21);
            this.txtMaNCC.TabIndex = 1;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(104, 57);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(100, 21);
            this.txtTenNCC.TabIndex = 2;
            // 
            // lblTenTL
            // 
            this.lblTenTL.AutoSize = true;
            this.lblTenTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTL.Location = new System.Drawing.Point(3, 61);
            this.lblTenTL.Name = "lblTenTL";
            this.lblTenTL.Size = new System.Drawing.Size(66, 16);
            this.lblTenTL.TabIndex = 3;
            this.lblTenTL.Text = "Tên NCC:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(5, 32);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(61, 16);
            this.lblMaNCC.TabIndex = 5;
            this.lblMaNCC.Text = "Mã NCC:";
            // 
            // pnlChucNangSach
            // 
            this.pnlChucNangSach.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.pnlChucNangSach.Controls.Add(this.btnThemNCC);
            this.pnlChucNangSach.Controls.Add(this.btnKhongLuuNCC);
            this.pnlChucNangSach.Controls.Add(this.btnThoatfrmCapNhatNCC);
            this.pnlChucNangSach.Controls.Add(this.btnLuuNCC);
            this.pnlChucNangSach.Controls.Add(this.btnXoaNCC);
            this.pnlChucNangSach.Controls.Add(this.btnSuaNCC);
            this.pnlChucNangSach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlChucNangSach.Location = new System.Drawing.Point(13, 140);
            this.pnlChucNangSach.Name = "pnlChucNangSach";
            this.pnlChucNangSach.Size = new System.Drawing.Size(301, 74);
            this.pnlChucNangSach.TabIndex = 24;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Location = new System.Drawing.Point(0, 0);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(90, 24);
            this.btnThemNCC.TabIndex = 13;
            this.btnThemNCC.Text = "Thêm";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnKhongLuuNCC
            // 
            this.btnKhongLuuNCC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKhongLuuNCC.Location = new System.Drawing.Point(107, 45);
            this.btnKhongLuuNCC.Name = "btnKhongLuuNCC";
            this.btnKhongLuuNCC.Size = new System.Drawing.Size(94, 24);
            this.btnKhongLuuNCC.TabIndex = 17;
            this.btnKhongLuuNCC.Text = "Không Lưu";
            this.btnKhongLuuNCC.UseVisualStyleBackColor = true;
            this.btnKhongLuuNCC.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnThoatfrmCapNhatNCC
            // 
            this.btnThoatfrmCapNhatNCC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoatfrmCapNhatNCC.Location = new System.Drawing.Point(220, 45);
            this.btnThoatfrmCapNhatNCC.Name = "btnThoatfrmCapNhatNCC";
            this.btnThoatfrmCapNhatNCC.Size = new System.Drawing.Size(75, 25);
            this.btnThoatfrmCapNhatNCC.TabIndex = 18;
            this.btnThoatfrmCapNhatNCC.Text = "Thoát";
            this.btnThoatfrmCapNhatNCC.UseVisualStyleBackColor = true;
            this.btnThoatfrmCapNhatNCC.Click += new System.EventHandler(this.btnThoatfrmCapNhatNCC_Click);
            // 
            // btnLuuNCC
            // 
            this.btnLuuNCC.Location = new System.Drawing.Point(3, 45);
            this.btnLuuNCC.Name = "btnLuuNCC";
            this.btnLuuNCC.Size = new System.Drawing.Size(75, 24);
            this.btnLuuNCC.TabIndex = 16;
            this.btnLuuNCC.Text = "Lưu";
            this.btnLuuNCC.UseVisualStyleBackColor = true;
            this.btnLuuNCC.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaNCC
            // 
            this.btnXoaNCC.Location = new System.Drawing.Point(108, 0);
            this.btnXoaNCC.Name = "btnXoaNCC";
            this.btnXoaNCC.Size = new System.Drawing.Size(75, 24);
            this.btnXoaNCC.TabIndex = 14;
            this.btnXoaNCC.Text = "Xóa";
            this.btnXoaNCC.UseVisualStyleBackColor = true;
            this.btnXoaNCC.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaNCC
            // 
            this.btnSuaNCC.Location = new System.Drawing.Point(220, 1);
            this.btnSuaNCC.Name = "btnSuaNCC";
            this.btnSuaNCC.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNCC.TabIndex = 15;
            this.btnSuaNCC.Text = "Sửa";
            this.btnSuaNCC.UseVisualStyleBackColor = true;
            this.btnSuaNCC.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmCapNhatNCC
            // 
            this.AcceptButton = this.btnLuuNCC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoatfrmCapNhatNCC;
            this.ClientSize = new System.Drawing.Size(587, 235);
            this.Controls.Add(this.dgvThongTinNCC);
            this.Controls.Add(this.grbThongTinTL);
            this.Controls.Add(this.pnlChucNangSach);
            this.Name = "frmCapNhatNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Nhà Cung Cấp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCapNhatNCC_FormClosing);
            this.Load += new System.EventHandler(this.frmCapNhatNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNCC)).EndInit();
            this.grbThongTinTL.ResumeLayout(false);
            this.grbThongTinTL.PerformLayout();
            this.pnlChucNangSach.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinNCC;
        private System.Windows.Forms.GroupBox grbThongTinTL;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblTenTL;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Panel pnlChucNangSach;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnKhongLuuNCC;
        private System.Windows.Forms.Button btnThoatfrmCapNhatNCC;
        private System.Windows.Forms.Button btnLuuNCC;
        private System.Windows.Forms.Button btnXoaNCC;
        private System.Windows.Forms.Button btnSuaNCC;
    }
}