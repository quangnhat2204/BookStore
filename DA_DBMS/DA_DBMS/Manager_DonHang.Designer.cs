namespace DA_DBMS
{
    partial class Manager_DonHang
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
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMadh = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.GroupBox();
            this.txtNgaydat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbbTinhtrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenKH = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDonhang = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1.SuspendLayout();
            this.txt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Active = false;
            this.btnEdit.Activecolor = System.Drawing.Color.Crimson;
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
            this.btnEdit.Location = new System.Drawing.Point(117, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(120, 50);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.Black;
            this.btnEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Location = new System.Drawing.Point(20, 431);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 142);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Active = false;
            this.btnLuu.Activecolor = System.Drawing.Color.Crimson;
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
            this.btnLuu.Location = new System.Drawing.Point(117, 47);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLuu.OnHovercolor = System.Drawing.Color.Crimson;
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(120, 50);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLuu.Textcolor = System.Drawing.Color.Black;
            this.btnLuu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // txtMadh
            // 
            this.txtMadh.Location = new System.Drawing.Point(6, 367);
            this.txtMadh.Name = "txtMadh";
            this.txtMadh.Size = new System.Drawing.Size(10, 20);
            this.txtMadh.TabIndex = 50;
            this.txtMadh.Visible = false;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.txt.Controls.Add(this.txtMadh);
            this.txt.Controls.Add(this.txtNgaydat);
            this.txt.Controls.Add(this.cbbTinhtrang);
            this.txt.Controls.Add(this.label4);
            this.txt.Controls.Add(this.label3);
            this.txt.Controls.Add(this.txtPhi);
            this.txt.Controls.Add(this.label2);
            this.txt.Controls.Add(this.txtTenKH);
            this.txt.Controls.Add(this.label1);
            this.txt.Location = new System.Drawing.Point(20, 32);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(347, 393);
            this.txt.TabIndex = 53;
            this.txt.TabStop = false;
            this.txt.Text = "Thông tin Đơn hàng";
            // 
            // txtNgaydat
            // 
            this.txtNgaydat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNgaydat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNgaydat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.txtNgaydat.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNgaydat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgaydat.Enabled = false;
            this.txtNgaydat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaydat.ForeColor = System.Drawing.Color.Crimson;
            this.txtNgaydat.HintForeColor = System.Drawing.Color.Empty;
            this.txtNgaydat.HintText = "";
            this.txtNgaydat.isPassword = false;
            this.txtNgaydat.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNgaydat.LineIdleColor = System.Drawing.Color.Crimson;
            this.txtNgaydat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNgaydat.LineThickness = 3;
            this.txtNgaydat.Location = new System.Drawing.Point(118, 215);
            this.txtNgaydat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaydat.MaxLength = 32767;
            this.txtNgaydat.Name = "txtNgaydat";
            this.txtNgaydat.Size = new System.Drawing.Size(217, 31);
            this.txtNgaydat.TabIndex = 12;
            this.txtNgaydat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbbTinhtrang
            // 
            this.cbbTinhtrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.cbbTinhtrang.Enabled = false;
            this.cbbTinhtrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTinhtrang.FormattingEnabled = true;
            this.cbbTinhtrang.IntegralHeight = false;
            this.cbbTinhtrang.ItemHeight = 13;
            this.cbbTinhtrang.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbbTinhtrang.Location = new System.Drawing.Point(118, 315);
            this.cbbTinhtrang.Name = "cbbTinhtrang";
            this.cbbTinhtrang.Size = new System.Drawing.Size(217, 21);
            this.cbbTinhtrang.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tình trạng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Đặt:";
            // 
            // txtPhi
            // 
            this.txtPhi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.txtPhi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhi.Enabled = false;
            this.txtPhi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhi.ForeColor = System.Drawing.Color.Crimson;
            this.txtPhi.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhi.HintText = "";
            this.txtPhi.isPassword = false;
            this.txtPhi.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPhi.LineIdleColor = System.Drawing.Color.Crimson;
            this.txtPhi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPhi.LineThickness = 3;
            this.txtPhi.Location = new System.Drawing.Point(118, 126);
            this.txtPhi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhi.MaxLength = 32767;
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(217, 31);
            this.txtPhi.TabIndex = 5;
            this.txtPhi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phí Giao Dịch:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.txtTenKH.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.Crimson;
            this.txtTenKH.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenKH.HintText = "";
            this.txtTenKH.isPassword = false;
            this.txtTenKH.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTenKH.LineIdleColor = System.Drawing.Color.Crimson;
            this.txtTenKH.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTenKH.LineThickness = 3;
            this.txtTenKH.Location = new System.Drawing.Point(118, 34);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.MaxLength = 32767;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(217, 31);
            this.txtTenKH.TabIndex = 3;
            this.txtTenKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ Tên KH:";
            // 
            // NgayGiao
            // 
            this.NgayGiao.DataPropertyName = "NgayGiao";
            this.NgayGiao.HeaderText = "Ngày Giao";
            this.NgayGiao.Name = "NgayGiao";
            // 
            // TinhTrangDH
            // 
            this.TinhTrangDH.DataPropertyName = "TinhTrangDH";
            this.TinhTrangDH.HeaderText = "Tình Trạng ĐH";
            this.TinhTrangDH.Name = "TinhTrangDH";
            // 
            // PhiGiaoDich
            // 
            this.PhiGiaoDich.DataPropertyName = "PhiGiaoDich";
            this.PhiGiaoDich.HeaderText = "Phí Giao Dịch";
            this.PhiGiaoDich.Name = "PhiGiaoDich";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // MaDH
            // 
            this.MaDH.DataPropertyName = "MaDH";
            this.MaDH.HeaderText = "Mã ĐH";
            this.MaDH.Name = "MaDH";
            // 
            // NgayDat
            // 
            this.NgayDat.DataPropertyName = "NgayDat";
            this.NgayDat.HeaderText = "Ngày Đặt";
            this.NgayDat.Name = "NgayDat";
            // 
            // dgvDonhang
            // 
            this.dgvDonhang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonhang.ColumnHeadersHeight = 40;
            this.dgvDonhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDH,
            this.MaKH,
            this.PhiGiaoDich,
            this.TinhTrangDH,
            this.NgayDat,
            this.NgayGiao});
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.dgvDonhang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDonhang.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.dgvDonhang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dgvDonhang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.dgvDonhang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvDonhang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonhang.CurrentTheme.Name = null;
            this.dgvDonhang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.dgvDonhang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvDonhang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDonhang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.dgvDonhang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonhang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDonhang.EnableHeadersVisualStyles = false;
            this.dgvDonhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dgvDonhang.HeaderBackColor = System.Drawing.Color.Crimson;
            this.dgvDonhang.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvDonhang.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDonhang.Location = new System.Drawing.Point(373, 32);
            this.dgvDonhang.Name = "dgvDonhang";
            this.dgvDonhang.RowHeadersVisible = false;
            this.dgvDonhang.RowTemplate.Height = 40;
            this.dgvDonhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonhang.Size = new System.Drawing.Size(457, 541);
            this.dgvDonhang.TabIndex = 52;
            this.dgvDonhang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            this.dgvDonhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDonhang_CellContentClick);
            // 
            // Manager_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.dgvDonhang);
            this.Name = "Manager_DonHang";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.Manager_DonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.txt.ResumeLayout(false);
            this.txt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
        private System.Windows.Forms.TextBox txtMadh;
        private System.Windows.Forms.GroupBox txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNgaydat;
        private System.Windows.Forms.ComboBox cbbTinhtrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhi;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDat;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvDonhang;
    }
}
