using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanCafe
{
    public class Database
    {
        string ConnecString = "Data Source=DESKTOP-EV0MICC;Initial Catalog=QLQuanCafe;Integrated Security=True";


        //đăng nhập
        public void Login(string id, string pass)
        {
            SqlConnection connec1 = new SqlConnection(ConnecString);
            connec1.Open();

            string query1 = "SELECT * FROM NhanVien WHERE ChucVu like 'Q%' AND ID = '" + id + "' AND MatKhau = '" + pass + "'";
            SqlCommand cmd1 = new SqlCommand(query1, connec1);
            SqlDataReader data1 = cmd1.ExecuteReader();
            if (data1.Read() == true) // Cửa sổ của [Nhân viên quản lý]
            {
                MainWindow mainWd = new MainWindow();         
                mainWd.Show();
            }
            else
            {
                SqlConnection connec2 = new SqlConnection(ConnecString);
                connec2.Open();

                string query2 = "SELECT * FROM NhanVien WHERE ChucVu not like 'Q%' AND ID = '" + id + "' AND MatKhau = '" + pass + "'";
                SqlCommand cmd2 = new SqlCommand(query2, connec2);
                SqlDataReader data2 = cmd2.ExecuteReader();
                if (data2.Read() == true) // Cửa sổ của [Nhân viên thường]
                {
                    MainWindowNV mainWdNV = new MainWindowNV();
                    mainWdNV.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }
        //load
        public DataTable ExcuteQuery(string query)
        {
            SqlConnection connec = new SqlConnection(ConnecString);
            connec.Open();
            string CmdString = string.Empty;
            CmdString = query;
            SqlCommand cmd = new SqlCommand(CmdString, connec);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connec.Close();
            return dt;
        }

        //them
        public int add(string query)
        {
            SqlConnection connec = new SqlConnection(ConnecString);
            connec.Open();
            SqlCommand cmd = new SqlCommand(query, connec);
            int a = cmd.ExecuteNonQuery();
            connec.Close();
            return a;
        }

        //xoa
        public int remove(string query)
        {
            SqlConnection connec = new SqlConnection(ConnecString);
            connec.Open();
            SqlCommand cmd = new SqlCommand(query, connec);
            int a = cmd.ExecuteNonQuery();
            connec.Close();
            return a;
        }

    }
}
