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
    interface IRegisterBusiness {

        //List<UserRegister> getAllUsers();
        void addUser(UserRegister userRegister);
        bool checkUser(UserLogin userLogin);
        List<UserRegister> findID(UserRegister userRegister);
    
    }


  public  class RegisterBusiness : IRegisterBusiness
    {
      UserContext _userContext;
      List<UserRegister> listUserRegister;

      public RegisterBusiness()
      {
          _userContext = new UserContext(new DbContextFactory());
      }

      //public List<UserRegister> getAllUsers();

      public void addUser(UserRegister userRegister)
      {

          _userContext.UserRegisterRepository.Create(userRegister);
          _userContext.Commit();

      }

      public bool checkUser(UserLogin userLogin) {

          string _userNameText = userLogin.UserName;
          string _userPasswordText = userLogin.UserPassword;

          if (_userContext.UserLoginRepository.Find(a => a.UserName == _userNameText) != null && !_userNameText.Equals(_userPasswordText))
          {
              return true;
          }
          else
          {
              return false;
          }
      
      
      }

      public List<UserRegister> findID(UserRegister userRegister) {

          string mail=userRegister.Email;

        listUserRegister=  _userContext.UserRegisterRepository.Get().Where(x => x.Email == mail).ToList();

        return listUserRegister;
      
      }

    }

}
