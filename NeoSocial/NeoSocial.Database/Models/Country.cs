using System;
using System.Collections.Generic;

namespace NeoSocial.Database.Models
{
    public partial class Country
    {
        public int CountryID { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}
