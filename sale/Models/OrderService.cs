using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sale.Models
{
    /// <summary>
    /// 訂單的服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 新增訂單
        /// </summary>
        public void InsertOrder(Models.Order order)
        {
         
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrderById(string id)
        {
            
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder(Models.Order order)
        {

        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        public Models.Order GetOrderById(string id)
        {
            Models.Order result = new Order();
            result.CustId = "test_CustId";
            result.CustName = "test_CustName";
            return result;
        }
        /// <summary>
        /// 取得訂單
        /// </summary>
        /// <returns></returns>
        public List<Models.Order> GetOrders()
        {
            List<Models.Order> result = new List<Order>();
            result.Add(new Order() { CustId = "GSS", CustName = "瑞陽資訊", EmpId = 1, EmpName = "王曉明" ,Orderdate= DateTime.Parse("2015/11/08")});
            //result.Add(new Order() { CustId = "GSS??", CustName = "瑞陽資訊??", EmpId = 2, EmpName = "明", Orderdate = DateTime.Parse("2015/1/1") });
            return result;
        }
    }
}