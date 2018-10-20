namespace PartyHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvenuestring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Parties", "Venue", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Parties", "Venue", c => c.String(nullable: false));
        }
    }
}
