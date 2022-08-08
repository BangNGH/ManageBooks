using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public frmTrangChu()
        {
            InitializeComponent();

        }


        private void btnCapNhatDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatDocGia f = new frmCapNhatDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnCapNhatNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatNhanVien f = new frmCapNhatNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCapNhatSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatSach f = new frmCapNhatSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCapNhatTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatTL f = new frmCapNhatTL();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();

        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTaoTaiKhoan f = new frmTaoTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLapPhieuMuon_Tra f = new frmLapPhieuMuon_Tra();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTimKiemSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimKiemSach f = new frmTimKiemSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThongTinCTPM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTPM f = new frmCTPM();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void btnTimKiemSach_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimKiemSach f = new frmTimKiemSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTimKiemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimKiemNV f = new frmTimKiemNV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHoTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTinHoTro f = new frmThongTinHoTro();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnHuongDan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Process.Start(@"");
        }

        private void btnTimKiemDG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTimKiemDG f = new frmTimKiemDG();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCapNhatNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCapNhatNCC f = new frmCapNhatNCC();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhieuNhapSach f = new frmPhieuNhapSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCTPN f = new frmCTPN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmTrangChu_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}