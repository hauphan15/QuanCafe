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
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public Order()
        {
            InitializeComponent();
            Load();
        }

        class drink
        {
            public string ImgSrc { get; set; }
            public string TenSanPham { get; set; }
            public string LoaiSanPham { get; set; }
            public int sl { get; set; }
            
        }

        void Load()
        {
            var query = "select ImgSrc,TenSanPham,LoaiSanPham from SanPham Order by ID";
            Database db = new Database();
            var item = new List<drink>();
            var data = db.ExcuteQuery(query);
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var row = data.Rows[i];
                item.Add(new drink()
                {
                    ImgSrc=row[0].ToString(),
                    TenSanPham=row[1].ToString(),
                    LoaiSanPham=row[2].ToString(),
                    sl=0,
                });


            }
            list.ItemsSource = item;
        }

        drink l = new drink();
        bool isselect = false;

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                l = list.SelectedItem as drink;
                isselect = true;
                MessageBox.Show(l.sl.ToString());
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isselect)
            {

            }
        }
    }
}
