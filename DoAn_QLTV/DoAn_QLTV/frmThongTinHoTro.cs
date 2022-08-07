using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmThongTinHoTro : Form
    {
        public frmThongTinHoTro()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadThongTinHoTro()
        {
            command = connection.CreateCommand();
            command.CommandText = "select mssv 'Mã số SV', hoTen 'Họ tên', gioiTinh 'Giới tính', SDT 'Điện thoại', email 'email' from support";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinHoTro.DataSource = table;
        }
        private void frmThongTinHoTro_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinHoTro();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
