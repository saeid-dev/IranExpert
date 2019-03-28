namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCountry : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Countries (Id,Name) values (1,N'آلمان')");
            Sql("Insert into Countries (Id,Name) values (2,N'ایران')");
            Sql("Insert into Countries (Id,Name) values (3,N'سایر')");
        }
        
        public override void Down()
        {
        }
    }
}
