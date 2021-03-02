namespace DA_DBMS
{
    partial class FrmAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNXB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTacGia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNCC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDonHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSanPham = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKhachHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.thongKe1 = new DA_DBMS.ThongKe();
            this.manager_TacGia1 = new DA_DBMS.Manager_TacGia();
            this.manager_NXB1 = new DA_DBMS.Manager_NXB();
            this.manager_NCC1 = new DA_DBMS.Manager_NCC();
            this.manager_DonHang1 = new DA_DBMS.Manager_DonHang();
            this.managerSanPham1 = new DA_DBMS.ManagerSanPham();
            this.managerKhachHang1 = new DA_DBMS.UserControls.ManagerKhachHang();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnNXB);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnTacGia);
            this.bunifuGradientPanel1.Controls.Add(this.btnNCC);
            this.bunifuGradientPanel1.Controls.Add(this.btnDonHang);
            this.bunifuGradientPanel1.Controls.Add(this.btnSanPham);
            this.bunifuGradientPanel1.Controls.Add(this.btnKhachHang);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(210, 660);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = true;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "           Thống Kê";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 268);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = true;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(210, 60);
            this.bunifuFlatButton2.TabIndex = 25;
            this.bunifuFlatButton2.Text = "           Thống Kê";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = true;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "           Đăng Xuất";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 520);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = true;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(210, 60);
            this.bunifuFlatButton1.TabIndex = 24;
            this.bunifuFlatButton1.Text = "           Đăng Xuất";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // btnNXB
            // 
            this.btnNXB.Active = true;
            this.btnNXB.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnNXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnNXB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNXB.BorderRadius = 0;
            this.btnNXB.ButtonText = "           Nhà Xuất Bản";
            this.btnNXB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNXB, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnNXB.DisabledColor = System.Drawing.Color.Gray;
            this.btnNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNXB.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNXB.Iconimage = null;
            this.btnNXB.Iconimage_right = null;
            this.btnNXB.Iconimage_right_Selected = null;
            this.btnNXB.Iconimage_Selected = null;
            this.btnNXB.IconMarginLeft = 0;
            this.btnNXB.IconMarginRight = 0;
            this.btnNXB.IconRightVisible = true;
            this.btnNXB.IconRightZoom = 0D;
            this.btnNXB.IconVisible = true;
            this.btnNXB.IconZoom = 90D;
            this.btnNXB.IsTab = false;
            this.btnNXB.Location = new System.Drawing.Point(0, 457);
            this.btnNXB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNXB.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnNXB.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNXB.selected = true;
            this.btnNXB.Size = new System.Drawing.Size(210, 60);
            this.btnNXB.TabIndex = 23;
            this.btnNXB.Text = "           Nhà Xuất Bản";
            this.btnNXB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNXB.Textcolor = System.Drawing.Color.White;
            this.btnNXB.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNXB.Click += new System.EventHandler(this.BtnNXB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnTacGia
            // 
            this.btnTacGia.Active = true;
            this.btnTacGia.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnTacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnTacGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTacGia.BorderRadius = 0;
            this.btnTacGia.ButtonText = "           Tác Giả";
            this.btnTacGia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnTacGia, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnTacGia.DisabledColor = System.Drawing.Color.Gray;
            this.btnTacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTacGia.Iconimage = null;
            this.btnTacGia.Iconimage_right = null;
            this.btnTacGia.Iconimage_right_Selected = null;
            this.btnTacGia.Iconimage_Selected = null;
            this.btnTacGia.IconMarginLeft = 0;
            this.btnTacGia.IconMarginRight = 0;
            this.btnTacGia.IconRightVisible = true;
            this.btnTacGia.IconRightZoom = 0D;
            this.btnTacGia.IconVisible = true;
            this.btnTacGia.IconZoom = 90D;
            this.btnTacGia.IsTab = false;
            this.btnTacGia.Location = new System.Drawing.Point(0, 394);
            this.btnTacGia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTacGia.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnTacGia.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTacGia.selected = true;
            this.btnTacGia.Size = new System.Drawing.Size(210, 60);
            this.btnTacGia.TabIndex = 20;
            this.btnTacGia.Text = "           Tác Giả";
            this.btnTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTacGia.Textcolor = System.Drawing.Color.White;
            this.btnTacGia.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTacGia.Click += new System.EventHandler(this.BtnTacGia_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.Active = true;
            this.btnNCC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNCC.BorderRadius = 0;
            this.btnNCC.ButtonText = "           Nhà Cung Cấp";
            this.btnNCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnNCC, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnNCC.DisabledColor = System.Drawing.Color.Gray;
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNCC.Iconimage = null;
            this.btnNCC.Iconimage_right = null;
            this.btnNCC.Iconimage_right_Selected = null;
            this.btnNCC.Iconimage_Selected = null;
            this.btnNCC.IconMarginLeft = 0;
            this.btnNCC.IconMarginRight = 0;
            this.btnNCC.IconRightVisible = true;
            this.btnNCC.IconRightZoom = 0D;
            this.btnNCC.IconVisible = true;
            this.btnNCC.IconZoom = 90D;
            this.btnNCC.IsTab = false;
            this.btnNCC.Location = new System.Drawing.Point(0, 331);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNCC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnNCC.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNCC.selected = true;
            this.btnNCC.Size = new System.Drawing.Size(210, 60);
            this.btnNCC.TabIndex = 19;
            this.btnNCC.Text = "           Nhà Cung Cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Textcolor = System.Drawing.Color.White;
            this.btnNCC.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Click += new System.EventHandler(this.BtnNCC_Click);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Active = true;
            this.btnDonHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDonHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDonHang.BorderRadius = 0;
            this.btnDonHang.ButtonText = "           Đơn Hàng";
            this.btnDonHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDonHang, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDonHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDonHang.Iconimage = null;
            this.btnDonHang.Iconimage_right = null;
            this.btnDonHang.Iconimage_right_Selected = null;
            this.btnDonHang.Iconimage_Selected = null;
            this.btnDonHang.IconMarginLeft = 0;
            this.btnDonHang.IconMarginRight = 0;
            this.btnDonHang.IconRightVisible = true;
            this.btnDonHang.IconRightZoom = 0D;
            this.btnDonHang.IconVisible = true;
            this.btnDonHang.IconZoom = 90D;
            this.btnDonHang.IsTab = false;
            this.btnDonHang.Location = new System.Drawing.Point(0, 205);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDonHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDonHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDonHang.selected = true;
            this.btnDonHang.Size = new System.Drawing.Size(210, 60);
            this.btnDonHang.TabIndex = 18;
            this.btnDonHang.Text = "           Đơn Hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Textcolor = System.Drawing.Color.White;
            this.btnDonHang.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Click += new System.EventHandler(this.BtnDonHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Active = true;
            this.btnSanPham.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSanPham.BorderRadius = 0;
            this.btnSanPham.ButtonText = "           Sản Phẩm";
            this.btnSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSanPham, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnSanPham.DisabledColor = System.Drawing.Color.Gray;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSanPham.Iconimage = null;
            this.btnSanPham.Iconimage_right = null;
            this.btnSanPham.Iconimage_right_Selected = null;
            this.btnSanPham.Iconimage_Selected = null;
            this.btnSanPham.IconMarginLeft = 0;
            this.btnSanPham.IconMarginRight = 0;
            this.btnSanPham.IconRightVisible = true;
            this.btnSanPham.IconRightZoom = 0D;
            this.btnSanPham.IconVisible = true;
            this.btnSanPham.IconZoom = 90D;
            this.btnSanPham.IsTab = false;
            this.btnSanPham.Location = new System.Drawing.Point(0, 142);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSanPham.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSanPham.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSanPham.selected = true;
            this.btnSanPham.Size = new System.Drawing.Size(210, 60);
            this.btnSanPham.TabIndex = 17;
            this.btnSanPham.Text = "           Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Textcolor = System.Drawing.Color.White;
            this.btnSanPham.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Click += new System.EventHandler(this.BtnSanPham_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Active = true;
            this.btnKhachHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKhachHang.BorderRadius = 0;
            this.btnKhachHang.ButtonText = "           Khách Hàng";
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnKhachHang, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnKhachHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKhachHang.Iconimage = null;
            this.btnKhachHang.Iconimage_right = null;
            this.btnKhachHang.Iconimage_right_Selected = null;
            this.btnKhachHang.Iconimage_Selected = null;
            this.btnKhachHang.IconMarginLeft = 0;
            this.btnKhachHang.IconMarginRight = 0;
            this.btnKhachHang.IconRightVisible = true;
            this.btnKhachHang.IconRightZoom = 0D;
            this.btnKhachHang.IconVisible = true;
            this.btnKhachHang.IconZoom = 90D;
            this.btnKhachHang.IsTab = false;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 79);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnKhachHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnKhachHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnKhachHang.selected = true;
            this.btnKhachHang.Size = new System.Drawing.Size(210, 60);
            this.btnKhachHang.TabIndex = 16;
            this.btnKhachHang.Text = "           Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Textcolor = System.Drawing.Color.White;
            this.btnKhachHang.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Click += new System.EventHandler(this.BtnKhachHang_Click);
            // 
            // thongKe1
            // 
            this.bunifuTransition1.SetDecoration(this.thongKe1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.thongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongKe1.Location = new System.Drawing.Point(210, 0);
            this.thongKe1.Name = "thongKe1";
            this.thongKe1.Size = new System.Drawing.Size(850, 660);
            this.thongKe1.TabIndex = 20;
            this.thongKe1.Visible = false;
            // 
            // manager_TacGia1
            // 
            this.manager_TacGia1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.manager_TacGia1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.manager_TacGia1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manager_TacGia1.Location = new System.Drawing.Point(210, 0);
            this.manager_TacGia1.Name = "manager_TacGia1";
            this.manager_TacGia1.Size = new System.Drawing.Size(850, 660);
            this.manager_TacGia1.TabIndex = 7;
            this.manager_TacGia1.Visible = false;
            // 
            // manager_NXB1
            // 
            this.bunifuTransition1.SetDecoration(this.manager_NXB1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.manager_NXB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manager_NXB1.Location = new System.Drawing.Point(210, 0);
            this.manager_NXB1.Name = "manager_NXB1";
            this.manager_NXB1.Size = new System.Drawing.Size(850, 660);
            this.manager_NXB1.TabIndex = 6;
            this.manager_NXB1.Visible = false;
            // 
            // manager_NCC1
            // 
            this.bunifuTransition1.SetDecoration(this.manager_NCC1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.manager_NCC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manager_NCC1.Location = new System.Drawing.Point(210, 0);
            this.manager_NCC1.Name = "manager_NCC1";
            this.manager_NCC1.Size = new System.Drawing.Size(850, 660);
            this.manager_NCC1.TabIndex = 5;
            this.manager_NCC1.TabStop = false;
            this.manager_NCC1.Visible = false;
            // 
            // manager_DonHang1
            // 
            this.bunifuTransition1.SetDecoration(this.manager_DonHang1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.manager_DonHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manager_DonHang1.Location = new System.Drawing.Point(210, 0);
            this.manager_DonHang1.Name = "manager_DonHang1";
            this.manager_DonHang1.Size = new System.Drawing.Size(850, 660);
            this.manager_DonHang1.TabIndex = 4;
            this.manager_DonHang1.Visible = false;
            // 
            // managerSanPham1
            // 
            this.bunifuTransition1.SetDecoration(this.managerSanPham1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.managerSanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerSanPham1.Location = new System.Drawing.Point(210, 0);
            this.managerSanPham1.Name = "managerSanPham1";
            this.managerSanPham1.Size = new System.Drawing.Size(850, 660);
            this.managerSanPham1.TabIndex = 3;
            this.managerSanPham1.Visible = false;
            // 
            // managerKhachHang1
            // 
            this.bunifuTransition1.SetDecoration(this.managerKhachHang1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.managerKhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managerKhachHang1.Location = new System.Drawing.Point(210, 0);
            this.managerKhachHang1.Name = "managerKhachHang1";
            this.managerKhachHang1.Size = new System.Drawing.Size(850, 660);
            this.managerKhachHang1.TabIndex = 2;
            this.managerKhachHang1.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.ActiveImage = null;
            this.btnThoat.AllowAnimations = true;
            this.btnThoat.AllowBuffering = false;
            this.btnThoat.AllowZooming = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.btnThoat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnThoat.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ErrorImage")));
            this.btnThoat.FadeWhenInactive = false;
            this.btnThoat.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageActive = null;
            this.btnThoat.ImageLocation = null;
            this.btnThoat.ImageMargin = 50;
            this.btnThoat.ImageSize = new System.Drawing.Size(-15, -13);
            this.btnThoat.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnThoat.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.InitialImage")));
            this.btnThoat.Location = new System.Drawing.Point(1022, 2);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0;
            this.btnThoat.ShowActiveImage = true;
            this.btnThoat.ShowCursorChanges = true;
            this.btnThoat.ShowImageBorders = true;
            this.btnThoat.ShowSizeMarkers = false;
            this.btnThoat.Size = new System.Drawing.Size(35, 37);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.ToolTipText = "";
            this.btnThoat.WaitOnLoad = false;
            this.btnThoat.Zoom = 50;
            this.btnThoat.ZoomSpeed = 10;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click_1);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.thongKe1);
            this.Controls.Add(this.manager_TacGia1);
            this.Controls.Add(this.manager_NXB1);
            this.Controls.Add(this.manager_NCC1);
            this.Controls.Add(this.manager_DonHang1);
            this.Controls.Add(this.managerSanPham1);
            this.Controls.Add(this.managerKhachHang1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnTacGia;
        private Bunifu.Framework.UI.BunifuFlatButton btnNCC;
        private Bunifu.Framework.UI.BunifuFlatButton btnDonHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnSanPham;
        private Bunifu.Framework.UI.BunifuFlatButton btnKhachHang;
        private UserControls.ManagerKhachHang managerKhachHang1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private ManagerSanPham managerSanPham1;
        private Manager_DonHang manager_DonHang1;
        private Manager_NCC manager_NCC1;
        private Manager_TacGia manager_TacGia1;
        private Manager_NXB manager_NXB1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private ThongKe thongKe1;
        private Bunifu.UI.WinForms.BunifuImageButton btnThoat;
    }
}