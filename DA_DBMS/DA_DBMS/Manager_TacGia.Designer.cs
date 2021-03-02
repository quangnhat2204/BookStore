namespace DA_DBMS
{
    partial class Manager_TacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_TacGia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCongviec = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuoctich = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.dptNgaysinh = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueQuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTacGia = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Active = false;
            this.btnSua.Activecolor = System.Drawing.Color.Lime;
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 7;
            this.btnSua.ButtonText = "Apply";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = global::DA_DBMS.Properties.Resources.icons8_checkmark_64px;
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
            this.btnSua.Location = new System.Drawing.Point(640, 188);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSua.OnHovercolor = System.Drawing.Color.Lime;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(98, 37);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Apply";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.Black;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtCongviec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQuoctich);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dptNgaysinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Tác giả";
            // 
            // btnThem
            // 
            this.btnThem.Active = false;
            this.btnThem.Activecolor = System.Drawing.Color.Lime;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 7;
            this.btnThem.ButtonText = "Apply";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = global::DA_DBMS.Properties.Resources.icons8_checkmark_64px;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 90D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(640, 188);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThem.OnHovercolor = System.Drawing.Color.Lime;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(98, 37);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Apply";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.Black;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // txtCongviec
            // 
            this.txtCongviec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCongviec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCongviec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.txtCongviec.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCongviec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCongviec.Enabled = false;
            this.txtCongviec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongviec.ForeColor = System.Drawing.Color.Purple;
            this.txtCongviec.HintForeColor = System.Drawing.Color.Empty;
            this.txtCongviec.HintText = "";
            this.txtCongviec.isPassword = false;
            this.txtCongviec.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCongviec.LineIdleColor = System.Drawing.Color.Purple;
            this.txtCongviec.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCongviec.LineThickness = 3;
            this.txtCongviec.Location = new System.Drawing.Point(521, 107);
            this.txtCongviec.Margin = new System.Windows.Forms.Padding(4);
            this.txtCongviec.MaxLength = 32767;
            this.txtCongviec.Name = "txtCongviec";
            this.txtCongviec.Size = new System.Drawing.Size(217, 31);
            this.txtCongviec.TabIndex = 5;
            this.txtCongviec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Công Việc:";
            // 
            // txtQuoctich
            // 
            this.txtQuoctich.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuoctich.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuoctich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.txtQuoctich.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuoctich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuoctich.Enabled = false;
            this.txtQuoctich.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuoctich.ForeColor = System.Drawing.Color.Purple;
            this.txtQuoctich.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuoctich.HintText = "";
            this.txtQuoctich.isPassword = false;
            this.txtQuoctich.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuoctich.LineIdleColor = System.Drawing.Color.Purple;
            this.txtQuoctich.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuoctich.LineThickness = 3;
            this.txtQuoctich.Location = new System.Drawing.Point(121, 194);
            this.txtQuoctich.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuoctich.MaxLength = 32767;
            this.txtQuoctich.Name = "txtQuoctich";
            this.txtQuoctich.Size = new System.Drawing.Size(217, 31);
            this.txtQuoctich.TabIndex = 3;
            this.txtQuoctich.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quốc Tịch:";
            // 
            // dptNgaysinh
            // 
            this.dptNgaysinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dptNgaysinh.BorderRadius = 1;
            this.dptNgaysinh.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dptNgaysinh.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dptNgaysinh.DisabledColor = System.Drawing.Color.Purple;
            this.dptNgaysinh.DisplayWeekNumbers = false;
            this.dptNgaysinh.DPHeight = 0;
            this.dptNgaysinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dptNgaysinh.Enabled = false;
            this.dptNgaysinh.FillDatePicker = false;
            this.dptNgaysinh.ForeColor = System.Drawing.Color.Purple;
            this.dptNgaysinh.Icon = ((System.Drawing.Image)(resources.GetObject("dptNgaysinh.Icon")));
            this.dptNgaysinh.IconColor = System.Drawing.Color.Purple;
            this.dptNgaysinh.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dptNgaysinh.Location = new System.Drawing.Point(521, 23);
            this.dptNgaysinh.MinimumSize = new System.Drawing.Size(217, 32);
            this.dptNgaysinh.Name = "dptNgaysinh";
            this.dptNgaysinh.Size = new System.Drawing.Size(217, 32);
            this.dptNgaysinh.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Sinh:";
            // 
            // txtQue
            // 
            this.txtQue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.txtQue.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQue.Enabled = false;
            this.txtQue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQue.ForeColor = System.Drawing.Color.Purple;
            this.txtQue.HintForeColor = System.Drawing.Color.Empty;
            this.txtQue.HintText = "";
            this.txtQue.isPassword = false;
            this.txtQue.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQue.LineIdleColor = System.Drawing.Color.Purple;
            this.txtQue.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQue.LineThickness = 3;
            this.txtQue.Location = new System.Drawing.Point(121, 107);
            this.txtQue.Margin = new System.Windows.Forms.Padding(4);
            this.txtQue.MaxLength = 32767;
            this.txtQue.Name = "txtQue";
            this.txtQue.Size = new System.Drawing.Size(217, 31);
            this.txtQue.TabIndex = 2;
            this.txtQue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quê Quán:";
            // 
            // txtTen
            // 
            this.txtTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.txtTen.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Purple;
            this.txtTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTen.HintText = "";
            this.txtTen.isPassword = false;
            this.txtTen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTen.LineIdleColor = System.Drawing.Color.Purple;
            this.txtTen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTen.LineThickness = 3;
            this.txtTen.Location = new System.Drawing.Point(121, 18);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(217, 31);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ Tên TG:";
            // 
            // txtMatg
            // 
            this.txtMatg.Location = new System.Drawing.Point(3, 106);
            this.txtMatg.Name = "txtMatg";
            this.txtMatg.Size = new System.Drawing.Size(10, 20);
            this.txtMatg.TabIndex = 9;
            this.txtMatg.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(572, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 271);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.Purple;
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
            this.btnDelete.Location = new System.Drawing.Point(53, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Purple;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(153, 44);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Active = false;
            this.btnEdit.Activecolor = System.Drawing.Color.Purple;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 7;
            this.btnEdit.ButtonText = "Sửa";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = global::DA_DBMS.Properties.Resources.icons8_edit_64px;
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 90D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(53, 118);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHovercolor = System.Drawing.Color.Purple;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(153, 44);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.Black;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Active = false;
            this.btnAdd.Activecolor = System.Drawing.Color.Purple;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 7;
            this.btnAdd.ButtonText = "Thêm mới";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = global::DA_DBMS.Properties.Resources.icons8_add_64px;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(53, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Purple;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(153, 44);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.Black;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.Name = "QuocTich";
            // 
            // CongViec
            // 
            this.CongViec.DataPropertyName = "CongViec";
            this.CongViec.HeaderText = "Công việc";
            this.CongViec.Name = "CongViec";
            // 
            // QueQuan
            // 
            this.QueQuan.DataPropertyName = "QueQuan";
            this.QueQuan.HeaderText = "Quê quán";
            this.QueQuan.Name = "QueQuan";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Họ Tên";
            this.TenTacGia.Name = "TenTacGia";
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "ID";
            this.MaTacGia.Name = "MaTacGia";
            // 
            // dgvTacGia
            // 
            this.dgvTacGia.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTacGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTacGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTacGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTacGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTacGia.ColumnHeadersHeight = 40;
            this.dgvTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.TenTacGia,
            this.NgaySinh,
            this.QueQuan,
            this.CongViec,
            this.QuocTich});
            this.dgvTacGia.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.dgvTacGia.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTacGia.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTacGia.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvTacGia.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTacGia.CurrentTheme.BackColor = System.Drawing.Color.Purple;
            this.dgvTacGia.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvTacGia.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Purple;
            this.dgvTacGia.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvTacGia.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTacGia.CurrentTheme.Name = null;
            this.dgvTacGia.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.dgvTacGia.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvTacGia.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTacGia.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.dgvTacGia.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTacGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTacGia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTacGia.EnableHeadersVisualStyles = false;
            this.dgvTacGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.dgvTacGia.HeaderBackColor = System.Drawing.Color.Purple;
            this.dgvTacGia.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvTacGia.HeaderForeColor = System.Drawing.Color.White;
            this.dgvTacGia.Location = new System.Drawing.Point(22, 307);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.RowTemplate.Height = 40;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(544, 271);
            this.dgvTacGia.TabIndex = 6;
            this.dgvTacGia.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Purple;
            this.dgvTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTacGia_CellContentClick);
            // 
            // Manager_TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMatg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTacGia);
            this.Name = "Manager_TacGia";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.Manager_TacGia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCongviec;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuoctich;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDatePicker dptNgaysinh;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQue;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatg;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueQuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
    }
}
