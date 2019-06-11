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

namespace QuanCafe.UC
{
    /// <summary>
    /// Interaction logic for HoaDon_UC.xaml
    /// </summary>
    public partial class HoaDon_UC : UserControl
    {
        public HoaDon_UC()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            Database db = new Database();
            dataGrid1.ItemsSource = db.ExcuteQuery("SELECT * FROM HoaDon").DefaultView;
        }

        //click vào 1 dòng trong datagrid sẽ hiện tương ứng lên textfield
        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView rowSelected = dg.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                idHoaDon.Text = rowSelected["ID"].ToString();
                idSanPham.Text = rowSelected["ID_SP"].ToString();
                soLuong.Text = rowSelected["SoLuong"].ToString();
                ngay.Text = rowSelected["NgayBan"].ToString();
                tongTien.Text = rowSelected["Tien"].ToString();
            }
        }

        //xóa
        private void Xoa_Click(object sender, RoutedEventArgs e)
        {
            string query = "DELETE HoaDon WHERE ID = '" + idHoaDon.Text + "'";
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
    }
}
