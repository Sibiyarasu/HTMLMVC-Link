using ClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Model;

namespace HTMLMVC_Link.Controllers
{
    public class LoginController : Controller
    {
         
        public LoginController()
        {
        }


        // GET: LoginController
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

    
        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    //return Redirect("/Product/List");


                }
               return Redirect("/Product/List");
            }
            catch
            {
                return View();
            }
        }

      
    }
}
