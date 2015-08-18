using System;
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

        bool verifyUser(UserLogin _userLogin);
        void addUser(UserLogin _userLogin);
    
    }

  public  class LoginBusiness :ILoginBusiness
{

        UserContext _userContext;

        public LoginBusiness() 
        {
            _userContext = new UserContext(new DbContextFactory());
        }

        public   void addUser(UserLogin _userLogin)      
        {
            _userContext.UserLoginRepository.Create(_userLogin);
            _userContext.Commit();
        }

        public bool verifyUser(UserLogin _userLogin)
        {
            string _userNameText = _userLogin.UserName;
            string _userPasswordText = _userLogin.UserPassword;

            //Repository ile login bilgilerini kontrol et ve aynı zamanda şifre ve kullanıcı adının farklı olmasına dikkat et.
            if(_userContext.UserLoginRepository.Find(a => a.UserName == _userNameText) != null && !_userNameText.Equals(_userPasswordText))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
