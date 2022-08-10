using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DoAn_QLTV
{
    public partial class frmBaoCaoThongKe : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        DataTable table3 = new DataTable();


        void loadThongTinTatCaSach()
        {
            command = connection.CreateCommand();
            command.CommandText = "select b.MaSach 'Mã sách', b.TenSach 'Tên sách', b.TenTacGia 'Tên tác giả', c.TenTL 'Thể loại' , d.TenNXB 'Tên NXB' ,b.NamXB 'Năm XB', a.ViTri 'Vị trí' from KESACH as a, SACH as b, THELOAI as c, NHAXUATBAN as d where a.MaKeSach = b.MaKeSach and b.MaTL = c.MaTL and d.MaNXB = b.MaNXB ";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgvThongTinSach.DataSource = table1;
            dgvThongTinSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < dgvThongTinSach.Rows.Count; i++)
            {
                dgvThongTinSach.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        void loadThongTinSachMuon()
        {
            command = connection.CreateCommand();
            command.CommandText = "select b.MaSach 'Mã sách', b.TenSach 'Tên sách', b.TenTacGia 'Tên tác giả', c.TenTL 'Thể loại' , d.TenNXB 'Tên NXB' ,b.NamXB 'Năm XB'from CT_PHIEUMUON as a, SACH as b, THELOAI as c, NHAXUATBAN as d where a.MaSach = b.MaSach and b.MaTL = c.MaTL and d.MaNXB = b.MaNXB";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgvThongTinSach.DataSource = table2;
            dgvThongTinSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < dgvThongTinSach.Rows.Count; i++)
            {
                dgvThongTinSach.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        void loadThongTinSachHienCo()
        {
            command = connection.CreateCommand();
            command.CommandText = "select b.MaSach 'Mã sách', b.TenSach 'Tên sách', b.TenTacGia 'Tên tác giả', c.TenTL 'Thể loại' , d.TenNXB 'Tên NXB' ,b.NamXB 'Năm XB' from KESACH as a, SACH as b, THELOAI as c, NHAXUATBAN as d where a.MaKeSach = b.MaKeSach and b.MaTL = c.MaTL and d.MaNXB = b.MaNXB EXCEPT select distinct b.MaSach 'Mã sách', b.TenSach 'Tên sách', b.TenTacGia 'Tên tác giả', c.TenTL 'Thể loại' , d.TenNXB 'Tên NXB'   ,b.NamXB 'Năm XB' from CT_PHIEUMUON as a, SACH as b, THELOAI as c, NHAXUATBAN as d where a.MaSach = b.MaSach and b.MaTL = c.MaTL and d.MaNXB = b.MaNXB ";
            adapter.SelectCommand = command;
            table3.Clear();
            adapter.Fill(table3);
            dgvThongTinSach.DataSource = table3;
            dgvThongTinSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for (int i = 0; i < dgvThongTinSach.Rows.Count; i++)
            {
                dgvThongTinSach.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text == "Tất cả sách")
            {
                connection = new SqlConnection(str);
                connection.Open();
                loadThongTinTatCaSach();

            }
            else if (comboBoxEdit1.Text == "Sách được mượn")
            {
                connection = new SqlConnection(str);
                connection.Open();
                loadThongTinSachMuon();
            }
            else
            {
                connection = new SqlConnection(str);
                connection.Open();
                loadThongTinSachHienCo();
            }
        }

    }
}