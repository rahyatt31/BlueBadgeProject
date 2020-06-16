using FootballManager.Models.Team;
using FootballManagerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballManager.WebAPI.Controllers
{
    public class TeamViewController : Controller
    {
        // GET: TeamView
        public ActionResult Index()
        {
            TeamService teamService = new TeamService();
            return View(teamService.GetTeam());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateTeam ct)
        {
            if (this.ModelState.IsValid)
            {
                TeamController tc = new TeamController();
                tc.Post(ct);
                return RedirectToAction("Index", "Home"); //LOOKUP: redirect to action (take to another page) 
            }
            else
            {
                return View(ct);
            }
        }

        //Update
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(EditTeam et)
        {
            if (this.ModelState.IsValid)
            {
                TeamController tc = new TeamController();
                tc.Put(et);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(et);
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
                TeamController tc = new TeamController();
                tc.Delete(id);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(id);
            }
        }
    }
}