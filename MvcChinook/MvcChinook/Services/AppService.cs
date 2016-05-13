using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcChinook.Models;

namespace MvcChinook.Services
{
    public class AppService : IAppService
    {
        private ChinookEntities db = new ChinookEntities();

        //
        // GET: /Default1/

        public JsonResult GetCustomer()  //index
        {
            var co = db.Customers.ToList();
            return new JsonResult { Data = co, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        //public void CreCustomer(Customer customer)  //index
        //{
        //    db.Customers.Add(customer);
        //    db.SaveChanges();

        //}
    }
}
