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
        public ProductTypeRepository typrObj;


        public MultipleViewController()
        {
            prodObj = new ProductRepository();
            typrObj = new ProductTypeRepository();
        }

        // GET: MultipleViewController
        public ActionResult List()
        {
            var model = new ProductViewModel();
            model.Create = new ProductModel();
            model.Create.Type = typrObj.GetProductType();
            model.List = prodObj.SelectSP();
            string data = TempData["data"] as string;
            ViewBag.data = data;



            return View("view",model);
        }

        // GET: MultipleViewController/Details/5
        public ActionResult Details(int Productid)
        {
         var res=   prodObj.SelectProductById(Productid);
            return View("Details",res);
        }

        public ActionResult Create()
        {
            var model = new ProductModel();
            model.Type = typrObj.GetProductType();
            return View("_createpartial",model);
        }

        // POST: MultipleViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel  model)
        {
            try
            {
                model.Type = typrObj.GetProductType();
                prodObj.InsertProduct(model);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: MultipleViewController/Edit/5
        public ActionResult Edit(int Productid)
        {
            var res = prodObj.SelectProductById(Productid);

             res.Type = typrObj.GetProductType();
            return View("Edit",res);
        }

        // POST: MultipleViewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int Productid, ProductModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    prodObj.UpdateProduct(collection);
                    return RedirectToAction(nameof(List));

                }


            else
                {
                    return View("Edit", collection);
                } }
            catch
            {

                return View();
            }
        }

        // GET: MultipleViewController/Delete/5
        public ActionResult Delete(int Productid)
        {
          var res=  prodObj.SelectProductById(Productid);
            return View("Delete",res);
        }

        // POST: MultipleViewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int Productid)
        {
            try
            {
                prodObj.Deleteproduct(Productid);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
