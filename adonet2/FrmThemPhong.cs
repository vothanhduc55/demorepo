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
    public partial class FrmThemPhong : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\adonet\adonet2\QLNS.mdf;Integrated Security = True";
        public FrmThemPhong()
        {
            InitializeComponent();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;
            string tenPhong = txtTenPhong.Text;
            if (maPhong == string.Empty || tenPhong == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            ThemPhong(maPhong, tenPhong);
            this.Close();
        }

        private void ThemPhong(string maPhong, string tenPhong)
        {
            string query =string.Format("INSERT INTO DMPHONG VALUES('{0}','{1}')", maPhong, tenPhong);
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra:\n" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }


        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
