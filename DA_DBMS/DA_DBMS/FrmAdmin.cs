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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        DataConnDataContext db = new DataConnDataContext();
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thongKe1);
            bunifuTransition1.HideSync(manager_NXB1);
            bunifuTransition1.HideSync(manager_NCC1);
            bunifuTransition1.HideSync(manager_TacGia1);
            bunifuTransition1.HideSync(managerSanPham1);
            bunifuTransition1.HideSync(manager_DonHang1);
            bunifuTransition1.ShowSync(managerKhachHang1);
        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thongKe1);
            bunifuTransition1.HideSync(manager_NXB1);
            bunifuTransition1.HideSync(manager_NCC1);
            bunifuTransition1.HideSync(manager_TacGia1);
            bunifuTransition1.HideSync(managerKhachHang1);
            bunifuTransition1.HideSync(manager_DonHang1);
            bunifuTransition1.ShowSync(managerSanPham1);
        }

        private void BtnDonHang_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thongKe1);
            bunifuTransition1.HideSync(manager_NXB1);
            bunifuTransition1.HideSync(manager_NCC1);
            bunifuTransition1.HideSync(manager_TacGia1);
            bunifuTransition1.HideSync(managerSanPham1);
            bunifuTransition1.HideSync(managerKhachHang1);
            bunifuTransition1.ShowSync(manager_DonHang1);
        }

        private void BtnNCC_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thongKe1);
            bunifuTransition1.HideSync(manager_NXB1);
            bunifuTransition1.HideSync(managerKhachHang1);
            bunifuTransition1.HideSync(manager_TacGia1);
            bunifuTransition1.HideSync(managerSanPham1);
            bunifuTransition1.HideSync(manager_DonHang1);
            bunifuTransition1.ShowSync(manager_NCC1);
        }

        private void BtnTacGia_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thongKe1);
            bunifuTransition1.HideSync(manager_NXB1);
            bunifuTransition1.HideSync(manager_NCC1);
            bunifuTransition1.HideSync(managerKhachHang1);
            bunifuTransition1.HideSync(managerSanPham1);
            bunifuTransition1.HideSync(manager_DonHang1);
            bunifuTransition1.Show(manager_TacGia1);
        }

        private void BtnNXB_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(thongKe1);
            bunifuTransition1.HideSync(manager_TacGia1);
            bunifuTransition1.HideSync(manager_NCC1);
            bunifuTransition1.HideSync(managerKhachHang1);
            bunifuTransition1.HideSync(managerSanPham1);
            bunifuTransition1.HideSync(manager_DonHang1);
            bunifuTransition1.ShowSync(manager_NXB1);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
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


        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuTransition1.HideSync(manager_TacGia1);
            bunifuTransition1.HideSync(manager_NCC1);
            bunifuTransition1.HideSync(managerKhachHang1);
            bunifuTransition1.HideSync(managerSanPham1);
            bunifuTransition1.HideSync(manager_DonHang1);
            bunifuTransition1.HideSync(manager_NXB1);
            bunifuTransition1.ShowSync(thongKe1);       
        }

        private void BtnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
