namespace PartyHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationsondb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parties", "Host_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Parties", new[] { "Host_Id" });
            AlterColumn("dbo.Parties", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Parties", "Description", c => c.String(maxLength: 255));
            AlterColumn("dbo.Parties", "Venue", c => c.String(nullable: false));
            AlterColumn("dbo.Parties", "Host_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Parties", "Host_Id");
            AddForeignKey("dbo.Parties", "Host_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parties", "Host_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Parties", new[] { "Host_Id" });
            AlterColumn("dbo.Parties", "Host_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Parties", "Venue", c => c.String());
            AlterColumn("dbo.Parties", "Description", c => c.String());
            AlterColumn("dbo.Parties", "Title", c => c.String());
            CreateIndex("dbo.Parties", "Host_Id");
            AddForeignKey("dbo.Parties", "Host_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
