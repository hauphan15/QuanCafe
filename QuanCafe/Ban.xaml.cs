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

namespace QuanCafe
{
    /// <summary>
    /// Interaction logic for Ban.xaml
    /// </summary>
    public partial class Ban : UserControl
    {
        public Ban()
        {
            InitializeComponent();
            loadData();
        }

        
        //load
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
                idBan.Text = rowSelected[0].ToString();
                tinhTrang.Text = rowSelected[1].ToString();
            }
        }

        //thêm
        private void Them_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO Ban VALUES('" + idBan.Text + "', N'" + tinhTrang.Text +"')";
            Database db = new Database();
            int result = db.RunQuery(query);
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công !");
                loadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }

        //xóa
        private void Xoa_Click(object sender, RoutedEventArgs e)
        {
            string query = "DELETE FROM Ban WHERE ID = '" + idBan.Text + "'";
            Database db = new Database();
            int result = db.RunQuery(query);
            if (result == 1)
            {
                MessageBox.Show("Xóa thành công !");
                loadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = new Order(int.Parse(idBan.Text));
                window.ShowDialog();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }


    }
}
