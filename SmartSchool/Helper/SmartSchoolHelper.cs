using Entity.SmartSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSchool.Helper
{
    public class SmartSchoolHelper
    {
        public static readonly int SCHOOL_ID = 1;
    }

    public static class SmartSchoolExtensions
    {
        public static Pagination ToPagination(this DataTableAjaxPostModel model)
        {
            Pagination paginateModel = new Pagination();
            var start = model.start;
            var length = model.length;
            int pageNumber = (start + length) / length;
            var sortColumn = model.columns[model.order[0].column].data;
            var sortColumnDir = model.order[0].dir;
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;

            paginateModel.PageNumber = start + 1;
            paginateModel.PageSize = pageSize;
            paginateModel.Skip = skip;
            return paginateModel;
        }
    }
}