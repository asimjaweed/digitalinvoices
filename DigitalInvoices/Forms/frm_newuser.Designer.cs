namespace DigitalInvoices
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txt_fullname = new TextBox();
            btn_cancel = new Button();
            btn_reset = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15F, FontStyle.Bold);
            label4.Location = new Point(232, 56);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 6;
            label4.Text = "New User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20F, FontStyle.Bold);
            label3.Location = new Point(224, 8);
            label3.Name = "label3";
            label3.Size = new Size(335, 32);
            label3.TabIndex = 7;
            label3.Text = "Digital Invoicing System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 8);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 370);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Arial", 12F);
            txt_password.Location = new Point(240, 288);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(320, 26);
            txt_password.TabIndex = 12;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Arial", 12F);
            txt_username.Location = new Point(240, 208);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(320, 26);
            txt_username.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(240, 264);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(240, 184);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(240, 104);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 9;
            label5.Text = "Full Name";
            // 
            // txt_fullname
            // 
            txt_fullname.Font = new Font("Arial", 12F);
            txt_fullname.Location = new Point(240, 128);
            txt_fullname.Margin = new Padding(3, 2, 3, 2);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(320, 26);
            txt_fullname.TabIndex = 11;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Arial", 12F);
            btn_cancel.Location = new Point(248, 344);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(99, 32);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_reset
            // 
            btn_reset.Font = new Font("Arial", 12F);
            btn_reset.Location = new Point(356, 344);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(99, 32);
            btn_reset.TabIndex = 13;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Arial", 12F);
            btn_add.Location = new Point(464, 344);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(99, 32);
            btn_add.TabIndex = 13;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 382);
            Controls.Add(btn_add);
            Controls.Add(btn_reset);
            Controls.Add(btn_cancel);
            Controls.Add(txt_password);
            Controls.Add(txt_fullname);
            Controls.Add(txt_username);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "AddUserForm";
            Text = "Add New User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txt_fullname;
        private Button btn_cancel;
        private Button btn_reset;
        private Button btn_add;
    }
}