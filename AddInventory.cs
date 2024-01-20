using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class AddInventory : Form
    {
        DAL dal = new DAL();
        bool recfound = false;
        public AddInventory()
        {
            InitializeComponent();
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "select");
            dal.addParameters("id", txtid.Text);
            SqlDataReader rdr = dal.getreader("sp_inventory");
            dal.isProCall = false;
            if (rdr != null && rdr.HasRows)
            {
                recfound = true;
                rdr.Read();
                txtproductname.Text = rdr["productname"].ToString();
                txtproductprice.Text = rdr["price"].ToString();
                txtquantity.Text = rdr["quantity"].ToString();

            }

            else
            {
                txtproductname.Text = "";
                txtproductprice.Text = "";
                txtquantity.Text = "";


            }
            rdr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string query = "";
            if (MessageBox.Show("Do you want to save ?", "inventory", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "insert");
            dal.addParameters("id", txtid.Text);
            dal.addParameters("productname", txtproductname.Text);
            dal.addParameters("price", txtproductprice.Text);
            dal.addParameters("quantity", txtquantity.Text);


            if (!recfound)
            {
                query = $"insert into tbl_inventory values ('{txtid.Text}','{txtproductname.Text}'," +
                      $"'{txtproductprice.Text}','{txtquantity.Text}') ";
            }
            else
            {
                query = $"update tbl_inventory set productname='{txtproductname.Text}',price='{txtproductprice.Text}'," +
                    $"quantity='{txtquantity.Text}'";
            }

            try
            {
                int res = dal.ExecuteQuery("sp_inventory");


                if (res > 0)
                {
                    recfound = false;
                    MessageBox.Show("Record saved successfully!!");
                }
                dal.isProCall = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();

        }
        public void clear()
        {
            txtid.Text = string.Empty;
            txtproductname.Text = string.Empty;
            txtproductprice.Text = string.Empty;
            txtquantity.Text = string.Empty;
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action","delete");
            dal.addParameters("id",txtid.Text);
            int res = dal.ExecuteQuery("sp_inventory");
            dal.isProCall = false;

            if (res > 0)
            {
                MessageBox.Show("Customer Record deleted");

            }
            clear();
        }
    }
}
