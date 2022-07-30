using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;


namespace DoAn_QLTV
{
    public partial class frmCapNhatDocGia : Form
    {
        public frmCapNhatDocGia()
        {
            InitializeComponent();
            loadThongTinDG();
        }

        void loadThongTinDG()
        {
            string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);

            string query = "select * from DOCGIA";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            dgvThongTinDG.DataSource = data;

        }

        private void frmCapNhatDocGia_Load(object sender, EventArgs e)
        {
            
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
            Form f = new Form();
            f.Show();
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

        private void grbThongTinDG_Enter(object sender, EventArgs e)
        {

        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {

        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuuDG_Click(object sender, EventArgs e)
        {

        }

        private void dgvThongTinDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinDG.CurrentRow.Index;
            txtMaDG.Text = dgvThongTinDG.Rows[i].Cells[0].Value.ToString();
            txtTenDG.Text = dgvThongTinDG.Rows[i].Cells[1].Value.ToString();
            cmbGioiTinhDG.Text = dgvThongTinDG.Rows[i].Cells[4].Value.ToString();
            dtpNgaySinhDG.Text = dgvThongTinDG.Rows[i].Cells[2].Value.ToString();
            txtSDTDG.Text = dgvThongTinDG.Rows[i].Cells[3].Value.ToString();

        }
    }
}
