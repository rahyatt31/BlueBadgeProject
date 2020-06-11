using FootballManager.Models.Game;
using FootballManagerServices;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballManager.WebAPI.Controllers
{
    public class GameController : ApiController
    {
        private GameService CreateGameService()
        {
            var gameID = Guid.Parse(User.Identity.GetUserId());
            var gameService = new GameService(gameID);
            return gameService;
        }
        /// <summary>
        /// Looks up all Games.
        /// </summary>
        public IHttpActionResult Get()
        {
            GameService gameService = CreateGameService();
            var game = gameService.GetGame();
            return Ok(game);
        }
        /// <summary>
        /// Creates a Game with specific information.
        /// </summary>
        public IHttpActionResult Post(CreateGame game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateGameService();
            if (!service.CreateGame(game))
                return InternalServerError();
            return Ok();
        }
        /// <summary>
        /// Looks up a Game by its ID.
        /// </summary>
        public IHttpActionResult Get(int id)
        {
            GameService gameService = CreateGameService();
            var game = gameService.GetGameByID(id);
            return Ok(game);
        }
        /// <summary>
        /// Changes details about a Game.
        /// </summary>
        public IHttpActionResult Put(EditGame game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateGameService();
            if (!service.UpdateGame(game))
                return InternalServerError();
            return Ok();
        }
        /// <summary>
        /// Deletes a Game by their ID.
        /// </summary>
        public IHttpActionResult Delete(int id)
        {
            var service = CreateGameService();
            if (!service.DeleteGame(id))
                return InternalServerError();
            return Ok();
        }
    }
}
