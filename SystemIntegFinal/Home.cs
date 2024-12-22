using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIntegFinal
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            form1 obj = new form1();
            obj.Show();
            this.Hide();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }

}
