namespace DigitalInvoices.Forms
{
    partial class frm_product
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
            txt_ProductName = new TextBox();
            txt_HsCode = new TextBox();
            txt_UnitPrice = new TextBox();
            txt_ST = new TextBox();
            cmb_UoM = new ComboBox();
            bttn_Save = new Button();
            bttn_Reset = new Button();
            bttn_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 86);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 0;
            label2.Text = "HsCode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 138);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 0;
            label3.Text = "Unit Of Measurement";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 190);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 0;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 242);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 0;
            label5.Text = "Sales Tax Rate";
            // 
            // txt_ProductName
            // 
            txt_ProductName.Font = new Font("Segoe UI", 10F);
            txt_ProductName.Location = new Point(176, 24);
            txt_ProductName.MaxLength = 25;
            txt_ProductName.Name = "txt_ProductName";
            txt_ProductName.Size = new Size(184, 30);
            txt_ProductName.TabIndex = 1;
            // 
            // txt_HsCode
            // 
            txt_HsCode.Font = new Font("Segoe UI", 10F);
            txt_HsCode.Location = new Point(176, 76);
            txt_HsCode.MaxLength = 10;
            txt_HsCode.Name = "txt_HsCode";
            txt_HsCode.Size = new Size(184, 30);
            txt_HsCode.TabIndex = 1;
            // 
            // txt_UnitPrice
            // 
            txt_UnitPrice.Font = new Font("Segoe UI", 10F);
            txt_UnitPrice.Location = new Point(176, 180);
            txt_UnitPrice.MaxLength = 6;
            txt_UnitPrice.Name = "txt_UnitPrice";
            txt_UnitPrice.Size = new Size(184, 30);
            txt_UnitPrice.TabIndex = 1;
            // 
            // txt_ST
            // 
            txt_ST.Font = new Font("Segoe UI", 10F);
            txt_ST.Location = new Point(176, 232);
            txt_ST.MaxLength = 6;
            txt_ST.Name = "txt_ST";
            txt_ST.Size = new Size(184, 30);
            txt_ST.TabIndex = 1;
            // 
            // cmb_UoM
            // 
            cmb_UoM.Font = new Font("Segoe UI", 10F);
            cmb_UoM.FormattingEnabled = true;
            cmb_UoM.Items.AddRange(new object[] { "Kg", "Litter", "No" });
            cmb_UoM.Location = new Point(176, 130);
            cmb_UoM.Name = "cmb_UoM";
            cmb_UoM.Size = new Size(184, 31);
            cmb_UoM.TabIndex = 2;
            // 
            // bttn_Save
            // 
            bttn_Save.Location = new Point(248, 280);
            bttn_Save.Name = "bttn_Save";
            bttn_Save.Size = new Size(104, 40);
            bttn_Save.TabIndex = 3;
            bttn_Save.Text = "&Save";
            bttn_Save.UseVisualStyleBackColor = true;
            bttn_Save.Click += bttn_Save_Click;
            // 
            // bttn_Reset
            // 
            bttn_Reset.Location = new Point(128, 280);
            bttn_Reset.Name = "bttn_Reset";
            bttn_Reset.Size = new Size(104, 40);
            bttn_Reset.TabIndex = 3;
            bttn_Reset.Text = "&Rest";
            bttn_Reset.UseVisualStyleBackColor = true;
            bttn_Reset.Click += bttn_Reset_Click_1;
            // 
            // bttn_Cancel
            // 
            bttn_Cancel.Location = new Point(8, 280);
            bttn_Cancel.Name = "bttn_Cancel";
            bttn_Cancel.Size = new Size(104, 40);
            bttn_Cancel.TabIndex = 3;
            bttn_Cancel.Text = "&Cancel";
            bttn_Cancel.UseVisualStyleBackColor = true;
            bttn_Cancel.Click += bttn_Cancel_Click;
            // 
            // frm_product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttn_Cancel);
            Controls.Add(bttn_Reset);
            Controls.Add(bttn_Save);
            Controls.Add(cmb_UoM);
            Controls.Add(txt_ST);
            Controls.Add(txt_UnitPrice);
            Controls.Add(txt_HsCode);
            Controls.Add(txt_ProductName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_ProductName;
        private TextBox txt_HsCode;
        private TextBox txt_UnitPrice;
        private TextBox txt_ST;
        private ComboBox cmb_UoM;
        private Button bttn_Save;
        private Button bttn_Reset;
        private Button bttn_Cancel;
    }
}