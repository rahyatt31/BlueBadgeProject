using FootballManager.Data;
using FootballManager.Models.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerServices
{
    public class GameService
    {
        private readonly Guid _userID;
        public GameService(Guid userID)
        {
            _userID = userID;
        }
        public bool CreateGame(CreateGame model)
        {
            var entity = new Game()
            {
                //What ID do we need?
                HomeTeamID = model.HomeTeamID,
                AwayTeamID = model.AwayTeamID,
                GameDate = model.GameDate,
                HomeTeamScore = model.HomeTeamScore,
                AwayTeamScore = model.AwayTeamScore
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ListGame> GetGame()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Games
                        .Select(
                            e =>
                                new ListGame
                                {
                                    GameID = e.GameID,
                                    HomeTeamID = e.HomeTeamID,
                                    AwayTeamID = e.AwayTeamID,
                                    GameDate = e.GameDate,
                                    HomeTeamScore = e.HomeTeamScore,
                                    AwayTeamScore = e.AwayTeamScore
                                }
                        );
                return query.ToArray();
            }
        }
        public DetailGame GetGameByID(int gameID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameID == gameID);
                return
                    new DetailGame
                    {
                        GameID = entity.GameID,
                        GameDate = entity.GameDate,
                        HomeTeamScore = entity.HomeTeamScore,
                        AwayTeamScore = entity.AwayTeamScore
                    };
            }
        }
        public bool UpdateGame(EditGame model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameID == model.GameID);
                entity.GameID = model.GameID;
                entity.HomeTeamID = model.HomeTeamID;
                entity.AwayTeamID = model.AwayTeamID;
                entity.GameDate = model.GameDate;
                entity.HomeTeamScore = model.HomeTeamScore;
                entity.AwayTeamScore = model.AwayTeamScore;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGame(int gameID)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Games
                        .Single(e => e.GameID == gameID);
                ctx.Games.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}