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

        private void tsCapnhatdocgia_Click(object sender, EventArgs e)
        {
            frmCapNhatDocGia f = new frmCapNhatDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
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

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtTenNV.Enabled = true;
            txtSDTNV.Enabled = true;
            cmbGioiTinhNV.Enabled = true;
            dtpNgaySinhNV.Enabled = true;
            btnLuuNV.Enabled = true;
            btnKhongLuuNV.Enabled = true;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnThemNV.Enabled = false;

            dgvThongTinNV.Enabled = false;

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
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                txtMaNV.Text = "";
                txtSDTNV.Text = "";
                txtTenNV.Text = "";
                cmbGioiTinhNV.Text = "";
                dtpNgaySinhNV.Text = "";
                txtMaNV.Focus();
            }
            else
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "insert into NHANVIEN values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "', '" + dtpNgaySinhNV.Text + "',N'" + cmbGioiTinhNV.Text + "', '" + txtSDTNV.Text + "')";
                    command.ExecuteNonQuery();
                    loadThongTinNV();
                }
                catch (Exception loi)
                {
                    MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập!", "Thông Báo", MessageBoxButtons.OK);
                }

            }
            dgvThongTinNV.Enabled = true;
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDTNV.Enabled = false;
            cmbGioiTinhNV.Enabled = false;
            dtpNgaySinhNV.Enabled = false;
            btnLuuNV.Enabled = false;
            btnKhongLuuNV.Enabled = false;
            btnThemNV.Enabled = true;
            btnXoaNV.Enabled = true;
            btnSuaNV.Enabled = true;


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

        private void tsCapnhatnhanvien_Click(object sender, EventArgs e)
        {
            frmCapNhatNhanVien f = new frmCapNhatNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
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

        private void tsCapnhatdocgia_Click_1(object sender, EventArgs e)
        {
            frmCapNhatDocGia f = new frmCapNhatDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
