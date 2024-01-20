namespace PointOfSale
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txttotalamount = new TextBox();
            txtdiscount = new TextBox();
            lbldiscount = new Label();
            lbltotolamount = new Label();
            btncancel = new Button();
            btndel = new Button();
            btnsave = new Button();
            txtprodname = new TextBox();
            txtcustname = new TextBox();
            label5 = new Label();
            txtid = new TextBox();
            txtproductname = new Label();
            lblcustomername = new Label();
            lblid = new Label();
            txtdate = new TextBox();
            label1 = new Label();
            grddata = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grddata).BeginInit();
            SuspendLayout();
            // 
            // txttotalamount
            // 
            txttotalamount.Location = new Point(258, 302);
            txttotalamount.Name = "txttotalamount";
            txttotalamount.Size = new Size(365, 27);
            txttotalamount.TabIndex = 60;
            // 
            // txtdiscount
            // 
            txtdiscount.Location = new Point(258, 258);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(365, 27);
            txtdiscount.TabIndex = 61;
            // 
            // lbldiscount
            // 
            lbldiscount.AutoSize = true;
            lbldiscount.Location = new Point(121, 261);
            lbldiscount.Name = "lbldiscount";
            lbldiscount.Size = new Size(67, 20);
            lbldiscount.TabIndex = 59;
            lbldiscount.Text = "Discount";
            // 
            // lbltotolamount
            // 
            lbltotolamount.AutoSize = true;
            lbltotolamount.Location = new Point(109, 309);
            lbltotolamount.Name = "lbltotolamount";
            lbltotolamount.Size = new Size(99, 20);
            lbltotolamount.TabIndex = 58;
            lbltotolamount.Text = "Total Amount";
            // 
            // btncancel
            // 
            btncancel.Location = new Point(498, 408);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(138, 47);
            btncancel.TabIndex = 57;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(325, 408);
            btndel.Name = "btndel";
            btndel.Size = new Size(138, 47);
            btndel.TabIndex = 56;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(156, 408);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(138, 47);
            btnsave.TabIndex = 55;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtprodname
            // 
            txtprodname.Location = new Point(258, 201);
            txtprodname.Name = "txtprodname";
            txtprodname.Size = new Size(365, 27);
            txtprodname.TabIndex = 54;
            // 
            // txtcustname
            // 
            txtcustname.Location = new Point(258, 147);
            txtcustname.Name = "txtcustname";
            txtcustname.Size = new Size(365, 27);
            txtcustname.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(342, 30);
            label5.Name = "label5";
            label5.Size = new Size(147, 38);
            label5.TabIndex = 52;
            label5.Text = "PAYMENT";
            // 
            // txtid
            // 
            txtid.Location = new Point(258, 90);
            txtid.Name = "txtid";
            txtid.Size = new Size(365, 27);
            txtid.TabIndex = 51;
            txtid.Validating += txtid_Validating;
            // 
            // txtproductname
            // 
            txtproductname.AutoSize = true;
            txtproductname.Location = new Point(111, 208);
            txtproductname.Name = "txtproductname";
            txtproductname.Size = new Size(97, 20);
            txtproductname.TabIndex = 50;
            txtproductname.Text = "Productname";
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Location = new Point(111, 154);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(109, 20);
            lblcustomername.TabIndex = 49;
            lblcustomername.Text = "Customername";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(111, 93);
            lblid.Name = "lblid";
            lblid.Size = new Size(24, 20);
            lblid.TabIndex = 48;
            lblid.Text = "ID";
            // 
            // txtdate
            // 
            txtdate.Location = new Point(258, 355);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(365, 27);
            txtdate.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 358);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 62;
            label1.Text = "Date";
            // 
            // grddata
            // 
            grddata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grddata.Location = new Point(12, 471);
            grddata.Name = "grddata";
            grddata.RowHeadersWidth = 51;
            grddata.Size = new Size(858, 224);
            grddata.TabIndex = 64;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(882, 707);
            Controls.Add(grddata);
            Controls.Add(txtdate);
            Controls.Add(label1);
            Controls.Add(txttotalamount);
            Controls.Add(txtdiscount);
            Controls.Add(lbldiscount);
            Controls.Add(lbltotolamount);
            Controls.Add(btncancel);
            Controls.Add(btndel);
            Controls.Add(btnsave);
            Controls.Add(txtprodname);
            Controls.Add(txtcustname);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(txtproductname);
            Controls.Add(lblcustomername);
            Controls.Add(lblid);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)grddata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncancel;
        private Button btndel;
        private Button btnsave;
        private TextBox txtprodname;
        private TextBox txtquantity;
        private Label label5;
        private TextBox txtid;
        private Label lblquantity;
        private Label txtprice;
        private Label lblproduct;
        private Label lblid;
        private Label txtproductname;
        private TextBox txttotalamount;
        private TextBox txtdiscount;
        private Label lbldiscount;
        private Label lbltotolamount;
        private TextBox txtcustname;
        private Label lblcustomername;
        private TextBox txtdate;
        private Label label1;
        private DataGridView grddata;
    }
}