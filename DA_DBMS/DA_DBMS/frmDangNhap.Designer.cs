namespace DA_DBMS
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMatKhau = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDangky = new System.Windows.Forms.LinkLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDangNhap = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThoat = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMatKhau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMatKhau.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.txtMatKhau.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.txtMatKhau.HintText = "";
            this.txtMatKhau.isPassword = true;
            this.txtMatKhau.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            this.txtMatKhau.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMatKhau.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            this.txtMatKhau.LineThickness = 3;
            this.txtMatKhau.Location = new System.Drawing.Point(397, 291);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(316, 33);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(397, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 33);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(394, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(394, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "PASSWORD";
            // 
            // lblDangky
            // 
            this.lblDangky.AutoSize = true;
            this.lblDangky.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.lblDangky.Location = new System.Drawing.Point(536, 407);
            this.lblDangky.Name = "lblDangky";
            this.lblDangky.Size = new System.Drawing.Size(202, 13);
            this.lblDangky.TabIndex = 4;
            this.lblDangky.TabStop = true;
            this.lblDangky.Text = "Bạn chưa có tài khoản? Đăng ký tại đây!";
            this.lblDangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblDangky_LinkClicked);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AllowToggling = false;
            this.btnDangNhap.AnimationSpeed = 200;
            this.btnDangNhap.AutoGenerateColors = false;
            this.btnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnDangNhap.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            this.btnDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.BackgroundImage")));
            this.btnDangNhap.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDangNhap.ButtonText = "Đăng Nhập";
            this.btnDangNhap.ButtonTextMarginLeft = 0;
            this.btnDangNhap.ColorContrastOnClick = 45;
            this.btnDangNhap.ColorContrastOnHover = 45;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDangNhap.CustomizableEdges = borderEdges1;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangNhap.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnDangNhap.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDangNhap.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDangNhap.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            this.btnDangNhap.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.IconMarginLeft = 11;
            this.btnDangNhap.IconPadding = 10;
            this.btnDangNhap.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            this.btnDangNhap.IdleBorderRadius = 3;
            this.btnDangNhap.IdleBorderThickness = 1;
            this.btnDangNhap.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            this.btnDangNhap.IdleIconLeftImage = null;
            this.btnDangNhap.IdleIconRightImage = null;
            this.btnDangNhap.IndicateFocus = false;
            this.btnDangNhap.Location = new System.Drawing.Point(397, 388);
            this.btnDangNhap.Name = "btnDangNhap";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            stateProperties1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnDangNhap.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(180)))), ((int)(((byte)(74)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(60)))), ((int)(((byte)(5)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(238)))), ((int)(((byte)(183)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnDangNhap.OnPressedState = stateProperties2;
            this.btnDangNhap.Size = new System.Drawing.Size(135, 41);
            this.btnDangNhap.TabIndex = 20;
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangNhap.TextMarginLeft = 0;
            this.btnDangNhap.UseDefaultRadiusAndThickness = true;
            this.btnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ActiveImage = null;
            this.btnThoat.AllowAnimations = true;
            this.btnThoat.AllowBuffering = false;
            this.btnThoat.AllowZooming = true;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ErrorImage")));
            this.btnThoat.FadeWhenInactive = false;
            this.btnThoat.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnThoat.Image = global::DA_DBMS.Properties.Resources.icons8_delete_sign_100px;
            this.btnThoat.ImageActive = null;
            this.btnThoat.ImageLocation = null;
            this.btnThoat.ImageMargin = 50;
            this.btnThoat.ImageSize = new System.Drawing.Size(-15, -13);
            this.btnThoat.ImageZoomSize = new System.Drawing.Size(35, 37);
            this.btnThoat.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.InitialImage")));
            this.btnThoat.Location = new System.Drawing.Point(720, 0);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Rotation = 0;
            this.btnThoat.ShowActiveImage = true;
            this.btnThoat.ShowCursorChanges = true;
            this.btnThoat.ShowImageBorders = true;
            this.btnThoat.ShowSizeMarkers = false;
            this.btnThoat.Size = new System.Drawing.Size(35, 37);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.ToolTipText = "";
            this.btnThoat.WaitOnLoad = false;
            this.btnThoat.Zoom = 50;
            this.btnThoat.ZoomSpeed = 10;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DA_DBMS.Properties.Resources.stylowi_pl_podroze_i_miejsca_google__20285447;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 587);
            this.panel1.TabIndex = 0;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(757, 587);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblDangky);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMatKhau;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.LinkLabel lblDangky;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuImageButton btnThoat;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDangNhap;
    }
}