using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NeoSocial.Database.Models;
using NeoSocial.Database.Repository;
using NeoSocial.Database.IUnitOfWork;
using NeoSocial.Business;

namespace NeoSocial.ViewModels
{
    public class Register
    {
        public UserRegister register { get; set; }
        public UserLogin login { get; set; }
        public Country country { get; set; }
        public TurkeyCity city { get; set; }


    }
}