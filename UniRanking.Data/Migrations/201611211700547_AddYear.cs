namespace UniRanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RatingDatas", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RatingDatas", "Year");
        }
    }
}
