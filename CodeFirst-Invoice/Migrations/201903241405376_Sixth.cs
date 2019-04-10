namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sixth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders");
            DropPrimaryKey("dbo.InvoiceHeaders");
            AlterColumn("dbo.InvoiceHeaders", "InvoiceID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.InvoiceHeaders", "InvoiceID");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders", "InvoiceID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders");
            DropPrimaryKey("dbo.InvoiceHeaders");
            AlterColumn("dbo.InvoiceHeaders", "InvoiceID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.InvoiceHeaders", "InvoiceID");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders", "InvoiceID", cascadeDelete: true);
        }
    }
}
