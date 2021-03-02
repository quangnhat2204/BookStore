namespace DA_DBMS
{
    partial class Manager_NCC
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
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtWebsiteNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT_NCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNCC = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.DodgerBlue;
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
            this.btnDelete.Location = new System.Drawing.Point(3, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDelete.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(137, 44);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Active = false;
            this.btnAdd.Activecolor = System.Drawing.Color.DodgerBlue;
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
            this.btnAdd.Location = new System.Drawing.Point(3, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(137, 44);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.Black;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.btnSua.Location = new System.Drawing.Point(543, 225);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSua.OnHovercolor = System.Drawing.Color.Lime;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(98, 37);
            this.btnSua.TabIndex = 49;
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
            this.btnThem.Location = new System.Drawing.Point(543, 225);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.Transparent;
            this.btnThem.OnHovercolor = System.Drawing.Color.Lime;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(98, 37);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Apply";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.Black;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.Active = false;
            this.btnEdit.Activecolor = System.Drawing.Color.DodgerBlue;
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
            this.btnEdit.Location = new System.Drawing.Point(3, 225);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(137, 44);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.Black;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Location = new System.Drawing.Point(6, 171);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(8, 20);
            this.txtMaNCC.TabIndex = 50;
            this.txtMaNCC.Visible = false;
            this.txtMaNCC.WordWrap = false;
            // 
            // txtWebsiteNCC
            // 
            this.txtWebsiteNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtWebsiteNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtWebsiteNCC.BackColor = System.Drawing.Color.White;
            this.txtWebsiteNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWebsiteNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWebsiteNCC.Enabled = false;
            this.txtWebsiteNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsiteNCC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtWebsiteNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtWebsiteNCC.HintText = "";
            this.txtWebsiteNCC.isPassword = false;
            this.txtWebsiteNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtWebsiteNCC.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtWebsiteNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtWebsiteNCC.LineThickness = 3;
            this.txtWebsiteNCC.Location = new System.Drawing.Point(464, 114);
            this.txtWebsiteNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsiteNCC.MaxLength = 32767;
            this.txtWebsiteNCC.Name = "txtWebsiteNCC";
            this.txtWebsiteNCC.Size = new System.Drawing.Size(177, 31);
            this.txtWebsiteNCC.TabIndex = 5;
            this.txtWebsiteNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Website:";
            // 
            // txtSDT_NCC
            // 
            this.txtSDT_NCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSDT_NCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSDT_NCC.BackColor = System.Drawing.Color.White;
            this.txtSDT_NCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSDT_NCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT_NCC.Enabled = false;
            this.txtSDT_NCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT_NCC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtSDT_NCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtSDT_NCC.HintText = "";
            this.txtSDT_NCC.isPassword = false;
            this.txtSDT_NCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSDT_NCC.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtSDT_NCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSDT_NCC.LineThickness = 3;
            this.txtSDT_NCC.Location = new System.Drawing.Point(464, 20);
            this.txtSDT_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT_NCC.MaxLength = 32767;
            this.txtSDT_NCC.Name = "txtSDT_NCC";
            this.txtSDT_NCC.Size = new System.Drawing.Size(177, 31);
            this.txtSDT_NCC.TabIndex = 4;
            this.txtSDT_NCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Website
            // 
            this.Website.DataPropertyName = "Website";
            this.Website.HeaderText = "Website";
            this.Website.Name = "Website";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // SDT_NCC
            // 
            this.SDT_NCC.DataPropertyName = "SDT_NCC";
            this.SDT_NCC.HeaderText = "SĐT";
            this.SDT_NCC.Name = "SDT_NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "SĐT:";
            // 
            // txtEmailNCC
            // 
            this.txtEmailNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmailNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmailNCC.BackColor = System.Drawing.Color.White;
            this.txtEmailNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmailNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailNCC.Enabled = false;
            this.txtEmailNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNCC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtEmailNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmailNCC.HintText = "";
            this.txtEmailNCC.isPassword = false;
            this.txtEmailNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmailNCC.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtEmailNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmailNCC.LineThickness = 3;
            this.txtEmailNCC.Location = new System.Drawing.Point(115, 210);
            this.txtEmailNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailNCC.MaxLength = 32767;
            this.txtEmailNCC.Name = "txtEmailNCC";
            this.txtEmailNCC.Size = new System.Drawing.Size(177, 31);
            this.txtEmailNCC.TabIndex = 3;
            this.txtEmailNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email:";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiaChiNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiaChiNCC.BackColor = System.Drawing.Color.White;
            this.txtDiaChiNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDiaChiNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChiNCC.Enabled = false;
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtDiaChiNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtDiaChiNCC.HintText = "";
            this.txtDiaChiNCC.isPassword = false;
            this.txtDiaChiNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDiaChiNCC.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtDiaChiNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDiaChiNCC.LineThickness = 3;
            this.txtDiaChiNCC.Location = new System.Drawing.Point(115, 114);
            this.txtDiaChiNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChiNCC.MaxLength = 32767;
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(177, 31);
            this.txtDiaChiNCC.TabIndex = 2;
            this.txtDiaChiNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Địa Chỉ:";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenNCC.BackColor = System.Drawing.Color.White;
            this.txtTenNCC.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.Enabled = false;
            this.txtTenNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTenNCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenNCC.HintText = "";
            this.txtTenNCC.isPassword = false;
            this.txtTenNCC.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTenNCC.LineIdleColor = System.Drawing.Color.DodgerBlue;
            this.txtTenNCC.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTenNCC.LineThickness = 3;
            this.txtTenNCC.Location = new System.Drawing.Point(115, 20);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.MaxLength = 32767;
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(177, 31);
            this.txtTenNCC.TabIndex = 1;
            this.txtTenNCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên NCC:";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên NCC";
            this.TenNCC.Name = "TenNCC";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtMaNCC);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtWebsiteNCC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSDT_NCC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtEmailNCC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiaChiNCC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTenNCC);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(169, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 282);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin NCC";
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.ColumnHeadersHeight = 40;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SDT_NCC,
            this.Email,
            this.Website});
            this.dgvNCC.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNCC.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNCC.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNCC.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNCC.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNCC.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNCC.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNCC.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNCC.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNCC.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNCC.CurrentTheme.Name = null;
            this.dgvNCC.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNCC.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNCC.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNCC.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNCC.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNCC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNCC.EnableHeadersVisualStyles = false;
            this.dgvNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNCC.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNCC.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNCC.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNCC.Location = new System.Drawing.Point(169, 320);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersVisible = false;
            this.dgvNCC.RowTemplate.Height = 40;
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(661, 257);
            this.dgvNCC.TabIndex = 4;
            this.dgvNCC.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNCC_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(20, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 545);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // Manager_NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manager_NCC";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.Manager_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaNCC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtWebsiteNCC;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSDT_NCC;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailNCC;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDiaChiNCC;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenNCC;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
    }
}
