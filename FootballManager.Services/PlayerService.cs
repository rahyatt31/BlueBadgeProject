using FootballManager.Data;
using FootballManager.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerServices
{
    public class PlayerService
    {
        private readonly Guid _userID; // Need to be Guid?
        public PlayerService(Guid userID)
        {
            _userID = userID;
        }
        public bool CreatePlayer(CreatePlayer model)
        {
            var entity = new Player()
            {
                PlayerID = model.PlayerID,
                PlayerFirstName = model.PlayerFirstName,
                PlayerLastName = model.PlayerLastName,
                PlayerPosition = model.PlayerPosition,
                PlayerJerseyNumber = model.PlayerJerseyNumber,
                PlayerHeightByInches = model.PlayerHeightByInches,
                PlayerWeightByPounds = model.PlayerWeightByPounds
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Players.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ListPlayer> GetPlayer()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Players
                        //.Where(e => e.UserID == _userID)
                        .Select(
                            e =>
                                new ListPlayer
                                {
                                    PlayerID = e.PlayerID,
                                    //TeamID = e.TeamID,
                                    PlayerFirstName = e.PlayerFirstName,
                                    PlayerLastName = e.PlayerLastName,
                                    PlayerPosition = e.PlayerPosition,
                                    PlayerJerseyNumber = e.PlayerJerseyNumber,
                                    PlayerHeightByInches = e.PlayerHeightByInches,
                                    PlayerWeightByPounds = e.PlayerWeightByPounds
                                }
                        );
                return query.ToArray();
            }
        }
        public DetailPlayer GetPlayerByID(int playerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Players
                        .Single(e => e.PlayerID == playerId);
                return
                    new DetailPlayer
                    {
                        PlayerID = entity.PlayerID,
                        //TeamID = entity.TeamID,
                        PlayerFirstName = entity.PlayerFirstName,
                        PlayerLastName = entity.PlayerLastName,
                        PlayerPosition = entity.PlayerPosition,
                        PlayerJerseyNumber = entity.PlayerJerseyNumber,
                        PlayerHeightByInches = entity.PlayerHeightByInches,
                        PlayerWeightByPounds = entity.PlayerWeightByPounds
                    };
            }
        }
        public bool UpdatePlayer(EditPlayer model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Players
                        .Single(e => e.PlayerID == model.PlayerID);
                entity.PlayerID = model.PlayerID;
                entity.PlayerFirstName = model.PlayerFirstName;
                entity.PlayerLastName = model.PlayerLastName;
                entity.PlayerPosition = model.PlayerPosition;
                entity.PlayerJerseyNumber = model.PlayerJerseyNumber;
                entity.PlayerHeightByInches = model.PlayerHeightByInches;
                entity.PlayerWeightByPounds = model.PlayerWeightByPounds;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeletePlayer(int playerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Players
                        .Single(e => e.PlayerID == playerId);
                ctx.Players.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}