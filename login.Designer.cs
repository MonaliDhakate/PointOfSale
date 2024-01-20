namespace PointOfSale
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            lblid = new Label();
            lblname = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            btnlogin = new Button();
            btncancel = new Button();
            txtlogin = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblid.Location = new Point(153, 195);
            lblid.Name = "lblid";
            lblid.Size = new Size(33, 28);
            lblid.TabIndex = 0;
            lblid.Text = "ID";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblname.Location = new Point(106, 293);
            lblname.Name = "lblname";
            lblname.Size = new Size(122, 28);
            lblname.TabIndex = 1;
            lblname.Text = "PASSWORD";
            // 
            // txtid
            // 
            txtid.Location = new Point(258, 199);
            txtid.Name = "txtid";
            txtid.Size = new Size(284, 27);
            txtid.TabIndex = 2;
            // 
            // txtname
            // 
            txtname.Location = new Point(258, 293);
            txtname.Name = "txtname";
            txtname.Size = new Size(284, 27);
            txtname.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnlogin.Location = new Point(219, 357);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(120, 49);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btncancel
            // 
            btncancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btncancel.Location = new Point(391, 357);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(120, 49);
            btncancel.TabIndex = 5;
            btncancel.Text = "CANCEL";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // txtlogin
            // 
            txtlogin.AutoSize = true;
            txtlogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtlogin.Location = new Point(303, 24);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(191, 38);
            txtlogin.TabIndex = 6;
            txtlogin.Text = "LOGIN FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(329, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(711, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtlogin);
            Controls.Add(btncancel);
            Controls.Add(btnlogin);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(lblname);
            Controls.Add(lblid);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblname;
        private TextBox txtid;
        private TextBox txtname;
        private Button btnlogin;
        private Button btncancel;
        private Label txtlogin;
        private PictureBox pictureBox1;
    }
}
