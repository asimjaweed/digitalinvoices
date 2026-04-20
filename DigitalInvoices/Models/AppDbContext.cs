using DigitalInvoices.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Customer> customers { get;set; }
    public DbSet<HsCode>hscodes { get;set; }
    public DbSet<Invoice> invoices { get;set; }
    public DbSet<InvoiceItem> invoicesItem { get;set; }
    public DbSet<Product> products { get;set; }
    public DbSet<Seller>sellers { get;set; }
    public DbSet<User> users { get; set; }
    public DbSet<Scenario>scenarios { get; set; }
    
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            "Server=localhost;Database=invoicedb;User=root;Password='';Port=3306",
            new MySqlServerVersion(new Version(10, 4, 32))
        );
    }
}
