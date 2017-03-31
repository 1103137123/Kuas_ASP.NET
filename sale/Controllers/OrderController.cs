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
            //Models.OrderService orderService = new Models.OrderService();
            //var order = orderService.GetOrderById("123");
            //ViewBag.CustId = order.CustId;
            //ViewBag.CustName = order.CustName;

            //Models.OrderService orderService = new Models.OrderService();
            //ViewBag.Data = orderService.GetOrders();

            //ViewBag.Desc1 = "ViewBag";
            //ViewData["Desc2"] = "ViewData";
            //TempData["Desc3"] = "TempData";

            List<SelectListItem> custData = new List<SelectListItem>();
            custData.Add(new SelectListItem()
            {
                Text = "瑞陽資訊",
                Value = "1"
            });
            custData.Add(new SelectListItem()
            {
                Text = "網軟資訊",
                Value = "2"
            });
            ViewBag.custData = custData;
            return View();
        }
        /// <summary>
        /// 新增訂單的畫面
        /// </summary>
        /// <returns></returns>
        public ActionResult InsertOrder()
        {
            Models.Order order = new Models.Order();
            order.CustId = "瑞陽資訊";
            return View(order);
        }

        /// <summary>
        /// 新增訂單存檔的Action
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost()]
        public ActionResult InsertOrder(Models.Order order)
        {
            //Models.OrderService orderService = new Models.OrderService();
            //orderService.InsertOrder(order);
            return View();
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