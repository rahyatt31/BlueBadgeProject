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
            return View();
        }
    }
}