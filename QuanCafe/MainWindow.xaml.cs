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
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuanCafe.UC;
using QuanCafe.Chil_Window;

namespace QuanCafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ID;
        public MainWindow( string id)
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
            ThucUong_UC th = new ThucUong_UC();
            show.Children.Clear();
            show.Children.Add(th);
        }

        private void BanBtn_Click(object sender, RoutedEventArgs e)
        {
            var b = new Ban_UC();
            show.Children.Clear();
            show.Children.Add(b);
        }

        private void NhanVienBtn_Click(object sender, RoutedEventArgs e)
        {
            var nv = new NhanVien_UC();
            show.Children.Clear();
            show.Children.Add(nv);
        }

        private void HoaDonBtn_Click(object sender, RoutedEventArgs e)
        {
            var hd = new HoaDon_UC();
            show.Children.Clear();
            show.Children.Add(hd);
        }

        private void KhoBtn_Click(object sender, RoutedEventArgs e)
        {
            var k = new Kho_UC();
            show.Children.Clear();
            show.Children.Add(k);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new DoiMatKhau(ID);
            window.ShowDialog();
        }

        private void ThongKeBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chưa hoàn thành!");
        }
    }
}
