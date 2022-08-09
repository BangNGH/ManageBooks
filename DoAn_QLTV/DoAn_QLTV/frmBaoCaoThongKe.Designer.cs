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
            this.components = new System.ComponentModel.Container();
            this.grbThongTinTL = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvThongTinSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dOAnQLTVDataSet1 = new DoAn_QLTV.DOAnQLTVDataSet1();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new DoAn_QLTV.DOAnQLTVDataSet1TableAdapters.SACHTableAdapter();
            this.grbThongTinTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinTL
            // 
            this.grbThongTinTL.BackgroundImage = global::DoAn_QLTV.Properties.Resources._5;
            this.grbThongTinTL.Controls.Add(this.comboBox1);
            this.grbThongTinTL.Controls.Add(this.btnThoat);
            this.grbThongTinTL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinTL.Location = new System.Drawing.Point(183, 60);
            this.grbThongTinTL.Name = "grbThongTinTL";
            this.grbThongTinTL.Size = new System.Drawing.Size(336, 54);
            this.grbThongTinTL.TabIndex = 22;
            this.grbThongTinTL.TabStop = false;
            this.grbThongTinTL.Text = "Tùy chọn";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tất cả sách",
            "Sách được mượn",
            "Sách hiện còn"});
            this.comboBox1.Location = new System.Drawing.Point(36, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(245, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 25);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvThongTinSach
            // 
            this.dgvThongTinSach.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvThongTinSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinSach.Location = new System.Drawing.Point(1, 133);
            this.dgvThongTinSach.Name = "dgvThongTinSach";
            this.dgvThongTinSach.RowHeadersWidth = 51;
            this.dgvThongTinSach.Size = new System.Drawing.Size(728, 314);
            this.dgvThongTinSach.TabIndex = 24;
            this.dgvThongTinSach.AllowUserToAddRowsChanged += new System.EventHandler(this.dgvThongTinSach_AllowUserToAddRowsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Báo Cáo Thống Kê Sách";
            // 
            // dOAnQLTVDataSet1
            // 
            this.dOAnQLTVDataSet1.DataSetName = "DOAnQLTVDataSet1";
            this.dOAnQLTVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongTinSach);
            this.Controls.Add(this.grbThongTinTL);
            this.Name = "frmBaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo - Thống Kê";
            this.grbThongTinTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOAnQLTVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinTL;
        private System.Windows.Forms.DataGridView dgvThongTinSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private DOAnQLTVDataSet1 dOAnQLTVDataSet1;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private DOAnQLTVDataSet1TableAdapters.SACHTableAdapter sACHTableAdapter;
    }
}