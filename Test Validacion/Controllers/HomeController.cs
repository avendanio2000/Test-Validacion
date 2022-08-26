using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_Validacion.Models;

namespace Test_Validacion.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginDataModel logingDataModel)
        {
            if (ModelState.IsValid)
                return RedirectToAction("About");
            else
                return View(logingDataModel);
        }

        public ActionResult Ok()
        {
            //codigo validacion correcta
            ViewBag.Message = "Inicio exitoso";

            return View();
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