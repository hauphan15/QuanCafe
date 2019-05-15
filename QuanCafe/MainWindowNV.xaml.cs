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
    /// Interaction logic for MainWindowNV.xaml
    /// </summary>
    public partial class MainWindowNV : Window
    {
        public MainWindowNV()
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

        private void HoaDonBtn_Click(object sender, RoutedEventArgs e)
        {
            HoaDon hd = new HoaDon();
            show.Children.Clear();
            show.Children.Add(hd);
        }

    }
}
