using System;
using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }

        private void frmTrangchu_Load(object sender, EventArgs e)
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
            frmCapNhatDocGia f = new frmCapNhatDocGia();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsCapnhatnhanvien_Click(object sender, EventArgs e)
        {
            frmCapNhatNhanVien f = new frmCapNhatNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tsCapnhatsach_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
