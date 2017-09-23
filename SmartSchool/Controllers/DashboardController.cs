using Contract.SmartSchool;
using Entity.SmartSchool;
using SmartSchool.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartSchool.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            DashboardDto dashboard = new DashboardDto();
            WCFProxy.Using((delegate (IDashboardService client)
            {
                dashboard = client.getDashboard();
            }));
            return View(dashboard);
        }
    }
}