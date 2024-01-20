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
    public partial class AddToCart : Form
    { AddCustomer a = new AddCustomer();
        DAL dal = new DAL();
        bool recfound = false;
        public AddToCart()
        {
            InitializeComponent();
        }

        private void txtid_Validating(object sender, CancelEventArgs e)
        {
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "select");
            dal.addParameters("id", txtid.Text);
            SqlDataReader rdr = dal.getreader("sp_cart");
            dal.isProCall = false;
            if (rdr != null && rdr.HasRows)
            {
                recfound = true;
                rdr.Read();
                txtcustname.Text = rdr["customername"].ToString();
                txtprodprice.Text = rdr["productname"].ToString();
                txtprice.Text = rdr["price"].ToString();
                txtquantity.Text = rdr["quantity"].ToString();
                txttotalamount.Text = rdr["totalamount"].ToString();

            }

            else
            {
                txtcustname.Text = "";
                txtprodprice.Text = "";
                txtprice.Text = "";
                txtquantity.Text = "";
                txttotalamount.Text = "";


            }
            rdr.Close();
        }

        public void clear()
        {
            txtid.Text = string.Empty;
            txtcustname.Text = string.Empty;
            txtprice.Text = string.Empty;
            txtprodprice.Text = string.Empty;
            txtquantity.Text = string.Empty;
            txttotalamount.Text = string.Empty;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string query = "";
            if (MessageBox.Show("Do you want to save ?", "cart", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "insert");
            dal.addParameters("id", txtid.Text);
            dal.addParameters("customername", txtcustname.Text);
            dal.addParameters("productname", txtprodprice.Text);
            dal.addParameters("price", txtprice.Text);
            dal.addParameters("quantity", txtquantity.Text);
            dal.addParameters("totalamount", txttotalamount.Text);


            if (!recfound)
            {
                query = $"insert into tbl_cart values ('{txtid.Text}','{txtcustname.Text}','{txtprodprice.Text}'," +
                      $"'{txtprice.Text}','{txtquantity.Text}','{txttotalamount.Text}') ";
            }
            else
            {
                query = $"update  tbl_cart  set customername='{txtcustname.Text}', productname='{txtprodprice.Text}'," +
                    $"price='{txtprice.Text}', quantity='{txtquantity.Text}',totalamount='{txttotalamount.Text}'";
            }

            try
            {
                int res = dal.ExecuteQuery("sp_cart");


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

        private void btndel_Click(object sender, EventArgs e)
        {
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "delete");
            dal.addParameters("id", txtid.Text);
            int res = dal.ExecuteQuery("sp_cart");
            dal.isProCall = false;

            if (res > 0)
            {
                MessageBox.Show("Customer Record deleted");

            }
            clear();
        }

        private void txtquantity_Validating(object sender, CancelEventArgs e)
        {
            txttotalamount.Text = (Convert.ToInt32(txtquantity.Text) * Convert.ToDouble(txtprice.Text)).ToString();
        }
    }
}
