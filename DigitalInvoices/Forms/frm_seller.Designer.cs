namespace DigitalInvoices.Forms
{
    partial class frm_seller
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txt_STN = new TextBox();
            txt_NTN = new TextBox();
            txt_BusinessName = new TextBox();
            txt_RegNo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cmb_Province = new ComboBox();
            txt_Address = new TextBox();
            txt_CNIC = new TextBox();
            txt_Email = new TextBox();
            txt_FullName = new TextBox();
            bttn_Update = new Button();
            bttn_Reset = new Button();
            label11 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(0, 8);
            label1.Name = "label1";
            label1.Size = new Size(800, 48);
            label1.TabIndex = 0;
            label1.Text = "Seller Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 32);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 40);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Business Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 32);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 0;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 104);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 0;
            label6.Text = "Province";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(294, 104);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 0;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(584, 32);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 0;
            label8.Text = "CNIC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_STN);
            groupBox1.Controls.Add(txt_NTN);
            groupBox1.Controls.Add(txt_BusinessName);
            groupBox1.Controls.Add(txt_RegNo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(8, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 192);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Business Info";
            // 
            // txt_STN
            // 
            txt_STN.Font = new Font("Segoe UI", 11F);
            txt_STN.Location = new Point(584, 144);
            txt_STN.Name = "txt_STN";
            txt_STN.Size = new Size(192, 32);
            txt_STN.TabIndex = 5;
            // 
            // txt_NTN
            // 
            txt_NTN.Font = new Font("Segoe UI", 11F);
            txt_NTN.Location = new Point(294, 144);
            txt_NTN.Name = "txt_NTN";
            txt_NTN.Size = new Size(188, 32);
            txt_NTN.TabIndex = 6;
            // 
            // txt_BusinessName
            // 
            txt_BusinessName.Font = new Font("Segoe UI", 11F);
            txt_BusinessName.Location = new Point(8, 64);
            txt_BusinessName.Name = "txt_BusinessName";
            txt_BusinessName.Size = new Size(760, 32);
            txt_BusinessName.TabIndex = 7;
            // 
            // txt_RegNo
            // 
            txt_RegNo.Font = new Font("Segoe UI", 11F);
            txt_RegNo.Location = new Point(8, 144);
            txt_RegNo.Name = "txt_RegNo";
            txt_RegNo.Size = new Size(184, 32);
            txt_RegNo.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(584, 120);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 2;
            label10.Text = "STN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(294, 120);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 3;
            label9.Text = "NTN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 120);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Reg. No";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmb_Province);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_Address);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_CNIC);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_Email);
            groupBox2.Controls.Add(txt_FullName);
            groupBox2.Location = new Point(8, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(784, 176);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Info";
            // 
            // cmb_Province
            // 
            cmb_Province.Font = new Font("Segoe UI", 11F);
            cmb_Province.FormattingEnabled = true;
            cmb_Province.Items.AddRange(new object[] { "Islamabad", "Punjab", "Sindh", "KPK", "Ajk", "Gilgit", "Balochistan" });
            cmb_Province.Location = new Point(8, 128);
            cmb_Province.Name = "cmb_Province";
            cmb_Province.Size = new Size(184, 33);
            cmb_Province.TabIndex = 8;
            // 
            // txt_Address
            // 
            txt_Address.Font = new Font("Segoe UI", 11F);
            txt_Address.Location = new Point(294, 129);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(482, 32);
            txt_Address.TabIndex = 7;
            // 
            // txt_CNIC
            // 
            txt_CNIC.Font = new Font("Segoe UI", 11F);
            txt_CNIC.Location = new Point(584, 56);
            txt_CNIC.Name = "txt_CNIC";
            txt_CNIC.Size = new Size(192, 32);
            txt_CNIC.TabIndex = 7;
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI", 11F);
            txt_Email.Location = new Point(294, 56);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(184, 32);
            txt_Email.TabIndex = 7;
            // 
            // txt_FullName
            // 
            txt_FullName.Font = new Font("Segoe UI", 11F);
            txt_FullName.Location = new Point(8, 56);
            txt_FullName.Name = "txt_FullName";
            txt_FullName.Size = new Size(184, 32);
            txt_FullName.TabIndex = 7;
            // 
            // bttn_Update
            // 
            bttn_Update.Font = new Font("Segoe UI", 11F);
            bttn_Update.Location = new Point(648, 488);
            bttn_Update.Name = "bttn_Update";
            bttn_Update.Size = new Size(142, 40);
            bttn_Update.TabIndex = 4;
            bttn_Update.Text = "Update";
            bttn_Update.UseVisualStyleBackColor = true;
            bttn_Update.Click += bttn_Update_Click;
            // 
            // bttn_Reset
            // 
            bttn_Reset.Font = new Font("Segoe UI", 11F);
            bttn_Reset.Location = new Point(496, 488);
            bttn_Reset.Name = "bttn_Reset";
            bttn_Reset.Size = new Size(142, 40);
            bttn_Reset.TabIndex = 4;
            bttn_Reset.Text = "Reset";
            bttn_Reset.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Location = new Point(16, 472);
            label11.Name = "label11";
            label11.Size = new Size(776, 2);
            label11.TabIndex = 0;
            // 
            // frm_seller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 536);
            Controls.Add(bttn_Reset);
            Controls.Add(label11);
            Controls.Add(bttn_Update);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frm_seller";
            Text = "Add Seller Info";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_STN;
        private TextBox txt_NTN;
        private TextBox txt_RegNo;
        private Label label10;
        private Label label9;
        private Label label2;
        private TextBox txt_FullName;
        private TextBox txt_Email;
        private TextBox txt_Address;
        private TextBox txt_CNIC;
        private ComboBox cmb_Province;
        private TextBox txt_BusinessName;
        protected internal Label label1;
        protected internal GroupBox groupBox1;
        protected internal GroupBox groupBox2;
        protected internal Button bttn_Update;
        protected internal Button bttn_Reset;
        protected internal Label label11;
    }
}