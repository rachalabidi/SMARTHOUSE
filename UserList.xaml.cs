using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using xMap;
using System.Xml;
using System.Windows.Forms;
using SHINS;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Utilities;
using BDserver;

namespace SHINS
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Window
    {
       Connection1.IConnection a = (Connection1.IConnection)Activator.GetObject(typeof(ConxImpl), "tcp://localhost:8085/obj");


        public UserList()
        {
            InitializeComponent();
           a.Connecter();
            LoadData();
            
            
        }


        private void LoadData()
        {
            List<Person> PersonList = new List<Person>();

           // a.Con(out List<BDserver.Person> personList);
             using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=smarthouse;password=")) {
             con.Open();

             

                using (MySqlCommand cmd = new MySqlCommand("select id, firstname, lastname, type from users" , con))
                {


                    MySqlDataReader reader = cmd.ExecuteReader();
                    List<Person> personList = new List<Person>();
                    while (reader.Read())
                    {
                        Person person = new Person();
                        person.Id = reader["id"].ToString();
                        person.FirstName = reader["firstname"].ToString();
                        person.LastName = reader["lastname"].ToString();
                        person.Type = reader["type"].ToString();
                        personList.Add(person);
                    }
                    dataGrid.ItemsSource = personList;
                }
            }
        }



        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = dataGrid.SelectedItem as Person;

            if (selectedItem != null)
            {
                var editForm = new EditForm(selectedItem.Id);

                // Set the data in the EditForm
                editForm.txtFirstName.Text = selectedItem.FirstName;
                editForm.txtLastName.Text = selectedItem.LastName;
               

                var result = editForm.ShowDialog();

                if (result == true)
                {
                    // Get the updated data from the EditForm
                    selectedItem.FirstName = editForm.txtFirstName.Text;
                    selectedItem.LastName = editForm.txtLastName.Text;
                   

                    // Save the changes to the XML file
                    //...

                    // Refresh the DataGrid
                    dataGrid.Items.Refresh();
                }
            }
        }
    




            private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected row
            Person selectedPerson = dataGrid.SelectedItem as Person;
            if (selectedPerson != null)
            {
                // Confirm delete
                MessageBoxResult result = System.Windows.MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // Delete the selected person from the database
                     using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=smarthouse;password="))
                     {
                      con.Open();
                      using (MySqlCommand cmd = new MySqlCommand("DELETE FROM users WHERE id = @ID", con))
                      {
                         cmd.Parameters.AddWithValue("@ID", selectedPerson.Id);
                         cmd.ExecuteNonQuery();
                     }
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM user WHERE id = @ID", con))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedPerson.Id);
                            cmd.ExecuteNonQuery();
                        }
                        // a.Del(selectedPerson.Id);
                    }
                    // Reload the data
                    LoadData();
                }
            }
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

            public void Button_Click_3(object sender, RoutedEventArgs e)
            {
                dashboard dash = new dashboard();
                this.Close();
                dash.Show();
            }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            habitant dash = new habitant();
            this.Close();
            dash.Show();
        }
    }
    }

