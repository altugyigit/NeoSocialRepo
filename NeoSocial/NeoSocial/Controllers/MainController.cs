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
        PostBusiness _postBusiness;
        int _userId;
        //
        // GET: /Main/
        [Authorize]
        public ActionResult MainPage()
        {            
            _postBusiness = new PostBusiness();

            try
            {
               _userId = (int)Session["UserId"];
            }
            catch(Exception ex)
            {
            }
            ViewData["postDatabase"] = _postBusiness.getUserArticlePost(_userId);

            ViewData["pathImage"] = "/Content/Image/Icons/iconFamale3.jpg";

            return View();
        }
    }
}
