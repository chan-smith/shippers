using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shippers.Models;

namespace shippers.Controllers
{
    public class ShippersController : Controller
    {
        private IShippersRepository db = new ShippersRepository();
        // GET: Shippers
        public ActionResult Index()
        {
            return View(db.GetAll());
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Shippers shippersForm)
        {
            db.Insert(shippersForm);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id=0)
        {
            return View(db.GetOne(id));
        }

        [HttpPost]
        public ActionResult Update(Shippers shippersForm)
        {
            db.Update(shippersForm);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id=0)
        {
            db.Delete(db.GetOne(id));
            return RedirectToAction("Index");
        }
    }
}