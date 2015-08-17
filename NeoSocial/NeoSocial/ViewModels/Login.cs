using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NeoSocial.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "Kullanıcı Adı Girilmesi Zorunludur !")]
        [Display(Name = "Kullanıcı Adı")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Şifre Girilmesi Zorunludur !")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string userPassword { get; set; }

    }
}