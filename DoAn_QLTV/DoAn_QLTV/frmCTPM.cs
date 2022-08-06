using System.Windows.Forms;

namespace DoAn_QLTV
{
    public partial class frmCTPM : Form
    {
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

        }
    }
}
