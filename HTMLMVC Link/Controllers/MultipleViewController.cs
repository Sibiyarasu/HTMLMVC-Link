using ClassLibrary.Model;
using ClassLibrary.Repository;
using HTMLMVC_Link.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTMLMVC_Link.Controllers
{
    public class MultipleViewController : Controller
    {
        public ProductRepository prodObj;


        public MultipleViewController()
        {
            prodObj = new ProductRepository();
        }

        // GET: MultipleViewController
        public ActionResult Index()
        {
            var model = new ProductViewModel();
            model.Create = new ClassLibrary.Model.ProductModel();
            model.List = prodObj.SelectSP();


            return View("view", model);
        }

        // GET: MultipleViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    

        // POST: MultipleViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel  model)
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

        // GET: MultipleViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MultipleViewController/Edit/5
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

        // GET: MultipleViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MultipleViewController/Delete/5
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
