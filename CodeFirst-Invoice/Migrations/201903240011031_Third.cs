namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CityID", "dbo.Cities");
            DropIndex("dbo.Customers", new[] { "CityID" });
            AddColumn("dbo.Customers", "CountyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CountyID");
            AddForeignKey("dbo.Customers", "CountyID", "dbo.Counties", "CountyID", cascadeDelete: true);
            DropColumn("dbo.Customers", "CityID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CityID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "CountyID", "dbo.Counties");
            DropIndex("dbo.Customers", new[] { "CountyID" });
            DropColumn("dbo.Customers", "CountyID");
            CreateIndex("dbo.Customers", "CityID");
            AddForeignKey("dbo.Customers", "CityID", "dbo.Cities", "CityID", cascadeDelete: true);
        }
    }
}
