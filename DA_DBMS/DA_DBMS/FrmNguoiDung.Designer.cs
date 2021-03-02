namespace DA_DBMS
{
    partial class FrmNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNguoiDung));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDangxuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDonHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThanhToan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGioHang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnStore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.myDonHang1 = new DA_DBMS.UserControls.MyDonHang();
            this.donHang1 = new DA_DBMS.UserControls.DonHang();
            this.cart1 = new DA_DBMS.UserControls.Cart();
            this.store1 = new DA_DBMS.UserControls.Store();
            this.profile1 = new DA_DBMS.UserControls.Profile();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnDangxuat);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnDonHang);
            this.bunifuGradientPanel1.Controls.Add(this.btnThanhToan);
            this.bunifuGradientPanel1.Controls.Add(this.btnGioHang);
            this.bunifuGradientPanel1.Controls.Add(this.btnStore);
            this.bunifuGradientPanel1.Controls.Add(this.btnProfile);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(177)))), ((int)(((byte)(233)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(31)))), ((int)(((byte)(141)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(210, 600);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Active = true;
            this.btnDangxuat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDangxuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangxuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangxuat.BorderRadius = 0;
            this.btnDangxuat.ButtonText = "           Đăng Xuất";
            this.btnDangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnDangxuat, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnDangxuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDangxuat.Iconimage = null;
            this.btnDangxuat.Iconimage_right = null;
            this.btnDangxuat.Iconimage_right_Selected = null;
            this.btnDangxuat.Iconimage_Selected = null;
            this.btnDangxuat.IconMarginLeft = 0;
            this.btnDangxuat.IconMarginRight = 0;
            this.btnDangxuat.IconRightVisible = true;
            this.btnDangxuat.IconRightZoom = 0D;
            this.btnDangxuat.IconVisible = true;
            this.btnDangxuat.IconZoom = 90D;
            this.btnDangxuat.IsTab = false;
            this.btnDangxuat.Location = new System.Drawing.Point(0, 429);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDangxuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDangxuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDangxuat.selected = true;
            this.btnDangxuat.Size = new System.Drawing.Size(210, 60);
            this.btnDangxuat.TabIndex = 23;
            this.btnDangxuat.Text = "           Đăng Xuất";
            this.btnDangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Textcolor = System.Drawing.Color.White;
            this.btnDangxuat.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.Click += new System.EventHandler(this.BtnDangxuat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Book Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DA_DBMS.Properties.Resources.icons8_books_96px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(10, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnDonHang
            // 
            this.btnDonHang.Active = true;
            this.btnDonHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDonHang.BackColor = System.Drawing.Color.Transparent;
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
            this.btnDonHang.Location = new System.Drawing.Point(0, 366);
            this.btnDonHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDonHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnDonHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDonHang.selected = true;
            this.btnDonHang.Size = new System.Drawing.Size(210, 60);
            this.btnDonHang.TabIndex = 20;
            this.btnDonHang.Text = "           Đơn Hàng";
            this.btnDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonHang.Textcolor = System.Drawing.Color.White;
            this.btnDonHang.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Click += new System.EventHandler(this.BtnDonHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Active = true;
            this.btnThanhToan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThanhToan.BorderRadius = 0;
            this.btnThanhToan.ButtonText = "           Thanh Toán";
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnThanhToan, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnThanhToan.DisabledColor = System.Drawing.Color.Gray;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Iconimage = null;
            this.btnThanhToan.Iconimage_right = null;
            this.btnThanhToan.Iconimage_right_Selected = null;
            this.btnThanhToan.Iconimage_Selected = null;
            this.btnThanhToan.IconMarginLeft = 0;
            this.btnThanhToan.IconMarginRight = 0;
            this.btnThanhToan.IconRightVisible = true;
            this.btnThanhToan.IconRightZoom = 0D;
            this.btnThanhToan.IconVisible = true;
            this.btnThanhToan.IconZoom = 90D;
            this.btnThanhToan.IsTab = false;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 303);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThanhToan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnThanhToan.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThanhToan.selected = true;
            this.btnThanhToan.Size = new System.Drawing.Size(210, 60);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "           Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Textcolor = System.Drawing.Color.White;
            this.btnThanhToan.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.Active = true;
            this.btnGioHang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnGioHang.BackColor = System.Drawing.Color.Transparent;
            this.btnGioHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGioHang.BorderRadius = 0;
            this.btnGioHang.ButtonText = "           Giỏ Hàng";
            this.btnGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnGioHang, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnGioHang.DisabledColor = System.Drawing.Color.Gray;
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGioHang.Iconimage = null;
            this.btnGioHang.Iconimage_right = null;
            this.btnGioHang.Iconimage_right_Selected = null;
            this.btnGioHang.Iconimage_Selected = null;
            this.btnGioHang.IconMarginLeft = 0;
            this.btnGioHang.IconMarginRight = 0;
            this.btnGioHang.IconRightVisible = true;
            this.btnGioHang.IconRightZoom = 0D;
            this.btnGioHang.IconVisible = true;
            this.btnGioHang.IconZoom = 90D;
            this.btnGioHang.IsTab = false;
            this.btnGioHang.Location = new System.Drawing.Point(0, 240);
            this.btnGioHang.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGioHang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnGioHang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGioHang.selected = true;
            this.btnGioHang.Size = new System.Drawing.Size(210, 60);
            this.btnGioHang.TabIndex = 18;
            this.btnGioHang.Text = "           Giỏ Hàng";
            this.btnGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGioHang.Textcolor = System.Drawing.Color.White;
            this.btnGioHang.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Click += new System.EventHandler(this.BtnGioHang_Click);
            // 
            // btnStore
            // 
            this.btnStore.Active = true;
            this.btnStore.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnStore.BackColor = System.Drawing.Color.Transparent;
            this.btnStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStore.BorderRadius = 0;
            this.btnStore.ButtonText = "           Cửa Hàng";
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnStore, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnStore.DisabledColor = System.Drawing.Color.Gray;
            this.btnStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStore.Iconimage = null;
            this.btnStore.Iconimage_right = null;
            this.btnStore.Iconimage_right_Selected = null;
            this.btnStore.Iconimage_Selected = null;
            this.btnStore.IconMarginLeft = 0;
            this.btnStore.IconMarginRight = 0;
            this.btnStore.IconRightVisible = true;
            this.btnStore.IconRightZoom = 0D;
            this.btnStore.IconVisible = true;
            this.btnStore.IconZoom = 90D;
            this.btnStore.IsTab = false;
            this.btnStore.Location = new System.Drawing.Point(0, 177);
            this.btnStore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnStore.Name = "btnStore";
            this.btnStore.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStore.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnStore.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStore.selected = true;
            this.btnStore.Size = new System.Drawing.Size(210, 60);
            this.btnStore.TabIndex = 17;
            this.btnStore.Text = "           Cửa Hàng";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.Textcolor = System.Drawing.Color.White;
            this.btnStore.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Click += new System.EventHandler(this.BtnStore_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Active = true;
            this.btnProfile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfile.BorderRadius = 0;
            this.btnProfile.ButtonText = "           Cá Nhân";
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnProfile, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.btnProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfile.Iconimage = null;
            this.btnProfile.Iconimage_right = null;
            this.btnProfile.Iconimage_right_Selected = null;
            this.btnProfile.Iconimage_Selected = null;
            this.btnProfile.IconMarginLeft = 0;
            this.btnProfile.IconMarginRight = 0;
            this.btnProfile.IconRightVisible = true;
            this.btnProfile.IconRightZoom = 0D;
            this.btnProfile.IconVisible = true;
            this.btnProfile.IconZoom = 90D;
            this.btnProfile.IsTab = false;
            this.btnProfile.Location = new System.Drawing.Point(0, 114);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProfile.selected = true;
            this.btnProfile.Size = new System.Drawing.Size(210, 60);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Text = "           Cá Nhân";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Textcolor = System.Drawing.Color.White;
            this.btnProfile.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
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
            this.bunifuTransition1.TimeStep = 0.03F;
            // 
            // myDonHang1
            // 
            this.bunifuTransition1.SetDecoration(this.myDonHang1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.myDonHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDonHang1.Location = new System.Drawing.Point(210, 0);
            this.myDonHang1.Name = "myDonHang1";
            this.myDonHang1.Size = new System.Drawing.Size(790, 600);
            this.myDonHang1.TabIndex = 17;
            this.myDonHang1.Visible = false;
            // 
            // donHang1
            // 
            this.bunifuTransition1.SetDecoration(this.donHang1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.donHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donHang1.Location = new System.Drawing.Point(210, 0);
            this.donHang1.Name = "donHang1";
            this.donHang1.Size = new System.Drawing.Size(790, 600);
            this.donHang1.TabIndex = 4;
            this.donHang1.Visible = false;
            // 
            // cart1
            // 
            this.bunifuTransition1.SetDecoration(this.cart1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.cart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cart1.Location = new System.Drawing.Point(210, 0);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(790, 600);
            this.cart1.TabIndex = 3;
            this.cart1.Visible = false;
            // 
            // store1
            // 
            this.bunifuTransition1.SetDecoration(this.store1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.store1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.store1.Location = new System.Drawing.Point(210, 0);
            this.store1.Name = "store1";
            this.store1.Size = new System.Drawing.Size(790, 600);
            this.store1.TabIndex = 2;
            this.store1.Visible = false;
            // 
            // profile1
            // 
            this.bunifuTransition1.SetDecoration(this.profile1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.profile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.profile1.Location = new System.Drawing.Point(210, 0);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(790, 600);
            this.profile1.TabIndex = 1;
            this.profile1.Visible = false;
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
            this.btnThoat.Location = new System.Drawing.Point(954, 9);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0;
            this.btnThoat.ShowActiveImage = true;
            this.btnThoat.ShowCursorChanges = true;
            this.btnThoat.ShowImageBorders = true;
            this.btnThoat.ShowSizeMarkers = false;
            this.btnThoat.Size = new System.Drawing.Size(35, 37);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.ToolTipText = "";
            this.btnThoat.WaitOnLoad = false;
            this.btnThoat.Zoom = 50;
            this.btnThoat.ZoomSpeed = 10;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // FrmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.myDonHang1);
            this.Controls.Add(this.donHang1);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.store1);
            this.Controls.Add(this.profile1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNguoiDung";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfile;
        private Bunifu.Framework.UI.BunifuFlatButton btnStore;
        private Bunifu.Framework.UI.BunifuFlatButton btnThanhToan;
        private Bunifu.Framework.UI.BunifuFlatButton btnGioHang;
        private Bunifu.Framework.UI.BunifuFlatButton btnDonHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDangxuat;
        private UserControls.DonHang donHang1;
        private UserControls.Cart cart1;
        private UserControls.Store store1;
        private UserControls.Profile profile1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuTransition bunifuTransition1;
        private UserControls.MyDonHang myDonHang1;
        private Bunifu.UI.WinForms.BunifuImageButton btnThoat;
    }
}