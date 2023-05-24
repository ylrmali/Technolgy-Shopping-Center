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

        private void Shop_Load(object sender, EventArgs e)
        {
            wallet1.Visible = false;

            // Create an empty list of strings
            Dictionary<string, string> myDict = new Dictionary<string, string>();

            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT id, name FROM laptop";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Access the data using reader
                            var id = reader.GetInt32(0).ToString();
                            var name = reader.GetString(1).ToString();

                            myDict.Add(id, name);
                        }
                    }
                }
                connection.Close();
            }

            // Using foreach loop with var
            foreach (var kvp in myDict)
            {
                string key = kvp.Key;
                string value = kvp.Value;
                MessageBox.Show($"Key: {key}, Value: {value}");
            }

        }

        private void wallet_Click(object sender, EventArgs e)
        {
            wallet1.Visible = true;
            Login newLogin = new Login();
            string username = newLogin.get_username();
        }

    }
}
