namespace DA_DBMS.UserControls
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dgvGiohang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTien = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbDongia = new System.Windows.Forms.Label();
            this.lbSach = new System.Windows.Forms.Label();
            this.txtSoluong = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiohang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGiohang
            // 
            this.dgvGiohang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvGiohang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGiohang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiohang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiohang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvGiohang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGiohang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGiohang.ColumnHeadersHeight = 40;
            this.dgvGiohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.Soluong,
            this.Tongtien});
            this.dgvGiohang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvGiohang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvGiohang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGiohang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvGiohang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGiohang.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgvGiohang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvGiohang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvGiohang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvGiohang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvGiohang.CurrentTheme.Name = null;
            this.dgvGiohang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvGiohang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvGiohang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvGiohang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvGiohang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiohang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGiohang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGiohang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGiohang.EnableHeadersVisualStyles = false;
            this.dgvGiohang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvGiohang.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgvGiohang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvGiohang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvGiohang.Location = new System.Drawing.Point(0, 331);
            this.dgvGiohang.Name = "dgvGiohang";
            this.dgvGiohang.RowHeadersVisible = false;
            this.dgvGiohang.RowTemplate.Height = 40;
            this.dgvGiohang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiohang.Size = new System.Drawing.Size(574, 269);
            this.dgvGiohang.TabIndex = 13;
            this.dgvGiohang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.dgvGiohang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGiohang_CellContentClick);
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
            // Soluong
            // 
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            // 
            // Tongtien
            // 
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Đơn Giá";
            this.Tongtien.Name = "Tongtien";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DA_DBMS.Properties.Resources.pngtree_color_h5_ad_background_image_37670;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(574, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 600);
            this.panel1.TabIndex = 7;
            // 
            // txtTien
            // 
            this.txtTien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTien.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTien.Enabled = false;
            this.txtTien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTien.HintForeColor = System.Drawing.Color.Empty;
            this.txtTien.HintText = "";
            this.txtTien.isPassword = false;
            this.txtTien.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTien.LineIdleColor = System.Drawing.Color.Black;
            this.txtTien.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTien.LineThickness = 4;
            this.txtTien.Location = new System.Drawing.Point(18, 198);
            this.txtTien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTien.MaxLength = 32767;
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(182, 31);
            this.txtTien.TabIndex = 8;
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::DA_DBMS.Properties.Resources.hinh_nen_slide_thuyet_trinh_dep_30_1024x640;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.lbDongia);
            this.panel2.Controls.Add(this.lbSach);
            this.panel2.Controls.Add(this.txtSoluong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 331);
            this.panel2.TabIndex = 14;
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
            this.bunifuImageButton1.TabIndex = 31;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(179, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Giá bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Tên Sản phẩm:";
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.Red;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.ButtonText = "Xóa Sản phẩm";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::DA_DBMS.Properties.Resources.icons8_delete_64px;
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
            this.btnDelete.Location = new System.Drawing.Point(424, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Red;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(147, 54);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa Sản phẩm";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Yellow;
            this.btnDelete.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = global::DA_DBMS.Properties.Resources.icons8_connection_sync_64px_1;
            this.btnReload.ImageActive = null;
            this.btnReload.Location = new System.Drawing.Point(289, 151);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(37, 35);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 30;
            this.btnReload.TabStop = false;
            this.btnReload.Zoom = 10;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click_1);
            // 
            // lbDongia
            // 
            this.lbDongia.AutoSize = true;
            this.lbDongia.BackColor = System.Drawing.Color.Transparent;
            this.lbDongia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongia.ForeColor = System.Drawing.Color.Black;
            this.lbDongia.Location = new System.Drawing.Point(337, 85);
            this.lbDongia.Name = "lbDongia";
            this.lbDongia.Size = new System.Drawing.Size(68, 21);
            this.lbDongia.TabIndex = 29;
            this.lbDongia.Text = "Giá bán";
            // 
            // lbSach
            // 
            this.lbSach.AutoSize = true;
            this.lbSach.BackColor = System.Drawing.Color.Transparent;
            this.lbSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSach.ForeColor = System.Drawing.Color.Black;
            this.lbSach.Location = new System.Drawing.Point(337, 17);
            this.lbSach.Name = "lbSach";
            this.lbSach.Size = new System.Drawing.Size(60, 21);
            this.lbSach.TabIndex = 28;
            this.lbSach.Text = "Tên SP";
            // 
            // txtSoluong
            // 
            this.txtSoluong.AcceptsReturn = false;
            this.txtSoluong.AcceptsTab = false;
            this.txtSoluong.AnimationSpeed = 200;
            this.txtSoluong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSoluong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSoluong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoluong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSoluong.BackgroundImage")));
            this.txtSoluong.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSoluong.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSoluong.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSoluong.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSoluong.BorderRadius = 10;
            this.txtSoluong.BorderThickness = 1;
            this.txtSoluong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSoluong.DefaultText = "";
            this.txtSoluong.FillColor = System.Drawing.Color.White;
            this.txtSoluong.HideSelection = true;
            this.txtSoluong.IconLeft = null;
            this.txtSoluong.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.IconPadding = 10;
            this.txtSoluong.IconRight = null;
            this.txtSoluong.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoluong.Lines = new string[0];
            this.txtSoluong.Location = new System.Drawing.Point(183, 151);
            this.txtSoluong.MaxLength = 32767;
            this.txtSoluong.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSoluong.Modified = false;
            this.txtSoluong.Multiline = false;
            this.txtSoluong.Name = "txtSoluong";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSoluong.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSoluong.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSoluong.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSoluong.OnIdleState = stateProperties4;
            this.txtSoluong.PasswordChar = '\0';
            this.txtSoluong.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSoluong.PlaceholderText = "Số lượng";
            this.txtSoluong.ReadOnly = false;
            this.txtSoluong.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoluong.SelectedText = "";
            this.txtSoluong.SelectionLength = 0;
            this.txtSoluong.SelectionStart = 0;
            this.txtSoluong.ShortcutsEnabled = true;
            this.txtSoluong.Size = new System.Drawing.Size(100, 35);
            this.txtSoluong.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSoluong.TabIndex = 27;
            this.txtSoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoluong.TextMarginBottom = 0;
            this.txtSoluong.TextMarginLeft = 5;
            this.txtSoluong.TextMarginTop = 0;
            this.txtSoluong.TextPlaceholder = "Số lượng";
            this.txtSoluong.UseSystemPasswordChar = false;
            this.txtSoluong.WordWrap = true;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvGiohang);
            this.Controls.Add(this.panel1);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(790, 600);
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiohang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTien;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvGiohang;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnReload;
        private System.Windows.Forms.Label lbDongia;
        private System.Windows.Forms.Label lbSach;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSoluong;
    }
}
