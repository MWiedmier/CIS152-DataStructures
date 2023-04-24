using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS152FinalProjectWiedmier.Models;
using System.Web.Mvc;
using System.Web.Mvc.Html;
//using Microsoft.AspNetCore.Mvc;


namespace CIS152FinalProjectWiedmier.Controllers
{
    public class HomeController : Controller
    {
        [Route ("/")]
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.RN = "";
            ViewBag.P = "";
            ViewBag.DOW = "";
            ViewBag.NOP = 0;
            ViewBag.PN = "";

            return View();
        }
        [HttpPost]
        public ActionResult Index(PriorityQueue model)
        {
            if (ModelState.IsValid)
            {
                model.enqueue(model.newNode(ViewBag.RN, ViewBag.P, ViewBag.DOW, ViewBag.NOP, ViewBag.PN));
                return View(model);
            }
            else
            {
                ViewBag.Pay = 0; ViewBag.StudentName = ""; return View(model);

            }
        }

        [HttpGet]
        public ViewResult ReservationLists()
        {

            var model = new ReservationViewModel();

            return View(model);
        }
    }
}