using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DoAn_QLTV
{
    public partial class frmCapNhatNCC : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinNCC()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHACUNGCAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinNCC.DataSource = table;
            dgvThongTinNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmCapNhatNCC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtTenNCC.Enabled = true;
            btnLuuNCC.Enabled = true;
            btnKhongLuuNCC.Enabled = true;
            btnThemNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnSuaNCC.Enabled = false;

            txtTenNCC.Text = "";
            txtMaNCC.Text = "";
            txtMaNCC.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "")
            {
                MessageBox.Show("Hãy Click vào nhà cung cấp muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa nhà cung cấp?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from NHACUNGCAP where MaNCC = '" + txtMaNCC.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinNCC();
                txtTenNCC.Text = "";
                txtMaNCC.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtTenNCC.Text = "";
                txtMaNCC.Text = "";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = true;
            btnLuuNCC.Enabled = true;
            btnKhongLuuNCC.Enabled = true;
            btnThemNCC.Enabled = false;
            btnXoaNCC.Enabled = false;
            btnSuaNCC.Enabled = false;
        }

        private void btnThoatfrmCapNhatNCC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Enabled == true)
            {
                if (txtMaNCC.Text == "" || txtTenNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into NHACUNGCAP values('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "')";
                        command.ExecuteNonQuery();
                        loadThongTinNCC();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (txtMaNCC.Enabled == false)
            {
                if (txtMaNCC.Text == "" || txtTenNCC.Text == "")
                {
                    MessageBox.Show("Hãy Click vào NCC muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update NHACUNGCAP set TenNCC = N'" + txtTenNCC.Text + "' where MaNCC = '" + txtMaNCC.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinNCC();
                    txtMaNCC.Text = "";
                    txtTenNCC.Text = "";

                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }

            frmCapNhatNCC_Load(sender, e);
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            frmCapNhatNCC_Load(sender, e);
        }

        private void frmCapNhatNCC_Load(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtTenNCC.Enabled = false;
            btnLuuNCC.Enabled = false;
            btnKhongLuuNCC.Enabled = false;
            btnThemNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            txtTenNCC.Text = "";
            txtMaNCC.Text = "";

            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinNCC();
        }

        private void dgvThongTinNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvThongTinNCC.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Text = dgvThongTinNCC.Rows[i].Cells[1].Value.ToString();
        }

        private void frmCapNhatNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
