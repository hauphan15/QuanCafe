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

namespace QuanCafe
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DangNhap : Window
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Click(object sender, RoutedEventArgs e)
        {
            Database db = new Database();
            string tk = tenDangNhap.Text;
            string mk = this.matKhau.Password;
            int result = db.Login(tk, mk);
            if(result==1)
            {
                MainWindowNV mainWdNV = new MainWindowNV();
                mainWdNV.Show();
                this.Close();
            }
            if(result==2)
            {
                MainWindow mainWd = new MainWindow();
                mainWd.Show();
                this.Close();
            }
            if(result==0)
            {
                MessageBox.Show("Sai ID hoặc Mật Khẩu!\n Vui lòng nhập lại!");
            }

        }

        private void Thoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
