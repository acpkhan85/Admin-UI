using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Contract.SmartSchool;
using SmartSchool.Helper;

namespace SmartSchool.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            //WCFProxy.Using((delegate (IClassSetupService client)
            //{
            //    var resulrt = client.getExamTimeTable(1);
            //}));

            return View();
        }
    }
}