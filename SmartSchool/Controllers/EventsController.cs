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
            ViewBag.SchoolId = 1;
            //WCFProxy.Using((delegate (IClassSetupService client)
            //{
            //    var resulrt = client.getExamTimeTable(1);
            //}));

            return View();
        }

        public ActionResult SubmitEvent(EventsDto eventDto)
        {
            MessageDTO message = new MessageDTO();
            
            WCFProxy.Using((delegate (IEventsAndNewsService client)
            {
                message = client.addUpdateEvents(eventDto);
            }));

            return Json(message.message, JsonRequestBehavior.AllowGet);
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