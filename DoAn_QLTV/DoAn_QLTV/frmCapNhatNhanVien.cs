using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;


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
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinNV();
        }

        private void mượntrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {

        }

        private void dgvThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.ReadOnly = true;
            int i;
            i = dgvThongTinNV.CurrentRow.Index;
            txtMaNV.Text = dgvThongTinNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvThongTinNV.Rows[i].Cells[1].Value.ToString();
            cmbGioiTinhNV.Text = dgvThongTinNV.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinhNV.Text = dgvThongTinNV.Rows[i].Cells[2].Value.ToString();
            txtSDTNV.Text = dgvThongTinNV.Rows[i].Cells[4].Value.ToString();
            txtChucVuNV.Text = dgvThongTinNV.Rows[i].Cells[5].Value.ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbGioiTinhNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTenNV_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinhNV_ValueChanged(object sender, EventArgs e)
        {

        }

    
    }
}
