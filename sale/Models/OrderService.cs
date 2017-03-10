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
        public void InsertOrder()
        {
         
        }
        /// <summary>
        /// 刪除訂單
        /// </summary>
        public void DeleteOrderById()
        {
            
        }
        /// <summary>
        /// 更新訂單
        /// </summary>
        public void UpdateOrder()
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
            return new List<Order>();
        }
    }
}