using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmCapNhatSach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinSach()
        {
            command = connection.CreateCommand();
            command.CommandText = "select b.MaSach 'Mã sách', b.TenSach 'Tên sách', b.TenTacGia 'Tên tác giả', c.TenTL 'Thể loại' , d.TenNXB 'Tên NXB' ,b.NamXB 'Năm XB', a.ViTri 'Vị trí' from KESACH as a, SACH as b, THELOAI as c, NHAXUATBAN as d where a.MaKeSach = b.MaKeSach and b.MaTL = c.MaTL and d.MaNXB = b.MaNXB ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinSach.DataSource = table;
            dgvThongTinSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmCapNhatSach()
        {
            InitializeComponent();
        }

        private void frmCapNhatSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.KESACH' table. You can move, or remove it, as needed.
            this.kESACHTableAdapter.Fill(this.dOAnQLTVDataSet1.KESACH);
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.NHAXUATBAN' table. You can move, or remove it, as needed.
            this.nHAXUATBANTableAdapter.Fill(this.dOAnQLTVDataSet1.NHAXUATBAN);
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.THELOAI' table. You can move, or remove it, as needed.
            this.tHELOAITableAdapter.Fill(this.dOAnQLTVDataSet1.THELOAI);
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            cmbMaTL.Enabled = false;
            cmbMaNXB.Enabled = false;
            txtNamXB.Enabled = false;
            txtTenTG.Enabled = false;
            btnLuuSach.Enabled = false;
            cmbMaKS.Enabled = false;
            btnKhongLuuSach.Enabled = false;
            btnThemSach.Enabled = true;
            btnXoaSach.Enabled = true;
            btnSuaSach.Enabled = true;


            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cmbMaTL.Text = "";
            cmbMaNXB.Text = "";
            txtNamXB.Text = "";
            cmbMaKS.Text = "";
            txtTenTG.Text = "";

            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinSach();
        }

        private void btnThoatfrmSach_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKhongLuuSach_Click(object sender, EventArgs e)
        {
            frmCapNhatSach_Load(sender, e);
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            cmbMaTL.Enabled = true;
            cmbMaNXB.Enabled = true;
            txtNamXB.Enabled = true;
            txtTenTG.Enabled = true;
            btnLuuSach.Enabled = true;
            cmbMaKS.Enabled = true;
            btnKhongLuuSach.Enabled = true;
            btnThemSach.Enabled = false;
            btnXoaSach.Enabled = false;
            btnSuaSach.Enabled = false;

            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cmbMaTL.Text = "";
            cmbMaNXB.Text = "";
            txtNamXB.Text = "";
            cmbMaKS.Text = "";
            txtTenTG.Text = "";
            txtMaSach.Focus();
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = true;
            cmbMaTL.Enabled = true;
            cmbMaNXB.Enabled = true;
            txtNamXB.Enabled = true;
            txtTenTG.Enabled = true;
            btnLuuSach.Enabled = true;
            cmbMaKS.Enabled = true;
            btnKhongLuuSach.Enabled = true;
            btnThemSach.Enabled = false;
            btnXoaSach.Enabled = false;
            btnSuaSach.Enabled = false;

        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Hãy Click vào độc giả muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa sách này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from SACH where MaSach = '" + txtMaSach.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinSach();
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                cmbMaTL.Text = "";
                cmbMaNXB.Text = "";
                txtNamXB.Text = "";
                cmbMaKS.Text = "";
                txtTenTG.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                cmbMaTL.Text = "";
                cmbMaNXB.Text = "";
                txtNamXB.Text = "";
                cmbMaKS.Text = "";
                txtTenTG.Text = "";
            }
        }
        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Enabled == true)
            {
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);

                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into SACH values('" + txtMaSach.Text + "',N'" + txtTenSach.Text + "', N'" + txtTenTG.Text + "', '" + cmbMaTL.SelectedValue + "', '" + cmbMaNXB.SelectedValue + "', '" + txtNamXB.Text + "', '" + cmbMaKS.SelectedValue + "')";
                        command.ExecuteNonQuery();
                        loadThongTinSach();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (txtMaSach.Enabled == false)
            {
                if (txtMaSach.Text == "")
                {
                    MessageBox.Show("Hãy Click vào sách muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update SACH set TenSach =N'" + txtTenSach.Text + "', TenTacGia = N'" + txtTenTG.Text + "', MaTL = '" + cmbMaTL.SelectedValue + "', MaNXB ='" + cmbMaNXB.SelectedValue + "', NamXB= '" + txtNamXB.Text + "', MaKeSach ='" + cmbMaKS.SelectedValue + "' where MaSach = '" + txtMaSach.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinSach();

                    txtMaSach.Text = "";
                    txtTenSach.Text = "";
                    cmbMaTL.Text = "";
                    cmbMaNXB.Text = "";
                    txtNamXB.Text = "";
                    cmbMaKS.Text = "";
                    txtTenTG.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
            frmCapNhatSach_Load(sender, e);
        }

        private void dgvThongTinSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinSach.CurrentRow.Index;
            txtMaSach.Text = dgvThongTinSach.Rows[i].Cells[0].Value.ToString();
            txtTenSach.Text = dgvThongTinSach.Rows[i].Cells[1].Value.ToString();
            txtTenTG.Text = dgvThongTinSach.Rows[i].Cells[2].Value.ToString();
            cmbMaTL.SelectedValue = dgvThongTinSach.Rows[i].Cells[3].Value.ToString();
            cmbMaNXB.SelectedValue = dgvThongTinSach.Rows[i].Cells[4].Value.ToString();
            txtNamXB.Text = dgvThongTinSach.Rows[i].Cells[5].Value.ToString();
            cmbMaKS.SelectedValue = dgvThongTinSach.Rows[i].Cells[6].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCapNhatSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
