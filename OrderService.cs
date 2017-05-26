using sample01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sample01
{
    public class OrderService
    {
        private Model1 DB = new Model1();

        //public List<Categories> GetCategoryList()
        //{
        //    return DB.Categories.ToList();
        //}
        //public List<Suppliers> GetSupplierList()
        //{
        //    return DB.Suppliers.ToList();
        //}

        ////GET : Orders

        //public List<Orders> GetList()
        //{
        //    var Orders = DB.Orders.Include("Categories").Include("Suppliers");
        //    return Orders.ToList();
        //}

        ////GET:Orders/Detials
        //public Orders GetSingle(int id)
        //{
        //    Orders orders = DB.Orders.Single(p => p.OrderID == id);
        //    return orders;
        //}
        ////POST:/Orders/Creat
        //public void Creat(Orders orders)
        //{
        //    DB.Orders.Add(orders);
        //    DB.SaveChanges();
        //}
        ////Orders/Edit
        //public void Edit(Orders orders)
        //{
        //    DB.Orders.Attach(orders);
        //    DB.O
        //}
    }
}