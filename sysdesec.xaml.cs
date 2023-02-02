using MySql.Data.MySqlClient;
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
    /// Interaction logic for sysdesec.xaml
    /// </summary>
    public partial class sysdesec : Window
    {
        public sysdesec()
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

        private void Card_Checked(object sender, RoutedEventArgs e)
        {

            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `securitysys`(`time`, `active`) VALUES (@id,@Username  );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "0");
              

                mySqlCommand.Prepare();
                Console.Write("debug here  ___________");
                _ = mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Console.Write("ERR hna ", ex);
            }
        }

        private void Card_Unchecked(object sender, RoutedEventArgs e)
        {

            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `securitysys`(`time`, `active`) VALUES (@id,@Username  );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
              

                mySqlCommand.Prepare();
                Console.Write("debug here  ___________");
                _ = mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Console.Write("ERR hna ", ex);
            }
        }
        private string GetTimestamp(DateTime value)
        {
            return value.ToString("MM dd HH mm ");

        }

        private void DOOR_Checked(object sender, RoutedEventArgs e)
        {

            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `door`(`time`, `open`, `person`) VALUES (@id,@Username,@p  );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                _ = mySqlCommand.Parameters.AddWithValue("@p", "admin");

                mySqlCommand.Prepare();
                Console.Write("debug here  ___________");
                _ = mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Console.Write("ERR hna ", ex);
            }
        }

        private void DOOR_Unchecked(object sender, RoutedEventArgs e)
        {

            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `door`(`time`, `open`, `person`) VALUES (@id,@Username,@p  );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "0");
                _ = mySqlCommand.Parameters.AddWithValue("@p", "admin");

                mySqlCommand.Prepare();
                Console.Write("debug here  ___________");
                _ = mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                Console.Write("ERR hna ", ex);
            }
        }
    }
}
