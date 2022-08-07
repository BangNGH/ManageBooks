using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmCapNhatTL : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinTL()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from THELOAI";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinTL.DataSource = table;
        }
        public frmCapNhatTL()
        {
            InitializeComponent();
        }



        private void dgvThongTinTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinTL.CurrentRow.Index;
            txtMaTL.Text = dgvThongTinTL.Rows[i].Cells[0].Value.ToString();
            txtTenTL.Text = dgvThongTinTL.Rows[i].Cells[1].Value.ToString();
        }

        private void frmCapNhatTL_Load(object sender, EventArgs e)
        {
            txtMaTL.Enabled = false;
            txtTenTL.Enabled = false;
            btnLuuTL.Enabled = false;
            btnKhongLuuTL.Enabled = false;
            btnThemTL.Enabled = true;
            btnXoaTL.Enabled = true;
            btnSuaTL.Enabled = true;
            txtTenTL.Text = "";
            txtMaTL.Text = "";

            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinTL();
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            txtMaTL.Enabled = true;
            txtTenTL.Enabled = true;
            btnLuuTL.Enabled = true;
            btnKhongLuuTL.Enabled = true;
            btnThemTL.Enabled = false;
            btnXoaTL.Enabled = false;
            btnSuaTL.Enabled = false;

            txtTenTL.Text = "";
            txtMaTL.Text = "";
            txtMaTL.Focus();

        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "" || txtTenTL.Text == "")
            {
                MessageBox.Show("Hãy Click vào thể loại muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa thể loại?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from THELOAI where MaTL = '" + txtMaTL.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinTL();
                txtTenTL.Text = "";
                txtMaTL.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtTenTL.Text = "";
                txtMaTL.Text = "";
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            txtMaTL.Enabled = false;
            txtTenTL.Enabled = true;
            btnLuuTL.Enabled = true;
            btnKhongLuuTL.Enabled = true;
            btnThemTL.Enabled = false;
            btnXoaTL.Enabled = false;
            btnSuaTL.Enabled = false;
        }

        private void btnLuuTL_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Enabled == true)
            {
                if (txtMaTL.Text == "" || txtTenTL.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into THELOAI values('" + txtMaTL.Text + "',N'" + txtTenTL.Text + "')";
                        command.ExecuteNonQuery();
                        loadThongTinTL();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (txtMaTL.Enabled == false)
            {
                if (txtMaTL.Text == "" || txtTenTL.Text == "")
                {
                    MessageBox.Show("Hãy Click vào độc giả muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update THELOAI set TenTL = N'" + txtTenTL.Text + "' where MaTL = '" + txtMaTL.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinTL();
                    txtMaTL.Text = "";
                    txtTenTL.Text = "";

                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
            frmCapNhatTL_Load(sender, e);
        }

        private void btnKhongLuuTL_Click(object sender, EventArgs e)
        {
            frmCapNhatTL_Load(sender, e);
        }

        private void btnThoatfrmCapNhatTL_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
