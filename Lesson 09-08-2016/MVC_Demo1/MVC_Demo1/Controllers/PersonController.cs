using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Demo1.Models;
using System.Web.Mvc;


namespace MVC_Demo1.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            PersonModel person = new PersonModel();
            person.ListAllPersons(); //Initialize empty list....
            person.TotalRecords = "Total Records: " + person.lstPersons.Count.ToString("###,##0");
            ViewBag.MenuTitle = "Personnel Info Database";
            return View(person);
        }

        [HttpGet]
        public PartialViewResult GetSearh(string state)
        {
            PersonModel modelP = new PersonModel();

            if(state != "0")
            {
                modelP.StateParam = state;
                modelP.ListAllPersons(); //Initialize list based on state value.
            }
            modelP.TotalRecords = "Total Records: " + modelP.lstPersons.Count.ToString("###,##0");
            string aga = PartialView("~/Views/Person/_GridResult.cshtml", modelP).ToString();
            return PartialView("~/Views/Person/_GridResult.cshtml", modelP);
        }
    }
}