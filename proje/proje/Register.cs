﻿using System;
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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
        private void register_reg_Click(object sender, EventArgs e)
        {
            string mail = mail_input.Text;
            string username = username_register.Text;
            string password = password_reg.Text;
            string rePassword = re_password.Text;


            // if repassword and password match create new user
            if (password == rePassword)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();


                    string sql = "INSERT INTO user (username, password, mail) VALUES (@username, @password, @mail)";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@mail", mail);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Account created successfully!");
                            Shop newForm = new Shop();
                            newForm.Show();
                        }
                        catch (Exception ex) 
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    connection.Close();
                }

            }
        }
    }
}
