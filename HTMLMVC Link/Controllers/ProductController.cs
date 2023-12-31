﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 using ClassLibrary.Model;
using ClassLibrary.Repository;
using HTMLMVC_Link.Models;

namespace HTMLMVC_Link.Controllers
{
    public class ProductController : Controller
    {

        public ProductRepository _prodObj;
        public ProductTypeRepository _typrObj;
        public ProductController(ProductRepository prodobj, ProductTypeRepository typrObj)
        {
            /* prodObj = new ProductRepository();
             typrObj = new ProductTypeRepository();*/

            _prodObj = prodobj;
            _typrObj = typrObj;


        }
        // GET: ProductController
        public ActionResult List()

        {
            return View("ProductList", _prodObj.SelectSP());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int productid)
        {
            var result = _prodObj.SelectProductById(productid);
            return View("Details", result);
        }


        // GET: ProductController/Create
        public ActionResult Insert()
        {

            var model = new ProductModel();
            model.Type = _typrObj.GetProductType();

            return View("Insert", model);

        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(ProductModel storeData)
        
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_prodObj.IsExists(storeData.ProductName))
                    {
                        ModelState.AddModelError("ProductName", "Product Name Already exists");
                        storeData.Type = _typrObj.GetProductType();
                        return View("Insert", new ProductModel());
                    }

                    _prodObj.InsertProduct(storeData);
                    return RedirectToAction(nameof(List));
                }
                else
                {
                    storeData.Type = _typrObj.GetProductType();
                    return View("Insert", storeData);
                }

            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ErrorMessage = ex.Message });
            }

        }
        // GET: ProductController/Edit/5
        public ActionResult Edit(int Productid)
        {
            try
            {
               // if (ModelState.IsValid)
               // {
                    var result = _prodObj.SelectProductById(Productid);
                    result.Type = _typrObj.GetProductType();
                    return View("UpdateProduct", result);
              //  }
             //   else
             //   {
                    //  storeData.Type = typrObj.GetProductType();
                    return View("Insert");
               // }
            }
            catch (Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ErrorMessage = ex.Message });
            }
        }
            // POST: ProductController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(int Productid, ProductModel collection)
            {
               try
               {
                    if (ModelState.IsValid)
                    {

                        if (_prodObj.UpdateNameCheck(collection.ProductName, collection.Productid))
                        {
                        ModelState.AddModelError("ProductName", "Product Name Already exists");
                        collection.Type = _typrObj.GetProductType();
                        return View("Insert", collection);
                        }
                    
                    }
                     else

                        collection.Productid = Productid;
                        collection.Type = _typrObj.GetProductType();

                          _prodObj.UpdateProduct(collection);
                           return RedirectToAction(nameof(List));
               }
                catch (Exception ex)
                {
                    return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ErrorMessage = ex.Message });
                }
            }

            // GET: ProductController/Delete/5
            public ActionResult Delete(int productid)
            {
            try
            {
                var result = _prodObj.SelectProductById(productid);

                //return RedirectToAction(nameof(List));
                return View("Deleteproduct", result);
            }
            catch(Exception ex)
            {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ErrorMessage = ex.Message });
            }
        }

            // POST: ProductController/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Remove(int productid)
            {
                try
                {
                    _prodObj.Deleteproduct(productid);

                    return RedirectToAction(nameof(List));
                }
                catch (Exception ex)
                {
                return View("Error", new ErrorViewModel { CustomMessage = "Error in Product Edit feature", ErrorMessage = ex.Message });
            }
        }
        }
    } 
