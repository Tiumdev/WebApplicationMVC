using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            MVCdbEntities1 db = new MVCdbEntities1();

            User user = db.Users.SingleOrDefault(x=>x.Id == 1);

            UsersViewModel usrVM = new UsersViewModel();
            usrVM.Id = user.Id;
            usrVM.FName = user.FName;
            usrVM.LName = user.LName;
            usrVM.Address = user.Address;
            return View(usrVM);
        }
    }
}