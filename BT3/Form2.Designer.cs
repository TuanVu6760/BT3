namespace BT3
{
    partial class frmNhanVien
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
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(23, 36);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(38, 13);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "MSNV";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(23, 87);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(79, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên Nhân Viên";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(23, 136);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(73, 13);
            this.lblLuong.TabIndex = 0;
            this.lblLuong.Text = "Lương cơ bản";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(113, 36);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(201, 20);
            this.txtMSNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(113, 84);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(201, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(113, 129);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(201, 20);
            this.txtLuong.TabIndex = 1;
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(113, 198);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(57, 26);
            this.btnDongy.TabIndex = 2;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(257, 198);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(57, 26);
            this.btnBoqua.TabIndex = 2;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblNhanVien);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnBoqua;
    }
}