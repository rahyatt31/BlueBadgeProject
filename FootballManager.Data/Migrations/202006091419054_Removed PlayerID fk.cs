namespace FootballManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedPlayerIDfk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerStats", "PlayerID", "dbo.Player");
            DropIndex("dbo.PlayerStats", new[] { "PlayerID" });
            DropColumn("dbo.PlayerStats", "PlayerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerStats", "PlayerID", c => c.Int(nullable: false));
            CreateIndex("dbo.PlayerStats", "PlayerID");
            AddForeignKey("dbo.PlayerStats", "PlayerID", "dbo.Player", "PlayerID", cascadeDelete: true);
        }
    }
}
