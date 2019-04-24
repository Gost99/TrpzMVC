namespace TrpzMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pages", "BackgroundImageId", "dbo.Images");
            DropIndex("dbo.Pages", new[] { "BackgroundImageId" });
            AlterColumn("dbo.Pages", "BackgroundImageId", c => c.Int());
            CreateIndex("dbo.Pages", "BackgroundImageId");
            AddForeignKey("dbo.Pages", "BackgroundImageId", "dbo.Images", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pages", "BackgroundImageId", "dbo.Images");
            DropIndex("dbo.Pages", new[] { "BackgroundImageId" });
            AlterColumn("dbo.Pages", "BackgroundImageId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pages", "BackgroundImageId");
            AddForeignKey("dbo.Pages", "BackgroundImageId", "dbo.Images", "Id", cascadeDelete: true);
        }
    }
}
