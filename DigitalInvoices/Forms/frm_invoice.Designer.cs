namespace DigitalInvoices
{
    partial class InvoiceForm
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
            cmb_customer = new ComboBox();
            label11 = new Label();
            bttn_Add = new Button();
            label18 = new Label();
            dtp_Date = new DateTimePicker();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            txt_FixedNotifiedValue = new TextBox();
            txt_ValueExcludingST = new TextBox();
            txt_FurtherTax = new TextBox();
            txt_ExtraTax = new TextBox();
            txt_STWithoutSource = new TextBox();
            txt_SroItemNo = new TextBox();
            txt_SaleType = new TextBox();
            txt_Discount = new TextBox();
            txt_FedPayable = new TextBox();
            txt_SroSchedule = new TextBox();
            txt_STApplicable = new TextBox();
            txt_TotalValue = new TextBox();
            txt_Rate = new TextBox();
            label22 = new Label();
            label6 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label5 = new Label();
            label16 = new Label();
            label15 = new Label();
            label4 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmb_Uom = new ComboBox();
            cmb_product = new ComboBox();
            cmb_Qty = new ComboBox();
            bttn_Reset = new Button();
            bttn_Save = new Button();
            lbl_formDimensions = new Label();
            label23 = new Label();
            txt_InvoiceRefNo = new TextBox();
            label24 = new Label();
            cmb_Scenario = new ComboBox();
            btt_ValidateData = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Arial", 10.2F);
            label1.Location = new Point(11, 8);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 0);
            label1.Size = new Size(1917, 31);
            label1.TabIndex = 1;
            label1.Text = "Invoice Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F);
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 2;
            label2.Text = "Customer *";
            // 
            // cmb_customer
            // 
            cmb_customer.Font = new Font("Arial", 10.2F);
            cmb_customer.FormattingEnabled = true;
            cmb_customer.Location = new Point(127, 55);
            cmb_customer.Name = "cmb_customer";
            cmb_customer.Size = new Size(289, 27);
            cmb_customer.TabIndex = 1;
            // 
            // label11
            // 
            label11.BackColor = Color.LightSkyBlue;
            label11.Font = new Font("Arial", 10.2F);
            label11.Location = new Point(0, 152);
            label11.Margin = new Padding(3, 3, 3, 0);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 5, 0, 0);
            label11.Size = new Size(1924, 31);
            label11.TabIndex = 1;
            label11.Text = "Invoice Details";
            // 
            // bttn_Add
            // 
            bttn_Add.BackColor = Color.LightSkyBlue;
            bttn_Add.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bttn_Add.Location = new Point(1160, 272);
            bttn_Add.Margin = new Padding(1);
            bttn_Add.Name = "bttn_Add";
            bttn_Add.Size = new Size(120, 32);
            bttn_Add.TabIndex = 22;
            bttn_Add.Text = "Add";
            bttn_Add.UseVisualStyleBackColor = false;
            bttn_Add.Click += bttn_Add_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 10.2F);
            label18.Location = new Point(424, 104);
            label18.Name = "label18";
            label18.Size = new Size(100, 19);
            label18.TabIndex = 8;
            label18.Text = "Invoice Date";
            // 
            // dtp_Date
            // 
            dtp_Date.Location = new Point(560, 96);
            dtp_Date.Margin = new Padding(3, 4, 3, 4);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(241, 27);
            dtp_Date.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.Location = new Point(16, 552);
            listView1.Name = "listView1";
            listView1.Size = new Size(1415, 304);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_FixedNotifiedValue);
            groupBox1.Controls.Add(txt_ValueExcludingST);
            groupBox1.Controls.Add(txt_FurtherTax);
            groupBox1.Controls.Add(txt_ExtraTax);
            groupBox1.Controls.Add(txt_STWithoutSource);
            groupBox1.Controls.Add(txt_SroItemNo);
            groupBox1.Controls.Add(txt_SaleType);
            groupBox1.Controls.Add(txt_Discount);
            groupBox1.Controls.Add(txt_FedPayable);
            groupBox1.Controls.Add(txt_SroSchedule);
            groupBox1.Controls.Add(txt_STApplicable);
            groupBox1.Controls.Add(txt_TotalValue);
            groupBox1.Controls.Add(txt_Rate);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmb_Uom);
            groupBox1.Controls.Add(cmb_product);
            groupBox1.Controls.Add(cmb_Qty);
            groupBox1.Location = new Point(8, 200);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1136, 320);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Item Detail";
            // 
            // txt_FixedNotifiedValue
            // 
            txt_FixedNotifiedValue.Location = new Point(232, 184);
            txt_FixedNotifiedValue.Name = "txt_FixedNotifiedValue";
            txt_FixedNotifiedValue.Size = new Size(176, 27);
            txt_FixedNotifiedValue.TabIndex = 11;
            txt_FixedNotifiedValue.Text = "20000";
            // 
            // txt_ValueExcludingST
            // 
            txt_ValueExcludingST.Location = new Point(8, 184);
            txt_ValueExcludingST.Name = "txt_ValueExcludingST";
            txt_ValueExcludingST.Size = new Size(176, 27);
            txt_ValueExcludingST.TabIndex = 10;
            txt_ValueExcludingST.Text = "20000";
            // 
            // txt_FurtherTax
            // 
            txt_FurtherTax.Location = new Point(976, 184);
            txt_FurtherTax.Name = "txt_FurtherTax";
            txt_FurtherTax.Size = new Size(144, 27);
            txt_FurtherTax.TabIndex = 15;
            txt_FurtherTax.Text = "0";
            // 
            // txt_ExtraTax
            // 
            txt_ExtraTax.Location = new Point(804, 184);
            txt_ExtraTax.Name = "txt_ExtraTax";
            txt_ExtraTax.Size = new Size(144, 27);
            txt_ExtraTax.TabIndex = 14;
            txt_ExtraTax.Text = "0";
            // 
            // txt_STWithoutSource
            // 
            txt_STWithoutSource.Location = new Point(632, 184);
            txt_STWithoutSource.Name = "txt_STWithoutSource";
            txt_STWithoutSource.Size = new Size(144, 27);
            txt_STWithoutSource.TabIndex = 13;
            txt_STWithoutSource.Text = "0";
            // 
            // txt_SroItemNo
            // 
            txt_SroItemNo.Location = new Point(804, 272);
            txt_SroItemNo.Name = "txt_SroItemNo";
            txt_SroItemNo.Size = new Size(144, 27);
            txt_SroItemNo.TabIndex = 20;
            txt_SroItemNo.Text = "1";
            // 
            // txt_SaleType
            // 
            txt_SaleType.Location = new Point(632, 272);
            txt_SaleType.Name = "txt_SaleType";
            txt_SaleType.Size = new Size(144, 27);
            txt_SaleType.TabIndex = 19;
            // 
            // txt_Discount
            // 
            txt_Discount.Location = new Point(456, 272);
            txt_Discount.Name = "txt_Discount";
            txt_Discount.Size = new Size(144, 27);
            txt_Discount.TabIndex = 18;
            txt_Discount.Text = "0";
            // 
            // txt_FedPayable
            // 
            txt_FedPayable.Location = new Point(232, 272);
            txt_FedPayable.Name = "txt_FedPayable";
            txt_FedPayable.Size = new Size(192, 27);
            txt_FedPayable.TabIndex = 17;
            txt_FedPayable.Text = "0";
            // 
            // txt_SroSchedule
            // 
            txt_SroSchedule.Location = new Point(8, 272);
            txt_SroSchedule.Name = "txt_SroSchedule";
            txt_SroSchedule.Size = new Size(176, 27);
            txt_SroSchedule.TabIndex = 16;
            txt_SroSchedule.Text = "741";
            // 
            // txt_STApplicable
            // 
            txt_STApplicable.Location = new Point(456, 184);
            txt_STApplicable.Name = "txt_STApplicable";
            txt_STApplicable.Size = new Size(144, 27);
            txt_STApplicable.TabIndex = 12;
            txt_STApplicable.Text = "15";
            // 
            // txt_TotalValue
            // 
            txt_TotalValue.Location = new Point(976, 72);
            txt_TotalValue.Name = "txt_TotalValue";
            txt_TotalValue.Size = new Size(144, 27);
            txt_TotalValue.TabIndex = 9;
            txt_TotalValue.Text = "20000";
            // 
            // txt_Rate
            // 
            txt_Rate.Location = new Point(456, 72);
            txt_Rate.Name = "txt_Rate";
            txt_Rate.Size = new Size(144, 27);
            txt_Rate.TabIndex = 6;
            txt_Rate.Text = "20000";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(804, 248);
            label22.Name = "label22";
            label22.Size = new Size(130, 20);
            label22.TabIndex = 48;
            label22.Text = "Sro Item Serial No";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 48);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 47;
            label6.Text = "UoM";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(632, 248);
            label21.Name = "label21";
            label21.Size = new Size(68, 20);
            label21.TabIndex = 49;
            label21.Text = "SaleType";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(456, 248);
            label20.Name = "label20";
            label20.Size = new Size(67, 20);
            label20.TabIndex = 46;
            label20.Text = "Discount";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(232, 248);
            label19.Name = "label19";
            label19.Size = new Size(88, 20);
            label19.TabIndex = 38;
            label19.Text = "Fed Payable";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 48);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 44;
            label5.Text = "Rate";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 248);
            label16.Name = "label16";
            label16.Size = new Size(119, 20);
            label16.TabIndex = 43;
            label16.Text = "Sro Schedule No";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(976, 129);
            label15.Name = "label15";
            label15.Size = new Size(76, 20);
            label15.TabIndex = 42;
            label15.Text = "FurtherTax";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 48);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 41;
            label4.Text = "Product";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(804, 129);
            label14.Name = "label14";
            label14.Size = new Size(63, 20);
            label14.TabIndex = 40;
            label14.Text = "ExtraTax";
            // 
            // label13
            // 
            label13.Location = new Point(632, 129);
            label13.Name = "label13";
            label13.Size = new Size(143, 47);
            label13.TabIndex = 39;
            label13.Text = "SaleTax withholding at Source";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(456, 129);
            label12.Name = "label12";
            label12.Size = new Size(104, 20);
            label12.TabIndex = 45;
            label12.Text = "S.T Applicable";
            // 
            // label10
            // 
            label10.Location = new Point(232, 129);
            label10.Name = "label10";
            label10.Size = new Size(184, 48);
            label10.TabIndex = 37;
            label10.Text = "Fixed Notified Value/Retail Price";
            // 
            // label9
            // 
            label9.Location = new Point(8, 129);
            label9.Name = "label9";
            label9.Size = new Size(171, 47);
            label9.TabIndex = 36;
            label9.Text = "Value Sales Excluding Sale Tax";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(976, 48);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 35;
            label8.Text = "Total Value";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(804, 48);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 34;
            label7.Text = "Qty.";
            // 
            // cmb_Uom
            // 
            cmb_Uom.Font = new Font("Arial", 10.2F);
            cmb_Uom.FormattingEnabled = true;
            cmb_Uom.Items.AddRange(new object[] { "Kg", "Litre", "No" });
            cmb_Uom.Location = new Point(632, 72);
            cmb_Uom.Name = "cmb_Uom";
            cmb_Uom.Size = new Size(144, 27);
            cmb_Uom.TabIndex = 7;
            // 
            // cmb_product
            // 
            cmb_product.Font = new Font("Arial", 10.2F);
            cmb_product.FormattingEnabled = true;
            cmb_product.Items.AddRange(new object[] { "Live Stock", "Fresh Water" });
            cmb_product.Location = new Point(8, 72);
            cmb_product.Name = "cmb_product";
            cmb_product.Size = new Size(417, 27);
            cmb_product.TabIndex = 5;
            // 
            // cmb_Qty
            // 
            cmb_Qty.Font = new Font("Arial", 10.2F);
            cmb_Qty.FormattingEnabled = true;
            cmb_Qty.Location = new Point(804, 72);
            cmb_Qty.Name = "cmb_Qty";
            cmb_Qty.Size = new Size(144, 27);
            cmb_Qty.TabIndex = 8;
            // 
            // bttn_Reset
            // 
            bttn_Reset.BackColor = Color.LightSkyBlue;
            bttn_Reset.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bttn_Reset.Location = new Point(1160, 216);
            bttn_Reset.Margin = new Padding(1);
            bttn_Reset.Name = "bttn_Reset";
            bttn_Reset.Size = new Size(120, 32);
            bttn_Reset.TabIndex = 21;
            bttn_Reset.Text = "Reset";
            bttn_Reset.UseVisualStyleBackColor = false;
            // 
            // bttn_Save
            // 
            bttn_Save.Location = new Point(1336, 872);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(94, 29);
            bttn_Save.TabIndex = 23;
            bttn_Save.Text = "Save";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Click += bttn_Save_Click;
            // 
            // lbl_formDimensions
            // 
            lbl_formDimensions.AutoSize = true;
            lbl_formDimensions.Location = new Point(296, 984);
            lbl_formDimensions.Name = "lbl_formDimensions";
            lbl_formDimensions.Size = new Size(54, 20);
            lbl_formDimensions.TabIndex = 30;
            lbl_formDimensions.Text = "Height";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 10.2F);
            label23.Location = new Point(424, 63);
            label23.Name = "label23";
            label23.Size = new Size(126, 19);
            label23.TabIndex = 2;
            label23.Text = "Invoice Ref. No.";
            // 
            // txt_InvoiceRefNo
            // 
            txt_InvoiceRefNo.Location = new Point(568, 55);
            txt_InvoiceRefNo.MaxLength = 10;
            txt_InvoiceRefNo.Name = "txt_InvoiceRefNo";
            txt_InvoiceRefNo.Size = new Size(232, 27);
            txt_InvoiceRefNo.TabIndex = 31;
            txt_InvoiceRefNo.Text = "986";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 10.2F);
            label24.Location = new Point(13, 104);
            label24.Name = "label24";
            label24.Size = new Size(89, 19);
            label24.TabIndex = 2;
            label24.Text = "ScenarioId";
            // 
            // cmb_Scenario
            // 
            cmb_Scenario.Font = new Font("Arial", 10.2F);
            cmb_Scenario.FormattingEnabled = true;
            cmb_Scenario.Location = new Point(127, 96);
            cmb_Scenario.Name = "cmb_Scenario";
            cmb_Scenario.Size = new Size(289, 27);
            cmb_Scenario.TabIndex = 2;
            // 
            // btt_ValidateData
            // 
            btt_ValidateData.BackColor = Color.PaleGreen;
            btt_ValidateData.Location = new Point(1232, 512);
            btt_ValidateData.Name = "btt_ValidateData";
            btt_ValidateData.Size = new Size(198, 29);
            btt_ValidateData.TabIndex = 32;
            btt_ValidateData.Text = "Validate Data";
            btt_ValidateData.UseVisualStyleBackColor = false;
            btt_ValidateData.Click += btt_ValidateData_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1582, 913);
            Controls.Add(btt_ValidateData);
            Controls.Add(txt_InvoiceRefNo);
            Controls.Add(lbl_formDimensions);
            Controls.Add(bttn_Save);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Controls.Add(dtp_Date);
            Controls.Add(bttn_Reset);
            Controls.Add(bttn_Add);
            Controls.Add(label18);
            Controls.Add(cmb_Scenario);
            Controls.Add(cmb_customer);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewInvoice";
            WindowState = FormWindowState.Maximized;
            Load += InvoiceForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmb_customer;
        private Label label11;
       
        /// <summary>
        /// private RichTextBox richTextBox1;
        /// </summary>
        private Button bttn_Add;
        private Label label18;
        private DateTimePicker dtp_Date;
        private ListView listView1;
        private GroupBox groupBox1;
        private TextBox txt_FixedNotifiedValue;
        private TextBox txt_ValueExcludingST;
        private TextBox txt_FurtherTax;
        private TextBox txt_ExtraTax;
        private TextBox txt_STWithoutSource;
        private TextBox txt_SroItemNo;
        private TextBox txt_SaleType;
        private TextBox txt_Discount;
        private TextBox txt_FedPayable;
        private TextBox txt_SroSchedule;
        private TextBox txt_STApplicable;
        private TextBox txt_TotalValue;
        private TextBox txt_Rate;
        private Label label22;
        private Label label6;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label5;
        private Label label16;
        private Label label15;
        private Label label4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox cmb_Uom;
        private ComboBox cmb_product;
        private ComboBox cmb_Qty;
        private Button bttn_Reset;
        private Button bttn_Save;
        private Label lbl_formDimensions;
        private Label label23;
        private TextBox txt_InvoiceRefNo;
        private Label label24;
        private ComboBox cmb_Scenario;
        private Button btt_ValidateData;
    }
}