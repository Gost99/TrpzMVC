namespace TrpzMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        BackgroundImageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.BackgroundImageId, cascadeDelete: true)
                .Index(t => t.BackgroundImageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "BackgroundImageId", "dbo.Images");
            DropIndex("dbo.Pages", new[] { "BackgroundImageId" });
            DropTable("dbo.Pages");
            DropTable("dbo.Images");
        }
    }
}
