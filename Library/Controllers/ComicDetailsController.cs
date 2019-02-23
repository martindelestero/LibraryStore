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

                ViewBag.SeriesTitle = "Spider Man";
                ViewBag.IssueNumber = 700;
                ViewBag.Description = "Final issue";
                ViewBag.artists = new string[]  // array to add artists, if statement to check if there are any content to render, if false do not render
                    {
                        "Script: Ana bonetto",
                        //"Edition: Shan kumar"
                    };

                return View();
            }


            return Content("Cerrado los dias de la semana");

        }

    }
}
