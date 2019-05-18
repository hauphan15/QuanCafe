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
        static string ConnecString = @"Data Source=.\sqlexpress;Initial Catalog=QLQuanCafe;Integrated Security=True";
        SqlConnection connection = new SqlConnection(ConnecString);
        private void makeconnection()
        {
            try
            {
                connection.Open();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //đăng nhập
        public int Login(string id, string pass)
        {
            makeconnection();

            string query1 = "SELECT * FROM NhanVien WHERE ChucVu like 'Q%' AND ID = @ID AND MatKhau = @MatKhau";
            SqlCommand cmd1 = new SqlCommand(query1, connection);
            cmd1.Parameters.AddWithValue("@ID", id);
            cmd1.Parameters.AddWithValue("@MatKhau", pass);
            SqlDataReader data1 = cmd1.ExecuteReader();
            if (data1.Read() == true) // Cửa sổ của [Nhân viên quản lý]
            {
                connection.Close();
                return 2;
            }
            else
            {
                connection.Close(); makeconnection();
                string query2 = "SELECT * FROM NhanVien WHERE ChucVu not like 'Q%' AND ID = @ID AND MatKhau = @MatKhau";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("@ID", id);
                cmd2.Parameters.AddWithValue("@MatKhau", pass);
                SqlDataReader data2 = cmd2.ExecuteReader();
                if (data2.Read() == true) // Cửa sổ của [Nhân viên thường]
                {
                    connection.Close();
                    return 1;
                }
                else
                {
                    
                    connection.Close();
                    return 0;
                }
            }

            return 0;
        }
        //load
        public DataTable ExcuteQuery(string query)
        {
            makeconnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            connection.Close();
            return dt;
        }

        public int RunQuery(string query)
        {
            makeconnection();
            int a = 0;
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                a = cmd.ExecuteNonQuery();
                connection.Close();

            }
            catch(Exception error)
            {
                a = 0;
            }
            return a;
        }

    

    }
}
