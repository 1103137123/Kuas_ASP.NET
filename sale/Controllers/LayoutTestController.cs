﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sale.Controllers
{
    public class LayoutTestController : Controller
    {
        // GET: LayoutTest
        
        /// <summary>
        /// 測試主板頁面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}