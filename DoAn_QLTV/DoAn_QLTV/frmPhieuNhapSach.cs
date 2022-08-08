using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmPhieuNhapSach : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinPN()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUNHAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinPN.DataSource = table;
            dgvThongTinPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmPhieuNhapSach()
        {
            InitializeComponent();
        }
        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Enabled == true)
            {
                if (txtMaPN.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into PHIEUNHAP values('" + txtMaPN.Text + "','" + cmbMaNV.SelectedValue + "', '" + cmbMaNCC.SelectedValue + "')";
                        command.ExecuteNonQuery();
                        loadThongTinPN();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (txtMaPN.Enabled == false)
            {
                if (txtMaPN.Text == "")
                {
                    MessageBox.Show("Hãy Click vào phiếu mượn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update PHIEUNHAP set MaNCC =N'" + cmbMaNCC.SelectedValue + "', MaNV = '" + cmbMaNV.SelectedValue + "' where MaPN = '" + txtMaPN.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinPN();

                    txtMaPN.Text = "";
                    cmbMaNCC.Text = "";
                    cmbMaNV.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }

            MessageBox.Show("Vui lòng cung cấp thông tin chi tiết phiếu nhập!", "Thông báo", MessageBoxButtons.OK);
            frmCTPN f = new frmCTPN();
            this.Hide();
            f.ShowDialog();
            this.Show();
            frmPhieuNhapSach_Load(sender, e);
        }
        private void frmPhieuNhapSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dOAnQLTVDataSet1.NHANVIEN);
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.dOAnQLTVDataSet1.NHACUNGCAP);
            txtMaPN.Enabled = false;
            cmbMaNV.Enabled = false;
            cmbMaNCC.Enabled = false;
            btnLuuPN.Enabled = false;
            btnKhongLuuPN.Enabled = false;
            btnThemPN.Enabled = true;
            btnXoaPN.Enabled = true;
            btnSuaPN.Enabled = true;

            txtMaPN.Text = "";
            cmbMaNCC.Text = "";
            cmbMaNV.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinPN();

        }
        private void dgvThongTinPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinPN.CurrentRow.Index;
            txtMaPN.Text = dgvThongTinPN.Rows[i].Cells[0].Value.ToString();
            cmbMaNV.SelectedValue = dgvThongTinPN.Rows[i].Cells[1].Value.ToString();
            cmbMaNCC.SelectedValue = dgvThongTinPN.Rows[i].Cells[2].Value.ToString();

        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = true;
            cmbMaNV.Enabled = true;
            cmbMaNCC.Enabled = true;
            btnLuuPN.Enabled = true;
            btnKhongLuuPN.Enabled = true;
            btnThemPN.Enabled = false;
            btnXoaPN.Enabled = false;
            btnSuaPN.Enabled = false;

            txtMaPN.Text = "";
            cmbMaNCC.Text = "";
            cmbMaNV.Text = "";
            txtMaPN.Focus();
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Hãy Click vào phiếu nhập muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa phiếu này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from PHIEUNHAP where MaPN = '" + txtMaPN.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinPN();

                txtMaPN.Text = "";
                cmbMaNCC.Text = "";
                cmbMaNV.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtMaPN.Text = "";
                cmbMaNCC.Text = "";
                cmbMaNV.Text = "";
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = false;
            cmbMaNV.Enabled = true;
            cmbMaNCC.Enabled = true;
            btnLuuPN.Enabled = true;
            btnKhongLuuPN.Enabled = true;
            btnThemPN.Enabled = false;
            btnXoaPN.Enabled = false;
            btnSuaPN.Enabled = false;
        }

        private void btnKhongLuuPN_Click(object sender, EventArgs e)
        {
            frmPhieuNhapSach_Load(sender, e);
        }

        private void btnThoatfrmPN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPhieuNhapSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
