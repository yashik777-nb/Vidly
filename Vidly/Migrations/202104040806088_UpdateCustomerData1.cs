namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerData1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = CAST('1992-01-01' AS DATETIME) WHERE ID = 1");
            Sql("UPDATE Customers SET BirthDate = CAST('1998-01-01' AS DATETIME) WHERE ID = 2");
        }
        
        public override void Down()
        {
        }
    }
}
