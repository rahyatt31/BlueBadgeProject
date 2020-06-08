using FootballManager.Models.PlayerStats;
using FootballManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballManager.WebAPI.Controllers
{
    public class PlayerStatsController : ApiController
    {
        private PlayerStatsService CreatePlayerStatsService()
        {
            var playerStatsID = Guid.Parse(User.Identity.GetUserId());
            var playerStatsService = new PlayerStatsService(playerStatsID);
            return playerStatsService;
        }
        public IHttpActionResult Get()
        {
            PlayerStatsService playerStatsService = CreatePlayerStatsService();
            var playerStats = playerStatsService.GetPlayerStats();
            return Ok(playerStats);
        }
        public IHttpActionResult Post(CreatePlayerStats playerStats)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlayerStatsService();
            if (!service.CreatePlayerStats(playerStats))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            PlayerStatsService playerStatsService = CreatePlayerStatsService();
            var playerStats = playerStatsService.GetPlayerStatsByID(id);
            return Ok(playerStats);
        }
        public IHttpActionResult Put(EditPlayerStats playerStats)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlayerStatsService();
            if (!service.UpdatePlayerStats(playerStats))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePlayerStatsService();
            if (!service.DeletePlayerStats(id))
                return InternalServerError();
            return Ok();
        }
    }
}
