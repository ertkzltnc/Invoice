namespace CodeFirst_Invoice.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using CodeFirst_Invoice.Entity;
    public class InvoiceContext : DbContext
    {
        // Your context has been configured to use a 'InvoiceContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_Invoice.Context.InvoiceContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InvoiceContext' 
        // connection string in the application configuration file.
        public InvoiceContext()
            : base("name=InvoiceContext")
        {
        }
        public DbSet<City> Citys { get; set; }
        public DbSet<County> Countys { get; set; }
        public DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Unit> Units { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}