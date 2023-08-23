using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using ClassLibrary.Model;
using ClassLibrary.Repository;

namespace HTMLMVC_Link.Controllers
{
    public class ProductController : Controller
    {
         public ProductRepository obj1;
        public ProductTypeRepository obj2;
        public ProductController()
        {
            obj1 = new ProductRepository();
            obj2 = new ProductTypeRepository();
        }
        // GET: ProductController
        public ActionResult List()

        {
            return View("ProductList", obj1.SelectSP());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Insert()
        {

            var model = new ProductModel();
            model.ProductType = obj2.GetProductType();
            return View("Insert", model);
           
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductModel StoreData)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    obj1.InsertProduct(StoreData);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    return View("Insert", new ProductModel());

                }
              /*  obj1.InsertProduct(StoreData);
                return RedirectToAction(nameof(List));*/
            }
            catch
            {
                return View();
            }
          

        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int Productid)
        {
            var result = obj1.SelectProductById(Productid);
            return View("UpdateProduct", result);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int Productid, ProductModel collection)
        {
            try
            {
                collection.Productid = Productid;
                obj1.UpdateProduct(collection);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int productid)
        {

            var result = obj1.Deleteproduct(productid);

            return RedirectToAction(nameof(List));
            return View("Deleteproduct",result);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int productid)
        {
            try
            {
                obj1.Deleteproduct(productid);

                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
