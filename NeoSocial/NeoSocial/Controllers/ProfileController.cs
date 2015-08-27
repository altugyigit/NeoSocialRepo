using NeoSocial.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NeoSocial.Business;
using NeoSocial.Database.Models;
namespace NeoSocial.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        PostBusiness _postBusiness;
        IconBusiness _iconBusiness;
        ProfileBusiness _profileBusiness;
        LoginBusiness _loginBusiness;
        int _userId;
        int _iconId;

        //
        // GET: /Profile/
        [Authorize]
        public ActionResult Profile()
        {
             _userId = -1;
            
            _postBusiness = new PostBusiness();
            _iconBusiness = new IconBusiness();
            _profileBusiness = new ProfileBusiness();

            try
            {
                _userId = (int)Session["UserId"];
                _iconId = (int)_profileBusiness.getProfileInfo(_userId).IconID;

                ViewData["pathImage"] = _iconBusiness.getIconUrl(_iconId);
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

        [HttpGet]
        public ActionResult Icon() {

            return View();
        
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Icon(ViewModel model)
        {
              int userId = (int)Session["UserId"];
            _profileBusiness = new ProfileBusiness();
            UserProfile profile = new UserProfile();
            _loginBusiness = new LoginBusiness();
            
            profile = _profileBusiness.getProfileInfo(userId);

            profile.IconID = model.profile.IconID;
            

            _profileBusiness.updateIcon(profile);
           
            return View();
        }
    }
}
