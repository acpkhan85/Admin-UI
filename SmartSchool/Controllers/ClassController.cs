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
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Division()
        {
            //Pagination paging = new Pagination();
            //paging.PageNumber = 1;
            //paging.PageSize= 10;
            //paging.SchoolId = SmartSchoolHelper.SCHOOL_ID;
            //paging.SortColumn = "Standard_Asc";

            //int i = 0;
            //List<ClassRoom> classRoomDto = new List<ClassRoom>();
            //WCFProxy.Using((delegate (IClassSetupService client)
            //{
            //    classRoomDto = client.getStandardDivision(1,1,paging,out i);
            //}));
            return View();
        }

        public ActionResult StudentSetUp()
        {
            return View();
        }

        public ActionResult ExamTimeTable()
        {
            return View();
        }

        public ActionResult TimeTable()
        {
            return View();
        }
        public ActionResult Holiday()
        {
            return View();
        }

        public ActionResult StudentProfile()
        {
            return View();
        }
        public ActionResult StudentAttendanceProfile()
        {
            return View();
        }

    }
}