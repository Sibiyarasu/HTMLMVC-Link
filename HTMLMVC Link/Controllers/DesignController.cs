using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLMVC_Link.Controllers
{
    public class DesignController : Controller
    {
        // GET: DesignController
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }


        public ActionResult Program()
        {
            return View();
        }

        // GET: DesignController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DesignController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DesignController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DesignController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DesignController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DesignController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DesignController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
