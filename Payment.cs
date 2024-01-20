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
    public partial class Payment : Form
    {
        DAL dal = new DAL();
        bool recfound = false;
        EDAL edal = new EDAL();
        public Payment()
        {
            InitializeComponent();
            loadgrid();
        }



        private void txtid_Validating(object sender, CancelEventArgs e)
        {

            try
            {

                finalpayment emp = edal.payments.AsQueryable().ToList().FirstOrDefault(e => e.id == Convert.ToInt32(txtid.Text));

                if (emp != null)
                {
                    recfound = true;
                    txtcustname.Text = emp.customername.ToString();
                    txtprodname.Text = emp.productname.ToString();
                    txttotalamount.Text = emp.totalamount.ToString();
                    txtdiscount.Text = emp.discount.ToString();
                    txtdate.Text = emp.date.ToString();


                }
                else
                {
                    txtcustname.Text = "";
                    txtprodname.Text = "";
                    txttotalamount.Text = "";
                    txtdiscount.Text = "";
                    txtdate.Text = "0000-00-00";


                }

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
            txtcustname.Text = string.Empty;
            txtprodname.Text = string.Empty;
            txttotalamount.Text = string.Empty;
            txtdiscount.Text = string.Empty;
            txtdate.Text = string.Empty;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save ?", "payments", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EDAL ed = new EDAL();
            finalpayment sav = new finalpayment();
            sav.id = Convert.ToInt32(txtid.Text);
            sav.customername = txtcustname.Text;
            sav.productname=txtprodname.Text;
            sav.totalamount = Convert.ToDouble(txttotalamount.Text);
            sav.discount= Convert.ToInt32(txtdiscount.Text);
            sav.date=Convert.ToDateTime(txtdate.Text);



            if (recfound)
            {
                ed.Update(sav);
            }
            else
            {
                ed.Add(sav);
            }
           
            try
            {
                int res = ed.SaveChanges();
                if (res > 0)
                {
                    MessageBox.Show("Record saved successfully");
                    clear();
                }
                loadgrid();
                clear();

            }
            catch(Exception eg)
            {
                MessageBox.Show(eg.Message);
            }


        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do u want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;


                EDAL i = new EDAL();
                finalpayment e1 = new finalpayment();
                e1.id = Convert.ToInt32(txtid.Text);
                i.Remove(e1);

                int res = i.SaveChanges();

                if (res > 0)
                {
                    MessageBox.Show("Record delete successfully");
                    clear();
                }
                loadgrid();


            }

            catch (Exception eg)
            {
                MessageBox.Show(eg.Message);
            }
        }
        public void loadgrid()
        {
            try
            {
                DataSet ds = dal.gettables("select * from payments;");

                if (ds.Tables.Count == 1)
                {
                    grddata.DataSource = ds.Tables[0];

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
