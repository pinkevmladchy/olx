namespace OLX_Course.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtovar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tovars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                        Cost = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        CityId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.CategoryId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tovars", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Tovars", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Tovars", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Tovars", new[] { "UserId" });
            DropIndex("dbo.Tovars", new[] { "CategoryId" });
            DropIndex("dbo.Tovars", new[] { "CityId" });
            DropTable("dbo.Tovars");
        }
    }
}
