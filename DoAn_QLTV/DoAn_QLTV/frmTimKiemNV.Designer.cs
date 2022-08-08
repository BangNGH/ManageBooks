namespace DoAn_QLTV
{
    partial class frmTimKiemNV
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.lblTimKiemNV = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvThongTinNV = new System.Windows.Forms.DataGridView();
            this.txtTimNV = new System.Windows.Forms.TextBox();
            this.cmbTimNV = new System.Windows.Forms.ComboBox();
            this.lblTruongDuLieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(464, 70);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "HIển thị hết";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(237, 73);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(66, 18);
            this.lblTuKhoa.TabIndex = 14;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // lblTimKiemNV
            // 
            this.lblTimKiemNV.AutoSize = true;
            this.lblTimKiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemNV.Location = new System.Drawing.Point(179, 9);
            this.lblTimKiemNV.Name = "lblTimKiemNV";
            this.lblTimKiemNV.Size = new System.Drawing.Size(260, 31);
            this.lblTimKiemNV.TabIndex = 13;
            this.lblTimKiemNV.Text = "Tìm Kiếm Nhân Viên";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(545, 70);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvThongTinNV
            // 
            this.dgvThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinNV.Location = new System.Drawing.Point(2, 137);
            this.dgvThongTinNV.Name = "dgvThongTinNV";
            this.dgvThongTinNV.Size = new System.Drawing.Size(618, 277);
            this.dgvThongTinNV.TabIndex = 11;
            // 
            // txtTimNV
            // 
            this.txtTimNV.Location = new System.Drawing.Point(309, 72);
            this.txtTimNV.Name = "txtTimNV";
            this.txtTimNV.Size = new System.Drawing.Size(130, 20);
            this.txtTimNV.TabIndex = 2;
            this.txtTimNV.TextChanged += new System.EventHandler(this.txtTimNV_TextChanged);
            // 
            // cmbTimNV
            // 
            this.cmbTimNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimNV.FormattingEnabled = true;
            this.cmbTimNV.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên",
            "Số điện thoại",
            "Chức vụ"});
            this.cmbTimNV.Location = new System.Drawing.Point(81, 71);
            this.cmbTimNV.Name = "cmbTimNV";
            this.cmbTimNV.Size = new System.Drawing.Size(130, 21);
            this.cmbTimNV.TabIndex = 1;
            // 
            // lblTruongDuLieu
            // 
            this.lblTruongDuLieu.AutoSize = true;
            this.lblTruongDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruongDuLieu.Location = new System.Drawing.Point(5, 71);
            this.lblTruongDuLieu.Name = "lblTruongDuLieu";
            this.lblTruongDuLieu.Size = new System.Drawing.Size(70, 18);
            this.lblTruongDuLieu.TabIndex = 7;
            this.lblTruongDuLieu.Text = "Tìm theo:";
            // 
            // frmTimKiemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(621, 410);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.lblTimKiemNV);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThongTinNV);
            this.Controls.Add(this.txtTimNV);
            this.Controls.Add(this.cmbTimNV);
            this.Controls.Add(this.lblTruongDuLieu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiemNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemNV_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label lblTimKiemNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvThongTinNV;
        private System.Windows.Forms.TextBox txtTimNV;
        private System.Windows.Forms.ComboBox cmbTimNV;
        private System.Windows.Forms.Label lblTruongDuLieu;
    }
}