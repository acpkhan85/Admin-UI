using Contract.SmartSchool;
using Entity.SmartSchool;
using SmartSchool.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entity.SmartSchool;

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
            ClassRoomDto c = new ClassRoomDto();
            return View(c);
        }
       
        public JsonResult GetDivisions(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;

            ClassRoomCollection classRoomsCollection = new ClassRoomCollection();
            WCFProxy.Using((delegate (IClassSetupService client)
            {
                classRoomsCollection = client.getStandardDivision(null, null,1, paginateModel);
            }));

            recordsTotal = classRoomsCollection.TotalCount;
            var data = classRoomsCollection.ClassRoom.Skip(paginateModel.Skip).Take(paginateModel.PageSize).ToList();

            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = data
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult StudentSetUp()
        {
            StudentDto d = new StudentDto();
            return View(d);
        }

        public JsonResult GetStudents(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;
            StudentCollection studentCollection = new StudentCollection();
            WCFProxy.Using((delegate (IClassSetupService client)
            {
                studentCollection = client.getStudent(1, 1, paginateModel);
            }));

            recordsTotal = studentCollection.TotalCount;
            var data = studentCollection.StudentList.Skip(paginateModel.Skip).Take(paginateModel.PageSize).ToList();

            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = data
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ExamTimeTable()
        {
            ExamTimeTableDto examTimeTableDto = new ExamTimeTableDto();
            return View(examTimeTableDto);
        }

        public JsonResult GetExamTimetable(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;
            List<ExamTimeTableDto> examTimeTableList = new List<ExamTimeTableDto>();
            WCFProxy.Using((delegate (IClassSetupService client)
            {
                examTimeTableList = client.getExamTimeTable(1);
            }));

            recordsTotal = examTimeTableList.Count;
            var data = examTimeTableList.Skip(paginateModel.Skip).Take(paginateModel.PageSize).ToList();

            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = data
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TimeTable()
        {
            TimeTableDto timeTableDto = new TimeTableDto();
            return View(timeTableDto);
        }

        public JsonResult GetTimetable(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;
            List<TimeTableDto> timeTableList = new List<TimeTableDto>();
            WCFProxy.Using((delegate (IClassSetupService client)
            {
                timeTableList = client.getTimeTable(1);
            }));

            recordsTotal = timeTableList.Count();
            var data = timeTableList.Skip(paginateModel.Skip).Take(paginateModel.PageSize).ToList();

            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = data
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Holiday()
        {
            HolidaysDto colidaysDto = new HolidaysDto();
            return View(colidaysDto);
        }

        public JsonResult GetHolidays(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;
            List<HolidaysDto> holidaysList = new List<HolidaysDto>();
            WCFProxy.Using((delegate (IClassSetupService client)
            {
                holidaysList = client.getHolidayDetail(1);
            }));

            recordsTotal = holidaysList.Count();
            var data = holidaysList.Skip(paginateModel.Skip).Take(paginateModel.PageSize).ToList();

            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = data
            }, JsonRequestBehavior.AllowGet);
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