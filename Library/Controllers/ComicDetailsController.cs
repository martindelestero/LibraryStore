using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class ComicDetailsController : Controller
    {
        public string Detail()
        {
            return "BOOKS DETAILS";
        }

        public ActionResult Contenido()
        {

            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday || DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            {
                //  return Redirect("/");
                return View();
            }


            return Content("Cerrado los dias de la semana");

        }

    }
}
