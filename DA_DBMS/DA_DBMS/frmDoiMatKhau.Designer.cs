namespace DA_DBMS
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMKcu = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMKcu);
            this.groupBox1.Controls.Add(this.txtConfirm);
            this.groupBox1.Controls.Add(this.txtMKmoi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 163);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtMKcu
            // 
            this.txtMKcu.Location = new System.Drawing.Point(185, 49);
            this.txtMKcu.Name = "txtMKcu";
            this.txtMKcu.PasswordChar = '*';
            this.txtMKcu.Size = new System.Drawing.Size(182, 26);
            this.txtMKcu.TabIndex = 2;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(185, 128);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(182, 26);
            this.txtConfirm.TabIndex = 4;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(185, 89);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.PasswordChar = '*';
            this.txtMKmoi.Size = new System.Drawing.Size(182, 26);
            this.txtMKmoi.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(185, 17);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnDoiMK);
            this.groupBox2.Location = new System.Drawing.Point(8, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 77);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(249, 23);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 39);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click_1);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(91, 23);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(92, 39);
            this.btnDoiMK.TabIndex = 7;
            this.btnDoiMK.Text = "Ok";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.BtnDoiMK_Click_1);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 260);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMKcu;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMK;
    }
}