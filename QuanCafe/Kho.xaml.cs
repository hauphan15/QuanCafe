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
    /// Interaction logic for Kho.xaml
    /// </summary>
    public partial class Kho : UserControl
    {
        public Kho()
        {
            InitializeComponent();
            loadData();
        }


        //load data
        public void loadData()
        {
            Database db = new Database();
            dataGrid1.ItemsSource = db.ExcuteQuery("SELECT * FROM Kho").DefaultView;
        }



        //click vào 1 dòng trong datagrid sẽ hiện tương ứng lên textfield
        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = (DataGrid)sender;
            DataRowView rowSelected = dg.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                idNL.Text = rowSelected["ID"].ToString();
                tenNL.Text = rowSelected["TenNguyenLieu"].ToString();
                soLuong.Text = rowSelected["SoLuong"].ToString();
                ngayNhap.Text = rowSelected["NgayNhap"].ToString();
                phiNhap.Text = rowSelected["PhiNhap"].ToString();
            }
        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO Kho(ID, TenNguyenLieu, SoLuong,NgayNhap,PhiNhap) VALUES('" + idNL.Text + "', N'" + tenNL.Text + "', '" + soLuong.Text + "', '" + ngayNhap.Text + "', '" + phiNhap.Text + "')";
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

        private void Xoa_Click(object sender, RoutedEventArgs e)
        {
            string query = "DELETE FROM Kho WHERE ID = '" + idNL.Text + "'";
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
