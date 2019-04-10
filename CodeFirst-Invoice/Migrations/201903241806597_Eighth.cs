namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eighth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InvoiceDetails", "UnitPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "UnitPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.InvoiceDetails", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
