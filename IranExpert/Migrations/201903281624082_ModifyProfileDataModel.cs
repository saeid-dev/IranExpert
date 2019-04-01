namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyProfileDataModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Profiles", "FullName", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Status", "Name", c => c.String(maxLength: 40));
            AlterColumn("dbo.Universities", "Name", c => c.String(maxLength: 60));
            DropColumn("dbo.Profiles", "Name");
            DropColumn("dbo.Profiles", "Family");
            DropColumn("dbo.Profiles", "IsInGermany");
            DropColumn("dbo.Profiles", "ViewAlternateEmail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Profiles", "ViewAlternateEmail", c => c.Boolean());
            AddColumn("dbo.Profiles", "IsInGermany", c => c.Boolean());
            AddColumn("dbo.Profiles", "Family", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Profiles", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Universities", "Name", c => c.String(maxLength: 30));
            AlterColumn("dbo.Status", "Name", c => c.String(maxLength: 20));
            DropColumn("dbo.Profiles", "FullName");
        }
    }
}
