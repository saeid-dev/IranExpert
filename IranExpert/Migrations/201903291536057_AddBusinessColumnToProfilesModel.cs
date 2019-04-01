namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBusinessColumnToProfilesModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "Business", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profiles", "Business");
        }
    }
}
