using System;
using System.Collections.Generic;

namespace NeoSocial.Database.Models
{
    public partial class UserProfile
    {
        public int UserProfileID { get; set; }
        public Nullable<int> UserRegisterID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> IconID { get; set; }
    }
}
