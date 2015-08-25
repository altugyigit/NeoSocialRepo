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
    [Authorize]
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        CountryBusiness _countryBusiness;
        RegisterBusiness _registerBusiness;
        LoginBusiness _loginBusiness;
        ProfileBusiness _profileBusiness;


        [AllowAnonymous]
        public ActionResult Register() {
            _countryBusiness = new CountryBusiness();
            ViewData["country"] = _countryBusiness.getAllCountry();


            return View();
        
        
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(ViewModel model)
        {
            _countryBusiness = new CountryBusiness();
            _registerBusiness = new RegisterBusiness();
            _loginBusiness = new LoginBusiness();
            _profileBusiness = new ProfileBusiness();
            List<UserRegister> listUserRegister;
            List<UserLogin> listUserLogin;
            

            DateTime dt = Convert.ToDateTime(model.register.BirthDate);
           
            model.register.BirthDate = dt.ToShortDateString();

            if (!_registerBusiness.checkUser(model.login))//Kullanıcı yoksa ekle.
            {
                _registerBusiness.addUser(model.register);

                listUserRegister = _registerBusiness.findID(model.register);
                model.login.UserRegisterID = listUserRegister[0].UserRegisterID;


                _loginBusiness.addUser(model.login);

                listUserLogin = _loginBusiness.findUser(model.login);
            //    model.profile.UserID = listUserLogin[0].UserID;
           
            //model.profile.UserRegisterID = model.login.UserRegisterID;
            _profileBusiness.addProfile(model.profile);


                TempData["true"] ="kaydınız alınmıştır'" ;

                return Redirect("~/User/Login");
            }

            else {
                TempData["false"] = "kullanıcı adı daha önceden alınmış ya da kullanıcı adınızla şifreniz aynı" ;
            
            }

            ViewData["country"] = _countryBusiness.getAllCountry();
            return View();
        }
       

    }
}
