using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmLapPhieuMuon_Tra : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinPM()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHIEUMUON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinPM.DataSource = table;
            dgvThongTinPM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmLapPhieuMuon_Tra()
        {
            InitializeComponent();
        }


        private void btnLuuPM_Click(object sender, EventArgs e)
        {
            if (txtMaPM.Enabled == true)
            {
                if (txtMaPM.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into PHIEUMUON values('" + txtMaPM.Text + "','" + cmbMaNV.SelectedValue + "', '" + cmbMaDG.SelectedValue + "')";
                        command.ExecuteNonQuery();
                        loadThongTinPM();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (txtMaPM.Enabled == false)
            {
                if (txtMaPM.Text == "")
                {
                    MessageBox.Show("Hãy Click vào phiếu mượn muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update PHIEUMUON set MaDG =N'" + cmbMaDG.SelectedValue + "', MaNV = '" + cmbMaNV.SelectedValue + "' where MaPM = '" + txtMaPM.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinPM();

                    txtMaPM.Text = "";
                    cmbMaDG.Text = "";
                    cmbMaNV.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }

            MessageBox.Show("Vui lòng cung cấp thông tin chi tiết phiếu mượn!", "Thông báo", MessageBoxButtons.OK);
            frmCTPM f = new frmCTPM();
            this.Hide();
            f.ShowDialog();
            this.Show();
            frmLapPhieuMuon_Tra_Load(sender, e);
        }


        private void frmLapPhieuMuon_Tra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.DOCGIA' table. You can move, or remove it, as needed.
            this.dOCGIATableAdapter.Fill(this.dOAnQLTVDataSet1.DOCGIA);
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dOAnQLTVDataSet1.NHANVIEN);
            txtMaPM.Enabled = false;
            cmbMaNV.Enabled = false;
            cmbMaDG.Enabled = false;
            btnLuuPM.Enabled = false;
            btnKhongLuuPM.Enabled = false;
            btnThemPM.Enabled = true;
            btnXoaPM.Enabled = true;
            btnSuaPM.Enabled = true;

            txtMaPM.Text = "";
            cmbMaDG.Text = "";
            cmbMaNV.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinPM();

        }

        private void dgvThongTinPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinPM.CurrentRow.Index;
            txtMaPM.Text = dgvThongTinPM.Rows[i].Cells[0].Value.ToString();
            cmbMaNV.SelectedValue = dgvThongTinPM.Rows[i].Cells[1].Value.ToString();
            cmbMaDG.SelectedValue = dgvThongTinPM.Rows[i].Cells[2].Value.ToString();

        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            txtMaPM.Enabled = true;
            cmbMaNV.Enabled = true;
            cmbMaDG.Enabled = true;
            btnLuuPM.Enabled = true;
            btnKhongLuuPM.Enabled = true;
            btnThemPM.Enabled = false;
            btnXoaPM.Enabled = false;
            btnSuaPM.Enabled = false;

            txtMaPM.Text = "";
            cmbMaDG.Text = "";
            cmbMaNV.Text = "";
            txtMaPM.Focus();
        }

        private void btnXoaPM_Click(object sender, EventArgs e)
        {
            if (txtMaPM.Text == "")
            {
                MessageBox.Show("Hãy Click vào phiếu mượn muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa phiếu này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from PHIEUMUON where MaPM = '" + txtMaPM.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinPM();

                txtMaPM.Text = "";
                cmbMaDG.Text = "";
                cmbMaNV.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                txtMaPM.Text = "";
                cmbMaDG.Text = "";
                cmbMaNV.Text = "";
            }
        }

        private void btnSuaPM_Click(object sender, EventArgs e)
        {
            txtMaPM.Enabled = false;
            cmbMaNV.Enabled = true;
            cmbMaDG.Enabled = true;
            btnLuuPM.Enabled = true;
            btnKhongLuuPM.Enabled = true;
            btnThemPM.Enabled = false;
            btnXoaPM.Enabled = false;
            btnSuaPM.Enabled = false;
        }

        private void btnKhongLuuPM_Click(object sender, EventArgs e)
        {
            frmLapPhieuMuon_Tra_Load(sender, e);
        }

        private void btnThoatfrmPM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLapPhieuMuon_Tra_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
