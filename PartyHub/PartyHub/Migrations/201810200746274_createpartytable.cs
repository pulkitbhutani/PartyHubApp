namespace PartyHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createpartytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Venue = c.String(),
                        Host_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Host_Id)
                .Index(t => t.Host_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parties", "Host_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Parties", new[] { "Host_Id" });
            DropTable("dbo.Parties");
        }
    }
}
