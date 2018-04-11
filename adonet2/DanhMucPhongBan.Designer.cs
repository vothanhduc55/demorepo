namespace adonet2
{
    partial class DanhMucPhongBan
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
            this.lbQuanLiDanhMucPhongBan = new System.Windows.Forms.Label();
            this.lb_MaPhong = new System.Windows.Forms.Label();
            this.lb_TenPhong = new System.Windows.Forms.Label();
            this.lb_DanhMuc = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuanLiDanhMucPhongBan
            // 
            this.lbQuanLiDanhMucPhongBan.AutoSize = true;
            this.lbQuanLiDanhMucPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLiDanhMucPhongBan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbQuanLiDanhMucPhongBan.Location = new System.Drawing.Point(112, 9);
            this.lbQuanLiDanhMucPhongBan.Name = "lbQuanLiDanhMucPhongBan";
            this.lbQuanLiDanhMucPhongBan.Size = new System.Drawing.Size(283, 24);
            this.lbQuanLiDanhMucPhongBan.TabIndex = 0;
            this.lbQuanLiDanhMucPhongBan.Text = "Quản lí danh mục phòng ban";
            // 
            // lb_MaPhong
            // 
            this.lb_MaPhong.AutoSize = true;
            this.lb_MaPhong.Location = new System.Drawing.Point(12, 60);
            this.lb_MaPhong.Name = "lb_MaPhong";
            this.lb_MaPhong.Size = new System.Drawing.Size(56, 13);
            this.lb_MaPhong.TabIndex = 1;
            this.lb_MaPhong.Text = "Mã Phòng";
            // 
            // lb_TenPhong
            // 
            this.lb_TenPhong.AutoSize = true;
            this.lb_TenPhong.Location = new System.Drawing.Point(13, 92);
            this.lb_TenPhong.Name = "lb_TenPhong";
            this.lb_TenPhong.Size = new System.Drawing.Size(60, 13);
            this.lb_TenPhong.TabIndex = 2;
            this.lb_TenPhong.Text = "Tên Phòng";
            // 
            // lb_DanhMuc
            // 
            this.lb_DanhMuc.AutoSize = true;
            this.lb_DanhMuc.Location = new System.Drawing.Point(12, 151);
            this.lb_DanhMuc.Name = "lb_DanhMuc";
            this.lb_DanhMuc.Size = new System.Drawing.Size(113, 13);
            this.lb_DanhMuc.TabIndex = 3;
            this.lb_DanhMuc.Text = "Danh Mục Phòng Ban";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(320, 50);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(320, 82);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(320, 115);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong});
            this.dgvPhongBan.Location = new System.Drawing.Point(12, 190);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(502, 166);
            this.dgvPhongBan.TabIndex = 7;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(97, 60);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(145, 20);
            this.txt_MaPhong.TabIndex = 8;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(97, 92);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(145, 20);
            this.txt_TenPhong.TabIndex = 9;
            // 
            // DanhMucPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 368);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.txt_MaPhong);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.lb_DanhMuc);
            this.Controls.Add(this.lb_TenPhong);
            this.Controls.Add(this.lb_MaPhong);
            this.Controls.Add(this.lbQuanLiDanhMucPhongBan);
            this.Name = "DanhMucPhongBan";
            this.Text = "Quản lí phòng ban";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuanLiDanhMucPhongBan;
        private System.Windows.Forms.Label lb_MaPhong;
        private System.Windows.Forms.Label lb_TenPhong;
        private System.Windows.Forms.Label lb_DanhMuc;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
    }
}

