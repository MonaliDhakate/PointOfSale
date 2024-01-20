namespace PointOfSale
{
    partial class AddInventory
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
            lblid = new Label();
            lblproduct = new Label();
            lblprice = new Label();
            lblquantity = new Label();
            txtid = new TextBox();
            label5 = new Label();
            txtproductname = new TextBox();
            txtquantity = new TextBox();
            txtproductprice = new TextBox();
            btnsave = new Button();
            btndel = new Button();
            btncancel = new Button();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(68, 75);
            lblid.Name = "lblid";
            lblid.Size = new Size(24, 20);
            lblid.TabIndex = 0;
            lblid.Text = "ID";
            // 
            // lblproduct
            // 
            lblproduct.AutoSize = true;
            lblproduct.Location = new Point(68, 134);
            lblproduct.Name = "lblproduct";
            lblproduct.Size = new Size(97, 20);
            lblproduct.TabIndex = 1;
            lblproduct.Text = "Productname";
            // 
            // lblprice
            // 
            lblprice.AutoSize = true;
            lblprice.Location = new Point(68, 193);
            lblprice.Name = "lblprice";
            lblprice.Size = new Size(41, 20);
            lblprice.TabIndex = 2;
            lblprice.Text = "Price";
            // 
            // lblquantity
            // 
            lblquantity.AutoSize = true;
            lblquantity.Location = new Point(68, 252);
            lblquantity.Name = "lblquantity";
            lblquantity.Size = new Size(65, 20);
            lblquantity.TabIndex = 3;
            lblquantity.Text = "Quantity";
            // 
            // txtid
            // 
            txtid.Location = new Point(215, 74);
            txtid.Name = "txtid";
            txtid.Size = new Size(365, 27);
            txtid.TabIndex = 4;
            txtid.Validating += txtid_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 19);
            label5.Name = "label5";
            label5.Size = new Size(175, 38);
            label5.TabIndex = 5;
            label5.Text = "INVENTORY";
            // 
            // txtproductname
            // 
            txtproductname.Location = new Point(215, 127);
            txtproductname.Name = "txtproductname";
            txtproductname.Size = new Size(365, 27);
            txtproductname.TabIndex = 6;
            // 
            // txtquantity
            // 
            txtquantity.Location = new Point(215, 252);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(365, 27);
            txtquantity.TabIndex = 7;
            // 
            // txtproductprice
            // 
            txtproductprice.Location = new Point(215, 186);
            txtproductprice.Name = "txtproductprice";
            txtproductprice.Size = new Size(365, 27);
            txtproductprice.TabIndex = 7;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(149, 327);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(138, 47);
            btnsave.TabIndex = 8;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(312, 327);
            btndel.Name = "btndel";
            btndel.Size = new Size(138, 47);
            btndel.TabIndex = 9;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(484, 327);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(138, 47);
            btncancel.TabIndex = 10;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btncancel);
            Controls.Add(btndel);
            Controls.Add(btnsave);
            Controls.Add(txtproductprice);
            Controls.Add(txtquantity);
            Controls.Add(txtproductname);
            Controls.Add(label5);
            Controls.Add(txtid);
            Controls.Add(lblquantity);
            Controls.Add(lblprice);
            Controls.Add(lblproduct);
            Controls.Add(lblid);
            Name = "AddInventory";
            Text = "AddInventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblproduct;
        private Label lblprice;
        private Label lblquantity;
        private TextBox txtid;
        private Label label5;
        private TextBox txtproductname;
        private TextBox txtquantity;
        private TextBox txtproductprice;
        private Button btnsave;
        private Button btndel;
        private Button btncancel;
    }
}