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
    /// Interaction logic for systemp.xaml
    /// </summary>
    public partial class systemp : Window
    {
        public systemp()
        {
            InitializeComponent();
        }
        private void log_out_Click(object sender, RoutedEventArgs e)
        {

            MainWindow log_in = new MainWindow();
            this.Close();
            log_in.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserList list = new UserList();
            this.Close();
            list.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sysdesec sec = new sysdesec();
            this.Close();
            sec.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            systemp sect = new systemp();
            this.Close();
            sect.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            dashboard dash = new dashboard();
            this.Close();
            dash.Show();
        }
    }
}
