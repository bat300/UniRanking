namespace UniRanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingMyID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RatingDatas", "MyID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RatingDatas", "MyID");
        }
    }
}
