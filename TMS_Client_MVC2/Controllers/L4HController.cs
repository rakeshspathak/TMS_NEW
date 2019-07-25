using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Client.Mvc.Controllers
{
    public class L4HController : Controller
    {
        // GET: L4H
        public ActionResult Index()
        {
            return View();
        }

        // GET: L4H/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: L4H/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: L4H/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: L4H/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: L4H/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: L4H/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: L4H/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
