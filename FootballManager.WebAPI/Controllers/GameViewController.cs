using FootballManager.Models.Game;
using FootballManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballManager.WebAPI.Controllers
{
    public class GameViewController : Controller
    {
        // GET: GameCreate
        public ActionResult Index()
        {
            GameService gameService = new GameService();
            return View(gameService.GetGame());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateGame cg)
        {
            if (this.ModelState.IsValid)
            {
                GameController gc = new GameController();
                gc.Post(cg);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(cg);
            }
        }

        //Update
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(EditGame eg)
        {
            if (this.ModelState.IsValid)
            {
                GameController gc = new GameController();
                gc.Put(eg);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(eg);
            }
        }

        //Delete
        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (this.ModelState.IsValid)
            {
                GameController gc = new GameController();
                gc.Delete(id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(id);
            }
        }
    }
}