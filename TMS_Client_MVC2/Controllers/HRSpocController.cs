using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMS.Client.Mvc.Controllers
{
    public class HRSpocController : Controller
    {
        // GET: HRSpoc
        public ActionResult Index()
        {
            return View();
        }

        // GET: HRSpoc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HRSpoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HRSpoc/Create
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

        // GET: HRSpoc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HRSpoc/Edit/5
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

        // GET: HRSpoc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HRSpoc/Delete/5
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
