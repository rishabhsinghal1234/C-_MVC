namespace MVC_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) values(1,'Romance')");
            Sql("INSERT INTO Genres(Id, Name) values(2,'Fiction')");
            Sql("INSERT INTO Genres(Id, Name) values(3,'Romance')");
            Sql("INSERT INTO Genres(Id, Name) values(4,'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
