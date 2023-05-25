using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Common;


namespace proje
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private string user;
        private string pass;

        public string Usr
        {
            get { return user; }
            set { user = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string userName;
        private void Authenticate(string username, string password)
        {
            Login login = new Login();

            
            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT username, password FROM user WHERE username = @username";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the data using reader
                            login.Usr = reader.GetString(0);
                            login.Pass = reader.GetString(1);
                        }
                    }
                }

                connection.Close();
            }
            //string user = login.User;
            //string pass = login.Password;

            // control datas 
            if (username == login.Usr && password == login.Pass)
            {
                // first delete old instance 
                DeleteUser();
                // create current user table for user process
                CreateUser(username);

                Shop newForm = new Shop();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Password does not match with this username");
            }

        }


        // create current user session
        public void CreateUser(string username)
        {
            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS current_user (id INTEGER PRIMARY KEY, username TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                //add current user into current user table
                string sql2 = "INSERT INTO current_user (id, username) values (1, @username)";
                using (SQLiteCommand command2 = new SQLiteCommand(sql2, connection))
                {
                    command2.Parameters.AddWithValue("@username", username);
                    command2.ExecuteNonQuery();
                }

                connection.Close();

            }
        }

        // delete current user session
        public void DeleteUser()
        {
            
            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "DROP TABLE IF EXISTS current_user";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }


        private void login_login_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;

            Authenticate(username, password);
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
