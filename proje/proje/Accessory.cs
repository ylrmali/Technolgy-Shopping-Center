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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proje
{
    public partial class Accessory : UserControl
    {
        public Accessory()
        {
            InitializeComponent();
        }

        private Laptop laptop = new Laptop();

        

        private void button5_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(1, "accessory");
            laptop.BuyProduct(price, laptop.GetUserBalance(),laptop.GetUserName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(2, "accessory");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(3, "accessory");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(4, "accessory");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(5, "accessory");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(6, "accessory");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }
    }
}
