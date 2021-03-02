namespace DA_DBMS.UserControls
{
    partial class MyDonHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLSdonhang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTinhtrang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPhi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbngaydat = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbMadh = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHuyDH = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSdonhang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLSdonhang
            // 
            this.dgvLSdonhang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvLSdonhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLSdonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSdonhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLSdonhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLSdonhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLSdonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLSdonhang.ColumnHeadersHeight = 40;
            this.dgvLSdonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.PhiGiaoDich,
            this.NgayDat,
            this.TinhTrangDH});
            this.dgvLSdonhang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.dgvLSdonhang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLSdonhang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLSdonhang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvLSdonhang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLSdonhang.CurrentTheme.BackColor = System.Drawing.Color.Maroon;
            this.dgvLSdonhang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvLSdonhang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.dgvLSdonhang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvLSdonhang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLSdonhang.CurrentTheme.Name = null;
            this.dgvLSdonhang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dgvLSdonhang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvLSdonhang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLSdonhang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvLSdonhang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLSdonhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLSdonhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLSdonhang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLSdonhang.EnableHeadersVisualStyles = false;
            this.dgvLSdonhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvLSdonhang.HeaderBackColor = System.Drawing.Color.Maroon;
            this.dgvLSdonhang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvLSdonhang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvLSdonhang.Location = new System.Drawing.Point(0, 319);
            this.dgvLSdonhang.Name = "dgvLSdonhang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLSdonhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLSdonhang.RowHeadersVisible = false;
            this.dgvLSdonhang.RowTemplate.Height = 40;
            this.dgvLSdonhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLSdonhang.Size = new System.Drawing.Size(790, 281);
            this.dgvLSdonhang.TabIndex = 3;
            this.dgvLSdonhang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            this.dgvLSdonhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLSdonhang_CellContentClick);
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã ĐH";
            this.MaDH.Name = "MaDH";
            // 
            // PhiGiaoDich
            // 
            this.PhiGiaoDich.DataPropertyName = "PhiGiaoDich";
            this.PhiGiaoDich.HeaderText = "Phí giao dịch";
            this.PhiGiaoDich.Name = "PhiGiaoDich";
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày đặt";
            this.NgayDat.Name = "NgayDat";
            // 
            // TinhTrangDH
            // 
            this.TinhTrangDH.DataPropertyName = "TinhTrangDH";
            this.TinhTrangDH.HeaderText = "Trình trạng";
            this.TinhTrangDH.Name = "TinhTrangDH";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DA_DBMS.Properties.Resources._80479391_stack_of_colorful_books_education_background_back_to_school_book_hardback_colorful_books_on_wooden_t;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTinhtrang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbPhi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbngaydat);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lbMadh);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.btnHuyDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 321);
            this.panel1.TabIndex = 4;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(44, 247);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 16);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Xem Chi tiết...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tình trạng Đơn hàng:";
            // 
            // lbTinhtrang
            // 
            this.lbTinhtrang.AutoSize = true;
            this.lbTinhtrang.BackColor = System.Drawing.Color.Transparent;
            this.lbTinhtrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhtrang.Location = new System.Drawing.Point(563, 156);
            this.lbTinhtrang.Name = "lbTinhtrang";
            this.lbTinhtrang.Size = new System.Drawing.Size(89, 21);
            this.lbTinhtrang.TabIndex = 52;
            this.lbTinhtrang.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Phí giao dịch:";
            // 
            // lbPhi
            // 
            this.lbPhi.AutoSize = true;
            this.lbPhi.BackColor = System.Drawing.Color.Transparent;
            this.lbPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhi.Location = new System.Drawing.Point(169, 156);
            this.lbPhi.Name = "lbPhi";
            this.lbPhi.Size = new System.Drawing.Size(35, 21);
            this.lbPhi.TabIndex = 50;
            this.lbPhi.Text = "Phí";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ngày đặt hàng:";
            // 
            // lbngaydat
            // 
            this.lbngaydat.AutoSize = true;
            this.lbngaydat.BackColor = System.Drawing.Color.Transparent;
            this.lbngaydat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaydat.Location = new System.Drawing.Point(563, 69);
            this.lbngaydat.Name = "lbngaydat";
            this.lbngaydat.Size = new System.Drawing.Size(80, 21);
            this.lbngaydat.TabIndex = 48;
            this.lbngaydat.Text = "Ngày đặt";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(43, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(108, 21);
            this.label.TabIndex = 47;
            this.label.Text = "Mã Đơn hàng:";
            // 
            // lbMadh
            // 
            this.lbMadh.AutoSize = true;
            this.lbMadh.BackColor = System.Drawing.Color.Transparent;
            this.lbMadh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMadh.Location = new System.Drawing.Point(169, 69);
            this.lbMadh.Name = "lbMadh";
            this.lbMadh.Size = new System.Drawing.Size(62, 21);
            this.lbMadh.TabIndex = 46;
            this.lbMadh.Text = "Mã ĐH";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::DA_DBMS.Properties.Resources.icons8_spinner_frame_2_64px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 45;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // btnHuyDH
            // 
            this.btnHuyDH.Active = false;
            this.btnHuyDH.Activecolor = System.Drawing.Color.Transparent;
            this.btnHuyDH.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyDH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuyDH.BorderRadius = 0;
            this.btnHuyDH.ButtonText = "Hủy Đơn hàng";
            this.btnHuyDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyDH.DisabledColor = System.Drawing.Color.Gray;
            this.btnHuyDH.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHuyDH.Iconimage = global::DA_DBMS.Properties.Resources.icons8_delete_64px;
            this.btnHuyDH.Iconimage_right = null;
            this.btnHuyDH.Iconimage_right_Selected = null;
            this.btnHuyDH.Iconimage_Selected = null;
            this.btnHuyDH.IconMarginLeft = 0;
            this.btnHuyDH.IconMarginRight = 0;
            this.btnHuyDH.IconRightVisible = true;
            this.btnHuyDH.IconRightZoom = 0D;
            this.btnHuyDH.IconVisible = true;
            this.btnHuyDH.IconZoom = 90D;
            this.btnHuyDH.IsTab = false;
            this.btnHuyDH.Location = new System.Drawing.Point(633, 273);
            this.btnHuyDH.Name = "btnHuyDH";
            this.btnHuyDH.Normalcolor = System.Drawing.Color.Transparent;
            this.btnHuyDH.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnHuyDH.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnHuyDH.selected = false;
            this.btnHuyDH.Size = new System.Drawing.Size(153, 44);
            this.btnHuyDH.TabIndex = 44;
            this.btnHuyDH.Text = "Hủy Đơn hàng";
            this.btnHuyDH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuyDH.Textcolor = System.Drawing.Color.Black;
            this.btnHuyDH.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDH.Click += new System.EventHandler(this.BtnHuyDH_Click);
            // 
            // MyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLSdonhang);
            this.Name = "MyDonHang";
            this.Size = new System.Drawing.Size(790, 600);
            this.Load += new System.EventHandler(this.MyDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSdonhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvLSdonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangDH;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnHuyDH;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbMadh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTinhtrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPhi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbngaydat;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
