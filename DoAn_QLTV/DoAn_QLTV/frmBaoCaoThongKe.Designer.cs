namespace DoAn_QLTV
{
    partial class frmBaoCaoThongKe
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
            this.grbThongTinTL = new System.Windows.Forms.GroupBox();
            this.dgvThongTinTL = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbThongTinTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinTL)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinTL
            // 
            this.grbThongTinTL.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinTL.Controls.Add(this.comboBox1);
            this.grbThongTinTL.Controls.Add(this.btnThoat);
            this.grbThongTinTL.Controls.Add(this.btnThongKe);
            this.grbThongTinTL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold);
            this.grbThongTinTL.Location = new System.Drawing.Point(69, 12);
            this.grbThongTinTL.Name = "grbThongTinTL";
            this.grbThongTinTL.Size = new System.Drawing.Size(588, 91);
            this.grbThongTinTL.TabIndex = 22;
            this.grbThongTinTL.TabStop = false;
            this.grbThongTinTL.Text = "Báo Cáo Thống Kê Sách Thư Viện";
            // 
            // dgvThongTinTL
            // 
            this.dgvThongTinTL.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinTL.Location = new System.Drawing.Point(69, 124);
            this.dgvThongTinTL.Name = "dgvThongTinTL";
            this.dgvThongTinTL.RowHeadersWidth = 51;
            this.dgvThongTinTL.Size = new System.Drawing.Size(516, 314);
            this.dgvThongTinTL.TabIndex = 24;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(364, 19);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(91, 52);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê ";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(477, 33);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 25);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 27);
            this.comboBox1.TabIndex = 2;
            // 
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 450);
            this.Controls.Add(this.dgvThongTinTL);
            this.Controls.Add(this.grbThongTinTL);
            this.Name = "frmBaoCaoThongKe";
            this.Text = "frmBaoCaoThongKe";
            this.grbThongTinTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinTL;
        private System.Windows.Forms.DataGridView dgvThongTinTL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThongKe;
    }
}