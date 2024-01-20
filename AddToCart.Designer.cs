namespace PointOfSale
{
    partial class AddToCart
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
            lbltotalitem = new Label();
            txtprice = new TextBox();
            txtquantity = new TextBox();
            lblquantity = new Label();
            lblprice = new Label();
            btncancel = new Button();
            btndel = new Button();
            btnsave = new Button();
            txtprodprice = new TextBox();
            txtcustname = new TextBox();
            label5 = new Label();
            txtid = new TextBox();
            txtproductname = new Label();
            lblcustomername = new Label();
            lblid = new Label();
            SuspendLayout();
            // 
            // txttotalamount
            // 
            txttotalamount.Location = new Point(281, 350);
            txttotalamount.Name = "txttotalamount";
            txttotalamount.Size = new Size(365, 27);
            txttotalamount.TabIndex = 47;
            // 
            // lbltotalitem
            // 
            lbltotalitem.AutoSize = true;
            lbltotalitem.Location = new Point(134, 357);
            lbltotalitem.Name = "lbltotalitem";
            lbltotalitem.Size = new Size(95, 20);
            lbltotalitem.TabIndex = 46;
            lbltotalitem.Text = "TotalAmount";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(281, 241);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(365, 27);
            txtprice.TabIndex = 44;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(281, 293);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(365, 27);
            txtquantity.TabIndex = 45;
            txtquantity.Validating += txtquantity_Validating;
            // 
            // lblquantity
            // 
            lblquantity.AutoSize = true;
            lblquantity.Location = new Point(134, 300);
            lblquantity.Name = "lblquantity";
            lblquantity.Size = new Size(65, 20);
            lblquantity.TabIndex = 43;
            lblquantity.Text = "Quantity";
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(134, 244);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(41, 20);
            lblprice.TabIndex = 42;
            lblprice.Text = "Price";
            // 
            // btncancel
            // 
            btncancel.Location = new Point(528, 421);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(138, 47);
            btncancel.TabIndex = 41;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(356, 421);
            btndel.Name = "btndel";
            btndel.Size = new Size(138, 47);
            btndel.TabIndex = 40;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(193, 421);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(138, 47);
            btnsave.TabIndex = 39;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtprodprice
            // 
            txtprodprice.Location = new Point(281, 180);
            txtprodprice.Name = "txtprodprice";
            txtprodprice.Size = new Size(365, 27);
            txtprodprice.TabIndex = 38;
            // 
            // txtcustname
            // 
            txtcustname.Location = new Point(281, 126);
            txtcustname.Name = "txtcustname";
            txtcustname.Size = new Size(365, 27);
            txtcustname.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(365, 9);
            label5.Name = "label5";
            label5.Size = new Size(87, 38);
            label5.TabIndex = 36;
            label5.Text = "CART";
            // 
            // txtid
            // 
            txtid.Location = new Point(281, 69);
            txtid.Name = "txtid";
            txtid.Size = new Size(365, 27);
            txtid.TabIndex = 35;
            txtid.Validating += txtid_Validating;
            // 
            // txtproductname
            // 
            txtproductname.AutoSize = true;
            txtproductname.Location = new Point(134, 187);
            txtproductname.Name = "txtproductname";
            txtproductname.Size = new Size(97, 20);
            txtproductname.TabIndex = 34;
            txtproductname.Text = "Productname";
            // 
            // lblcustomername
            // 
            lblcustomername.AutoSize = true;
            lblcustomername.Location = new Point(134, 133);
            lblcustomername.Name = "lblcustomername";
            lblcustomername.Size = new Size(109, 20);
            lblcustomername.TabIndex = 33;
            lblcustomername.Text = "Customername";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(134, 72);
            lblid.Name = "lblid";
            lblid.Size = new Size(24, 20);
            lblid.TabIndex = 32;
            lblid.Text = "ID";
            // 
            // AddToCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 527);
            Controls.Add(txttotalamount);
            Controls.Add(lbltotalitem);
            Controls.Add(txtprice);
            Controls.Add(txtquantity);
            Controls.Add(lblquantity);
            Controls.Add(lblprice);
            Controls.Add(btncancel);
            Controls.Add(btndel);
            Controls.Add(btnsave);
            Controls.Add(txtprodprice);
            Controls.Add(txtcustname);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(txtproductname);
            Controls.Add(lblcustomername);
            Controls.Add(lblid);
            Name = "AddToCart";
            Text = "AddToCart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttotalamount;
        private Label lbltotalitem;
        private TextBox txtprice;
        private TextBox txtquantity;
        private Label lblquantity;
        private Label lblprice;
        private Button btncancel;
        private Button btndel;
        private Button btnsave;
        private TextBox txtprodprice;
        private TextBox txtcustname;
        private Label label5;
        private TextBox txtid;
        private Label txtproductname;
        private Label lblcustomername;
        private Label lblid;
    }
}