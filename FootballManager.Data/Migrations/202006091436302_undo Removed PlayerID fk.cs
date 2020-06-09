namespace FootballManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class undoRemovedPlayerIDfk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PlayerStats", "DefensiveStatsID", "dbo.Player");
            DropForeignKey("dbo.PlayerStats", "OffensiveStatsID", "dbo.Player");
            DropForeignKey("dbo.PlayerStats", "Player_PlayerID", "dbo.Player");
            DropIndex("dbo.PlayerStats", new[] { "OffensiveStatsID" });
            DropIndex("dbo.PlayerStats", new[] { "DefensiveStatsID" });
            DropIndex("dbo.PlayerStats", new[] { "Player_PlayerID" });
            RenameColumn(table: "dbo.PlayerStats", name: "Player_PlayerID", newName: "PlayerID");
            AlterColumn("dbo.PlayerStats", "PlayerID", c => c.Int(nullable: false));
            CreateIndex("dbo.PlayerStats", "PlayerID");
            AddForeignKey("dbo.PlayerStats", "PlayerID", "dbo.Player", "PlayerID", cascadeDelete: true);
            DropColumn("dbo.PlayerStats", "OffensiveStatsID");
            DropColumn("dbo.PlayerStats", "DefensiveStatsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PlayerStats", "DefensiveStatsID", c => c.Int(nullable: false));
            AddColumn("dbo.PlayerStats", "OffensiveStatsID", c => c.Int(nullable: false));
            DropForeignKey("dbo.PlayerStats", "PlayerID", "dbo.Player");
            DropIndex("dbo.PlayerStats", new[] { "PlayerID" });
            AlterColumn("dbo.PlayerStats", "PlayerID", c => c.Int());
            RenameColumn(table: "dbo.PlayerStats", name: "PlayerID", newName: "Player_PlayerID");
            CreateIndex("dbo.PlayerStats", "Player_PlayerID");
            CreateIndex("dbo.PlayerStats", "DefensiveStatsID");
            CreateIndex("dbo.PlayerStats", "OffensiveStatsID");
            AddForeignKey("dbo.PlayerStats", "Player_PlayerID", "dbo.Player", "PlayerID");
            AddForeignKey("dbo.PlayerStats", "OffensiveStatsID", "dbo.Player", "PlayerID", cascadeDelete: true);
            AddForeignKey("dbo.PlayerStats", "DefensiveStatsID", "dbo.Player", "PlayerID", cascadeDelete: true);
        }
    }
}
