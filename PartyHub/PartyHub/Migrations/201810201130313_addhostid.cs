namespace PartyHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addhostid : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Parties", name: "Host_Id", newName: "HostId");
            RenameIndex(table: "dbo.Parties", name: "IX_Host_Id", newName: "IX_HostId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Parties", name: "IX_HostId", newName: "IX_Host_Id");
            RenameColumn(table: "dbo.Parties", name: "HostId", newName: "Host_Id");
        }
    }
}
