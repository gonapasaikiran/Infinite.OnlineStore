namespace Infinite.OnlineStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PackSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Packsize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        TotalPrice = c.Int(nullable: false),
                        PackSizeId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.PackSizes", t => t.PackSizeId, cascadeDelete: true)
                .Index(t => t.PackSizeId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "PackSizeId", "dbo.PackSizes");
            DropForeignKey("dbo.ProductDetails", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ProductDetails", new[] { "CategoryId" });
            DropIndex("dbo.ProductDetails", new[] { "PackSizeId" });
            DropTable("dbo.ProductDetails");
            DropTable("dbo.PackSizes");
            DropTable("dbo.Categories");
        }
    }
}
