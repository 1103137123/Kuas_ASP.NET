using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sale.Controllers
{
    public class OrderController : Controller
    {
        /// <summary>
        /// 訂單管理系統首頁
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetOrderById("123");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;

            //ViewBag.Desc1 = "ViewBag";
            //ViewData["Desc2"] = "ViewData";
            //TempData["Desc3"] = "TempData";
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            return View();
        }

        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            Models.OrderService orderService = new Models.OrderService();
            orderService.InsertOrder(order);
            return View("Index");
        }

        [HttpGet()]
        public JsonResult TestJson()
        {
            //var result = new Models.Order();
            //result.CustId = "TEST";
            //result.CustName = "TESTNAME";

            var result = new Models.Order() { CustId="testId",CustName="testName"};
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}