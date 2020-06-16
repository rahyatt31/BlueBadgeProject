using FootballManager.Data;
using FootballManager.Models.Player;
using FootballManager.Models.PlayerStats;
using FootballManager.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManagerServices
{
    public class TeamService
    {
        private readonly Guid _userID;
        public TeamService(Guid userID)
        {
            _userID = userID;
        }

        public TeamService()
        {
        }

        public bool CreateTeam(CreateTeam model)
        {
            var entity = new Team()
            {
                TeamName = model.TeamName
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Teams.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ListTeam> GetTeam()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Teams
                        .Select(
                            e =>
                                new ListTeam
                                {
                                    TeamID = e.TeamID,
                                    TeamName = e.TeamName
                                }
                        );
                return query.ToArray();
            }
        }
        public DetailTeam GetTeamByID(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Teams
                        .Single(e => e.TeamID == teamId);
                List<ListPlayer> roster = entity.Players
                .Select(
                    e =>
                        new ListPlayer
                        {
                            PlayerID = e.PlayerID,
                            TeamID = e.TeamID,
                            TeamName = e.Team.TeamName, //available because of 'virtual'
                            PlayerFirstName = e.PlayerFirstName,
                            PlayerLastName = e.PlayerLastName
                        }
                    ).ToList();
                return
                    new DetailTeam
                    {
                        TeamID = entity.TeamID,
                        TeamName = entity.TeamName,
                        TeamPlayers = roster
                    };
            }
        }

        public bool UpdateTeam(EditTeam model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Teams
                        .Single(e => e.TeamID == model.TeamID);
                entity.TeamName = model.TeamName;
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteTeam(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Teams
                        .Single(e => e.TeamID == teamId);
                ctx.Teams.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}