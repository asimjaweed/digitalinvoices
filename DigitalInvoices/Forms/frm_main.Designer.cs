namespace DigitalInvoices
{
    partial class frm_main
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
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            invoiceToolStripMenuItem = new ToolStripMenuItem();
            newInvoiceToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            editUserToolStripMenuItem = new ToolStripMenuItem();
            allUsersToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            sellerInfoToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            addCustomerToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            listProductToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, invoiceToolStripMenuItem, userManagementToolStripMenuItem, settingsToolStripMenuItem, customerToolStripMenuItem, productToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1366, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem1, exitToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(60, 24);
            loginToolStripMenuItem.Text = "Login";
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(129, 26);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(129, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // invoiceToolStripMenuItem
            // 
            invoiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newInvoiceToolStripMenuItem });
            invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            invoiceToolStripMenuItem.Size = new Size(70, 24);
            invoiceToolStripMenuItem.Text = "Invoice";
            // 
            // newInvoiceToolStripMenuItem
            // 
            newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            newInvoiceToolStripMenuItem.Size = new Size(173, 26);
            newInvoiceToolStripMenuItem.Text = "New Invoice";
            newInvoiceToolStripMenuItem.Click += newInvoiceToolStripMenuItem_Click;
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, editUserToolStripMenuItem, allUsersToolStripMenuItem });
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(144, 24);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(153, 26);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(153, 26);
            editUserToolStripMenuItem.Text = "Edit User";
            // 
            // allUsersToolStripMenuItem
            // 
            allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            allUsersToolStripMenuItem.Size = new Size(153, 26);
            allUsersToolStripMenuItem.Text = "All Users";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sellerInfoToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // sellerInfoToolStripMenuItem
            // 
            sellerInfoToolStripMenuItem.Name = "sellerInfoToolStripMenuItem";
            sellerInfoToolStripMenuItem.Size = new Size(159, 26);
            sellerInfoToolStripMenuItem.Text = "Seller Info";
            sellerInfoToolStripMenuItem.Click += sellerInfoToolStripMenuItem_Click;
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCustomerToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            addCustomerToolStripMenuItem.Size = new Size(187, 26);
            addCustomerToolStripMenuItem.Text = "Add Customer";
            addCustomerToolStripMenuItem.Click += addCustomerToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem, listProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(224, 26);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // listProductToolStripMenuItem
            // 
            listProductToolStripMenuItem.Name = "listProductToolStripMenuItem";
            listProductToolStripMenuItem.Size = new Size(224, 26);
            listProductToolStripMenuItem.Text = "List Product";
            // 
            // frm_main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 761);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frm_main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":: Digital Invoices";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem invoiceToolStripMenuItem;
        private ToolStripMenuItem newInvoiceToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem allUsersToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem sellerInfoToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem listProductToolStripMenuItem;
    }
}
