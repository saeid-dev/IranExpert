namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModofiyCityModelIdKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profiles", "CityId", "dbo.Cities");
            DropPrimaryKey("dbo.Cities");
            AlterColumn("dbo.Cities", "Id", c => c.Byte(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cities", "Id");
            AddForeignKey("dbo.Profiles", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "CityId", "dbo.Cities");
            DropPrimaryKey("dbo.Cities");
            AlterColumn("dbo.Cities", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Cities", "Id");
            AddForeignKey("dbo.Profiles", "CityId", "dbo.Cities", "Id", cascadeDelete: true);
        }
    }
}
