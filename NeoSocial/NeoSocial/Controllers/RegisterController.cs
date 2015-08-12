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

        RegisterBusiness _registerBusiness;
        UserRegister _userRegister;

        public ActionResult Register()
        {
            _registerBusiness = new RegisterBusiness();
            _userRegister = new UserRegister();
            
            _userRegister.UserID = 0;
            _userRegister.UserRegisterID = 0;
            _userRegister.CityID = 0;
            _userRegister.CountryID = 0;
            _userRegister.BirthDate = "29/06/2015";
            _userRegister.Email = "altug@neosinerji.com";
            _userRegister.Gender = 1;
            _userRegister.Name = "Altuğ";
            _userRegister.Surname = "YİĞİT";
            
            _registerBusiness.addUser(_userRegister);
            return View();
        }
       

    }
}
