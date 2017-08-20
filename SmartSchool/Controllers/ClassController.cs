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
            ClassRoomDto c = new ClassRoomDto();


            return View(c);
        }

        public ActionResult GetDivisions()
        {
            List<ClassRoomDto> classRooms = new List<ClassRoomDto>();
            classRooms.Add(new ClassRoomDto { Standard = "5th", Division = "A", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "5th", Division = "B", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "5th", Division = "C", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "5th", Division = "D", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
                                                                              
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "A", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "B", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "C", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "D", Actions= "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });

            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "A", Actions = "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "B", Actions = "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "C", Actions = "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            classRooms.Add(new ClassRoomDto { Standard = "6th", Division = "D", Actions = "<i title='view' class='fa fa-eye btn btn-dark' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-pencil btn btn-success' data-toggle='modal' data-target='.bs-example-modal-lg'></i><i title = 'edit' class='fa fa-close btn btn-danger' data-toggle='modal' data-target='.bs-example-modal-lg'></i>" });
            return Json(new { data = classRooms }, JsonRequestBehavior.AllowGet);
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