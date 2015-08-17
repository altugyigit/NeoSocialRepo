using NeoSocial.Business;
using NeoSocial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NeoSocial.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        LoginBusiness _loginBusiness;

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
            {
                FormsAuthentication.SignOut();
                return View();
            }
            
            return Redirect("~/Home/Index");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginModel  )
        {
            _loginBusiness = new LoginBusiness();


            return View();
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

    }
}
