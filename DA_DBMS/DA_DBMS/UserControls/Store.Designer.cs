namespace DA_DBMS.UserControls
{
    partial class Store
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.dgvSanPham = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbChuDe = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.ColumnHeadersHeight = 40;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSanPham.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.dgvSanPham.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.dgvSanPham.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSanPham.CurrentTheme.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSanPham.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgvSanPham.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSanPham.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanPham.CurrentTheme.Name = null;
            this.dgvSanPham.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSanPham.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSanPham.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSanPham.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.dgvSanPham.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgvSanPham.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSanPham.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSanPham.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvSanPham.Name = "dgvSanPham";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowTemplate.Height = 40;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(563, 600);
            this.dgvSanPham.TabIndex = 12;
            this.dgvSanPham.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DodgerBlue;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSanPham_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenSach";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên Sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenTacGia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tác Giả";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá Bán";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenChuDe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Chủ Đề";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = global::DA_DBMS.Properties.Resources.icons8_search_64px;
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 13;
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
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.SystemColors.Window;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(44, 3);
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
            stateProperties4.FillColor = System.Drawing.SystemColors.Window;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Tên Sách hoặc Tác giả";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(180, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Tên Sách hoặc Tác giả";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::DA_DBMS.Properties.Resources.pngtree_blue_fluid_gradient_ad_image_42102;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clbChuDe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(563, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 600);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DA_DBMS.Properties.Resources.icons8_abc_64px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 40);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sách theo chủ đề";
            // 
            // clbChuDe
            // 
            this.clbChuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.clbChuDe.CheckOnClick = true;
            this.clbChuDe.Cursor = System.Windows.Forms.Cursors.Default;
            this.clbChuDe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbChuDe.FormattingEnabled = true;
            this.clbChuDe.Location = new System.Drawing.Point(12, 175);
            this.clbChuDe.Name = "clbChuDe";
            this.clbChuDe.Size = new System.Drawing.Size(203, 334);
            this.clbChuDe.TabIndex = 13;
            this.clbChuDe.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbChuDe_ItemCheck);
            this.clbChuDe.SelectedIndexChanged += new System.EventHandler(this.ClbChuDe_SelectedIndexChanged);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.panel1);
            this.Name = "Store";
            this.Size = new System.Drawing.Size(790, 600);
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbChuDe;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvSanPham;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
