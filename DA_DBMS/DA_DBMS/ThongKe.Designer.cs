namespace DA_DBMS
{
    partial class ThongKe
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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBanchay = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSachtrongkho = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaSach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuPages1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanchay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachtrongkho)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = true;
            this.bunifuPages1.Controls.Add(this.tabPage1);
            this.bunifuPages1.Controls.Add(this.tabPage2);
            this.bunifuPages1.Location = new System.Drawing.Point(26, 48);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.tabPage2;
            this.bunifuPages1.PageIndex = 1;
            this.bunifuPages1.PageName = "tabPage2";
            this.bunifuPages1.PageTitle = "tabPage2";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(797, 524);
            this.bunifuPages1.TabIndex = 0;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBanchay);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBanchay
            // 
            this.dgvBanchay.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvBanchay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanchay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanchay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBanchay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBanchay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanchay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBanchay.ColumnHeadersHeight = 40;
            this.dgvBanchay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.SoLuong,
            this.ThanhTien});
            this.dgvBanchay.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvBanchay.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvBanchay.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBanchay.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvBanchay.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBanchay.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgvBanchay.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvBanchay.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvBanchay.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvBanchay.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBanchay.CurrentTheme.Name = null;
            this.dgvBanchay.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvBanchay.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvBanchay.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvBanchay.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvBanchay.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBanchay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBanchay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanchay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBanchay.EnableHeadersVisualStyles = false;
            this.dgvBanchay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvBanchay.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgvBanchay.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvBanchay.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBanchay.Location = new System.Drawing.Point(3, 3);
            this.dgvBanchay.Name = "dgvBanchay";
            this.dgvBanchay.RowHeadersVisible = false;
            this.dgvBanchay.RowTemplate.Height = 40;
            this.dgvBanchay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanchay.Size = new System.Drawing.Size(783, 492);
            this.dgvBanchay.TabIndex = 3;
            this.dgvBanchay.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.dgvBanchay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBanchay_CellContentClick);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSachtrongkho);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSachtrongkho
            // 
            this.dgvSachtrongkho.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvSachtrongkho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSachtrongkho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachtrongkho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSachtrongkho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSachtrongkho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachtrongkho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSachtrongkho.ColumnHeadersHeight = 40;
            this.dgvSachtrongkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach1,
            this.TenSach1,
            this.SoLuong1,
            this.GiaBan1});
            this.dgvSachtrongkho.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvSachtrongkho.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSachtrongkho.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSachtrongkho.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSachtrongkho.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSachtrongkho.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvSachtrongkho.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSachtrongkho.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSachtrongkho.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSachtrongkho.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSachtrongkho.CurrentTheme.Name = null;
            this.dgvSachtrongkho.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachtrongkho.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSachtrongkho.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSachtrongkho.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSachtrongkho.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachtrongkho.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSachtrongkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachtrongkho.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSachtrongkho.EnableHeadersVisualStyles = false;
            this.dgvSachtrongkho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSachtrongkho.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSachtrongkho.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSachtrongkho.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSachtrongkho.Location = new System.Drawing.Point(3, 3);
            this.dgvSachtrongkho.Name = "dgvSachtrongkho";
            this.dgvSachtrongkho.RowHeadersVisible = false;
            this.dgvSachtrongkho.RowTemplate.Height = 40;
            this.dgvSachtrongkho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachtrongkho.Size = new System.Drawing.Size(783, 492);
            this.dgvSachtrongkho.TabIndex = 0;
            this.dgvSachtrongkho.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvSachtrongkho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSachtrongkho_CellContentClick);
            // 
            // MaSach1
            // 
            this.MaSach1.DataPropertyName = "MaSach";
            this.MaSach1.HeaderText = "Mã Sách";
            this.MaSach1.Name = "MaSach1";
            // 
            // TenSach1
            // 
            this.TenSach1.DataPropertyName = "TenSach";
            this.TenSach1.HeaderText = "Tên Sách";
            this.TenSach1.Name = "TenSach1";
            // 
            // SoLuong1
            // 
            this.SoLuong1.DataPropertyName = "SoLuong";
            this.SoLuong1.HeaderText = "Số Lượng Còn";
            this.SoLuong1.Name = "SoLuong1";
            // 
            // GiaBan1
            // 
            this.GiaBan1.DataPropertyName = "GiaBan";
            this.GiaBan1.HeaderText = "Giá Bán";
            this.GiaBan1.Name = "GiaBan1";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "SP trong Kho";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::DA_DBMS.Properties.Resources.icons8_warehouse_64px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(472, 3);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Lime;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(135, 46);
            this.bunifuFlatButton1.TabIndex = 51;
            this.bunifuFlatButton1.Text = "SP trong Kho";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // btnSua
            // 
            this.btnSua.Active = false;
            this.btnSua.Activecolor = System.Drawing.Color.Lime;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 7;
            this.btnSua.ButtonText = "SP Bán Chạy";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = global::DA_DBMS.Properties.Resources.icons8_statistics_40px;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 90D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(282, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSua.OnHovercolor = System.Drawing.Color.Lime;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(135, 46);
            this.btnSua.TabIndex = 50;
            this.btnSua.Text = "SP Bán Chạy";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.Black;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bunifuPages1);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.bunifuPages1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanchay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachtrongkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvBanchay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvSachtrongkho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
