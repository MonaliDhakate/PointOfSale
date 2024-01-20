namespace PointOfSale
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtid.Text=="admin" && txtname.Text=="admin123")
            {
                MessageBox.Show("login successfully");
            }
            else
            {
                MessageBox.Show("Invalid id password ");
            }

            MainPagecs m=new MainPagecs();
            m.ShowDialog();
        }
    }
}
