﻿using System.Web;
using System.Web.Mvc;

namespace OpenQbit.InventorySystem.Presentation.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}