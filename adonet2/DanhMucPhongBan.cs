using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adonet2
{
    public partial class DanhMucPhongBan : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QLNS"].ConnectionString;
        public DanhMucPhongBan()
        {
            InitializeComponent();
            dgvPhongBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_MaPhong.ReadOnly = true;
            txt_TenPhong.ReadOnly = true;
            LayDanhSachPhong();
            HienThiThongTin();
        }

        private void LayDanhSachPhong()
        {
            dgvPhongBan.Rows.Clear();
            string query = "Select * from DMPHONG";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string maPhong = (string)dr[0];
                            string tenPhong = (string)dr[1];
                            dgvPhongBan.Rows.Add(maPhong, tenPhong);
                        }
                    }
                }
            }

            
        }

        private void HienThiThongTin()
        {
            if (dgvPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPhongBan.SelectedRows[0];
                string maPhong = row.Cells[0].Value.ToString();
                string tenPhong = row.Cells[1].Value.ToString();
                txt_MaPhong.Text = maPhong;
                txt_TenPhong.Text = tenPhong;
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string maPhong = dgvPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenPhong = dgvPhongBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_MaPhong.Text = maPhong;
                
                txt_TenPhong.Text = tenPhong;
            }
            catch
            {
                MessageBox.Show("Không hợp lệ !","Thông Báo");
            }
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            FrmThemPhong form = new FrmThemPhong();
            form.ShowDialog();
            LayDanhSachPhong();
            HienThiThongTin();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            frmSuaPhong form = new frmSuaPhong();
            form.Message = txt_MaPhong.Text;
            form.Show();
            

            LayDanhSachPhong();
            HienThiThongTin();
        }

        private void XoaPhong(string maPhong)
        {
            string query = "DELETE FROM DMPHONG WHERE MaPhong = @MP";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@MP", SqlDbType.NVarChar);
                    cmd.Parameters["@MP"].Value = maPhong;
                    try
                    {
                        con.Open();
                        int kq = cmd.ExecuteNonQuery();
                        if(kq > 0)
                        {
                            MessageBox.Show("Đã xóa thành công: + Mã phòng: " +maPhong);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thực hiện:", ex.ToString());
                    }
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maPhong = txt_MaPhong.Text;
            if (MessageBox.Show("Bạn có muốn xóa không", "Xác nhận xóa ?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                XoaPhong(maPhong);
                LayDanhSachPhong();
                HienThiThongTin();
            }
        }
    }
}
