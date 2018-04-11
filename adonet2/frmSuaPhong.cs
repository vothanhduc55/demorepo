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
    public partial class frmSuaPhong : Form
    {
        private string message;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\adonet\adonet2\QLNS.mdf;Integrated Security = True";
        public frmSuaPhong()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            if(tenPhong == string.Empty)
            {
                MessageBox.Show("Vui Lòng nhập đủ thông tin");
            }
            
            SuaPhong(tenPhong, maPhong);
            this.Close();
        }

        private void SuaPhong(string tenPhong, string maPhong)
        {
            
            string query1 = "UPDATE DMPHONG SET TenPhong = @TP WHERE MaPhong = @MP";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@TP", tenPhong);
                    cmd.Parameters.AddWithValue("@MP", maPhong);
                    try
                    {
                        con.Open();
                       
                        int kq1 = cmd.ExecuteNonQuery();
                        if (kq1 > 0)
                        {
                            MessageBox.Show("Đã Sửa thành công phòng ban:\n + Mã phòng" + maPhong + "TênPhòng:\n" + tenPhong);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi khi sửa phòng ban", ex.ToString());
                    }
                }
            }
        }

        private void frmSuaPhong_Load(object sender, EventArgs e)
        {

            txtMaPhong.ReadOnly = true;
            txtTenPhong.ReadOnly = false;
            txtMaPhong.Text = message;
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

