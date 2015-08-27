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
        int _userId;

        //
        // GET: /Profile/
        [Authorize]
        public ActionResult Profile()
        {
            int _userId = -1;
            
            PostBusiness _postBusiness = new PostBusiness();

            try
            {
                _userId = (int)Session["UserId"];

                ViewData["pathImage"] = "/Content/Image/Icons/iconFamale3.gif";
                ViewData["postDatabase"] = _postBusiness.getUserArticlePost(_userId);
            }
            catch(Exception ex)
            {
            }
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

            model.article.PostLikeCount = 0;
            model.article.PostCommentID = 0;

            _postBusiness.insertArticlePost(model.article);

            return Redirect("~/Profile/Profile");
            
        }

        public ActionResult Icon() {


            return View();
        }

    }
}
