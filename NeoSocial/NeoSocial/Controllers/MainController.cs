using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoSocial.Business;
using System.IO;
using System.Web.Security;
namespace NeoSocial.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        //
        // GET: /Main/
        [Authorize]
        public ActionResult MainPage()
        {            
            PostBusiness _postBusiness = new PostBusiness();
            ViewData["postDatabase"] = _postBusiness.getAllArticlePost();

            ViewData["pathImage"] = "/Content/Image/Icons/iconFamale3.jpg";

            return View();
        }
    }
}
