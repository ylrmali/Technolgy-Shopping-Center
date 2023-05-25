using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Wallet : UserControl
    {
        public Wallet()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public string wallet;
        public string username;
        private void Wallet_Load(object sender, EventArgs e)
        {
            Shop shop = new Shop();
            // get datas list
            List<string> list = shop.GetUserDatas();


            // define variables 
            username = list[0];
            string email = list[1];
            wallet = list[2];


            // set current wallet balance
            balance.Text = $"{wallet} TL ";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get current balance
            double wall = Convert.ToDouble(wallet);

            // get new money amount
            double amount = Convert.ToDouble(money_amount.Text);

            double result = wall + amount ;

            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            string sql = "UPDATE user SET wallet = @wallet WHERE username = @username" ;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    // Set the parameter values
                    command.Parameters.AddWithValue("@wallet", result.ToString());
                    command.Parameters.AddWithValue("@username", username);


                    // Execute the update command
                    command.ExecuteNonQuery();

                }

                connection.Close();
            }

            // set current wallet balance
            balance.Text = $"{result} TL ";
        }
    }
}
