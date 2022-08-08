namespace DoAn_QLTV
{
    partial class frmTimKiemSach
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
            this.lblTruongDuLieu = new System.Windows.Forms.Label();
            this.cmbTimSach = new System.Windows.Forms.ComboBox();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.dgvThongTinSach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTruongDuLieu
            // 
            this.lblTruongDuLieu.AutoSize = true;
            this.lblTruongDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruongDuLieu.Location = new System.Drawing.Point(15, 68);
            this.lblTruongDuLieu.Name = "lblTruongDuLieu";
            this.lblTruongDuLieu.Size = new System.Drawing.Size(70, 18);
            this.lblTruongDuLieu.TabIndex = 0;
            this.lblTruongDuLieu.Text = "Tìm theo:";
            // 
            // cmbTimSach
            // 
            this.cmbTimSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimSach.FormattingEnabled = true;
            this.cmbTimSach.Items.AddRange(new object[] {
            "Tên sách",
            "Tên tác giả",
            "Thể loại",
            "Mã sách"});
            this.cmbTimSach.Location = new System.Drawing.Point(91, 68);
            this.cmbTimSach.Name = "cmbTimSach";
            this.cmbTimSach.Size = new System.Drawing.Size(130, 21);
            this.cmbTimSach.TabIndex = 1;
            // 
            // txtTimSach
            // 
            this.txtTimSach.Location = new System.Drawing.Point(322, 66);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(130, 20);
            this.txtTimSach.TabIndex = 2;
            this.txtTimSach.TextChanged += new System.EventHandler(this.TimSach_TextChanged);
            // 
            // dgvThongTinSach
            // 
            this.dgvThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSach.Location = new System.Drawing.Point(1, 174);
            this.dgvThongTinSach.Name = "dgvThongTinSach";
            this.dgvThongTinSach.Size = new System.Drawing.Size(683, 277);
            this.dgvThongTinSach.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(596, 62);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(207, 9);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(196, 31);
            this.lblTimKiem.TabIndex = 5;
            this.lblTimKiem.Text = "Tìm Kiếm Sách";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(250, 67);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(66, 18);
            this.lblTuKhoa.TabIndex = 6;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // btnLoad
            // 
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLoad.Location = new System.Drawing.Point(515, 62);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "HIển thị hết";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(683, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThongTinSach);
            this.Controls.Add(this.txtTimSach);
            this.Controls.Add(this.cmbTimSach);
            this.Controls.Add(this.lblTruongDuLieu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemSach_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTruongDuLieu;
        private System.Windows.Forms.ComboBox cmbTimSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.DataGridView dgvThongTinSach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Button btnLoad;
    }
}