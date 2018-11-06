using Coffee_Shop_Web_App_Lab_21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee_Shop_Web_App_Lab_21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserRegistration()
        {
            ViewBag.Message = "Nice to meet you! Who are you again?";

            return View();
        }

        public ActionResult Welcome(Registration r)
        {
            ViewBag.Message = $"Welcome {r.firstName}. Maybe I'll remember you next time :(";
            ViewBag.password = $"pfft... why'd make your password so predictable? Anyone would guess {r.password} for that username...";

            return View();
        }
           
    }
}