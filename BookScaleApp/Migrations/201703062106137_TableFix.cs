namespace BookScaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Author_ID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_ID" });
            AlterColumn("dbo.Books", "Author_ID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Author_ID", c => c.Int());
            CreateIndex("dbo.Books", "Author_ID");
            AddForeignKey("dbo.Books", "Author_ID", "dbo.Authors", "ID");
        }
    }
}
