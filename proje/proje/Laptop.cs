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

namespace proje
{
    public partial class Laptop : UserControl
    {
       
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductImagePath { get; set; }
        public List<Laptop> products = new List<Laptop>();

        public void GetDatas()
        {
            Dictionary < string, string[]> myDict = new Dictionary<string, string[]>();
            List<string[]> myList = new List<string[]>();
            // Retrieve data from the SQLite database
            string connectionString = "Data Source=C:\\Users\\ali\\Desktop\\a.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT id, name, price, imagepath FROM laptop";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.GetInt32(0).ToString();
                            var name = reader.GetString(1).ToString();
                            var price = reader.GetString(2).ToString();
                            var imagepath = reader.GetString(3).ToString();
                            string[] myArr = { name, price, imagepath };
                           
                            myDict.Add(id, myArr);
                        }
                    }
                }

                connection.Close();
            }

            // Using foreach loop with var
            foreach (var kvp in myDict)
            {
                string key = kvp.Key;
                string[] value = kvp.Value;
                string name = value[0];
                string price = value[1];
                string imagepath = value[2];
                CreateProducts(name, price, imagepath);

                MessageBox.Show($"Key: {key}, name: {name}, price: {price}, img: {imagepath}");
            }

            //MessageBox.Show(products.Count.ToString());
        }

        public void CreateProducts(string name, string price, string imagepath)
        {
            // Create and position group boxes dynamically
            int groupBoxHeight = 150;
            int groupBoxWidth = 200;
            int spacing = 20;
            int startX = 20;
            int startY = 20;

            GroupBox groupBox = new GroupBox();
            groupBox.Text = name;
            groupBox.Size = new Size(groupBoxWidth, groupBoxHeight);
            groupBox.Location = new Point(startX, startY);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(imagepath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(groupBoxWidth - 20, groupBoxHeight - 80);
            pictureBox.Location = new Point(10, 30);

            Label nameLabel = new Label();
            nameLabel.Text = name;
            nameLabel.Location = new Point(10, groupBoxHeight - 40);

            Label priceLabel = new Label();
            priceLabel.Text = price;
            priceLabel.Location = new Point(10, groupBoxHeight - 20);

            // Add the controls to the group box
            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(nameLabel);
            groupBox.Controls.Add(priceLabel);

            // Add the group box to the form
            this.Controls.Add(groupBox);

            // Update the starting Y position for the next group box
            startY += groupBoxHeight + spacing;
        }

        public Laptop()
        {
            InitializeComponent();
            GetDatas();
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
    }


}
