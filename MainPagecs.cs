using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class MainPagecs : Form
    {
        public MainPagecs()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddCustomer a = new AddCustomer();
            a.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddInventory a = new AddInventory();
            a.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddToCart a = new AddToCart();
            a.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.ShowDialog();
        }
    }
}
