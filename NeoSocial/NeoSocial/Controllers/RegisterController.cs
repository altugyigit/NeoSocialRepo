using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoSocial.Database.Models;
using NeoSocial.Database.Repository;
using NeoSocial.Database.IUnitOfWork;
using NeoSocial.Business;
using NeoSocial.ViewModels;


namespace NeoSocial.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
      
        

        public ActionResult Register()
        {
            return View();
        }


       

    }
}
