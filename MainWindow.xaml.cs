using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using BDserver;
using MySql.Data.MySqlClient;   

namespace SHINS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connection1.IConnection a = (Connection1.IConnection)Activator.GetObject(typeof(ConxImpl), "tcp://localhost:8085/obj");
        
        public MainWindow()
        {
            InitializeComponent();
            a.Connecter();
          
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Cls_btn_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void login_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            string s= "hello";
        }

        private void pass_KeyUp(object sender, KeyEventArgs e)
        {
            string s = "hello";
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            string username = this.Username.Text;
            string password = this.pass.Password;
            bool res;
            a.LoginValidation(password, username ,out res);
            if (res == true) 
            {
                dashboard dashboardForm = new dashboard();
                this.Close();
                dashboardForm.Show();

            }
            else
            {
                loginError errorForm = new loginError();
                errorForm.Show();
            }


        }


       

       
    }
    }

