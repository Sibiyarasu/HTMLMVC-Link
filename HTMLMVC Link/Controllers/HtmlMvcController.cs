using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLMVC_Link.Controllers
{
    public class HtmlMvcController : Controller
    {
        // GET: HtmlMvcController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HtmlMvcController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HtmlMvcController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HtmlMvcController/Create
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

        // GET: HtmlMvcController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HtmlMvcController/Edit/5
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

        // GET: HtmlMvcController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HtmlMvcController/Delete/5
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
