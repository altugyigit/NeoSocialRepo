﻿using System;
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
            List<UserRegister> listUserRegister;

            DateTime dt = Convert.ToDateTime(model.register.BirthDate);
           
            model.register.BirthDate = dt.ToShortDateString();

            if (!_registerBusiness.checkUser(model.login))//Kullanıcı yoksa ekle.
            {
                _registerBusiness.addUser(model.register);

                listUserRegister = _registerBusiness.findID(model.register);
                model.login.UserRegisterID = listUserRegister[0].UserRegisterID;


                _loginBusiness.addUser(model.login);
                TempData["true"] ="kaydınız alınmıştır'" ;
                return Redirect("~/Views/User/Login");
            }

            else {
                TempData["false"] = "kullanıcı adı daha önceden alınmış ya da kullanıcı adınızla şifreniz aynı" ;
            
            }

            ViewData["country"] = _countryBusiness.getAllCountry();
            return View();
        }
       

    }
}
