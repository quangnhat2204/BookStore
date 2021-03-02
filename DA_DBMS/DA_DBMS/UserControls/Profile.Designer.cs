namespace DA_DBMS.UserControls
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvThongtin = new System.Windows.Forms.DataGridView();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.dptNgaysinh = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDoiMK = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSave = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtSex = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtSdt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDiaChi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtHoTen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.label6.Location = new System.Drawing.Point(3, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "PROFILE";
            // 
            // dgvThongtin
            // 
            this.dgvThongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtin.Location = new System.Drawing.Point(0, 232);
            this.dgvThongtin.Name = "dgvThongtin";
            this.dgvThongtin.Size = new System.Drawing.Size(22, 16);
            this.dgvThongtin.TabIndex = 22;
            this.dgvThongtin.Visible = false;
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackgroundImage = global::DA_DBMS.Properties.Resources.images;
            this.pbxAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxAvatar.Location = new System.Drawing.Point(625, 87);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(142, 146);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 23;
            this.pbxAvatar.TabStop = false;
            // 
            // dptNgaysinh
            // 
            this.dptNgaysinh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dptNgaysinh.BorderRadius = 5;
            this.dptNgaysinh.Color = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.dptNgaysinh.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dptNgaysinh.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dptNgaysinh.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.dptNgaysinh.DisplayWeekNumbers = false;
            this.dptNgaysinh.DPHeight = 0;
            this.dptNgaysinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dptNgaysinh.Enabled = false;
            this.dptNgaysinh.FillDatePicker = false;
            this.dptNgaysinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptNgaysinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.dptNgaysinh.Icon = ((System.Drawing.Image)(resources.GetObject("dptNgaysinh.Icon")));
            this.dptNgaysinh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.dptNgaysinh.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dptNgaysinh.Location = new System.Drawing.Point(9, 325);
            this.dptNgaysinh.MinimumSize = new System.Drawing.Size(252, 44);
            this.dptNgaysinh.Name = "dptNgaysinh";
            this.dptNgaysinh.Size = new System.Drawing.Size(252, 44);
            this.dptNgaysinh.TabIndex = 5;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 87);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(261, 16);
            this.bunifuSeparator1.TabIndex = 30;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Active = true;
            this.btnOpenFile.Activecolor = System.Drawing.Color.Gray;
            this.btnOpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.BorderRadius = 0;
            this.btnOpenFile.ButtonText = "Thay đổi ảnh";
            this.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFile.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpenFile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Iconimage")));
            this.btnOpenFile.Iconimage_right = null;
            this.btnOpenFile.Iconimage_right_Selected = null;
            this.btnOpenFile.Iconimage_Selected = null;
            this.btnOpenFile.IconMarginLeft = 0;
            this.btnOpenFile.IconMarginRight = 0;
            this.btnOpenFile.IconRightVisible = true;
            this.btnOpenFile.IconRightZoom = 0D;
            this.btnOpenFile.IconVisible = true;
            this.btnOpenFile.IconZoom = 90D;
            this.btnOpenFile.IsTab = false;
            this.btnOpenFile.Location = new System.Drawing.Point(625, 208);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOpenFile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnOpenFile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpenFile.selected = true;
            this.btnOpenFile.Size = new System.Drawing.Size(142, 26);
            this.btnOpenFile.TabIndex = 33;
            this.btnOpenFile.Text = "Thay đổi ảnh";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Textcolor = System.Drawing.Color.DimGray;
            this.btnOpenFile.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Visible = false;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.AllowToggling = false;
            this.btnEdit.AnimationSpeed = 200;
            this.btnEdit.AutoGenerateColors = false;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.ButtonTextMarginLeft = 0;
            this.btnEdit.ColorContrastOnClick = 45;
            this.btnEdit.ColorContrastOnHover = 45;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnEdit.CustomizableEdges = borderEdges3;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnEdit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEdit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.IconMarginLeft = 11;
            this.btnEdit.IconPadding = 10;
            this.btnEdit.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.IdleBorderColor = System.Drawing.Color.Aqua;
            this.btnEdit.IdleBorderRadius = 30;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnEdit.IdleIconLeftImage = null;
            this.btnEdit.IdleIconRightImage = null;
            this.btnEdit.IndicateFocus = false;
            this.btnEdit.Location = new System.Drawing.Point(625, 258);
            this.btnEdit.Name = "btnEdit";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 30;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnEdit.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 30;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnEdit.OnPressedState = stateProperties6;
            this.btnEdit.Size = new System.Drawing.Size(142, 38);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.TextMarginLeft = 0;
            this.btnEdit.UseDefaultRadiusAndThickness = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click_1);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.AllowToggling = false;
            this.btnDoiMK.AnimationSpeed = 200;
            this.btnDoiMK.AutoGenerateColors = false;
            this.btnDoiMK.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMK.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnDoiMK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.BackgroundImage")));
            this.btnDoiMK.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDoiMK.ButtonText = "Đổi Mật Khẩu";
            this.btnDoiMK.ButtonTextMarginLeft = 0;
            this.btnDoiMK.ColorContrastOnClick = 45;
            this.btnDoiMK.ColorContrastOnHover = 45;
            this.btnDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDoiMK.CustomizableEdges = borderEdges2;
            this.btnDoiMK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoiMK.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnDoiMK.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDoiMK.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDoiMK.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnDoiMK.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoiMK.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.IconMarginLeft = 11;
            this.btnDoiMK.IconPadding = 10;
            this.btnDoiMK.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.IdleBorderColor = System.Drawing.Color.Aqua;
            this.btnDoiMK.IdleBorderRadius = 30;
            this.btnDoiMK.IdleBorderThickness = 1;
            this.btnDoiMK.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnDoiMK.IdleIconLeftImage = null;
            this.btnDoiMK.IdleIconRightImage = null;
            this.btnDoiMK.IndicateFocus = false;
            this.btnDoiMK.Location = new System.Drawing.Point(625, 302);
            this.btnDoiMK.Name = "btnDoiMK";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 30;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnDoiMK.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 30;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnDoiMK.OnPressedState = stateProperties4;
            this.btnDoiMK.Size = new System.Drawing.Size(142, 38);
            this.btnDoiMK.TabIndex = 8;
            this.btnDoiMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoiMK.TextMarginLeft = 0;
            this.btnDoiMK.UseDefaultRadiusAndThickness = true;
            this.btnDoiMK.Click += new System.EventHandler(this.BtnDoiMK_Click);
            // 
            // btnSave
            // 
            this.btnSave.AllowToggling = false;
            this.btnSave.AnimationSpeed = 200;
            this.btnSave.AutoGenerateColors = false;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSave.ButtonText = "Lưu";
            this.btnSave.ButtonTextMarginLeft = 0;
            this.btnSave.ColorContrastOnClick = 45;
            this.btnSave.ColorContrastOnHover = 45;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSave.CustomizableEdges = borderEdges1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnSave.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSave.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IconMarginLeft = 11;
            this.btnSave.IconPadding = 10;
            this.btnSave.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.IdleBorderColor = System.Drawing.Color.Aqua;
            this.btnSave.IdleBorderRadius = 30;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.btnSave.IdleIconLeftImage = null;
            this.btnSave.IdleIconRightImage = null;
            this.btnSave.IndicateFocus = false;
            this.btnSave.Location = new System.Drawing.Point(625, 258);
            this.btnSave.Name = "btnSave";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnSave.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSave.OnPressedState = stateProperties2;
            this.btnSave.Size = new System.Drawing.Size(142, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextMarginLeft = 0;
            this.btnSave.UseDefaultRadiusAndThickness = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSex.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSex.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtSex.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSex.BorderThickness = 3;
            this.txtSex.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.Enabled = false;
            this.txtSex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtSex.isPassword = false;
            this.txtSex.Location = new System.Drawing.Point(9, 271);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSex.MaxLength = 32767;
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(252, 44);
            this.txtSex.TabIndex = 37;
            this.txtSex.Text = "Giới tính";
            this.txtSex.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSdt
            // 
            this.txtSdt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSdt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSdt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtSdt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSdt.BorderThickness = 3;
            this.txtSdt.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.Enabled = false;
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtSdt.isPassword = false;
            this.txtSdt.Location = new System.Drawing.Point(9, 217);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSdt.MaxLength = 32767;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(252, 44);
            this.txtSdt.TabIndex = 36;
            this.txtSdt.Tag = "";
            this.txtSdt.Text = "SĐT";
            this.txtSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDiaChi.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtDiaChi.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.BorderThickness = 3;
            this.txtDiaChi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtDiaChi.isPassword = false;
            this.txtDiaChi.Location = new System.Drawing.Point(9, 163);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.MaxLength = 32767;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(252, 44);
            this.txtDiaChi.TabIndex = 35;
            this.txtDiaChi.Text = "Địa chỉ";
            this.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtHoTen.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtHoTen.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.BorderThickness = 3;
            this.txtHoTen.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.txtHoTen.isPassword = false;
            this.txtHoTen.Location = new System.Drawing.Point(9, 110);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.MaxLength = 32767;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(252, 44);
            this.txtHoTen.TabIndex = 34;
            this.txtHoTen.Text = "Họ và Tên";
            this.txtHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.dptNgaysinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.dgvThongtin);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(65)))), ((int)(((byte)(154)))));
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(790, 600);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.DataGridView dgvThongtin;
        private Bunifu.UI.WinForms.BunifuDatePicker dptNgaysinh;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpenFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDoiMK;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEdit;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSex;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSdt;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDiaChi;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHoTen;
    }
}
