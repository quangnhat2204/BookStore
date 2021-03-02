namespace DA_DBMS.UserControls
{
    partial class DonHang
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.Framework.UI.BunifuRating();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dgvDonhang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThanhtoan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.lbNgaygiao = new System.Windows.Forms.Label();
            this.lbNgaydat = new System.Windows.Forms.Label();
            this.lbDiachi = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(607, 511);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 15);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gửi đánh giá!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Đánh giá Cửa hàng";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRating1.Location = new System.Drawing.Point(510, 555);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(249, 31);
            this.bunifuRating1.TabIndex = 18;
            this.bunifuRating1.Value = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(481, 355);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 20);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Chuyển khoản";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(481, 329);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(211, 20);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thanh toán khi nhận được hàng";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dgvDonhang
            // 
            this.dgvDonhang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonhang.ColumnHeadersHeight = 40;
            this.dgvDonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.Soluong,
            this.Tongtien});
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(242)))), ((int)(((byte)(203)))));
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.CurrentTheme.BackColor = System.Drawing.Color.LimeGreen;
            this.dgvDonhang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.dgvDonhang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.dgvDonhang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDonhang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonhang.CurrentTheme.Name = null;
            this.dgvDonhang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            this.dgvDonhang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDonhang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            this.dgvDonhang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(225)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonhang.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDonhang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDonhang.EnableHeadersVisualStyles = false;
            this.dgvDonhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(240)))), ((int)(((byte)(193)))));
            this.dgvDonhang.HeaderBackColor = System.Drawing.Color.LimeGreen;
            this.dgvDonhang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDonhang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDonhang.Location = new System.Drawing.Point(0, 312);
            this.dgvDonhang.Name = "dgvDonhang";
            this.dgvDonhang.RowHeadersVisible = false;
            this.dgvDonhang.RowTemplate.Height = 40;
            this.dgvDonhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonhang.Size = new System.Drawing.Size(475, 288);
            this.dgvDonhang.TabIndex = 14;
            this.dgvDonhang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.LimeGreen;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên sách";
            this.TenSach.Name = "TenSach";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Đơn giá";
            this.Tongtien.Name = "Tongtien";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Active = true;
            this.btnThanhtoan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhtoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhtoan.BorderRadius = 0;
            this.btnThanhtoan.ButtonText = "Đặt Hàng";
            this.btnThanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhtoan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhtoan.Iconimage = global::DA_DBMS.Properties.Resources.icons8_coins_64px;
            this.btnThanhtoan.Iconimage_right = null;
            this.btnThanhtoan.Iconimage_right_Selected = null;
            this.btnThanhtoan.Iconimage_Selected = null;
            this.btnThanhtoan.IconMarginLeft = 0;
            this.btnThanhtoan.IconMarginRight = 0;
            this.btnThanhtoan.IconRightVisible = true;
            this.btnThanhtoan.IconRightZoom = 0D;
            this.btnThanhtoan.IconVisible = true;
            this.btnThanhtoan.IconZoom = 90D;
            this.btnThanhtoan.IsTab = false;
            this.btnThanhtoan.Location = new System.Drawing.Point(539, 410);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThanhtoan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThanhtoan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThanhtoan.selected = true;
            this.btnThanhtoan.Size = new System.Drawing.Size(194, 48);
            this.btnThanhtoan.TabIndex = 15;
            this.btnThanhtoan.Text = "Đặt Hàng";
            this.btnThanhtoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanhtoan.Textcolor = System.Drawing.Color.Black;
            this.btnThanhtoan.TextFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.Click += new System.EventHandler(this.BtnThanhtoan_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DA_DBMS.Properties.Resources.pngtree_simple_book_city_advertising_background_backgroundfreshnaturaldoctor_hatbookblue_skyflying_image_73973;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbTongtien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvKH);
            this.panel1.Controls.Add(this.lbNgaygiao);
            this.panel1.Controls.Add(this.lbNgaydat);
            this.panel1.Controls.Add(this.lbDiachi);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.lbSdt);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 312);
            this.panel1.TabIndex = 1;
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
            this.bunifuImageButton1.TabIndex = 17;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "SĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày giao hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày đặt hàng:";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.BackColor = System.Drawing.Color.Transparent;
            this.lbTongtien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.Location = new System.Drawing.Point(441, 235);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(72, 30);
            this.lbTongtien.TabIndex = 8;
            this.lbTongtien.Text = "label7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phí giao dịch:";
            // 
            // dgvKH
            // 
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(3, 218);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(8, 8);
            this.dgvKH.TabIndex = 2;
            this.dgvKH.Visible = false;
            // 
            // lbNgaygiao
            // 
            this.lbNgaygiao.AutoSize = true;
            this.lbNgaygiao.BackColor = System.Drawing.Color.Transparent;
            this.lbNgaygiao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaygiao.Location = new System.Drawing.Point(574, 159);
            this.lbNgaygiao.Name = "lbNgaygiao";
            this.lbNgaygiao.Size = new System.Drawing.Size(57, 21);
            this.lbNgaygiao.TabIndex = 5;
            this.lbNgaygiao.Text = "label6";
            // 
            // lbNgaydat
            // 
            this.lbNgaydat.AutoSize = true;
            this.lbNgaydat.BackColor = System.Drawing.Color.Transparent;
            this.lbNgaydat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaydat.Location = new System.Drawing.Point(574, 109);
            this.lbNgaydat.Name = "lbNgaydat";
            this.lbNgaydat.Size = new System.Drawing.Size(57, 21);
            this.lbNgaydat.TabIndex = 4;
            this.lbNgaydat.Text = "label5";
            // 
            // lbDiachi
            // 
            this.lbDiachi.AutoSize = true;
            this.lbDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lbDiachi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiachi.Location = new System.Drawing.Point(190, 159);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Size = new System.Drawing.Size(57, 21);
            this.lbDiachi.TabIndex = 3;
            this.lbDiachi.Text = "label4";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(190, 109);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 21);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "label3";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.BackColor = System.Drawing.Color.Transparent;
            this.lbSdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(574, 61);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(57, 21);
            this.lbSdt.TabIndex = 1;
            this.lbSdt.Text = "label2";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.BackColor = System.Drawing.Color.Transparent;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.Location = new System.Drawing.Point(190, 61);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(57, 21);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "label1";
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.dgvDonhang);
            this.Controls.Add(this.panel1);
            this.Name = "DonHang";
            this.Size = new System.Drawing.Size(790, 600);
            this.Load += new System.EventHandler(this.DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label lbNgaygiao;
        private System.Windows.Forms.Label lbNgaydat;
        private System.Windows.Forms.Label lbDiachi;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuRating bunifuRating1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btnThanhtoan;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDonhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}
