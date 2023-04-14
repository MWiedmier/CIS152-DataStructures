using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CIS152FinalProjectWiedmier.Models;
using Microsoft.AspNetCore.Mvc;


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
            ViewBag.PN = 0;

            return View();
        }
        [HttpPost]
        public IActionResult Index(PriorityQueue model)
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