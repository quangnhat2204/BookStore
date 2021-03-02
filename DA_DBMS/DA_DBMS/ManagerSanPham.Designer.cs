namespace DA_DBMS
{
    partial class ManagerSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerSanPham));
            this.dgvSach = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnUpdate = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnThem = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSach.ColumnHeadersHeight = 40;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.GiaBan,
            this.SoLuong,
            this.MoTa,
            this.NgayCapNhap,
            this.Anh});
            this.dgvSach.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.dgvSach.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSach.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSach.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.dgvSach.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSach.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
            this.dgvSach.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.dgvSach.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.dgvSach.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSach.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSach.CurrentTheme.Name = null;
            this.dgvSach.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.dgvSach.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSach.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSach.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.dgvSach.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSach.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSach.EnableHeadersVisualStyles = false;
            this.dgvSach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.dgvSach.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.dgvSach.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSach.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSach.Location = new System.Drawing.Point(22, 37);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowTemplate.Height = 40;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(706, 532);
            this.dgvSach.TabIndex = 18;
            this.dgvSach.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            this.dgvSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSach_CellContentClick);
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
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            // 
            // NgayCapNhap
            // 
            this.NgayCapNhap.DataPropertyName = "NgayCapNhap";
            this.NgayCapNhap.HeaderText = "Ngày CN";
            this.NgayCapNhap.Name = "NgayCapNhap";
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.Name = "Anh";
            this.Anh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = global::DA_DBMS.Properties.Resources.icons8_spinner_frame_2_64px;
            this.btnReload.ImageActive = null;
            this.btnReload.Location = new System.Drawing.Point(3, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(37, 35);
            this.btnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReload.TabIndex = 21;
            this.btnReload.TabStop = false;
            this.btnReload.Zoom = 10;
            this.btnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(25, 391);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(12, 20);
            this.txtMaSach.TabIndex = 20;
            this.txtMaSach.Visible = false;
            this.txtMaSach.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(734, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 532);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // btnXoa
            // 
            this.btnXoa.ActiveImage = null;
            this.btnXoa.AllowAnimations = true;
            this.btnXoa.AllowBuffering = false;
            this.btnXoa.AllowZooming = true;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ErrorImage")));
            this.btnXoa.FadeWhenInactive = false;
            this.btnXoa.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnXoa.Image = global::DA_DBMS.Properties.Resources.icons8_delete_64px;
            this.btnXoa.ImageActive = null;
            this.btnXoa.ImageLocation = null;
            this.btnXoa.ImageMargin = 40;
            this.btnXoa.ImageSize = new System.Drawing.Size(56, 50);
            this.btnXoa.ImageZoomSize = new System.Drawing.Size(96, 90);
            this.btnXoa.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.InitialImage")));
            this.btnXoa.Location = new System.Drawing.Point(1, 325);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Rotation = 0;
            this.btnXoa.ShowActiveImage = true;
            this.btnXoa.ShowCursorChanges = true;
            this.btnXoa.ShowImageBorders = true;
            this.btnXoa.ShowSizeMarkers = false;
            this.btnXoa.Size = new System.Drawing.Size(96, 90);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.ToolTipText = "";
            this.btnXoa.WaitOnLoad = false;
            this.btnXoa.Zoom = 40;
            this.btnXoa.ZoomSpeed = 10;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveImage = null;
            this.btnUpdate.AllowAnimations = true;
            this.btnUpdate.AllowBuffering = false;
            this.btnUpdate.AllowZooming = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ErrorImage")));
            this.btnUpdate.FadeWhenInactive = false;
            this.btnUpdate.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnUpdate.Image = global::DA_DBMS.Properties.Resources.icons8_update_tag_64px;
            this.btnUpdate.ImageActive = null;
            this.btnUpdate.ImageLocation = null;
            this.btnUpdate.ImageMargin = 40;
            this.btnUpdate.ImageSize = new System.Drawing.Size(56, 50);
            this.btnUpdate.ImageZoomSize = new System.Drawing.Size(96, 90);
            this.btnUpdate.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.InitialImage")));
            this.btnUpdate.Location = new System.Drawing.Point(1, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0;
            this.btnUpdate.ShowActiveImage = true;
            this.btnUpdate.ShowCursorChanges = true;
            this.btnUpdate.ShowImageBorders = true;
            this.btnUpdate.ShowSizeMarkers = false;
            this.btnUpdate.Size = new System.Drawing.Size(96, 90);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.ToolTipText = "";
            this.btnUpdate.WaitOnLoad = false;
            this.btnUpdate.Zoom = 40;
            this.btnUpdate.ZoomSpeed = 10;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.ActiveImage = null;
            this.btnThem.AllowAnimations = true;
            this.btnThem.AllowBuffering = false;
            this.btnThem.AllowZooming = true;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ErrorImage")));
            this.btnThem.FadeWhenInactive = false;
            this.btnThem.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnThem.Image = global::DA_DBMS.Properties.Resources.icons8_add_64px;
            this.btnThem.ImageActive = null;
            this.btnThem.ImageLocation = null;
            this.btnThem.ImageMargin = 40;
            this.btnThem.ImageSize = new System.Drawing.Size(56, 50);
            this.btnThem.ImageZoomSize = new System.Drawing.Size(96, 90);
            this.btnThem.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnThem.InitialImage")));
            this.btnThem.Location = new System.Drawing.Point(1, 87);
            this.btnThem.Name = "btnThem";
            this.btnThem.Rotation = 0;
            this.btnThem.ShowActiveImage = true;
            this.btnThem.ShowCursorChanges = true;
            this.btnThem.ShowImageBorders = true;
            this.btnThem.ShowSizeMarkers = false;
            this.btnThem.Size = new System.Drawing.Size(96, 90);
            this.btnThem.TabIndex = 0;
            this.btnThem.ToolTipText = "";
            this.btnThem.WaitOnLoad = false;
            this.btnThem.Zoom = 40;
            this.btnThem.ZoomSpeed = 10;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // ManagerSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManagerSanPham";
            this.Size = new System.Drawing.Size(850, 600);
            this.Load += new System.EventHandler(this.ManagerSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReload)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private Bunifu.Framework.UI.BunifuImageButton btnReload;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnXoa;
        private Bunifu.UI.WinForms.BunifuImageButton btnUpdate;
        private Bunifu.UI.WinForms.BunifuImageButton btnThem;
    }
}
