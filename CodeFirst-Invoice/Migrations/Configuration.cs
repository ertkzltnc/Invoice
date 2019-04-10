namespace CodeFirst_Invoice.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst_Invoice.Context.InvoiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst_Invoice.Context.InvoiceContext context)
        {

            context.Citys.AddOrUpdate(x => x.CityID,
                new Entity.City() { CityID = 1, Description = "Erzurum" },
                new Entity.City() { CityID = 2, Description = "Erzincan" },
                new Entity.City() { CityID = 3, Description = "Bayburt" },
                new Entity.City() { CityID = 4, Description = "Ýstanbul" }
                );
            context.Countys.AddOrUpdate(x => x.CountyID,
                new Entity.County() { CountyID = 1, CityID = 1, Description = "Pasinler" },
                new Entity.County() { CountyID = 2, CityID = 1, Description = "Ilýca" },
                new Entity.County() { CountyID = 3, CityID = 1, Description = "Tortum" },
                new Entity.County() { CountyID = 4, CityID = 2, Description = "Tercan" },
                new Entity.County() { CountyID = 5, CityID = 2, Description = "Mercan" },
                new Entity.County() { CountyID = 6, CityID = 3, Description = "Demirözü" },
                new Entity.County() { CountyID = 7, CityID = 3, Description = "Aydýntepe" },
                new Entity.County() { CountyID = 8, CityID = 4, Description = "Adalar" },
                new Entity.County() { CountyID = 9, CityID = 4, Description = "Baðcýlar" },
                new Entity.County() { CountyID = 10, CityID = 4, Description = "Ataþehir" },
                new Entity.County() { CountyID = 11, CityID = 4, Description = "Ümraniye" }
                );

            context.Units.AddOrUpdate(x => x.UnitID,
                new Entity.Unit { UnitID = 1, UnitName = "Kg"},
                new Entity.Unit { UnitID = 2, UnitName = "m" },
                new Entity.Unit { UnitID = 3, UnitName = "lt" },
                new Entity.Unit { UnitID = 4, UnitName = "Kutu" },
                new Entity.Unit { UnitID = 5, UnitName = "m^3" }
                );

            context.Products.AddOrUpdate(x => x.ProductID,
                new Entity.Product { ProductID=1,ProductName="elma",ProductCode=4875,UnitPrice=10,UnitID=1 },
                new Entity.Product { ProductID = 2, ProductName = "portakal", ProductCode = 4876, UnitPrice = 8, UnitID = 1 },
                new Entity.Product { ProductID = 3, ProductName = "kumas", ProductCode = 4775, UnitPrice = 100, UnitID = 2 },
                new Entity.Product { ProductID = 4, ProductName = "süt", ProductCode = 4675, UnitPrice = 1.25, UnitID = 3 },
                new Entity.Product { ProductID = 5, ProductName = "meyve suyu", ProductCode = 4674, UnitPrice = 0.50, UnitID = 3 }
                );

        }
    }
}
