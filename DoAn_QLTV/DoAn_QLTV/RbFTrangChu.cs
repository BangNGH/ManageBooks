using System;

namespace DoAn_QLTV
{
    public partial class RbFTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RbFTrangChu()
        {
            InitializeComponent();
        }



        private void RbfrmTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
            FrmCapNhatSach f = new FrmCapNhatSach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCapNhatTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCapNhatTL f = new FrmCapNhatTL();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();

        }

        private void RbFTrangChu_Load(object sender, EventArgs e)
        {

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

        private void btnTraCuuSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}