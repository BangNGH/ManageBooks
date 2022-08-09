using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmTimKiemDG : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadThongTinDG()
        {
            command = connection.CreateCommand();
            command.CommandText = " select MaDG 'Mã độc giả', TenDG 'Tên độc giả', NgaySinhDG 'Ngày sinh', GioiTinh 'Giới tính', SDTDG 'Điện Thoại' from DOCGIA  ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinDG.DataSource = table;
            dgvThongTinDG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmTimKiemDG()
        {
            InitializeComponent();
        }

        private void txtTimDG_TextChanged(object sender, EventArgs e)
        {
            if (cmbTimDG.Text == "Mã độc giả")
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaDG 'Mã độc giả', TenDG 'Tên độc giả', NgaySinhDG 'Ngày sinh', GioiTinh 'Giới tính', SDTDG 'Điện Thoại' from DOCGIA where MaDG ='" + txtTimDG.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinDG.DataSource = table;
            }

            else if (cmbTimDG.Text == "Tên độc giả")
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaDG 'Mã độc giả', TenDG 'Tên độc giả', NgaySinhDG 'Ngày sinh', GioiTinh 'Giới tính', SDTDG 'Điện Thoại' from DOCGIA where TenDG = N'" + txtTimDG.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinDG.DataSource = table;
            }

            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaDG 'Mã độc giả', TenDG 'Tên độc giả', NgaySinhDG 'Ngày sinh', GioiTinh 'Giới tính', SDTDG 'Điện Thoại' from DOCGIA where SDTDG = '" + txtTimDG.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinDG.DataSource = table;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmTimKiemDG_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTimKiemDG_Load(object sender, EventArgs e)
        {
            cmbTimDG.Text = "Mã độc giả";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinDG();
        }

        private void frmTimKiemDG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
