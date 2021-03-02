﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace DA_DBMS
{
    public partial class SuaChiTiet : Form
    {
        public static int masach;
        DataConnDataContext db = new DataConnDataContext();
        public SuaChiTiet()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtGia.Enabled = true;
            txtSoluong.Enabled = true;
            btnSave.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateSach(masach, Convert.ToInt32(txtSoluong.Text), Convert.ToInt32(txtGia.Text));
                DialogResult a = MessageBox.Show("Sửa thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (a == DialogResult.OK)
                {
                    txtGia.Enabled = false;
                    txtSoluong.Enabled = false;
                    btnSave.Visible = false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuaChiTiet_Load(object sender, EventArgs e)
        {
            dgvSua.DataSource = db.ChitietSach(masach);
            txtTen.DataBindings.Add("Text", dgvSua.DataSource, "TenSach");
            txtGia.DataBindings.Add("Text", dgvSua.DataSource, "GiaBan");
            txtNgay.DataBindings.Add("Text", dgvSua.DataSource, "NgayCapNhap");
            txtSoluong.DataBindings.Add("Text", dgvSua.DataSource, "SoLuong");
            lbMoTa.DataBindings.Add("Text", dgvSua.DataSource, "MoTa");
            LoadAnh();
        }
        private void LoadAnh()
        {
            try
            {
                DataConnDataContext db = new DataConnDataContext();
                Sach sach = db.Saches.Where(a => a.MaSach == masach).FirstOrDefault();
                if (sach == null) return;
                MemoryStream stream = new MemoryStream(sach.Anh.ToArray());
                Image img = Image.FromStream(stream);
                if (img == null) return;
                pictureBox1.Image = img;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
