namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ntek2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceDetails", "InvoiceNumarasi", "dbo.InvoiceHeaders");
            RenameColumn(table: "dbo.InvoiceDetails", name: "InvoiceNumarasi", newName: "InvoiceID");
            RenameIndex(table: "dbo.InvoiceDetails", name: "IX_InvoiceNumarasi", newName: "IX_InvoiceID");
            DropPrimaryKey("dbo.InvoiceHeaders");
            AddColumn("dbo.InvoiceHeaders", "InvoiceID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.InvoiceHeaders", "InvoiceID");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders", "InvoiceID", cascadeDelete: true);
            DropColumn("dbo.InvoiceHeaders", "InvoiceNumarasi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.InvoiceHeaders", "InvoiceNumarasi", c => c.Int(nullable: false));
            DropForeignKey("dbo.InvoiceDetails", "InvoiceID", "dbo.InvoiceHeaders");
            DropPrimaryKey("dbo.InvoiceHeaders");
            DropColumn("dbo.InvoiceHeaders", "InvoiceID");
            AddPrimaryKey("dbo.InvoiceHeaders", "InvoiceNumarasi");
            RenameIndex(table: "dbo.InvoiceDetails", name: "IX_InvoiceID", newName: "IX_InvoiceNumarasi");
            RenameColumn(table: "dbo.InvoiceDetails", name: "InvoiceID", newName: "InvoiceNumarasi");
            AddForeignKey("dbo.InvoiceDetails", "InvoiceNumarasi", "dbo.InvoiceHeaders", "InvoiceNumarasi", cascadeDelete: true);
        }
    }
}
