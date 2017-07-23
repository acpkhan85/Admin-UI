using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartSchool.Controllers
{
    public class NoticeBoardController : Controller
    {
        // GET: NoticeBoard
        public ActionResult Index()
        {
            return View();
        }
    }
}