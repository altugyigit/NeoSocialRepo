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
    
   
    
    }


  public  class RegisterBusiness : IRegisterBusiness
    {
      UserContext _userContext;
     

      public RegisterBusiness() {

          _userContext = new UserContext(new DbContextFactory());

      }
      


          public void AddUser(UserRegister register) {
          
         _userContext.UserRegisterRepository.Create(register);
          
          
          
          }
      
      }

    }
