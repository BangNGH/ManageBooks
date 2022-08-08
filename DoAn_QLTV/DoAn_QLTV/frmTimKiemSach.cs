using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmTimKiemSach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinSach()
        {
            command = connection.CreateCommand();
            command.CommandText = "select a.MaSach 'Mã sách', a.TenSach 'Tên sách', a.TenTacGia 'Tên tác giả', b.TenTL 'Thể loại', a.MaNXB 'Mã NXB', a.NamXB 'Năm XB', a.MaKeSach 'Mã kệ sách' from SACH as a, THELOAI as b where a.MaTL = b.MaTL";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinSach.DataSource = table;
            dgvThongTinSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            cmbTimSach.Text = "Mã Sách";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinSach();
        }

        private void TimSach_TextChanged(object sender, EventArgs e)
        {
            if (cmbTimSach.Text == "Mã sách")
            {
                command = connection.CreateCommand();
                command.CommandText = "select a.MaSach 'Mã sách', a.TenSach 'Tên sách', a.TenTacGia 'Tên tác giả', b.TenTL 'Thể loại', a.MaNXB 'Mã NXB', a.NamXB 'Năm XB', a.MaKeSach 'Mã kệ sách' from SACH as a, THELOAI as b where a.MaTL = b.MaTL and a.MaSach like '%" + txtTimSach.Text.Trim() + "%' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinSach.DataSource = table;
            }

            else if (cmbTimSach.Text == "Tên sách")
            {
                command = connection.CreateCommand();
                command.CommandText = "select a.MaSach 'Mã sách', a.TenSach 'Tên sách', a.TenTacGia 'Tên tác giả', b.TenTL 'Thể loại', a.MaNXB 'Mã NXB', a.NamXB 'Năm XB', a.MaKeSach 'Mã kệ sách' from SACH as a, THELOAI as b where a.MaTL = b.MaTL and a.TenSach like N'%" + txtTimSach.Text.Trim() + "%' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinSach.DataSource = table;
            }

            else if (cmbTimSach.Text == "Tên tác giả")
            {
                command = connection.CreateCommand();
                command.CommandText = "select a.MaSach 'Mã sách', a.TenSach 'Tên sách', a.TenTacGia 'Tên tác giả', b.TenTL 'Thể loại', a.MaNXB 'Mã NXB', a.NamXB 'Năm XB', a.MaKeSach 'Mã kệ sách' from SACH as a, THELOAI as b where a.MaTL = b.MaTL and a.TenTacGia like N'%" + txtTimSach.Text.Trim() + "%' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinSach.DataSource = table;
            }

            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select a.MaSach 'Mã sách', a.TenSach 'Tên sách', a.TenTacGia 'Tên tác giả', b.TenTL 'Thể loại', a.MaNXB 'Mã NXB', a.NamXB 'Năm XB', a.MaKeSach 'Mã kệ sách' from SACH as a, THELOAI as b where a.MaTL = b.MaTL and b.TenTL like N'%" + txtTimSach.Text.Trim() + "%' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinSach.DataSource = table;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmTimKiemSach_Load(sender, e);
        }

        private void frmTimKiemSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
