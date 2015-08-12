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
    
    }


  public  class RegisterBusiness : IRegisterBusiness
    {
      UserContext _userContext;

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
    }

}
