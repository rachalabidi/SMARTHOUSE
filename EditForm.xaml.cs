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
    /// Interaction logic for EditForm.xaml
    /// </summary>
    public partial class EditForm 
    {
        private string _id;
        private Person selectedPerson;

        public EditForm(string id)
        {
            InitializeComponent();
            _id = id;
            LoadData();
        }

       

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=smarthouse;password="))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", _id);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFirstName.Text = reader["firstname"].ToString();
                    txtLastName.Text = reader["lastname"].ToString();
                    txtType.Text = reader["type"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=smarthouse;password="))
            {
                conn.Open();
                string query = "UPDATE users SET firstname = @FirstName, lastname = @LastName, type = @Type WHERE id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Type", txtType.Text);
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.ExecuteNonQuery();
            }
            Close();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            UserList usr = new UserList();
            this.Close();
            usr.Show();
        }
    }
}
