using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartSchool.Controllers
{
    public class CMSController : Controller
    {
        // GET: CMS
        public ActionResult Branding()
        {
            return View();
        }

        public ActionResult Banner()
        {
            return View();
        }
    }

}