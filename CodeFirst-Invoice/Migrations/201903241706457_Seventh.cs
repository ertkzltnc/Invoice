namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seventh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InvoiceDetails", "VATAmount", c => c.Double(nullable: false));
            AlterColumn("dbo.InvoiceDetails", "AmountWithVAT", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InvoiceDetails", "AmountWithVAT", c => c.Int(nullable: false));
            AlterColumn("dbo.InvoiceDetails", "VATAmount", c => c.Int(nullable: false));
        }
    }
}
