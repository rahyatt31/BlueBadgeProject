using FootballManager.Data;
using FootballManager.Models.PlayerStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Services
{
    public class PlayerStatsService
    {
        private readonly Guid _userID;
        public PlayerStatsService(Guid userID)
        {
            _userID = userID;
        }
        public bool CreatePlayerStats(CreatePlayerStats model)
        {
            var entity = new PlayerStats()
            {
                stuff
                stuff
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.PlayerStats.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ListPlayerStats> GetPlayerStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .PlayerStats
                        .Select(
                            e =>
                                new ListPlayerStats
                                {
                                    stuff
                                    stuff
                                }
                        );
                return query.ToArray();
            }
        }
        public DetailPlayerStats GetPlayerStatsByID(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PlayerStats
                        .Single(e => e.PlayerStatsID);
                return
                    new DetailPlayerStats
                    {
                        stuff
                        stuff
                    };
            }
        }
        public bool UpdatePlayerStats(EditPlayerStats model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PlayerStats
                        .Single(e => e.PlayerStatsID == model.PlayerStatsID);
                entity.something = model.somthing;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePlayerStats(int playerStatsId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PlayerStats
                        .Single(e => e.PlayerStatsID == playerStatsId);
                ctx.PlayerStats.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}