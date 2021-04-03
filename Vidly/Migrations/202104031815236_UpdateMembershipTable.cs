namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Pay As You Go' WHERE ID = 1");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Quaterly' WHERE ID = 3");
            Sql("UPDATE MembershipTypes SET MembershipTypeName = 'Annaul' WHERE ID = 4");
           
        }
        
        public override void Down()
        {
        }
    }
}
