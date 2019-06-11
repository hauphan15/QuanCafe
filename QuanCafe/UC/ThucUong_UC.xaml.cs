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
    /// Interaction logic for ThucUong_UC.xaml
    /// </summary>
    public partial class ThucUong_UC : UserControl
    {
        public ThucUong_UC()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            Database db = new Database();
            dataGrid1.ItemsSource = db.ExcuteQuery("SELECT * FROM SanPham").DefaultView;
        }

        //click vào 1 dòng trong datagrid sẽ hiện tương ứng lên textfield
        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView rowSelected = dg.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                idTU.Text = rowSelected["ID"].ToString();
                tenTU.Text = rowSelected["TenSanPham"].ToString();
                giaTU.Text = rowSelected["GiaBan"].ToString();
                loaiTU.Text = rowSelected["LoaiSanPham"].ToString();
                khuyenmai.Text = rowSelected["KhuyenMai"].ToString();
                imgsrc.Text = rowSelected["ImgSrc"].ToString();
            }
        }

        //thêm
        private void Them_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO SanPham(TenSanPham,LoaiSanPham,GiaBan,KhuyenMai,ImgSrc,Isdel) VALUES(N'" + tenTU.Text + "',N'" + loaiTU.Text + "','" + giaTU.Text + "','" + khuyenmai.Text + "','" + imgsrc.Text + "','0')";
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
            string query = "DELETE FROM SanPham WHERE ID = '" + idTU.Text + "'";
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

        private void CapNhat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chưa Hoàn thành!");
        }
    }
}
