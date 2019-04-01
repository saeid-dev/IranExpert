namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditUniIdProperty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Profiles", "UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Profiles", "University_Id", "dbo.Universities");
            DropIndex("dbo.Profiles", new[] { "UniversityId" });
            DropPrimaryKey("dbo.Universities");
            AddColumn("dbo.Profiles", "University_Id", c => c.Int());
            AlterColumn("dbo.Universities", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Universities", "Id");
            CreateIndex("dbo.Profiles", "University_Id");
            AddForeignKey("dbo.Profiles", "University_Id", "dbo.Universities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profiles", "University_Id", "dbo.Universities");
            DropIndex("dbo.Profiles", new[] { "University_Id" });
            DropPrimaryKey("dbo.Universities");
            AlterColumn("dbo.Universities", "Id", c => c.Byte(nullable: false));
            DropColumn("dbo.Profiles", "University_Id");
            AddPrimaryKey("dbo.Universities", "Id");
            CreateIndex("dbo.Profiles", "UniversityId");
            AddForeignKey("dbo.Profiles", "University_Id", "dbo.Universities", "Id");
            AddForeignKey("dbo.Profiles", "UniversityId", "dbo.Universities", "Id", cascadeDelete: true);
        }
    }
}
