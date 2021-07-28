using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialTempDataExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (TempData.ContainsKey("searchTerm"))
            {
                ViewBag.searchTerm = TempData["searchTerm"].ToString();
            }
            return View();
        }
        public PartialViewResult ShowPartial(string searchTerm)
        {
            return PartialView("ShowPartial", searchTerm);
        }
        public ActionResult PartialTest(string searchTerm = "")
        {

            TempData["searchTerm"] = searchTerm;
            
            return RedirectToAction("Index", "Home");

        }
       
    }
}