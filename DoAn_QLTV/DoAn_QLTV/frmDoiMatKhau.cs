using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmDoiMatKhau : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public bool kiemTraTaiKhoan(String tk)
        {
            return Regex.IsMatch(tk, "^[a-zA-Z0-9]{6,24}$");
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            string tk = txtTenTK.Text;
            string mkm = txtMKMoi.Text;
            string mkc = txtMKCu.Text;
            if (!kiemTraTaiKhoan(tk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản từ 6-24 ký tự chử hoặc số!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (!txtMKMoi.Text.Equals(txtXacNhanMKMoi.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "update Account set matKhau = '" + mkm + "' where taiKhoan = '" + tk + "' and matKhau = '" + mkc + "' ";
                command.ExecuteNonQuery();

                txtMatKhau.Text = "";
                txtMKCu.Text = "";
                txtMKMoi.Text = "";
                txtTenTK.Text = "";
                txtXacNhanMKMoi.Text = "";

            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
