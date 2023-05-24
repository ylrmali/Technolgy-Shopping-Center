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


namespace proje
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private string userName;
        private void Authenticate(string username, string password)
        {
            //sql connection
            string user = string.Empty;
            string pass = string.Empty;
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
                            user = reader.GetString(0);
                            pass = reader.GetString(1);
                        }
                    }
                }
                connection.Close();
            }
            // control datas 
            if (username == user && password == pass)
            {
                set_username(user);
                Shop newForm = new Shop();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Password does not match with this username");
            }

        }

        public object set_username(string username)
        {
            userName = username;
            return this;
        }

        public string get_username()
        {
            return userName;
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
