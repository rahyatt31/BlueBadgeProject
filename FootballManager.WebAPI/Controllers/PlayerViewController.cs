using FootballManager.Models.Player;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballManager.WebAPI.Controllers
{
    //[Authorize]
    public class PlayerViewController : Controller
    {
        //GET: PlayerView
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet] //this is where I get html from
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost] //this is where it posts upon submit
        public ActionResult Create(CreatePlayer cp)
        {
            PlayerController pc = new PlayerController();
            pc.Post(cp);
            return View(); //LOOKUP: redirect to action (take to another page) 
        }
    }
}