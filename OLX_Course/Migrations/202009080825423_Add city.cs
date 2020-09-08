namespace OLX_Course.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addcity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Category", newName: "Categories");
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cities");
            RenameTable(name: "dbo.Categories", newName: "Category");
        }
    }
}
