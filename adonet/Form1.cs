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

namespace adonet
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\adonet\adonet\Database1.mdf;Integrated Security=True";
        int thaotac = 0; // gắn cờ mặc định cho 1 là thêm, 2:sửa, 
        public Form1()
        {
            InitializeComponent();
            dgvPhongBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbx_maPhong.ReadOnly = true;
            tbx_tenPhong.ReadOnly = true;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            LayDanhSachPhong();
            HienThiThongTin();
            MacDinh();
        }
        private void LayDanhSachPhong()
        {
            string sqlselect = "Select * from Danhsachphongban"; // câu truy vấn
            SqlDataAdapter da = new SqlDataAdapter(sqlselect, connectionString);
            DataSet ds = new DataSet(); //tạo ra thùng chứa dữ liệu
            da.Fill(ds, "Danhsachphongban"); //đổ dữ liệu vào 
            dgvPhongBan.DataSource = ds.Tables["Danhsachphongban"];
        }
        //sự kiện click từng cell trong data gridview
        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               //lấy giữ liệu từng cell trong bảng
                string maPhong = dgvPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenPhong = dgvPhongBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbx_maPhong.Text = maPhong;
                tbx_tenPhong.Text = tenPhong;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong hop le");
            }
        }

        private void HienThiThongTin()
        {
            if(dgvPhongBan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPhongBan.SelectedRows[0];
                string maPhong = row.Cells[0].Value.ToString();
                string tenPhong = row.Cells[1].Value.ToString();
                tbx_maPhong.Text = maPhong;
                tbx_tenPhong.Text = tenPhong;
            }
           
        }

        private void MacDinh()
        {
            tbx_maPhong.ReadOnly = true;
            tbx_tenPhong.ReadOnly = true;
            btn_add.Enabled = true;
            btn_modify.Enabled = true;
            btn_delete.Enabled = true;
            btn_cancel.Enabled = false;
            btn_save.Enabled = false;
            tbx_maPhong.Text = null;
            tbx_tenPhong.Text = null;

            dgvPhongBan.Enabled = true;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_modify.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;

            tbx_maPhong.ReadOnly = false;
            tbx_tenPhong.ReadOnly = false;

            dgvPhongBan.Enabled = true;
            thaotac = 1;

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            btn_modify.Enabled = false;
            btn_delete.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;

            tbx_maPhong.ReadOnly = true; // không cho phép sửa mã phòng
            tbx_tenPhong.ReadOnly = false;

            dgvPhongBan.Enabled = true;
            thaotac = 2;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            LayDanhSachPhong();
            MacDinh();
            HienThiThongTin();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            string maPhong = tbx_maPhong.Text;
            string tenPhong = tbx_tenPhong.Text;
            if(maPhong == null || tenPhong == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào ô trống.");
            }
            else
            {
                switch (thaotac)
                {
                    case 1:
                        themPhong(maPhong, tenPhong);
                        LayDanhSachPhong();
                        MacDinh();
                        HienThiThongTin();
                        
                        break;
                    case 2:
                        suaPhong(maPhong, tenPhong);
                        LayDanhSachPhong();
                        MacDinh();
                        HienThiThongTin();
                        
                        break;
                }
            }
        }

        private void themPhong(string maPhong, string tenPhong)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string sqlinser = string.Format("INSERT INTO DanhSachPhongBan VALUES('{0}','{1}')",maPhong,tenPhong);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlinser, con);
                int kq = cmd.ExecuteNonQuery(); 
                if (kq > 0)
                {
                    MessageBox.Show("Đã thêm thành công:\n  + Mã Phòng  " + maPhong + " \n + Tên phòng:" + tenPhong);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi\n" + ex.ToString());
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void suaPhong(string maPhong, string tenPhong)
        {
            string sqlupdate = "UPDATE DanhSachPhongBan SET TenPhong = @TP WHERE MaPhong = @MP";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlupdate, con)) 
                {
                    cmd.Parameters.AddWithValue("@TP",tenPhong);
                    cmd.Parameters.AddWithValue("@MP", maPhong);
                    try
                    {
                        con.Open();
                        int kq2 = cmd.ExecuteNonQuery();
                        if (kq2 > 0)
                        {
                            MessageBox.Show("Đã sửa thành công phòng ban:\n + Mã Phòng" + maPhong + "\n + Tên Phòng:" + tenPhong);
                        }
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi sửa phòng: \n" + ex.ToString());
                    }
                   
                }
                

            }
              
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string maPhong = tbx_maPhong.Text;
            if (MessageBox.Show("Bạn có mua xóa không","Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Xóa phòng
                xoaPhong(maPhong);
                LayDanhSachPhong();
                MacDinh();
                HienThiThongTin();
                
            }
        }

        private void xoaPhong(string maPhong)
        {
            string sqldelete = "DELETE from Danhsachphongban where MaPhong = @MP";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(sqldelete, con))
                {
                    cmd.Parameters.Add("@MP", SqlDbType.NVarChar); //khởi tạo tham số
                    cmd.Parameters["@MP"].Value = maPhong;           // truyền dữ liệu cho tham số
                    try
                    {
                        con.Open();
                        int kq3 = cmd.ExecuteNonQuery();
                        if (kq3 > 0)
                        {
                            MessageBox.Show("Đã xóa thành công \n + Mã Phòng: " + maPhong);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("đã xảy ra lỗi khi xóa!", ex.ToString());
                    }
                }
            }
        }
    }
}
