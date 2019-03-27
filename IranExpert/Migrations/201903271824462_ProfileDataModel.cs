namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfileDataModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Degrees",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Titel = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Family = c.String(nullable: false, maxLength: 50),
                        IsInGermany = c.Boolean(),
                        CityId = c.Byte(nullable: false),
                        CountryId = c.Byte(nullable: false),
                        StatusId = c.Byte(nullable: false),
                        UniversityId = c.Byte(nullable: false),
                        DegreeId = c.Byte(nullable: false),
                        BirthDate = c.DateTime(),
                        CellPhone = c.String(maxLength: 50),
                        ViewAlternateEmail = c.Boolean(),
                        AlternateEmail = c.String(maxLength: 50),
                        WebSite = c.String(maxLength: 50),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Degrees", t => t.DegreeId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.Universities", t => t.UniversityId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.CityId)
                .Index(t => t.CountryId)
                .Index(t => t.StatusId)
                .Index(t => t.UniversityId)
                .Index(t => t.DegreeId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Profiles", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Profiles", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Profiles", "DegreeId", "dbo.Degrees");
            DropForeignKey("dbo.Profiles", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Profiles", "CityId", "dbo.Cities");
            DropIndex("dbo.Profiles", new[] { "UserId" });
            DropIndex("dbo.Profiles", new[] { "DegreeId" });
            DropIndex("dbo.Profiles", new[] { "UniversityId" });
            DropIndex("dbo.Profiles", new[] { "StatusId" });
            DropIndex("dbo.Profiles", new[] { "CountryId" });
            DropIndex("dbo.Profiles", new[] { "CityId" });
            DropTable("dbo.Universities");
            DropTable("dbo.Status");
            DropTable("dbo.Profiles");
            DropTable("dbo.Degrees");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
