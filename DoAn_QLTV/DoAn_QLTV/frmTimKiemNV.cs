using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmTimKiemNV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadThongTinNV()
        {
            command = connection.CreateCommand();
            command.CommandText = " select MaNV 'Mã nhân viên', TenNV 'Tên Nhân viên', NgaySinhNV 'Ngày sinh', GioiTinh 'Giới tính', SDT 'Điện Thoại', ChucVu 'Chức vụ' from NHANVIEN  ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinNV.DataSource = table;
            dgvThongTinNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmTimKiemNV()
        {
            InitializeComponent();
        }

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            if (cmbTimNV.Text == "Mã nhân viên")
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaNV 'Mã nhân viên', TenNV 'Tên Nhân viên', NgaySinhNV 'Ngày sinh', GioiTinh 'Giới tính', SDT 'Điện Thoại', ChucVu 'Chức vụ' from NHANVIEN where MaNV = '" + txtTimNV.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinNV.DataSource = table;
            }

            else if (cmbTimNV.Text == "Tên nhân viên")
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaNV 'Mã nhân viên', TenNV 'Tên Nhân viên', NgaySinhNV 'Ngày sinh', GioiTinh 'Giới tính', SDT 'Điện Thoại', ChucVu 'Chức vụ' from NHANVIEN where TenNV = N'" + txtTimNV.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinNV.DataSource = table;
            }

            else if (cmbTimNV.Text == "Chức vụ")
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaNV 'Mã nhân viên', TenNV 'Tên Nhân viên', NgaySinhNV 'Ngày sinh', GioiTinh 'Giới tính', SDT 'Điện Thoại', ChucVu 'Chức vụ' from NHANVIEN where ChucVu = N'" + txtTimNV.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinNV.DataSource = table;
            }

            else
            {
                command = connection.CreateCommand();
                command.CommandText = "select MaNV 'Mã nhân viên', TenNV 'Tên Nhân viên', NgaySinhNV 'Ngày sinh', GioiTinh 'Giới tính', SDT 'Điện Thoại', ChucVu 'Chức vụ' from NHANVIEN where SDT = '" + txtTimNV.Text.Trim() + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgvThongTinNV.DataSource = table;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmTimKiemNV_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTimKiemNV_Load(object sender, EventArgs e)
        {
            cmbTimNV.Text = "Mã nhân viên";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinNV();
        }

        private void frmTimKiemNV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
