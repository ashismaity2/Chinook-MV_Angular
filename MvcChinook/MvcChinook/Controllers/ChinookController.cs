using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcChinook.Models;
using MvcChinook.Services;

namespace MvcChinook.Controllers
{
    public class ChinookController : Controller
    {
        //private ChinookEntities db = new ChinookEntities();

        //
        // GET: /Chinook/
        private IAppService service;
        public ChinookController(IAppService service)
        {
            this.service = service;
        }
        public JsonResult Index()
        {
            return service.GetCustomer();
        }

        public ActionResult AngIndex()
        {
            return View();
        }
        //
        // GET: /Chinook/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    Customer customer = db.Customers.Find(id);
        //    if (customer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customer);
        //}

        ////
        //// GET: /Chinook/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /Chinook/Create

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Customers.Add(customer);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(customer);
        //}

        ////
        //// GET: /Chinook/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    Customer customer = db.Customers.Find(id);
        //    if (customer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customer);
        //}

        ////
        //// POST: /Chinook/Edit/5

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(Customer customer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(customer).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(customer);
        //}

        ////
        //// GET: /Chinook/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    Customer customer = db.Customers.Find(id);
        //    if (customer == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(customer);
        //}

        ////
        //// POST: /Chinook/Delete/5

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Customer customer = db.Customers.Find(id);
        //    db.Customers.Remove(customer);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}