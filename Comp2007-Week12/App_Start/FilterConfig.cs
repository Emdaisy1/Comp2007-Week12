﻿using System.Web;
using System.Web.Mvc;

namespace Comp2007_Week12
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}