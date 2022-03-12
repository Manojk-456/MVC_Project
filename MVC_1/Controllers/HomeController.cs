using MVC_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentModel obj = new StudentModel();
            obj.Roll = 123;
            obj.name = "manoj Kumar yadav";
            obj.email = "manukr2020@gmail.com";
            obj.mob ="6387720731";
            obj.address = "Varanasi";

            ViewBag.Sub = "math";
            ViewBag.Teacher = "Chaursiya";
            ViewBag.College="Government Polytechnic Aurai";
            ViewBag.Salary = 800000;
            ViewBag.List = new List<string>()
            {
                "I",
                "Love",
                "my",
                "India"
            };

            ViewData["department"]="NET Developer";
            ViewData["salary"] = 4000225;
            ViewData["Company"] = "chetu Inc";


            TempData["ename"] = "Mahesh Kumar";
            TempData["eid"] = 45525;
            TempData["salary"] = 8500055;
            TempData["department"] = ".NeT Developer";

            Session["data"] = "session start";
            return View(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}