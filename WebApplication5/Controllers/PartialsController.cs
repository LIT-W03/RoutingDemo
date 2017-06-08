using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class PartialsController : Controller
    {
        public ActionResult Page1()
        {
            return View(new PageOneViewModel());
        }

        public ActionResult Page2()
        {
            return View(new PageTwoViewModel {SomeText = "SOMETHING FROM THE CONTROLLER"});
        }
    }

    public class PageOneViewModel
    {
        public DateTime CurrentDate { get; set; }
        public List<int> Numbers { get; }

        public PageOneViewModel()
        {
            Numbers = Enumerable.Range(1, 20).ToList();
        }
    }

    public class PageTwoViewModel
    {
        public string SomeText { get; set; }

        public List<int> Numbers { get; }

        public PageTwoViewModel()
        {
            Numbers = Enumerable.Range(200, 30).ToList();
        }
    }

}