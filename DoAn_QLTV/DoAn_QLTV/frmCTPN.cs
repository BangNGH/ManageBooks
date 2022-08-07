using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmCTPN : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinCTPN()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CT_PHIEUNHAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinCTPN.DataSource = table;
        }
        public frmCTPN()
        {
            InitializeComponent();
        }

        private void frmCTPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.dOAnQLTVDataSet1.PHIEUNHAP);
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.dOAnQLTVDataSet1.SACH);
            btnThemCTPN.Enabled = true;
            btnXoaCTPN.Enabled = true;
            btnSuaCTPN.Enabled = true;
            btnKhongLuuCTPN.Enabled = false;
            btnLuuCTPN.Enabled = false;
            cmbMaPN.Enabled = false;
            cmbMaSach.Enabled = false;
            txtDonGia.Enabled = false;
            txtSLNhap.Enabled = false;

            cmbMaPN.Text = "";
            cmbMaSach.Text = "";
            txtDonGia.Text = "";
            txtSLNhap.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinCTPN();
        }

        private void btnThemCTPN_Click(object sender, EventArgs e)
        {
            btnThemCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            btnSuaCTPN.Enabled = false;
            btnKhongLuuCTPN.Enabled = true;
            btnLuuCTPN.Enabled = true;
            cmbMaPN.Enabled = true;
            cmbMaSach.Enabled = true;
            txtDonGia.Enabled = true;
            txtSLNhap.Enabled = true;

            cmbMaPN.Text = "";
            cmbMaSach.Text = "";
            txtDonGia.Text = "";
            txtSLNhap.Text = "";
            cmbMaPN.Focus();
        }

        private void btnXoaCTPN_Click(object sender, EventArgs e)
        {
            if (cmbMaPN.Text == "")
            {
                MessageBox.Show("Hãy Click vào phiếu nhập muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa chi tiết phiếu này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from CT_PHIEUNHAP where MaPN = '" + cmbMaPN.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinCTPN();

                cmbMaPN.Text = "";
                cmbMaSach.Text = "";
                txtDonGia.Text = "";
                txtSLNhap.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                cmbMaPN.Text = "";
                cmbMaSach.Text = "";
                txtDonGia.Text = "";
                txtSLNhap.Text = "";
            }
        }

        private void btnSuaCTPN_Click(object sender, EventArgs e)
        {
            btnThemCTPN.Enabled = false;
            btnXoaCTPN.Enabled = false;
            btnSuaCTPN.Enabled = false;
            btnKhongLuuCTPN.Enabled = true;
            btnLuuCTPN.Enabled = true;
            cmbMaPN.Enabled = false;
            cmbMaSach.Enabled = true;
            txtDonGia.Enabled = true;
            txtSLNhap.Enabled = true;
        }

        private void btnLuuCTPN_Click(object sender, EventArgs e)
        {
            if (cmbMaPN.Enabled == true)
            {
                if (txtSLNhap.Text == "" || txtDonGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into CT_PHIEUNHAP values('" + cmbMaPN.Text + "','" + cmbMaSach.SelectedValue + "', '" + int.Parse(txtSLNhap.Text) + "','" + int.Parse(txtDonGia.Text) + "')";
                        command.ExecuteNonQuery();
                        loadThongTinCTPN();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (cmbMaPN.Enabled == false)
            {
                if (txtSLNhap.Text == "" || txtDonGia.Text == "")
                {
                    MessageBox.Show("Hãy Click vào chi tiết phiếu muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update CT_PHIEUNHAP set MaSach = '" + cmbMaSach.SelectedValue + "' ,SoLuongNhap = '" + int.Parse(txtSLNhap.Text) + "', DonGiaNhap ='" + int.Parse(txtDonGia.Text) + "' where MaPN = '" + cmbMaPN.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinCTPN();

                    cmbMaPN.Text = "";
                    cmbMaSach.Text = "";
                    txtDonGia.Text = "";
                    txtSLNhap.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
            frmCTPN_Load(sender, e);

        }

        private void btnKhongLuuCTPN_Click(object sender, EventArgs e)
        {
            frmCTPN_Load(sender, e);
        }

        private void btnThoatfrmCTPN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvThongTinCTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinCTPN.CurrentRow.Index;
            cmbMaPN.Text = dgvThongTinCTPN.Rows[i].Cells[0].Value.ToString();
            cmbMaSach.SelectedValue = dgvThongTinCTPN.Rows[i].Cells[1].Value.ToString();
            txtSLNhap.Text = dgvThongTinCTPN.Rows[i].Cells[2].Value.ToString();
            txtDonGia.Text = dgvThongTinCTPN.Rows[i].Cells[3].Value.ToString();
        }
    }
}
