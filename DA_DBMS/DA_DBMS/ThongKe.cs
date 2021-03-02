using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DBMS
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void DgvBanchay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataConnDataContext db = new DataConnDataContext();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            dgvBanchay.DataSource = db.ThongkeBanchay();
            dgvSachtrongkho.DataSource = db.Thonghangcontrongkho();
        }

        private void DgvSachtrongkho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage1);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(tabPage2);
        }
    }
}
