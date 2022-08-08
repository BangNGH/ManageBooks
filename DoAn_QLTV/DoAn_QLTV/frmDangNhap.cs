using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            
        }
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if (taiKhoan.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
                SqlConnection connection = new SqlConnection(str);
                connection.Open();

                string query = "select taiKhoan, matKhau from Account where taiKhoan = '" + taiKhoan + "' and matKhau = '" + matKhau + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read() == false)
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmTrangChu f = new frmTrangChu();
                    this.Hide();
                    f.ShowDialog();
                    Application.Exit();
                }
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
        }


    }
}
