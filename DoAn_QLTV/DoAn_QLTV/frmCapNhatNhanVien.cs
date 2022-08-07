using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmCapNhatNhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinNV()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinNV.DataSource = table;
        }
        public frmCapNhatNhanVien()
        {
            InitializeComponent();

        }



        private void frmCapNhatNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDTNV.Enabled = false;
            cmbGioiTinhNV.Enabled = false;
            dtpNgaySinhNV.Enabled = false;
            btnLuuNV.Enabled = false;
            btnKhongLuuNV.Enabled = false;
            txtChucVuNV.Enabled = false;
            btnThemNV.Enabled = true;
            btnXoaNV.Enabled = true;
            btnSuaNV.Enabled = true;
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDTNV.Text = "";
            cmbGioiTinhNV.Text = "";
            dtpNgaySinhNV.Text = "";
            txtChucVuNV.Text = "";

            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinNV();
        }

        private void mượntrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void grbThongTinNV_Enter(object sender, EventArgs e)
        {

        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = true;
            txtSDTNV.Enabled = true;
            cmbGioiTinhNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
            btnLuuNV.Enabled = true;
            btnKhongLuuNV.Enabled = true;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnThemNV.Enabled = false;
            txtChucVuNV.Enabled = true;
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "")
            {
                MessageBox.Show("Hãy Click vào nhân viên muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from NHANVIEN where MaNV = '" + txtMaNV.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinNV();
                txtMaNV.Text = "";
                txtSDTNV.Text = "";
                txtTenNV.Text = "";
                cmbGioiTinhNV.Text = "";
                txtChucVuNV.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtMaNV.Text = "";
                txtSDTNV.Text = "";
                txtTenNV.Text = "";
                cmbGioiTinhNV.Text = "";
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtSDTNV.Enabled = true;
            cmbGioiTinhNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
            btnLuuNV.Enabled = true;
            txtChucVuNV.Enabled = true;
            btnKhongLuuNV.Enabled = true;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnThemNV.Enabled = false;

            txtMaNV.Text = "";
            txtSDTNV.Text = "";
            txtTenNV.Text = "";
            cmbGioiTinhNV.Text = "";
            dtpNgaySinhNV.Text = "";
            txtMaNV.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {

            if (txtMaNV.Enabled == true)
            {


                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into NHANVIEN values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "', '" + dtpNgaySinhNV.Text + "',N'" + cmbGioiTinhNV.Text + "', '" + txtSDTNV.Text + "', N'" + txtChucVuNV.Text + "')";
                        command.ExecuteNonQuery();
                        loadThongTinNV();
                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);
                    }

                }

            }
            if (txtMaNV.Enabled == false)
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "")
                {
                    MessageBox.Show("Hãy Click vào độc giả muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    txtMaNV.Enabled = false;
                    command = connection.CreateCommand();
                    command.CommandText = "update NHANVIEN set TenNV = N'" + txtTenNV.Text + "', NgaySinhNV='" + dtpNgaySinhNV.Text + "',GioiTinh = N'" + cmbGioiTinhNV.Text + "',SDT = '" + txtSDTNV.Text + "', ChucVu = N'" + txtChucVuNV.Text + "' where MaNV = '" + txtMaNV.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinNV();
                    txtMaNV.Text = "";
                    txtSDTNV.Text = "";
                    txtTenNV.Text = "";
                    cmbGioiTinhNV.Text = "";
                    txtChucVuNV.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
            frmCapNhatNhanVien_Load(sender, e);
        }

        private void dgvThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinNV.CurrentRow.Index;
            txtMaNV.Text = dgvThongTinNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvThongTinNV.Rows[i].Cells[1].Value.ToString();
            cmbGioiTinhNV.Text = dgvThongTinNV.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinhNV.Text = dgvThongTinNV.Rows[i].Cells[2].Value.ToString();
            txtSDTNV.Text = dgvThongTinNV.Rows[i].Cells[4].Value.ToString();
            txtChucVuNV.Text = dgvThongTinNV.Rows[i].Cells[5].Value.ToString();

        }

        private void dgvThongTinNV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKhongLuuNV_Click(object sender, EventArgs e)
        {
            frmCapNhatNhanVien_Load(sender, e);
        }
    }
}
