using System;
using System.Collections.Generic;
using System.Data;
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
        public Order(int id)
        {
            InitializeComponent();
            Load();

            Ban.Text = "Bàn " + id.ToString();
            ID_ban = id;
            Load_ListOrder();
        }

        class drink
        {
            public string ImgSrc { get; set; }
            public string TenSanPham { get; set; }
            public string LoaiSanPham { get; set; }
            public int sl { get; set; }
            
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Load();
        }

        void Load()
        {
            var query = "select  ImgSrc,TenSanPham,LoaiSanPham,ID from SanPham Where TenSanPham like N'%" + search.Text + "%' Order by ID";
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
        int ID_ban = 0;
        int sl = 0;
        ListViewItem listViewItem = null;

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list.SelectedItem != null)
            {
                l = list.SelectedItem as drink;

                isselect = true;
                
                if(listViewItem!=null)
                {
                    ContentPresenter contentPresenter = FindVisualChild<ContentPresenter>(listViewItem);

                    DataTemplate dataTemplate = contentPresenter.ContentTemplate;

                    TextBox tb = (TextBox)dataTemplate.FindName("tb", contentPresenter);
                    Button bt = (Button)dataTemplate.FindName("bt", contentPresenter);

                    bt.IsEnabled = false;
                    tb.IsEnabled = false;
                    tb.Text = "";

                }

                listViewItem = (ListViewItem)(list.ItemContainerGenerator.ContainerFromItem(list.SelectedItem));

                ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(listViewItem);

                DataTemplate myDataTemplate = myContentPresenter.ContentTemplate;

                Button button = (Button)myDataTemplate.FindName("bt", myContentPresenter);
                TextBox textBox = (TextBox)myDataTemplate.FindName("tb", myContentPresenter);

                button.IsEnabled = true;
                textBox.IsEnabled = true;

            }
        }

        private void Load_ListOrder()
        {
            var query = "SELECT B.TenSanPham,B.LoaiSanPham,A.SoLuong,(A.SoLuong*b.GiaBan) as Tien "
                       + "from(Select SP.ID, Sum(OD.SoLuong) as SoLuong "
                           + " from SanPham SP, Order_Ban OD "
                          + "  where SP.ID = OD.Id_SP and OD.ID_Ban = " + ID_ban.ToString()
                         + "   group by SP.ID) as A , SanPham as B "
                    + " Where B.ID = A.ID";
            var data = new Database().ExcuteQuery(query);
            order.ItemsSource = data.DefaultView;
        }

        int imsg = 0;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!isselect)
            {
                if (imsg == 0)
                {
                    MessageBox.Show("Bạn chưa chọn sản phẩm!");
                    imsg = 1;
                }
                (sender as TextBox).Text = "0";
                imsg = 0;
            }
            else
            {
                try
                {
                    sl = int.Parse((sender as TextBox).Text);
                    (sender as TextBox).Foreground = new SolidColorBrush(Colors.Black);
                }
                catch
                {
                    (sender as TextBox).Foreground = new SolidColorBrush(Colors.Red);
                    sl = 0;
                }


               
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!isselect)
            {
                    MessageBox.Show("Bạn chưa chọn sản phẩm!");
            }
            else if (sl!=0)
            {
                var id_sp = new Database().ExcuteQuery("select ID from SanPham where TenSanPham = N'" + l.TenSanPham + "'").Rows[0][0];
                var query = "Insert into Order_Ban Values ('" + ID_ban.ToString() + "','" + id_sp.ToString() + "','" + sl.ToString() + "')";

                var ordered_sp = new Database().ExcuteQuery("select * from Order_Ban where ID_Ban = " + ID_ban.ToString() + " And Id_SP = " + id_sp.ToString());

                if(ordered_sp.Rows.Count>0)
                {
                    query = "Update Order_Ban SET SoLuong = ( SoLuong + " + sl.ToString() + ") Where ID_Ban = " + ID_ban.ToString() + " And Id_SP = " + id_sp.ToString();
                }

                var db = new Database().RunQuery(query);

                ListViewItem listViewItem = (ListViewItem)(list.ItemContainerGenerator.ContainerFromItem(list.SelectedItem));

                ContentPresenter myContentPresenter = FindVisualChild<ContentPresenter>(listViewItem);

                DataTemplate myDataTemplate = myContentPresenter.ContentTemplate;

                TextBox textBox = (TextBox)myDataTemplate.FindName("tb", myContentPresenter);
                Button button = (Button)myDataTemplate.FindName("bt", myContentPresenter);

                button.IsEnabled = false;
                textBox.IsEnabled = false;

                list.SelectedItem = null;
                isselect = false;
                l = new drink();

                Load_ListOrder();
            }
        }

        private childItem FindVisualChild<childItem>(DependencyObject obj) where childItem : DependencyObject
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem)
                    return (childItem)child;
                else
                {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null)
                        return childOfChild;
                }
            }
            return null;
        }

        private void Order_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            var row = dg.SelectedItem as DataRowView;
            if (row!=null)
            {
                tensp.Text = row[0].ToString();
                loaisp.Text = row[1].ToString();
                soluong.Text = row[2].ToString();
                tien.Text = row[3].ToString();
                soluong.IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var id_sp = new Database().ExcuteQuery("select ID from SanPham where TenSanPham = N'" + tensp.Text + "'").Rows[0][0];
            var a = new Database().RunQuery("delete Order_Ban Where ID_Ban = " + ID_ban.ToString() + " And Id_SP = " + id_sp);
            Load_ListOrder();

            tensp.Text = "tên thức uống";
            loaisp.Text = "loại";
            soluong.Text = "số lượng";
            tien.Text = "thành tiền";
            soluong.IsEnabled = false;

        }


    }
}
