using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoSocial.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        //
        // GET: /Login/
        [AllowAnonymous]
        public ActionResult Login()
        {
            if (String.IsNullOrEmpty(HttpContext.User.Identity.Name))
            {
                return View();
            }
            
            return Redirect("~/Home/Index");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

    }
}
