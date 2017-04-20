using DavidSamuezaExercise.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DavidSamuezaExercise.Controllers
{
    public class PicoPlacaController : Controller
    {
        //
        // GET: /PicoPlaca/
        Restriction restriction = new Restriction();
        public ActionResult Index()
        {
            ViewBag.IsvalR = 0;
            return View();
        }


        [HttpPost]
        public ActionResult Index(PicoPlaca picoPlca)
        {
            ViewBag.IsvalR = 2;
            if (ModelState.IsValid)
            {
                if (restriction.IsAllowCar(picoPlca))
                {
                    ViewBag.IsvalR = 1;
                }
            }
            return View(picoPlca);
        }

    }
}
