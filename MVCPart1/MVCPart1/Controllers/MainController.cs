using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPart1.Models;

namespace MVCPart1.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            Introduction clsIntr = new Introduction();

            clsIntr.TitleName = "Welcome for today MVC lesson!!!";
            
            return View(clsIntr);
        }

        public ActionResult MainPage2()
        {
            ViewBag.Message = "Hello Page # 2";
            return View();
        }

        public ActionResult MainPage3()
        {
            List<Person> listP = new List<Person>();

            var p1 = new Person();
            p1.Age = 18;
            p1.Name = "Keisha";
            p1.Sex = "female";
            p1.SkinColor = "black";
            listP.Add(p1);

            var p2 = new Person();
            p2.Age = 23;
            p2.Name = "Alex";
            p2.Sex = "male";
            p2.SkinColor = "white";
            listP.Add(p2);

            return View(listP);
        }
    }
}