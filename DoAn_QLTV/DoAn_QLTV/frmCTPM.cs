using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmCTPM : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=NONAME\SQLEXPRESS;Initial Catalog=DOAnQLTV;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadThongTinCTPM()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CT_PHIEUMUON";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvThongTinCTPM.DataSource = table;
            dgvThongTinCTPM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public frmCTPM()
        {
            InitializeComponent();
        }

        private void frmCTPM_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.dOAnQLTVDataSet1.SACH);
            // TODO: This line of code loads data into the 'dOAnQLTVDataSet1.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.dOAnQLTVDataSet1.PHIEUMUON);

            btnThemCTPM.Enabled = true;
            btnXoaCTPM.Enabled = true;
            btnSuaCTPM.Enabled = true;
            btnKhongLuuCTPM.Enabled = false;
            btnLuuCTPM.Enabled = false;
            cmbMaPM.Enabled = false;
            dtpNgayMuon.Enabled = false;
            dtpNgayTra.Enabled = false;
            cmbTenSach.Enabled = false;
            cmbTinhTrangSach.Enabled = false;

            cmbMaPM.Text = "";
            cmbTenSach.Text = "";
            cmbTinhTrangSach.Text = "";
            connection = new SqlConnection(str);
            connection.Open();
            loadThongTinCTPM();
        }

        private void dgvThongTinCTPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvThongTinCTPM.CurrentRow.Index;
            cmbMaPM.Text = dgvThongTinCTPM.Rows[i].Cells[0].Value.ToString();
            cmbTenSach.SelectedValue = dgvThongTinCTPM.Rows[i].Cells[1].Value.ToString();
            cmbTinhTrangSach.Text = dgvThongTinCTPM.Rows[i].Cells[4].Value.ToString();
            dtpNgayTra.Text = dgvThongTinCTPM.Rows[i].Cells[3].Value.ToString();
            dtpNgayMuon.Text = dgvThongTinCTPM.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThemCTPM_Click(object sender, EventArgs e)
        {
            btnThemCTPM.Enabled = false;
            btnXoaCTPM.Enabled = false;
            btnSuaCTPM.Enabled = false;
            btnKhongLuuCTPM.Enabled = true;
            btnLuuCTPM.Enabled = true;
            cmbMaPM.Enabled = true;
            dtpNgayMuon.Enabled = true;
            dtpNgayTra.Enabled = true;
            cmbTenSach.Enabled = true;
            cmbTinhTrangSach.Enabled = true;

            cmbMaPM.Text = "";
            cmbTenSach.Text = "";
            cmbTinhTrangSach.Text = "";
            cmbMaPM.Focus();
        }

        private void btnXoaCTPM_Click(object sender, EventArgs e)
        {
            if (cmbMaPM.Text == "")
            {
                MessageBox.Show("Hãy Click vào phiếu mượn muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            try
            {

                if (MessageBox.Show("Xác nhận xóa chi tiết phiếu này?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
                command = connection.CreateCommand();
                command.CommandText = "delete from CT_PHIEUMUON where MaPM = '" + cmbMaPM.Text + "' ";
                command.ExecuteNonQuery();
                loadThongTinCTPM();

                cmbMaPM.Text = "";
                cmbTenSach.Text = "";
                cmbTinhTrangSach.Text = "";
            }
            catch
            {
                MessageBox.Show("Không thể xóa vì có quan hệ với bảng khác ", "Thông Báo", MessageBoxButtons.OK);
                cmbMaPM.Text = "";
                cmbTenSach.Text = "";
                cmbTinhTrangSach.Text = "";
            }
        }

        private void btnSuaCTPM_Click(object sender, EventArgs e)
        {
            btnThemCTPM.Enabled = false;
            btnXoaCTPM.Enabled = false;
            btnSuaCTPM.Enabled = false;
            cmbMaPM.Enabled = false;
            btnKhongLuuCTPM.Enabled = true;
            btnLuuCTPM.Enabled = true;
            dtpNgayMuon.Enabled = true;
            dtpNgayTra.Enabled = true;
            cmbTenSach.Enabled = true;
            cmbTinhTrangSach.Enabled = true;


        }

        private void btnLuuCTPM_Click(object sender, EventArgs e)
        {
            if (cmbMaPM.Enabled == true)
            {
                if (cmbTinhTrangSach.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "insert into CT_PHIEUMUON values('" + cmbMaPM.Text + "','" + cmbTenSach.SelectedValue + "', '" + dtpNgayMuon.Text + "', '" + dtpNgayTra.Text + "', N'" + cmbTinhTrangSach.Text + "')";
                        command.ExecuteNonQuery();
                        loadThongTinCTPM();

                    }
                    catch (Exception loi)
                    {
                        MessageBox.Show(loi.Message);

                    }

                }
            }


            if (cmbMaPM.Enabled == false)
            {
                if (cmbTinhTrangSach.Text == "")
                {
                    MessageBox.Show("Hãy Click vào chi tiết phiếu muốn sửa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "update CT_PHIEUMUON set MaSach = '" + cmbTenSach.SelectedValue + "' , NgayMuon = '" + dtpNgayMuon.Text + "' , NgayTra = '" + dtpNgayTra.Text + "', TinhTrangSach = N'" + cmbTinhTrangSach.Text + "' where MaPM = '" + cmbMaPM.Text + "'";
                    command.ExecuteNonQuery();
                    loadThongTinCTPM();

                    cmbMaPM.Text = "";
                    cmbTenSach.Text = "";
                    cmbTinhTrangSach.Text = "";
                }
                catch (Exception loi)
                {
                    MessageBox.Show(loi.Message);
                }
            }
            frmCTPM_Load(sender, e);

        }

        private void btnKhongLuuCTPM_Click(object sender, EventArgs e)
        {
            frmCTPM_Load(sender, e);
        }

        private void btnThoatfrmCTPM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCTPM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
