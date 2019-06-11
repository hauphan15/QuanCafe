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

namespace QuanCafe.Chil_Window
{
    /// <summary>
    /// Interaction logic for ThemNhanVien.xaml
    /// </summary>
    public partial class ThemNhanVien : Window
    {
        public ThemNhanVien()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            if (id.Text == "" || hoten.Text == "" || Pass.Password == "")
            {
                MessageBox.Show("Các ô đánh dấu * không được để trống!");
                return false;
            }
            return true;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if(Check())
            {
                var query="insert into NhanVien values('"+id.Text+"','"+Pass.Password+"',N'"+hoten.Text+"',N'"+diachi.Text+"','"
                    +ngaysinh.Text+"','"+ngayvaolam.Text+"','"+luong.Text+"','"+sdt.Text+"',N'"+chucvu.Text+"')";
                var db = new Database().RunQuery(query);
                if(db>0)
                {
                    MessageBox.Show("Thêm thành công!");

                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
;            }
        }

        private void Cencel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
