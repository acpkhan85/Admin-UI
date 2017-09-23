using Contract.SmartSchool;
using Entity.SmartSchool;
using SmartSchool.Helper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SmartSchool.Controllers
{
    public class AttendanceController : Controller
    {
        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult TodayAttendance()
        {
            List<ClassAttendanceDto> classAttendance = new List<ClassAttendanceDto>();
            WCFProxy.Using((delegate (IAttendanceService client)
            {
                classAttendance = client.getClassAttendence(0, 0);
            }));

            return View(classAttendance);
        }

        public ActionResult SubmitAttendance(List<ClassAttendanceDto> classAttendance)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}