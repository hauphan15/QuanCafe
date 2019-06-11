using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanCafe.Chil_Window
{
    /// <summary>
    /// Interaction logic for DoiMatKhau.xaml
    /// </summary>
    public partial class DoiMatKhau : Window
    {
        string ID;
        public DoiMatKhau(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(Check())
            {
                var db = new Database().RunQuery("update NhanVien set Password='" + Pass2.Password + "' where ID='" + ID + "'");
                this.Close();
            }

        }

        public bool Check()
        {
            if(Pass1.Password=="" || Pass2.Password==""||Pass3.Password=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            if(Pass2.Password!=Pass3.Password)
            {
                MessageBox.Show("Nhập sai mật khẩu mới. xin nhập lại!");
                return false;
            }
            var p = new Database().ExcuteQuery("select Password from NhanVien where ID='" + ID + "'").Rows[0][0];
            if(Pass1!=p)
            {
                MessageBox.Show("Nhập sai mật khẩu. xin nhập lại!");
                return false;
            }

            return true;
        }
    }
}
