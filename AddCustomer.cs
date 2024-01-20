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
    public partial class AddCustomer : Form
    {
        DAL dal = new DAL();
        bool recfound = false;
        public AddCustomer()
        {
            InitializeComponent();
        }

        public void txtid_Validating(object sender, CancelEventArgs e)
        {
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "select");
            dal.addParameters("id", txtid.Text);
            SqlDataReader rdr = dal.getreader("sp_addcustomer");
            dal.isProCall = false;
            if (rdr != null && rdr.HasRows)
            {
                recfound = true;
                rdr.Read();
                txtfname.Text = rdr["firstname"].ToString();
                txtlname.Text = rdr["latname"].ToString();
                txtmob.Text = rdr["mobileno"].ToString();
                txtstate.Text = rdr["state"].ToString();
                txtcity.Text = rdr["city"].ToString();
                txtaddress.Text = rdr["address"].ToString();
                txtpincode.Text = rdr["pincode"].ToString();
            }

            else
            {
                txtfname.Text = "";
                txtlname.Text = "";
                txtmob.Text = "";
                txtstate.Text = "";
                txtcity.Text = "";
                txtaddress.Text = "";
                txtpincode.Text = "";

            }
            rdr.Close();
        }

        public void btnsave_Click(object sender, EventArgs e)
        {
            string query = "";
            if (MessageBox.Show("Do you want to save ?", "inventory", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("id", txtid.Text);
            dal.addParameters("firstname", txtfname.Text);
            dal.addParameters("latname", txtlname.Text);
            dal.addParameters("mobileno", txtmob.Text);
            dal.addParameters("state", txtstate.Text);
            dal.addParameters("city", txtcity.Text);
            dal.addParameters("address", txtaddress.Text);
            dal.addParameters("pincode", txtpincode.Text);

            if (!recfound)
            {
                dal.addParameters("action", "insert");  //by dal
                query = $"insert into tbl_addcustomers values ('{txtid.Text}','{txtfname.Text}','{txtlname.Text}'," +
                 $"'{txtmob.Text}','{txtstate.Text}','{txtcity.Text}','{txtaddress.Text}','{txtpincode}')";


            }
            else
            {
                dal.addParameters("action", "update");
                query = $"UPDATE tbl_addcustomers SET firstname = '{txtfname.Text}', latname = '{txtlname.Text}', " +
                  $"mobileno = '{txtmob.Text}', state = '{txtstate.Text}', city = '{txtcity.Text}'," +
                  $" address = '{txtaddress}', pincode = '{txtpincode.Text}' WHERE id = '{txtid.Text}'";
            }

            try
            {
                int res = dal.ExecuteQuery("sp_addcustomer");


                if (res > 0)
                {
                    recfound = false;
                    MessageBox.Show("Customer Record saved successfully!!");
                }
                dal.isProCall = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {

            txtid.Text = string.Empty;
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtmob.Text = string.Empty;
            txtstate.Text = string.Empty;
            txtcity.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtpincode.Text = string.Empty;
        }

        public void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Delete Customer", MessageBoxButtons.YesNo) == DialogResult.No)

                return;

            dal.isProCall = true;
            dal.ClearParameters();
            dal.addParameters("action", "delete");
            dal.addParameters("id", txtid.Text);
            int res = dal.ExecuteQuery("sp_addcustomer");
            dal.isProCall = false;

            if (res > 0)
            {
                MessageBox.Show("Customer Record deleted....");

            }
            clear();
        }
    }
}
