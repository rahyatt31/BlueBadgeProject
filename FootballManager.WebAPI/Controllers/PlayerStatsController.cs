using FootballManager.Models.PlayerStats;
using FootballManager.Services;
using Microsoft.AspNet.Identity;
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
            //var playerStatsID = Guid.Parse(User.Identity.GetUserId());
            //var playerStatsService = new PlayerStatsService(playerStatsID);
            //return playerStatsService;
            return new PlayerStatsService();
        }
        /// <summary>
        /// Looks up all Player Stats.
        /// </summary>
        public IHttpActionResult Get()
        {
            PlayerStatsService playerStatsService = CreatePlayerStatsService();
            var playerStats = playerStatsService.GetPlayerStats();
            return Ok(playerStats);
        }
        /// <summary>
        /// Creates a Player Stat with specific information.
        /// </summary>
        public IHttpActionResult Post(CreatePlayerStats playerStats)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlayerStatsService();
            if (!service.CreatePlayerStats(playerStats))
                return InternalServerError();
            return Ok();
        }
        /// <summary>
        /// Looks up a Player Stat by its ID.
        /// </summary>
        public IHttpActionResult Get(int id)
        {
            PlayerStatsService playerStatsService = CreatePlayerStatsService();
            var playerStats = playerStatsService.GetPlayerStatsByID(id);
            return Ok(playerStats);
        }
        /// <summary>
        /// Changes details about a Player Stat.
        /// </summary>
        public IHttpActionResult Put(EditPlayerStats playerStats)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreatePlayerStatsService();
            if (!service.UpdatePlayerStats(playerStats))
                return InternalServerError();
            return Ok();
        }
        /// <summary>
        /// Deletes Player Stats by their ID.
        /// </summary>
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePlayerStatsService();
            if (!service.DeletePlayerStats(id))
                return InternalServerError();
            return Ok();
        }
    }
}
