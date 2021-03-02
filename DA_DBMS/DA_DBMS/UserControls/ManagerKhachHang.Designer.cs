namespace DA_DBMS.UserControls
{
    partial class ManagerKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerKhachHang));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQuyen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKH = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(0, 212);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(21, 20);
            this.txtMaKH.TabIndex = 53;
            this.txtMaKH.Visible = false;
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.Enabled = false;
            this.cbbQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cbbQuyen.Location = new System.Drawing.Point(442, 50);
            this.cbbQuyen.MaximumSize = new System.Drawing.Size(121, 0);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(120, 21);
            this.cbbQuyen.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cbbQuyen);
            this.groupBox1.Controls.Add(this.btnQuyen);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(20, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // btnLuu
            // 
            this.btnLuu.Active = false;
            this.btnLuu.Activecolor = System.Drawing.Color.Teal;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 7;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = global::DA_DBMS.Properties.Resources.icons8_save_64px;
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 90D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(575, 36);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLuu.OnHovercolor = System.Drawing.Color.Teal;
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(113, 35);
            this.btnLuu.TabIndex = 50;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.Black;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.Teal;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.ButtonText = "Xóa";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::DA_DBMS.Properties.Resources.icons8_delete_file_64px;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(706, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Teal;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(79, 35);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnQuyen
            // 
            this.btnQuyen.Active = false;
            this.btnQuyen.Activecolor = System.Drawing.Color.Teal;
            this.btnQuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnQuyen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuyen.BorderRadius = 7;
            this.btnQuyen.ButtonText = "Cấp quyền";
            this.btnQuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuyen.DisabledColor = System.Drawing.Color.Gray;
            this.btnQuyen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuyen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuyen.Iconimage")));
            this.btnQuyen.Iconimage_right = null;
            this.btnQuyen.Iconimage_right_Selected = null;
            this.btnQuyen.Iconimage_Selected = null;
            this.btnQuyen.IconMarginLeft = 0;
            this.btnQuyen.IconMarginRight = 0;
            this.btnQuyen.IconRightVisible = true;
            this.btnQuyen.IconRightZoom = 0D;
            this.btnQuyen.IconVisible = true;
            this.btnQuyen.IconZoom = 90D;
            this.btnQuyen.IsTab = false;
            this.btnQuyen.Location = new System.Drawing.Point(575, 36);
            this.btnQuyen.Name = "btnQuyen";
            this.btnQuyen.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuyen.OnHovercolor = System.Drawing.Color.Teal;
            this.btnQuyen.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnQuyen.selected = false;
            this.btnQuyen.Size = new System.Drawing.Size(113, 35);
            this.btnQuyen.TabIndex = 50;
            this.btnQuyen.Text = "Cấp quyền";
            this.btnQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuyen.Textcolor = System.Drawing.Color.Black;
            this.btnQuyen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuyen.Click += new System.EventHandler(this.BtnQuyen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::DA_DBMS.Properties.Resources.icons8_search_64px;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(223, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 14;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 30;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(17, 39);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Nhập Tên KH ...";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(200, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Nhập Tên KH ...";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // Avatar
            // 
            this.Avatar.DataPropertyName = "Avatar";
            this.Avatar.HeaderText = "Avatar";
            this.Avatar.Name = "Avatar";
            this.Avatar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "Quyen";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.Name = "Quyen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Sex";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.HeaderText = "PassWord";
            this.Pass.Name = "Pass";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Họ Tên";
            this.TenKH.Name = "TenKH";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // dgvKH
            // 
            this.dgvKH.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.ColumnHeadersHeight = 40;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.Email,
            this.Pass,
            this.UserName,
            this.DiaChi,
            this.SDT,
            this.GioiTinh,
            this.NgaySinh,
            this.Quyen,
            this.Avatar});
            this.dgvKH.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvKH.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvKH.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKH.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvKH.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvKH.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgvKH.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvKH.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvKH.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvKH.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKH.CurrentTheme.Name = null;
            this.dgvKH.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvKH.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvKH.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKH.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvKH.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvKH.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgvKH.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvKH.HeaderForeColor = System.Drawing.Color.White;
            this.dgvKH.Location = new System.Drawing.Point(20, 135);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.RowTemplate.Height = 40;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(810, 441);
            this.dgvKH.TabIndex = 2;
            this.dgvKH.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKH_CellContentClick);
            // 
            // ManagerKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKH);
            this.Name = "ManagerKhachHang";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.ManagerKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaKH;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuyen;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvKH;
    }
}
