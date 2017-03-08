namespace BookScaleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Authors", "DateOfDeath", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "DateOfDeath", c => c.Int());
            AlterColumn("dbo.Authors", "DateOfBirth", c => c.Int(nullable: false));
        }
    }
}
