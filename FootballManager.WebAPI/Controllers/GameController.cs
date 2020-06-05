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
        public IHttpActionResult Get()
        {
            GameService gameService = CreateGameService();
            var game = gameService.GetGame();
            return Ok(game);
        }
        public IHttpActionResult Post(CreateGame game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateGameService();
            if (!service.CreateGame(game))
                return InternalServerError();
            return Ok();
        }
        private GameService CreateGameService()
        {
            var gameID = Guid.Parse(User.Identity.GetUserId());
            var gameService = new GameService(gameID);
            return gameService;
        }
        public IHttpActionResult Get(int id)
        {
            GameService gameService = CreateGameService();
            var game = gameService.GetGameByID(id);
            return Ok(game);
        }
        public IHttpActionResult Put(EditGame game)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = GameService();
            if (!service.UpdateGame(game))
                return InternalServerError();
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = GameService();
            if (!service.DeleteGame(id))
                return InternalServerError();
            return Ok();
        }
    }
}
