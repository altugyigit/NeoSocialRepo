using NeoSocial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoSocial.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public CommonPost articlePost = new CommonPost();

        public ActionResult MainPage()
        {
            List<CommonPost> postList = new List<CommonPost>();

            postList.Add(new CommonPost() { PostID = 0, PostHeader="Güzel bir gün.", PostContent="Bugün çok mutluyum. :)", PostDate="10/08/2015", PostCommentID=0, PostLikeCount=0});
            postList.Add(new CommonPost() { PostID = 0, PostHeader = "Berbat bir gün.", PostContent = "Allah kahretsin.", PostDate = "10/08/2015", PostCommentID = 0, PostLikeCount = 0 });
            postList.Add(new CommonPost() { PostID = 0, PostHeader = "Hava güzel olunca", PostContent = "Hava güzel olunca piknik kaçmaz. :)", PostDate = "10/08/2015", PostCommentID = 0, PostLikeCount = 0 });

            ViewData["postList"] = postList;

            return View();
        }

    }
}
