using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internship.Controllers
{
    public class CircularsController : Controller
    {
        // GET: Circulars
        public ActionResult IndexCirculars()
        {
            return View();
        }
        public ActionResult DetailCompany()
        {
            return View();
        }
        public PartialViewResult Test()
        {
            return PartialView();
        }
    }
}