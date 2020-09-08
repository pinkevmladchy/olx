namespace OLX_Course.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtovar_images : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tovar_Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(nullable: false, maxLength: 500),
                        TovarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tovars", t => t.TovarId, cascadeDelete: true)
                .Index(t => t.TovarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tovar_Images", "TovarId", "dbo.Tovars");
            DropIndex("dbo.Tovar_Images", new[] { "TovarId" });
            DropTable("dbo.Tovar_Images");
        }
    }
}
