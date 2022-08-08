using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace DoAn_QLTV
{
    public partial class frmTaoTaiKhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        void loadMaDG()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MaDG from DOCGIA";
            adapter.SelectCommand = command;
            cmbDG.DisplayMember = "MaDG";
            table.Clear();
            adapter.Fill(table);
            cmbDG.DataSource = table;
        }
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        //Kiểm tra mật khẩu và tài khoản 
        public bool kiemTraTaiKhoan(String tk)
        {
            return Regex.IsMatch(tk, "^[a-zA-Z0-9]{6,24}$");
        }
        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
            connection = new SqlConnection(str);
            connection.Open();
            loadMaDG();

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            string tk = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;

            if (!kiemTraTaiKhoan(tk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản từ 6-24 ký tự chử hoặc số!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!kiemTraTaiKhoan(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu từ 6-24 ký tự chử hoặc số!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!txtMatKhau.Text.Equals(txtXacNhanMK.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            try

            {
                command = connection.CreateCommand();
                command.CommandText = "insert into Account values('" + tk + "', '" + mk + "', '" + cmbDG.Text + "')";
                command.ExecuteNonQuery();
                loadMaDG();
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK);
                txtMatKhau.Text = "";
                txtTenDangNhap.Text = "";
                txtXacNhanMK.Text = "";

            }
            catch (Exception loi)
            {
                MessageBox.Show(loi.Message);

            }
        }

        private void frmTaoTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
