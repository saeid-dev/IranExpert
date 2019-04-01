namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCityandUniModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profiles", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Profiles", "CityId", "dbo.Cities");
            DropIndex("dbo.Profiles", new[] { "City_Id" });
            DropColumn("dbo.Profiles", "CityId");
            RenameColumn(table: "dbo.Profiles", name: "City_Id", newName: "CityId");
            DropPrimaryKey("dbo.Cities");
            AlterColumn("dbo.Cities", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Profiles", "CityId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Cities", "Id");
            CreateIndex("dbo.Profiles", "CityId");
            AddForeignKey("dbo.Profiles", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "CityId", "dbo.Cities");
            DropIndex("dbo.Profiles", new[] { "CityId" });
            DropPrimaryKey("dbo.Cities");
            AlterColumn("dbo.Profiles", "CityId", c => c.Byte());
            AlterColumn("dbo.Cities", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cities", "Id");
            RenameColumn(table: "dbo.Profiles", name: "CityId", newName: "City_Id");
            AddColumn("dbo.Profiles", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Profiles", "City_Id");
            AddForeignKey("dbo.Profiles", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Profiles", "City_Id", "dbo.Cities", "Id");
        }
    }
}
