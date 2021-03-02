namespace DA_DBMS
{
    partial class Manager_NXB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWeb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtQuocgia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTruso = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TruSoChinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvNXB = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Location = new System.Drawing.Point(450, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 116);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.Chocolate;
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
            this.btnDelete.Location = new System.Drawing.Point(259, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHovercolor = System.Drawing.Color.Chocolate;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(114, 44);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Active = false;
            this.btnAdd.Activecolor = System.Drawing.Color.Chocolate;
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
            this.btnAdd.Location = new System.Drawing.Point(8, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHovercolor = System.Drawing.Color.Chocolate;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(114, 44);
            this.btnAdd.TabIndex = 46;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.Black;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Active = false;
            this.btnEdit.Activecolor = System.Drawing.Color.Chocolate;
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
            this.btnEdit.Location = new System.Drawing.Point(134, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHovercolor = System.Drawing.Color.Chocolate;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(114, 44);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.Black;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(6, 65);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(13, 20);
            this.txtMaNXB.TabIndex = 50;
            this.txtMaNXB.Visible = false;
            this.txtMaNXB.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Website:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quốc Gia";
            // 
            // Website
            // 
            this.Website.DataPropertyName = "Website";
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            // 
            // QuocGia
            // 
            this.QuocGia.DataPropertyName = "QuocGia";
            this.QuocGia.HeaderText = "Quốc Gia";
            this.QuocGia.Name = "QuocGia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Trụ Sở:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên NXB:";
            // 
            // txtWeb
            // 
            this.txtWeb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtWeb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.txtWeb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWeb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeb.Enabled = false;
            this.txtWeb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeb.ForeColor = System.Drawing.Color.Chocolate;
            this.txtWeb.HintForeColor = System.Drawing.Color.Empty;
            this.txtWeb.HintText = "";
            this.txtWeb.isPassword = false;
            this.txtWeb.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtWeb.LineIdleColor = System.Drawing.Color.Chocolate;
            this.txtWeb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtWeb.LineThickness = 3;
            this.txtWeb.Location = new System.Drawing.Point(145, 259);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeb.MaxLength = 32767;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(217, 31);
            this.txtWeb.TabIndex = 5;
            this.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtQuocgia
            // 
            this.txtQuocgia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuocgia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuocgia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.txtQuocgia.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtQuocgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuocgia.Enabled = false;
            this.txtQuocgia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuocgia.ForeColor = System.Drawing.Color.Chocolate;
            this.txtQuocgia.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuocgia.HintText = "";
            this.txtQuocgia.isPassword = false;
            this.txtQuocgia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuocgia.LineIdleColor = System.Drawing.Color.Chocolate;
            this.txtQuocgia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuocgia.LineThickness = 3;
            this.txtQuocgia.Location = new System.Drawing.Point(145, 184);
            this.txtQuocgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuocgia.MaxLength = 32767;
            this.txtQuocgia.Name = "txtQuocgia";
            this.txtQuocgia.Size = new System.Drawing.Size(217, 31);
            this.txtQuocgia.TabIndex = 4;
            this.txtQuocgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTruso
            // 
            this.txtTruso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTruso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTruso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.txtTruso.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTruso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTruso.Enabled = false;
            this.txtTruso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruso.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTruso.HintForeColor = System.Drawing.Color.Empty;
            this.txtTruso.HintText = "";
            this.txtTruso.isPassword = false;
            this.txtTruso.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTruso.LineIdleColor = System.Drawing.Color.Chocolate;
            this.txtTruso.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTruso.LineThickness = 3;
            this.txtTruso.Location = new System.Drawing.Point(144, 102);
            this.txtTruso.Margin = new System.Windows.Forms.Padding(4);
            this.txtTruso.MaxLength = 32767;
            this.txtTruso.Name = "txtTruso";
            this.txtTruso.Size = new System.Drawing.Size(217, 31);
            this.txtTruso.TabIndex = 3;
            this.txtTruso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTen
            // 
            this.txtTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.txtTen.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Chocolate;
            this.txtTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTen.HintText = "";
            this.txtTen.isPassword = false;
            this.txtTen.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTen.LineIdleColor = System.Drawing.Color.Chocolate;
            this.txtTen.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTen.LineThickness = 3;
            this.txtTen.Location = new System.Drawing.Point(145, 24);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.MaxLength = 32767;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(217, 31);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TruSoChinh
            // 
            this.TruSoChinh.DataPropertyName = "TruSoChinh";
            this.TruSoChinh.HeaderText = "Trụ Sở";
            this.TruSoChinh.Name = "TruSoChinh";
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.Name = "TenNXB";
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.txtMaNXB);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWeb);
            this.groupBox1.Controls.Add(this.txtQuocgia);
            this.groupBox1.Controls.Add(this.txtTruso);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Location = new System.Drawing.Point(450, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 422);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin NXB";
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
            this.btnSua.Location = new System.Drawing.Point(260, 339);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSua.OnHovercolor = System.Drawing.Color.Lime;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(102, 44);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Apply";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.Black;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(260, 339);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThem.OnHovercolor = System.Drawing.Color.Lime;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(102, 44);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Apply";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.Black;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // dgvNXB
            // 
            this.dgvNXB.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNXB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNXB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNXB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNXB.ColumnHeadersHeight = 40;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.TruSoChinh,
            this.QuocGia,
            this.Website});
            this.dgvNXB.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(217)))), ((int)(((byte)(198)))));
            this.dgvNXB.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNXB.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNXB.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            this.dgvNXB.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNXB.CurrentTheme.BackColor = System.Drawing.Color.Chocolate;
            this.dgvNXB.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgvNXB.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.dgvNXB.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNXB.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNXB.CurrentTheme.Name = null;
            this.dgvNXB.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            this.dgvNXB.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNXB.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNXB.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            this.dgvNXB.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(225)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(165)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNXB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNXB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNXB.EnableHeadersVisualStyles = false;
            this.dgvNXB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.dgvNXB.HeaderBackColor = System.Drawing.Color.Chocolate;
            this.dgvNXB.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNXB.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNXB.Location = new System.Drawing.Point(20, 32);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.RowTemplate.Height = 40;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(424, 544);
            this.dgvNXB.TabIndex = 50;
            this.dgvNXB.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Chocolate;
            this.dgvNXB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNXB_CellContentClick);
            // 
            // Manager_NXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNXB);
            this.Name = "Manager_NXB";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.Manager_NXB_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private System.Windows.Forms.TextBox txtMaNXB;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtWeb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuocgia;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTruso;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTen;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruSoChinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
    }
}
