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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        public void Form1_Load(object sender, EventArgs e)
        {
            login1.Visible = false;
            register1.Visible = false; 
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            register1.Visible = false;
            login1.Visible = true;
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            login1.Visible = false;
            register1.Visible = true;
        }

        private void control_Enter(object sender, EventArgs e)
        {

        }
    }
}
