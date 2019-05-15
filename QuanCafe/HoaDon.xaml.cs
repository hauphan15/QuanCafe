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
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
            loadData();
        }

        void loadData()
        {
            Database db = new Database();
            dataGrid1.ItemsSource = db.ExcuteQuery("SELECT * FROM ThongTinHoaDon").DefaultView;
        }

        //click vào 1 dòng trong datagrid sẽ hiện tương ứng lên textfield
        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView rowSelected = dg.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                idHoaDon.Text = rowSelected["ID"].ToString();
                idSanPham.Text = rowSelected["ID_SanPham"].ToString();
                idBan.Text = rowSelected["ID_Ban"].ToString();
                soLuong.Text = rowSelected["SoLuong"].ToString();
                tinhTrang.Text = rowSelected["TinhTrang"].ToString();
                ngay.Text = rowSelected["Ngay"].ToString();
                tongTien.Text = rowSelected["TongTien"].ToString();
            }
        }

        //thêm
        private void Them_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO ThongTinHoaDon(ID, ID_SanPham, ID_Ban, SoLuong, TinhTrang, Ngay, TongTien) VALUES('" + idHoaDon.Text + "', N'" + idSanPham.Text + "', '" + idBan.Text + "','" + soLuong.Text + "',N'" + tinhTrang.Text + "', '" + ngay.Text + "', '" + tongTien.Text + "')";
            Database db = new Database();
            int result = db.add(query);
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
            string query = "DELETE FROM ThongTinHoaDon WHERE ID = '" + idHoaDon.Text + "'";
            Database db = new Database();
            int result = db.add(query);
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
