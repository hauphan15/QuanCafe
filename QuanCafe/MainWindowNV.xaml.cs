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
using QuanCafe.UC;
using QuanCafe.Chil_Window;

namespace QuanCafe
{
    /// <summary>
    /// Interaction logic for MainWindowNV.xaml
    /// </summary>
    public partial class MainWindowNV : Window
    {
        string ID;
        public MainWindowNV(string id)
        {
            InitializeComponent();
            ThucUong_UC th = new ThucUong_UC();
            show.Children.Clear();
            show.Children.Add(th);
            ID = id;
            ten.Content = new Database().ExcuteQuery("select HoTen from NhanVien where ID='" + ID + "'").Rows[0][0];
        }

        private void ThucUongBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ThucUong_UC tu = new ThucUong_UC();
            show.Children.Clear();
            show.Children.Add(tu);
        }

        private void BanBtn_Click(object sender, RoutedEventArgs e)
        {
            var b = new Ban_UC();
            show.Children.Clear();
            show.Children.Add(b);
        }

        private void HoaDonBtn_Click(object sender, RoutedEventArgs e)
        {
            var hd = new HoaDon_UC();
            show.Children.Clear();
            show.Children.Add(hd);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new DoiMatKhau(ID);
            window.ShowDialog();
        }
    }
}
