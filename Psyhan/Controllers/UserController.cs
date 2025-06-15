using Business;
using Dataaccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Psyhan.Controllers
{
    public class UserController : Controller
    {
        UserRepo _userRepo = new UserRepo();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User newUser)
        {
            _userRepo.CreateUser(newUser);
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            UserRepo repo = new UserRepo();
            var loggedUser = repo.CheckLogin(user.UserName, user.Password);

            if (loggedUser != null)
            {
                Session["LoggedUser"] = loggedUser;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginError = "Kullanıcı adı veya şifre hatalı.";
                return View("Login");
            }
        }

    }
}