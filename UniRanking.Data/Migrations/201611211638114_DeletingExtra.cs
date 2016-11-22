namespace UniRanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletingExtra : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RatingDatas", "UniversitysId");
            DropColumn("dbo.UniversitysInfoes", "CountrysId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UniversitysInfoes", "CountrysId", c => c.Int(nullable: false));
            AddColumn("dbo.RatingDatas", "UniversitysId", c => c.Int(nullable: false));
        }
    }
}
