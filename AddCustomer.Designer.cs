namespace PointOfSale
{
    partial class AddCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtid = new TextBox();
            txtfname = new TextBox();
            txtlname = new TextBox();
            txtmob = new TextBox();
            txtstate = new TextBox();
            txtcity = new TextBox();
            txtaddress = new TextBox();
            txtpincode = new TextBox();
            btnsave = new Button();
            btncancel = new Button();
            btndel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 139);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 196);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 242);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Mob no";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 291);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 4;
            label5.Text = "State";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 343);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 5;
            label6.Text = "City";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 391);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 6;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 453);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 7;
            label8.Text = "Pincode";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(268, 9);
            label9.Name = "label9";
            label9.Size = new Size(236, 38);
            label9.TabIndex = 8;
            label9.Text = "ADD CUSTOMER";
            // 
            // txtid
            // 
            txtid.Location = new Point(246, 78);
            txtid.Name = "txtid";
            txtid.Size = new Size(323, 27);
            txtid.TabIndex = 9;
            txtid.Validating += txtid_Validating;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(246, 136);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(323, 27);
            txtfname.TabIndex = 10;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(246, 193);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(323, 27);
            txtlname.TabIndex = 11;
            // 
            // txtmob
            // 
            txtmob.Location = new Point(246, 242);
            txtmob.Name = "txtmob";
            txtmob.Size = new Size(323, 27);
            txtmob.TabIndex = 12;
            // 
            // txtstate
            // 
            txtstate.Location = new Point(246, 288);
            txtstate.Name = "txtstate";
            txtstate.Size = new Size(323, 27);
            txtstate.TabIndex = 13;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(246, 340);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(323, 27);
            txtcity.TabIndex = 14;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(246, 391);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(323, 27);
            txtaddress.TabIndex = 15;
            // 
            // txtpincode
            // 
            txtpincode.Location = new Point(237, 446);
            txtpincode.Name = "txtpincode";
            txtpincode.Size = new Size(323, 27);
            txtpincode.TabIndex = 16;
            // 
            // btnsave
            // 
            btnsave.Location = new Point(151, 517);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(144, 52);
            btnsave.TabIndex = 17;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btncancel
            // 
            btncancel.Location = new Point(320, 517);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(144, 52);
            btncancel.TabIndex = 18;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btndel
            // 
            btndel.Location = new Point(485, 517);
            btndel.Name = "btndel";
            btndel.Size = new Size(144, 52);
            btndel.TabIndex = 19;
            btndel.Text = "Delete";
            btndel.UseVisualStyleBackColor = true;
            btndel.Click += btndel_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(752, 581);
            Controls.Add(btndel);
            Controls.Add(btncancel);
            Controls.Add(btnsave);
            Controls.Add(txtpincode);
            Controls.Add(txtaddress);
            Controls.Add(txtcity);
            Controls.Add(txtstate);
            Controls.Add(txtmob);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtid;
        private TextBox txtfname;
        private TextBox txtlname;
        private TextBox txtmob;
        private TextBox txtstate;
        private TextBox txtcity;
        private TextBox txtaddress;
        private TextBox txtpincode;
        private Button btnsave;
        private Button btncancel;
        private Button btndel;
    }
}