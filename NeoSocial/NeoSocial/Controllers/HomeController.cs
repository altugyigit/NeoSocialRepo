using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoSocial.Models;
using System.Web.Security;

namespace NeoSocial.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [_SessionControl]
        public ActionResult Index()
        {
            return View();
        }
    }
}
