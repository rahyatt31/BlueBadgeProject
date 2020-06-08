namespace FootballManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayerStats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerStats",
                c => new
                    {
                        PlayerStatsID = c.Int(nullable: false, identity: true),
                        PassingYards = c.Int(nullable: false),
                        PassingTouchdowns = c.Int(nullable: false),
                        InterceptionThrown = c.Int(nullable: false),
                        RushingYards = c.Int(nullable: false),
                        RushingAttempts = c.Int(nullable: false),
                        RushingTouchDowns = c.Int(nullable: false),
                        ReceivingYards = c.Int(nullable: false),
                        Catches = c.Int(nullable: false),
                        ReceivingTouchDowns = c.Int(nullable: false),
                        Fumbles = c.Int(nullable: false),
                        Tackles = c.Int(nullable: false),
                        Sacks = c.Double(nullable: false),
                        Interceptions = c.Int(nullable: false),
                        ForcedFumbles = c.Int(nullable: false),
                        FumbleRecovery = c.Int(nullable: false),
                        Safety = c.Int(nullable: false),
                        BlockedKick = c.Int(nullable: false),
                        ReturnTouchDown = c.Int(nullable: false),
                        PlayerID = c.Int(nullable: false),
                        OffensiveStatsID = c.Int(nullable: false),
                        DefensiveStatsID = c.Int(nullable: false),
                        Player_PlayerID = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerStatsID)
                .ForeignKey("dbo.Player", t => t.DefensiveStatsID, cascadeDelete: false)
                .ForeignKey("dbo.Player", t => t.OffensiveStatsID, cascadeDelete: false)
                .ForeignKey("dbo.Player", t => t.PlayerID, cascadeDelete: false)
                .ForeignKey("dbo.Player", t => t.Player_PlayerID)
                .Index(t => t.PlayerID)
                .Index(t => t.OffensiveStatsID)
                .Index(t => t.DefensiveStatsID)
                .Index(t => t.Player_PlayerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerStats", "Player_PlayerID", "dbo.Player");
            DropForeignKey("dbo.PlayerStats", "PlayerID", "dbo.Player");
            DropForeignKey("dbo.PlayerStats", "OffensiveStatsID", "dbo.Player");
            DropForeignKey("dbo.PlayerStats", "DefensiveStatsID", "dbo.Player");
            DropIndex("dbo.PlayerStats", new[] { "Player_PlayerID" });
            DropIndex("dbo.PlayerStats", new[] { "DefensiveStatsID" });
            DropIndex("dbo.PlayerStats", new[] { "OffensiveStatsID" });
            DropIndex("dbo.PlayerStats", new[] { "PlayerID" });
            DropTable("dbo.PlayerStats");
        }
    }
}
