using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_DBMS
{
    public partial class FrmNguoiDung : Form
    {
        public FrmNguoiDung()
        {
            InitializeComponent();
        }

        private void BtnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Đăng xuất khỏi tài khoản?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                this.Hide();
                frmDangNhap frm = new frmDangNhap();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(myDonHang1);
            bunifuTransition1.HideSync(donHang1);
            bunifuTransition1.HideSync(store1);
            bunifuTransition1.HideSync(cart1);
            bunifuTransition1.ShowSync(profile1);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(myDonHang1);
            bunifuTransition1.HideSync(donHang1);
            bunifuTransition1.HideSync(profile1);
            bunifuTransition1.HideSync(cart1);
            bunifuTransition1.ShowSync(store1);
        }

        private void BtnGioHang_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(myDonHang1);
            bunifuTransition1.HideSync(donHang1);
            bunifuTransition1.HideSync(profile1);
            bunifuTransition1.HideSync(store1);
            bunifuTransition1.ShowSync(cart1);
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(myDonHang1);
            bunifuTransition1.HideSync(profile1);
            bunifuTransition1.HideSync(cart1);
            bunifuTransition1.HideSync(store1);
            bunifuTransition1.ShowSync(donHang1);
        }


        private void BtnDonHang_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(profile1);
            bunifuTransition1.HideSync(cart1);
            bunifuTransition1.HideSync(store1);
            bunifuTransition1.HideSync(donHang1);
            bunifuTransition1.ShowSync(myDonHang1);
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
