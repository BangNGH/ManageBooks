namespace DoAn_QLTV
{
    partial class frmTimKiemDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemDG));
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvThongTinDG = new System.Windows.Forms.DataGridView();
            this.txtTimDG = new System.Windows.Forms.TextBox();
            this.cmbTimDG = new System.Windows.Forms.ComboBox();
            this.lblTruongDuLieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(359, 60);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Hiển thị hết";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(109, 114);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(66, 18);
            this.lblTuKhoa.TabIndex = 14;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(143, 9);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(256, 31);
            this.lblTimKiem.TabIndex = 13;
            this.lblTimKiem.Text = "Thông Tin Tìm Kiếm";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(359, 113);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvThongTinDG
            // 
            this.dgvThongTinDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinDG.Location = new System.Drawing.Point(-1, 169);
            this.dgvThongTinDG.Name = "dgvThongTinDG";
            this.dgvThongTinDG.Size = new System.Drawing.Size(546, 277);
            this.dgvThongTinDG.TabIndex = 11;
            // 
            // txtTimDG
            // 
            this.txtTimDG.Location = new System.Drawing.Point(181, 113);
            this.txtTimDG.Name = "txtTimDG";
            this.txtTimDG.Size = new System.Drawing.Size(130, 20);
            this.txtTimDG.TabIndex = 9;
            this.txtTimDG.TextChanged += new System.EventHandler(this.txtTimDG_TextChanged);
            // 
            // cmbTimDG
            // 
            this.cmbTimDG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimDG.FormattingEnabled = true;
            this.cmbTimDG.Items.AddRange(new object[] {
            "Mã độc giả",
            "Tên độc giả",
            "Điện thoại"});
            this.cmbTimDG.Location = new System.Drawing.Point(181, 62);
            this.cmbTimDG.Name = "cmbTimDG";
            this.cmbTimDG.Size = new System.Drawing.Size(130, 21);
            this.cmbTimDG.TabIndex = 8;
            // 
            // lblTruongDuLieu
            // 
            this.lblTruongDuLieu.AutoSize = true;
            this.lblTruongDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTruongDuLieu.Location = new System.Drawing.Point(105, 62);
            this.lblTruongDuLieu.Name = "lblTruongDuLieu";
            this.lblTruongDuLieu.Size = new System.Drawing.Size(70, 18);
            this.lblTruongDuLieu.TabIndex = 7;
            this.lblTruongDuLieu.Text = "Tìm theo:";
            // 
            // frmTimKiemDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTuKhoa);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvThongTinDG);
            this.Controls.Add(this.txtTimDG);
            this.Controls.Add(this.cmbTimDG);
            this.Controls.Add(this.lblTruongDuLieu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTimKiemDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Kiếm Độc Giả";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimKiemDG_FormClosing);
            this.Load += new System.EventHandler(this.frmTimKiemDG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvThongTinDG;
        private System.Windows.Forms.TextBox txtTimDG;
        private System.Windows.Forms.ComboBox cmbTimDG;
        private System.Windows.Forms.Label lblTruongDuLieu;
    }
}