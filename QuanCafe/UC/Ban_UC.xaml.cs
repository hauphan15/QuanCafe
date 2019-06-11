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
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuanCafe.Chil_Window;

namespace QuanCafe.UC
{
    /// <summary>
    /// Interaction logic for Ban_UC.xaml
    /// </summary>
    public partial class Ban_UC : UserControl
    {
        public Ban_UC()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            string query = "SELECT * FROM Ban";
            Database db = new Database();
            dataGrid1.ItemsSource = db.ExcuteQuery(query).DefaultView;
        }

        //click vào 1 dòng trong datagrid sẽ hiện tương ứng lên textfield
        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView rowSelected = dg.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                ID.Text = rowSelected[0].ToString();
                trangthai.Text = rowSelected[1].ToString();
            }
            Xoa.IsEnabled = true;
        }


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem != null)
            {
                try
                {
                    var window = new Order(int.Parse(ID.Text));
                    window.ShowDialog();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            if (dataGrid1.SelectedItem != null)
            {
                try
                {
                    var window = new Order(int.Parse(ID.Text));
                    window.ShowDialog();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

            if (dataGrid1.SelectedItem != null)
            {
                try
                {
                    var window = new Order(int.Parse(ID.Text));
                    window.ShowDialog();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem != null)
            {
                var window = new ChuyenBan(ID.Text);
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn!");
            }

        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            var i = new Database().RunQuery("Insert into Ban Values('" + ID.Text + "','Idle')");
            if (i > 0)
            {
                MessageBox.Show("Thêm thành công!");
                ID.Text = "";
                trangthai.Text = "";
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void Xoa_Click(object sender, RoutedEventArgs e)
        {
            var i = new Database().RunQuery("Delete Ban Where ID= " + ID.Text + " And TinhTrang=N'Idle'");
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công!");
                ID.Text = "";
                trangthai.Text = "";
                Xoa.IsEnabled = false;
                loadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            loadData();
            Xoa.IsEnabled = false;
            ID.Text = "";
            trangthai.Text = "";

        }

    }
}
