﻿using Contract.SmartSchool;
using Entity.SmartSchool;
using SmartSchool.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartSchool.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SubmitNews(NewsDto newsDto)
        {
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNews(DataTableAjaxPostModel model)
        {
            Pagination paginateModel = model.ToPagination();
            int recordsTotal = 0;

            List<NewsDto> newsCollection = new List<NewsDto>();
            WCFProxy.Using((delegate (IEventsAndNewsService client)
            {
                newsCollection = client.getNews(1, paginateModel,out recordsTotal);
            }));

            return Json(new
            {
                // this is what datatables wants sending back
                draw = model.draw,
                recordsTotal = recordsTotal,
                recordsFiltered = recordsTotal,
                data = newsCollection
            }, JsonRequestBehavior.AllowGet);
        }
    }
}