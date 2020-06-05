using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FootballManagerServices;
using Microsoft.AspNet.Identity;
using FootballManager.Models.Team;

namespace FootballManager.WebAPI.Controllers
{
    public class TeamController : ApiController
    {
        private TeamService CreateTeamService()
        {
            var teamID = Guid.Parse(User.Identity.GetUserId());
            var teamService = new TeamService(teamID);
            return teamService;
        }
        public IHttpActionResult Get()
        {
            TeamService teamService = CreateTeamService();
            var teams = teamService.GetTeam();
            return Ok(teams);
        }
        public IHttpActionResult Post(CreateTeam team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateTeamService();
            if (!service.CreateTeam(team))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Get(Guid id)
        {
            TeamService teamService = CreateTeamService();
            var team = teamService.GetTeamByID(id);
            return Ok(team);
        }
        public IHttpActionResult Put(EditTeam team)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateTeamService();
            if (!service.UpdateTeam(team))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(Guid id)
        {
            var service = CreateTeamService();
            if (!service.DeleteTeam(id))
                return InternalServerError();
            return Ok();
        }
    }
}
