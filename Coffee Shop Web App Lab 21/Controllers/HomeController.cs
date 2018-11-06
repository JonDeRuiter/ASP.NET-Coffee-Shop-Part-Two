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
            ViewBag.Message = $"Welcome {r.email} can I call you {r.firstName}?";
            if (Validator.TruePW(r.password) && r.password == r.confirmPW)
            {
                ViewBag.password = $"Your password{r.password}, was accepted. Be sure to keep it secure!";
            }
            else
            {
                UserRegistration();
            }
            if (Validator.ValidPhone(r.phoneNum))
            {
                ViewBag.phone = $"I'll call you at {r.phoneNum} when your order is ready for pickup";
            }
            else
            {
                UserRegistration();
            }
            ViewBag.nintendo = $"Captain Falcon is way better than {r.ninFav}";
            ViewBag.market = $"So glad that you signed up {r.marketing}, for our coupons and stuff.";
            return View();
        }
           
    }
}