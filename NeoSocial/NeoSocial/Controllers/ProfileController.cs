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
        [HttpGet]
        public ActionResult PartialShareArticle()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult PartialShareArticle(ViewModel model)
        {
            _postBusiness = new PostBusiness();

            string currentDate = DateTime.Today.ToShortDateString();
            model.article.PostDate = currentDate;

            model.article.PostOwnerID = (int)Session["UserId"];

            model.article.PostLikeCount = -1;
            model.article.PostCommentID = -1;

            if (_postBusiness.insertArticlePost(model.article))
            {
                return Redirect("~/Profile/Profile");
            }
            else
            {
                Response.Write("HATA !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                return Redirect("~/Profile/Profile");
            }
            
        }
    }
}
