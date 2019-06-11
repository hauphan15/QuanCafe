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

namespace QuanCafe.Chil_Window
{
    /// <summary>
    /// Interaction logic for ChuyenBan.xaml
    /// </summary>
    public partial class ChuyenBan : Window
    {
        string ID;
        public ChuyenBan(string id)
        {
            InitializeComponent();
            ID = id;
            LoadData();
        }

        public void LoadData()
        {
            var query = "select * from Ban where TinhTrang='Idle'";
            list.ItemsSource = new Database().ExcuteQuery(query).DefaultView;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if(list.SelectedItem!=null)
            {
                var query = "update Order_Ban set ID_Ban='" + (list.SelectedItem as DataRowView)["ID"]+"' where ID_Ban='"+ID+"'";
                var db = new Database().RunQuery(query);
                query = "update Ban set TinhTrang='Idle' where ID='" + ID + "'";
                db = new Database().RunQuery(query);
                query = "select * from Order_Ban where ID_Ban='" + (list.SelectedItem as DataRowView)["ID"] + "'";
                var re = new Database().ExcuteQuery(query);
                if(re.Rows.Count>0)
                {
                    query = "update Ban set TinhTrang='Busy' where ID='" + (list.SelectedItem as DataRowView)["ID"] + "'";
                    db = new Database().RunQuery(query);
                }
                ID = (list.SelectedItem as DataRowView)["ID"].ToString();
                LoadData();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
