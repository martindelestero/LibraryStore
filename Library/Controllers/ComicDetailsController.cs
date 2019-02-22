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

            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                return Redirect("/");
            }


            return Content("Contenido TEST");

        }

    }
}
