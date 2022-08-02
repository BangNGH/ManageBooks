using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace DoAn_QLTV
{
    public partial class frmCapNhatDocGia : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinDG()
        {
           command = connection.CreateCommand();
           command.CommandText = "select * from DOCGIA";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinDG.DataSource = table;
        }
        public frmCapNhatDocGia()
        {
            InitializeComponent();
            
        }

        

        private void frmCapNhatDocGia_Load(object sender, EventArgs e)
        {
            txtMaDG.Enabled = false;
            txtTenDG.Enabled = false;
            txtSDTDG.Enabled = false;
            cmbGioiTinhDG.Enabled = false;
            dtpNgaySinhDG.Enabled = false;
            btnLuuDG.Enabled = false;
            btnKhongLuuDG.Enabled = false;
            btnThemDG.Enabled = true;
            btnXoaDG.Enabled = true;
            btnSuaDG.Enabled = true;
            txtMaDG.Text = "";
            txtSDTDG.Text = "";
            txtTenDG.Text = "";
            cmbGioiTinhDG.Text = "";


            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinDG();
        }

        private void mượntrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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

        private void grbThongTinDG_Enter(object sender, EventArgs e)
        {

        }

        private void btnSuaDG_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDG_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "" || txtTenDG.Text == "" || txtSDTDG.Text == "")
            {
                MessageBox.Show("Hãy Click vào độc giả muốn xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            
            try
            {
               command = connection.CreateCommand();
               command.CommandText = "delete from DOCGIA where MaDG = '"+txtMaDG.Text+"' ";
               command.ExecuteNonQuery();
               loadThongTinDG();
                txtMaDG.Text = "";
                txtSDTDG.Text = "";
                txtTenDG.Text = "";
                cmbGioiTinhDG.Text = "";
            }
            catch (Exception loi)
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtMaDG.Text = "";
                txtSDTDG.Text = "";
                txtTenDG.Text = "";
                cmbGioiTinhDG.Text = "";
            }
        }

        private void btnThemDG_Click(object sender, EventArgs e)
        {
            txtMaDG.Enabled = true;
            txtTenDG.Enabled = true;
            txtSDTDG.Enabled = true;
            cmbGioiTinhDG.Enabled = true;
            dtpNgaySinhDG.Enabled = true;
            btnLuuDG.Enabled = true;
            btnKhongLuuDG.Enabled = true;
            btnSuaDG.Enabled = false;
            btnXoaDG.Enabled = false;
            btnThemDG.Enabled = false;
            dgvThongTinDG.Enabled = false;

            txtMaDG.Text = "";
            txtSDTDG.Text = "";
            txtTenDG.Text = "";
            cmbGioiTinhDG.Text = "";
            txtMaDG.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLuuDG_Click(object sender, EventArgs e)
        {


            if (txtMaDG.Text == "" || txtTenDG.Text == "" || txtSDTDG.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                
            }
            else
            {
                try
                {
                   command = connection.CreateCommand();
                   command.CommandText = "insert into DOCGIA values('" + txtMaDG.Text + "',N'" + txtTenDG.Text + "', '" + dtpNgaySinhDG.Text + "',N'" + cmbGioiTinhDG.Text + "', '" + txtSDTDG.Text + "')";
                   command.ExecuteNonQuery();
                   loadThongTinDG();

                    txtMaDG.Text = "";
                    txtSDTDG.Text = "";
                    txtTenDG.Text = "";
                    cmbGioiTinhDG.Text = "";
                    txtMaDG.Enabled = false;
                    txtTenDG.Enabled = false;
                    txtSDTDG.Enabled = false;
                    cmbGioiTinhDG.Enabled = false;
                    dtpNgaySinhDG.Enabled = false;
                    btnLuuDG.Enabled = false;
                    btnKhongLuuDG.Enabled = false;
                    btnThemDG.Enabled = true;
                    btnXoaDG.Enabled = true;
                    btnSuaDG.Enabled = true;
                }
                catch (Exception loi)
                {  
                    MessageBox.Show("Vui lòng kiểm tra dữ liệu nhập!", "Thông Báo", MessageBoxButtons.OK);

                }

                txtMaDG.Text = "";
                txtSDTDG.Text = "";
                txtTenDG.Text = "";
                cmbGioiTinhDG.Text = "";
                txtMaDG.Enabled = false;
                txtTenDG.Enabled = false;
                txtSDTDG.Enabled = false;
                cmbGioiTinhDG.Enabled = false;
                dtpNgaySinhDG.Enabled = false;
                btnLuuDG.Enabled = false;
                btnKhongLuuDG.Enabled = false;
                btnThemDG.Enabled = true;
                btnXoaDG.Enabled = true;
                btnSuaDG.Enabled = true;
            }

            

        }

        private void dgvThongTinDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinDG.CurrentRow.Index;
            txtMaDG.Text = dgvThongTinDG.Rows[i].Cells[0].Value.ToString();
            txtTenDG.Text = dgvThongTinDG.Rows[i].Cells[1].Value.ToString();
            cmbGioiTinhDG.Text = dgvThongTinDG.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinhDG.Text = dgvThongTinDG.Rows[i].Cells[2].Value.ToString();
            txtSDTDG.Text = dgvThongTinDG.Rows[i].Cells[4].Value.ToString();

        }

        private void tsCapnhatnhanvien_Click(object sender, EventArgs e)
        {
            frmCapNhatNhanVien f = new frmCapNhatNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void dgvThongTinDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKhongLuuDG_Click(object sender, EventArgs e)
        {
            frmCapNhatDocGia_Load(sender, e);
        }

        private void tsCapnhatnhanvien_Click_1(object sender, EventArgs e)
        {
            frmCapNhatNhanVien f = new frmCapNhatNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
