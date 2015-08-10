using System;
using System.Collections.Generic;

namespace NeoSocial.Database.Models
{
    public partial class UserLogin
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserRegisterID { get; set; }
    }
}
