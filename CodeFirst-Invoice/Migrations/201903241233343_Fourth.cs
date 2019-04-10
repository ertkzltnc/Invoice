namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fourth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InvoiceHeaders", "TotalAmount", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InvoiceHeaders", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
