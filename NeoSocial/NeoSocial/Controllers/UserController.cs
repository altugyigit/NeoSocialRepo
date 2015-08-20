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

            return Redirect("~/Main/MainPage");
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(ViewModel viewModel)
        {
            _loginBusiness = new LoginBusiness();

            string _userName = viewModel.login.UserName.ToString();
            string _userPassword = viewModel.login.UserPassword.ToString();

            if (ModelState.IsValid && _loginBusiness.verifyUser(viewModel.login))
            {
                FormsAuthentication.SetAuthCookie(_userName, true);
                Session["UserName"] = _userName;
                Session["Password"] = _userPassword;

                return Redirect("~/Main/MainPage");
            }
            else
            {
                ModelState.AddModelError( "", "Kullanıcı Adı yada Parola Hatalı !");
            }
            return View(viewModel);
            
        }

        [Authorize]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }

        [Authorize]
        public ActionResult ForgotPassword()
        {
            return View();
        }

    }
}
