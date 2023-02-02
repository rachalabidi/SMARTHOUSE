using BDserver;
using Google.Protobuf.WellKnownTypes;
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

namespace SHINS
{
    /// <summary>
    /// Interaction logic for guestAcc.xaml
    /// </summary>
    public partial class guestAcc : Window
    {
        Connection1.IConnection a = (Connection1.IConnection)Activator.GetObject(typeof(ConxImpl), "tcp://localhost:8085/obj");

        public guestAcc()
        {
            InitializeComponent();
            a.Connecter();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        

        private void Cls_btn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow log_in = new MainWindow();
            this.Close();
            log_in.Show();
        }

        private void guest_Click(object sender, RoutedEventArgs e)
        {
            String id = GetTimestamp(DateTime.Now);


            string name =this.Username.Text;
            string firstname = this.FirstName.Text;
            string lastname = this.LastName.Text;
            string phone = this.Phone.Text;
            string password = this.pass.Password ;
            a.CreatGuestAccount(id, name, firstname, lastname, phone, password);
            MainWindow log_in = new MainWindow();
            this.Close();
            log_in.Show();


        }

        private string GetTimestamp(DateTime value)
        {
            return value.ToString("MMddHHmmssffff");

        }

    }
}
