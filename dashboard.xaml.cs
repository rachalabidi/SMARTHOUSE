using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SHINS
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Window
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Cls_btn_dashboard_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
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

        private void camera_Checked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `camera`(`time`, `active`, `stocked`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                _ = mySqlCommand.Parameters.AddWithValue("@first", "smarthome//vds//");

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

        private void camera_Unchecked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `camera`(`time`, `active`, `stocked`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", time);
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "0");
                _ = mySqlCommand.Parameters.AddWithValue("@first", "NO FILES ");

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

        private void Card_Checked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `information`(`composants`, `ACTIVE`, `TIME`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", "heating");
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                _ = mySqlCommand.Parameters.AddWithValue("@first", time);

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
                string sql = "INSERT INTO `information`(`composants`, `ACTIVE`, `TIME`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", "heating");
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "0");
                _ = mySqlCommand.Parameters.AddWithValue("@first", time);

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

        private void lamp_Checked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `information`(`composants`, `ACTIVE`, `TIME`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", "lamp");
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                _ = mySqlCommand.Parameters.AddWithValue("@first", time);

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

        private void lamp_Unchecked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `information`(`composants`, `ACTIVE`, `TIME`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", "lamp");
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                _ = mySqlCommand.Parameters.AddWithValue("@first", time);

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

        private void clim_Checked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `information`(`composants`, `ACTIVE`, `TIME`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", "air-conditioner");
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "1");
                _ = mySqlCommand.Parameters.AddWithValue("@first", time);

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

        private void clim_Unchecked(object sender, RoutedEventArgs e)
        {
            String time = GetTimestamp(DateTime.Now);
            string myslqcon = "server=localhost;user=root;database=smarthouse;password=";
            MySqlConnection mySqlConnection = new MySqlConnection(myslqcon);
            try
            {
                mySqlConnection.Open();
                Console.Write("odne");
                string sql = "INSERT INTO `information`(`composants`, `ACTIVE`, `TIME`) VALUES (@id,@Username , @first );";
                MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
                _ = mySqlCommand.Parameters.AddWithValue("@id", "air-conditioner");
                _ = mySqlCommand.Parameters.AddWithValue("@Username", "0");
                _ = mySqlCommand.Parameters.AddWithValue("@first", time);

                mySqlCommand.Prepare();
                Console.Write("debug here  ___________");
                _ = mySqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {

            }
        }
    }
}
