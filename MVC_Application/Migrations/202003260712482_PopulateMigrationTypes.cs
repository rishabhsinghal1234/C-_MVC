namespace MVC_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMigrationTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into membershiptypes(Id, SignUpFee, DurationInMonth, DiscountRate) values(1, 0, 0, 0)");
            Sql("Insert into membershiptypes(Id, SignUpFee, DurationInMonth, DiscountRate) values(2, 10, 1, 5)");
            Sql("Insert into membershiptypes(Id, SignUpFee, DurationInMonth, DiscountRate) values(3, 20, 3, 10)");
            Sql("Insert into membershiptypes(Id, SignUpFee, DurationInMonth, DiscountRate) values(4, 30, 4, 15)");
        }

        public override void Down()
        {
        }
    }
}
