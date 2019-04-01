namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCityandUniModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profiles", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Profiles", "University_Id", "dbo.Universities");
            DropIndex("dbo.Profiles", new[] { "CityId" });
            DropIndex("dbo.Profiles", new[] { "University_Id" });
            DropColumn("dbo.Profiles", "UniversityId");
            RenameColumn(table: "dbo.Profiles", name: "University_Id", newName: "UniversityId");
            AddColumn("dbo.Profiles", "City_Id", c => c.Byte());
            AlterColumn("dbo.Profiles", "CityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Profiles", "UniversityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Profiles", "UniversityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Profiles", "UniversityId");
            CreateIndex("dbo.Profiles", "City_Id");
            AddForeignKey("dbo.Profiles", "City_Id", "dbo.Cities", "Id");
            AddForeignKey("dbo.Profiles", "UniversityId", "dbo.Universities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Profiles", "City_Id", "dbo.Cities");
            DropIndex("dbo.Profiles", new[] { "City_Id" });
            DropIndex("dbo.Profiles", new[] { "UniversityId" });
            AlterColumn("dbo.Profiles", "UniversityId", c => c.Int());
            AlterColumn("dbo.Profiles", "UniversityId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Profiles", "CityId", c => c.Byte(nullable: false));
            DropColumn("dbo.Profiles", "City_Id");
            RenameColumn(table: "dbo.Profiles", name: "UniversityId", newName: "University_Id");
            AddColumn("dbo.Profiles", "UniversityId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Profiles", "University_Id");
            CreateIndex("dbo.Profiles", "CityId");
            AddForeignKey("dbo.Profiles", "University_Id", "dbo.Universities", "Id");
            AddForeignKey("dbo.Profiles", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
    }
}
