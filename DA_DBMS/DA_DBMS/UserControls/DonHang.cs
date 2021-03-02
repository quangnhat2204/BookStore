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
    public partial class DonHang : UserControl
    {
        public static string email;
        public DonHang()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();

        private void DonHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = db.Thongtindathang(email);
            lbTen.DataBindings.Add("Text", dgvKH.DataSource, "TenKH");
            lbSdt.DataBindings.Add("Text", dgvKH.DataSource, "SDT");
            lbEmail.DataBindings.Add("Text", dgvKH.DataSource, "Email");
            lbDiachi.DataBindings.Add("Text", dgvKH.DataSource, "DiaChi");
            lbTongtien.Text = db.Tongtien(db.getmakh(email)).ToString();
            DateTime dat = DateTime.Now;
            lbNgaydat.Text = dat.ToString();
            lbNgaygiao.Text = db.getngaygiao(dat).ToString();
            dgvDonhang.DataSource = db.GioHangtable(db.getmakh(email));
        }

        private void BtnThanhtoan_Click(object sender, EventArgs e)
        {
            if (db.CheckGiohang() == 0) MessageBox.Show("Bạn chưa thêm SP vào giỏ hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    db.Taodonhang(db.getmakh(email), db.Tongtien(db.getmakh(email)), Convert.ToDateTime(lbNgaydat.Text), Convert.ToDateTime(lbNgaygiao.Text));
                    MessageBox.Show("Đặt hàng thành công!", "Thông báo!");
                    btnThanhtoan.Enabled = false;
                    db.ResertGiohang();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã tin tưởng chúng tôi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            lbTongtien.Text = db.Tongtien(db.getmakh(email)).ToString();
            DateTime dat = DateTime.Now;
            lbNgaydat.Text = dat.ToString();
            lbNgaygiao.Text = db.getngaygiao(dat).ToString();
            dgvDonhang.DataSource = db.GioHangtable(db.getmakh(email));
            btnThanhtoan.Enabled = true;
        }

    }
}
