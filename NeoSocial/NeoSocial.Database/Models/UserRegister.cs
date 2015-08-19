using System;
using System.Collections.Generic;

namespace NeoSocial.Database.Models
{
    public partial class UserRegister
    {
        public int UserRegisterID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public Nullable<short> Gender { get; set; }
        public Nullable<int> CountryID { get; set; }
        public Nullable<int> CityID { get; set; }
    }
}
