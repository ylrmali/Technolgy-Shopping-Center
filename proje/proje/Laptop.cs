using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proje
{
    public partial class Laptop : UserControl
    {
       public string GetUserBalance()
        {
            Shop shop = new Shop();
            // get datas list
            List<string> instance = shop.GetUserDatas();

            string balance = instance[2];

            return balance;
        }

        public string GetUserName()
        {
            Shop shop = new Shop();
            // get datas list
            List<string> instance = shop.GetUserDatas();

            string username = instance[0];

            return username;
        }
        
        // get product price dynamicly
        public string GetProductPrice(int id, string table)
        {
            string price = string.Empty; 
            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = $"SELECT price FROM {table} WHERE id = @id";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("table", table);
                    command.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            price = reader.GetString(0);

                        }
                    }
                }

                connection.Close();
            }
            return price;
        }

        // product buying function
        public string BuyProduct(string  productPrice, string userBalance, string userName) 
        {

            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // if user want to buy
                if (Convert.ToDouble(userBalance) >= Convert.ToDouble(productPrice))
                {
                    double newBalance = Convert.ToDouble(userBalance) - Convert.ToDouble(productPrice);
                    string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "UPDATE user SET wallet = @newBalance WHERE username = @username";
                        using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@newBalance", newBalance.ToString());
                            command.Parameters.AddWithValue("@username", userName);
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }

                    MessageBox.Show($"Your current balance is {newBalance} TL", "New Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Your balance is not enough for buying this product. Go to wallet and deposit money!", "Balance is not enough", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (result == DialogResult.No)
            {
                // User clicked the "No" button
                // Perform the desired action or simply close the message box
            }
            return productPrice;
        }


        public Laptop()
        {
            InitializeComponent();
        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Laptop_Load(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string price = GetProductPrice(1, "laptop");
            BuyProduct(price, GetUserBalance(), GetUserName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string price = GetProductPrice(2, "laptop");
            BuyProduct(price, GetUserBalance(), GetUserName());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string price = GetProductPrice(3, "laptop");
            BuyProduct(price, GetUserBalance(), GetUserName());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string price = GetProductPrice(4, "laptop");
            BuyProduct(price, GetUserBalance(), GetUserName());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string price = GetProductPrice(5, "laptop");
            BuyProduct(price, GetUserBalance(), GetUserName());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string price = GetProductPrice(6, "laptop");
            BuyProduct(price, GetUserBalance(), GetUserName());
        }
    }


}
