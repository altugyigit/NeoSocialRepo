using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoSocial.Database.Models;
using NeoSocial.Database.Repository;
using NeoSocial.Database.IUnitOfWork;
using NeoSocial.Business;

namespace NeoSocial.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        RegisterBusiness b = new RegisterBusiness();
        

        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateUser(UserRegister model)
        {
            if (model.UserRegisterID == 0)
            {
                b.InsertUser(model);
              
            }
            else
            {
               
                
            }

            if (model.UserRegisterID > 0)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
