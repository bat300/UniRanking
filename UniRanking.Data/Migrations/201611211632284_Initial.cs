namespace UniRanking.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RatingDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorldRank = c.Int(nullable: false),
                        NationalRank = c.Int(nullable: false),
                        QualityOfEducation = c.Int(nullable: false),
                        AlumniEmployment = c.Int(nullable: false),
                        QualityOfFaculty = c.Int(nullable: false),
                        Publications = c.Int(nullable: false),
                        Influence = c.Int(nullable: false),
                        Citations = c.Int(nullable: false),
                        Patents = c.Int(nullable: false),
                        Score = c.Double(nullable: false),
                        BroadImpact = c.Int(nullable: false),
                        UniversitysId = c.Int(nullable: false),
                        Universiry_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UniversitysInfoes", t => t.Universiry_ID)
                .Index(t => t.Universiry_ID);
            
            CreateTable(
                "dbo.UniversitysInfoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameOfUniversity = c.String(),
                        CountrysId = c.Int(nullable: false),
                        CountryOfUniversity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.CountryOfUniversity_Id)
                .Index(t => t.CountryOfUniversity_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryOfUni = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RatingDatas", "Universiry_ID", "dbo.UniversitysInfoes");
            DropForeignKey("dbo.UniversitysInfoes", "CountryOfUniversity_Id", "dbo.Countries");
            DropIndex("dbo.UniversitysInfoes", new[] { "CountryOfUniversity_Id" });
            DropIndex("dbo.RatingDatas", new[] { "Universiry_ID" });
            DropTable("dbo.Countries");
            DropTable("dbo.UniversitysInfoes");
            DropTable("dbo.RatingDatas");
        }
    }
}
