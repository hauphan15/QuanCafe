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

namespace QuanCafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ThucUong th = new ThucUong();
            show.Children.Clear();
            show.Children.Add(th);
        }

        private void ThucUongBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ThucUong th = new ThucUong();
            show.Children.Clear();
            show.Children.Add(th);
        }

        private void BanBtn_Click(object sender, RoutedEventArgs e)
        {
            Ban b = new Ban();
            show.Children.Clear();
            show.Children.Add(b);
        }

        private void NhanVienBtn_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = new NhanVien();
            show.Children.Clear();
            show.Children.Add(nv);
        }

        private void HoaDonBtn_Click(object sender, RoutedEventArgs e)
        {
            HoaDon hd = new HoaDon();
            show.Children.Clear();
            show.Children.Add(hd);
        }

        private void KhoBtn_Click(object sender, RoutedEventArgs e)
        {
            Kho k = new Kho();
            show.Children.Clear();
            show.Children.Add(k);
        }
    }
}
