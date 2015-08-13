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

        void addUser(UserLogin _userLogin);
    
    }



  public  class LoginBusiness :ILoginBusiness
{

 UserContext _userContext;

 public LoginBusiness() {

     _userContext = new UserContext(new DbContextFactory());
 
 
 }

   public   void addUser(UserLogin _userLogin)
      
     {
         _userContext.UserLoginRepository.Create(_userLogin);
         _userContext.Commit();
      
      
      }


    }
}
