namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Status (Id,Name) values (1,N'دانشجو')");
            Sql("Insert into Status (Id,Name) values (2,N'فارغ التحصیل')");
            Sql("Insert into Status (Id,Name) values (3,N'دانشجوی زبان')");
            Sql("Insert into Status (Id,Name) values (4,N'جویای کار')");
            Sql("Insert into Status (Id,Name) values (5,N'شاغل')");
        }
        
        public override void Down()
        {
        }
    }
}
