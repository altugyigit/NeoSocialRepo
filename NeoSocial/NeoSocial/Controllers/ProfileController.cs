using NeoSocial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoSocial.Business;

namespace NeoSocial.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        PostBusiness _postBusiness;
        //
        // GET: /Profile/
        [Authorize]
        public ActionResult Profile()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult PartialShareArticle(ViewModel model)
        {
            _postBusiness = new PostBusiness();
            _postBusiness.insertArticlePost(model.article);

            return Redirect("~/Profile/Profile");
        }
    }
}
