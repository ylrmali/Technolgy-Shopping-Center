using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static proje.Shop;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace proje
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        public class YourObject
        {
            public int Id { get; set; }
            public string Name { get; set; }
            // Add more properties as needed
        }


        // this function returns current username 
        public string GetCurrentUser()
        {
            string user = string.Empty;
            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT username FROM current_user";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the data using reader
                            user = reader.GetString(0);
                        }

                    }
                }
                connection.Close();
            }
            return user;

        }


        // this function get current username datas
        public List<string> GetUserDatas()
        {
            string username = string.Empty;
            string mail = string.Empty;
            string wallet = string.Empty;
            List<string> data = new List<string>();

            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT username,mail,wallet FROM user WHERE username=@user";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    // get current user first
                    string currentUser = GetCurrentUser();
                    command.Parameters.AddWithValue("@user", currentUser);
                    // then get datas of user
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // get results of query
                            //id = reader.GetInt32(0);
                            username = reader.GetString(0);
                            mail = reader.GetString(1);
                            wallet = reader.GetString(2);

                            // store this datas an list
                            //data.Add(id);
                            data.Add(username);
                            data.Add(mail);
                            data.Add(wallet);
                        }

                    }
                }

                connection.Close();
            }
            return data;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            wallet1.Visible = false;
            laptop2.Visible = false;
            phone1.Visible = false;
            accessory1.Visible = false;
        }

        private void wallet_Click(object sender, EventArgs e)
        {
            wallet1.Visible = true;
            laptop2.Visible = false;
            accessory1.Visible = false;
        }

        private void wallet1_Load(object sender, EventArgs e)
        {

        }

        private void laptop_Click(object sender, EventArgs e)
        {
            laptop2.Visible = true;
            phone1.Visible = false;
            wallet1.Visible = false;
            accessory1.Visible = false;

        }

        private void laptop2_Load(object sender, EventArgs e)
        {

        }

        private void phone_Click(object sender, EventArgs e)
        {
            phone1.Visible = true;
            laptop2.Visible = false;
            wallet1.Visible = false;
            accessory1.Visible = false;

        }

        private void accessory_Click(object sender, EventArgs e)
        {
            accessory1.Visible = true;
            phone1.Visible = false;
            laptop2.Visible = false;
            wallet1.Visible = false;

        }
    }
}
