﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSocial.Database.Models;
using NeoSocial.Database.Repository;
using NeoSocial.Database.IUnitOfWork;
using NeoSocial.Business;


namespace NeoSocial.Business
{
    interface ILoginBusiness {

        int verifyUser(UserLogin userLogin);
        void addUser(UserLogin userLogin);
       List<UserLogin> findUser(UserLogin userLogin);
    
    }

  public  class LoginBusiness :ILoginBusiness
{

        UserContext _userContext;

        public LoginBusiness() 
        {
            _userContext = new UserContext(new DbContextFactory());
        }

        public   void addUser(UserLogin userLogin)      
        {
            _userContext.UserLoginRepository.Create(userLogin);
            _userContext.Commit();
        }

        public int verifyUser(UserLogin userLogin)
        {
            string _userNameText = userLogin.UserName;
            string _userPasswordText = userLogin.UserPassword;

            var resultVerify = _userContext.UserLoginRepository.Find(a => a.UserName == _userNameText && a.UserPassword == _userPasswordText);

            //Repository ile login bilgilerini kontrol et ve aynı zamanda şifre ve kullanıcı adının farklı olmasına dikkat et.
            if( resultVerify != null && !_userNameText.Equals(_userPasswordText))
            {
                return resultVerify.UserID;
            }
            else
            {
                return -1;
            }
        }

     public   List<UserLogin> findUser(UserLogin userLogin) {

            List<UserLogin> login = new List<UserLogin>();
            string username = userLogin.UserName;

        login=    _userContext.UserLoginRepository.Get().Where(x => x.UserName == username).ToList();

        return login;
        
        }

    }
}
