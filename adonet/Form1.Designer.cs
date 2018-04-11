namespace adonet
{
    partial class Form1
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
            this.lbmaPhong = new System.Windows.Forms.Label();
            this.lbtenPhong = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.tbx_maPhong = new System.Windows.Forms.TextBox();
            this.tbx_tenPhong = new System.Windows.Forms.TextBox();
            this.lb_DanhSachPhongBan = new System.Windows.Forms.Label();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmaPhong
            // 
            this.lbmaPhong.AutoSize = true;
            this.lbmaPhong.Location = new System.Drawing.Point(12, 32);
            this.lbmaPhong.Name = "lbmaPhong";
            this.lbmaPhong.Size = new System.Drawing.Size(59, 13);
            this.lbmaPhong.TabIndex = 0;
            this.lbmaPhong.Text = "Mã Phòng ";
            // 
            // lbtenPhong
            // 
            this.lbtenPhong.AutoSize = true;
            this.lbtenPhong.Location = new System.Drawing.Point(12, 75);
            this.lbtenPhong.Name = "lbtenPhong";
            this.lbtenPhong.Size = new System.Drawing.Size(59, 13);
            this.lbtenPhong.TabIndex = 1;
            this.lbtenPhong.Text = "Tên phòng";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(291, 32);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(291, 75);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(406, 32);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(406, 75);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(291, 122);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(75, 23);
            this.btn_modify.TabIndex = 6;
            this.btn_modify.Text = "Sửa";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // tbx_maPhong
            // 
            this.tbx_maPhong.Location = new System.Drawing.Point(73, 32);
            this.tbx_maPhong.Name = "tbx_maPhong";
            this.tbx_maPhong.Size = new System.Drawing.Size(165, 20);
            this.tbx_maPhong.TabIndex = 7;
            // 
            // tbx_tenPhong
            // 
            this.tbx_tenPhong.Location = new System.Drawing.Point(73, 75);
            this.tbx_tenPhong.Name = "tbx_tenPhong";
            this.tbx_tenPhong.Size = new System.Drawing.Size(165, 20);
            this.tbx_tenPhong.TabIndex = 8;
            // 
            // lb_DanhSachPhongBan
            // 
            this.lb_DanhSachPhongBan.AutoSize = true;
            this.lb_DanhSachPhongBan.Location = new System.Drawing.Point(15, 140);
            this.lb_DanhSachPhongBan.Name = "lb_DanhSachPhongBan";
            this.lb_DanhSachPhongBan.Size = new System.Drawing.Size(113, 13);
            this.lb_DanhSachPhongBan.TabIndex = 9;
            this.lb_DanhSachPhongBan.Text = "Danh sách phòng ban";
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong});
            this.dgvPhongBan.Location = new System.Drawing.Point(18, 180);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.Size = new System.Drawing.Size(463, 150);
            this.dgvPhongBan.TabIndex = 10;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "Mã Phòng";
            this.MaPhong.Name = "MaPhong";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "DANH MỤC PHÒNG BAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.lb_DanhSachPhongBan);
            this.Controls.Add(this.tbx_tenPhong);
            this.Controls.Add(this.tbx_maPhong);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbtenPhong);
            this.Controls.Add(this.lbmaPhong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmaPhong;
        private System.Windows.Forms.Label lbtenPhong;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.TextBox tbx_maPhong;
        private System.Windows.Forms.TextBox tbx_tenPhong;
        private System.Windows.Forms.Label lb_DanhSachPhongBan;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
    }
}

