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
    /// Interaction logic for NhanVien_UC.xaml
    /// </summary>
    public partial class NhanVien_UC : UserControl
    {
        public NhanVien_UC()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var query = "select ID,HoTen,DiaChi,NgaySinh,NgayVaoLam,Sdt,ChucVu,Luong from NhanVien";
            dataGrid1.ItemsSource = new Database().ExcuteQuery(query).DefaultView;
        }

        private void Them_Click(object sender, RoutedEventArgs e)
        {
            var window = new ThemNhanVien();
            window.ShowDialog();
        }

        private void Xoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var select = dataGrid1.SelectedItem as DataRowView;
            if(select!=null)
            {
                idNV.Text = select["ID"].ToString();
                hoTen.Text = select["HoTen"].ToString();
                diaChi.Text = select["DiaChi"].ToString();
                ngaySinh.Text = select["NgaySinh"].ToString();
                ngayVaoLam.Text = select["NgayVaoLam"].ToString();
                sdt.Text = select["Sdt"].ToString();
                luong.Text = select["Luong"].ToString();
                chucVu.Text = select["ChucVu"].ToString();
            }
        }

        private void CapNhat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Chưa hoàn thành");
        }
    }
}
