namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntek1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders");
            RenameColumn(table: "dbo.InvoiceDetails", name: "InvoiceID", newName: "InvoiceNumarasi");
            RenameIndex(table: "dbo.InvoiceDetails", name: "IX_InvoiceID", newName: "IX_InvoiceNumarasi");
            DropPrimaryKey("dbo.InvoiceHeaders");
            AddColumn("dbo.InvoiceHeaders", "InvoiceNumarasi", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.InvoiceHeaders", "InvoiceNumarasi");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceNumarasi", "dbo.InvoiceHeaders", "InvoiceNumarasi", cascadeDelete: true);
            DropColumn("dbo.InvoiceHeaders", "InvoiceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InvoiceHeaders", "InvoiceID", c => c.Int(nullable: false));
            DropForeignKey("dbo.InvoiceDetails", "InvoiceNumarasi", "dbo.InvoiceHeaders");
            DropPrimaryKey("dbo.InvoiceHeaders");
            DropColumn("dbo.InvoiceHeaders", "InvoiceNumarasi");
            AddPrimaryKey("dbo.InvoiceHeaders", "InvoiceID");
            RenameIndex(table: "dbo.InvoiceDetails", name: "IX_InvoiceNumarasi", newName: "IX_InvoiceID");
            RenameColumn(table: "dbo.InvoiceDetails", name: "InvoiceNumarasi", newName: "InvoiceID");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders", "InvoiceID", cascadeDelete: true);
        }
    }
}
