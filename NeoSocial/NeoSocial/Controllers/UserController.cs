using NeoSocial.Business;
using NeoSocial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using NeoSocial.Models;

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

                return Redirect("~/Home/Index");
            }
            else
            {
                ModelState.AddModelError( "", "Kullanıcı Adı yada Parola Hatalı !");
            }
            return View(viewModel);
            
        }

        [_SessionControl]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "User");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

    }
}
