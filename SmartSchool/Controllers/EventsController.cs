using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Contract.SmartSchool;
using SmartSchool.Helper;
using Entity.SmartSchool;
using Contract.SmartSchool;

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

        public ActionResult SubmitEvent(EventsDto eventDto)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEvents(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;

            List<EventsDto> eventsCollection = new List<EventsDto>();
            WCFProxy.Using((delegate (IEventsAndNewsService client)
            {
                eventsCollection = client.getEvents(1, paginateModel, out recordsTotal);
            }));
            
            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = eventsCollection
            }, JsonRequestBehavior.AllowGet);
        }
    }
}