using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmLapPhieuPhat : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinPP()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUPHAT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinPP.DataSource = table;
        }
        public frmLapPhieuPhat()
        {
            InitializeComponent();

        }

        private void frmLapPhieuPhat_Load(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(this.dOAnQLTVDataSet1.NHANVIEN);
            this.cT_PHIEUMUONTableAdapter.Fill(this.dOAnQLTVDataSet1.CT_PHIEUMUON);
            btnThemPP.Enabled = true;
            btnXoaPP.Enabled = true;
            btnSuaPP.Enabled = true;
            btnLuuPP.Enabled = false;
            btnKhongLuuPP.Enabled = false;
            txtMaPP.Enabled = false;
            cmbMaNV.Enabled = false;
            cmbMaPM.Enabled = false;
            cmbMaSach.Enabled = false;
            textBox2.Enabled = false;


            txtMaPP.Text = "";
            textBox2.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinPP();
        }

        private void dgvThongTinCTPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinPP.CurrentRow.Index;
            txtMaPP.Text = dgvThongTinPP.Rows[i].Cells[0].Value.ToString();
            cmbMaNV.SelectedValue = dgvThongTinPP.Rows[i].Cells[1].Value.ToString();
            cmbMaPM.Text = dgvThongTinPP.Rows[i].Cells[2].Value.ToString();
            cmbMaSach.Text = dgvThongTinPP.Rows[i].Cells[3].Value.ToString();
            textBox2.Text = dgvThongTinPP.Rows[i].Cells[4].Value.ToString();
        }

        private void btnThemPP_Click(object sender, EventArgs e)
        {
            btnThemPP.Enabled = false;
            btnXoaPP.Enabled = false;
            btnSuaPP.Enabled = false;
            btnLuuPP.Enabled = true;
            btnKhongLuuPP.Enabled = true;
            txtMaPP.Enabled = true;
            cmbMaNV.Enabled = true;
            cmbMaPM.Enabled = true;
            textBox2.Enabled = true;

            txtMaPP.Text = "";
            textBox2.Text = "";
            txtMaPP.Focus();
        }

        private void btnXoaPP_Click(object sender, EventArgs e)
        {
            if (txtMaPP.Text == "")
            {
                MessageBox.Show("Hãy Click vào phiếu phạt muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa phiếu này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from PHIEUPHAT where MaPP = '" + txtMaPP.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinPP();

                txtMaPP.Text = "";
                textBox2.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtMaPP.Text = "";
                textBox2.Text = "";
            }
        }

        private void btnSuaPP_Click(object sender, EventArgs e)
        {
            btnThemPP.Enabled = false;
            btnXoaPP.Enabled = false;
            btnSuaPP.Enabled = false;
            btnLuuPP.Enabled = true;
            btnKhongLuuPP.Enabled = true;
            txtMaPP.Enabled = false;
            cmbMaNV.Enabled = true;
            cmbMaPM.Enabled = true;
            textBox2.Enabled = true;
        }

        private void btnLuuPP_Click(object sender, EventArgs e)
        {
            if (txtMaPP.Enabled == true)
            {
                if (txtMaPP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into PHIEUPHAT values('" + txtMaPP.Text + "','" + cmbMaNV.SelectedValue + "', '" + cmbMaPM.Text + "', '" + cmbMaSach.Text + "', '" + int.Parse(textBox2.Text) + "')";
                        command.ExecuteNonQuery();
                        loadThongTinPP();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (txtMaPP.Enabled == false)
            {
                if (txtMaPP.Text == "")
                {
                    MessageBox.Show("Hãy Click vào chi tiết phiếu muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update PHIEUPHAT set MaNV = '" + cmbMaNV.SelectedValue + "' , MaPM ='" + cmbMaPM.Text + "', MaSach = '" + cmbMaSach.Text + "',MucPhiPhat = '" + int.Parse(textBox2.Text) + "' where MaPP = '" + txtMaPP.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinPP();

                    txtMaPP.Text = "";
                    textBox2.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
            frmLapPhieuPhat_Load(sender, e);
        }

        private void btnKhongLuuPP_Click(object sender, EventArgs e)
        {
            frmLapPhieuPhat_Load(sender, e);
        }

        private void btnThoatfrmLapPhieuPhat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
