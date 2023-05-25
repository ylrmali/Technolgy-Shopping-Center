using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Phone : UserControl
    {
        public Phone()
        {
            InitializeComponent();
        }

        private Laptop laptop = new Laptop();


        private void button5_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(1, "phone");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(2, "phone");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(3, "phone");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(4, "phone");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(5, "phone");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string price = laptop.GetProductPrice(6, "phone");
            laptop.BuyProduct(price, laptop.GetUserBalance(), laptop.GetUserName());
        }
    }
}
