namespace DigitalInvoices
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }


        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice_frm = new InvoiceForm();
            invoice_frm.MdiParent = this;
            invoice_frm.Show();

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm login_frm = new LoginForm();
            login_frm.MdiParent = this;
            login_frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUserForm adduser_frm = new AddUserForm();
            adduser_frm.MdiParent = this;
            adduser_frm.Show();
        }
    }
}
