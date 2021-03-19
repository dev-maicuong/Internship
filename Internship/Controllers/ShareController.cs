using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Internship.Controllers
{
    public class ShareController : Controller
    {
        // GET: Share
        public PartialViewResult Menu()
        {
            return PartialView();
        }
    }
}