namespace IranExpert.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDegrees : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Degrees (Id,Titel) values (1,N'کالج')");
            Sql("Insert into Degrees (Id,Titel) values (2,N'کارشناسی')");
            Sql("Insert into Degrees (Id,Titel) values (3,N'کارشناسی ارشد')");
            Sql("Insert into Degrees (Id,Titel) values (4,N'دکترا')");
            Sql("Insert into Degrees (Id,Titel) values (5,N'فرصت مطالعاتی')");

        }
        
        public override void Down()
        {
        }
    }
}
