using FootballManager.Data;
using FootballManager.WebAPI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FootballManager.WebAPI.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterBindingModel rbm)
        {
            var pc = new AccountController();
            var result = pc.Register(rbm);

            //var user = new ApplicationUser() { UserName = rbm.Email, Email = rbm.Email };
            //IdentityResult result = await UserManager.CreateAsync(user, rbm.Password);


            return RedirectToAction("Create", "PlayerView");
            //return View(rbm);
        }
    }
}