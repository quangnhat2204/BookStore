using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DBMS.UserControls
{
    public partial class Cart : UserControl
    {
        public static string email;
        public Cart()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        public void Cart_Load(object sender, EventArgs e)
        {
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
            txtTien.Text = db.Tongtien(db.getmakh(email)).ToString();
        }

        private void DgvGiohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbSach.Text = dgvGiohang.CurrentRow.Cells[1].Value.ToString();
            lbDongia.Text = dgvGiohang.CurrentRow.Cells[2].Value.ToString();
            txtSoluong.Text = dgvGiohang.CurrentRow.Cells[3].Value.ToString();
        }


        private void BtnReload_Click_1(object sender, EventArgs e)
        {
            db.Updatesoluong(Convert.ToInt32(dgvGiohang.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(txtSoluong.Text));
            txtTien.Text = db.Tongtien(db.getmakh(email)).ToString();
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            db.Xoaspkhoicart(Convert.ToInt32(dgvGiohang.CurrentRow.Cells[0].Value.ToString()), db.getmakh(email));
            txtTien.Text = db.Tongtien(db.getmakh(email)).ToString();
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
        }

        private void BunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            dgvGiohang.DataSource = db.GioHangtable(db.getmakh(email));
            txtTien.Text = db.Tongtien(db.getmakh(email)).ToString();
        }
    }
}
