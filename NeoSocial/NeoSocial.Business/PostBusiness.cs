using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoSocial.Database.Models;
using NeoSocial.Database.Repository;
using NeoSocial.Database.IUnitOfWork;

namespace NeoSocial.Business
{
    interface IPostBusiness
    {
        List<ArticlePost> getAllArticlePost();
        List<ArticlePost> getUserArticlePost();
    }
    public class PostBusiness : IPostBusiness
    {
        PostContext _postContext;
        List<ArticlePost> _articlePostList;

        public PostBusiness()
        {

            _postContext = new PostContext(new DbContextFactory());   

        }
        public List<ArticlePost> getAllArticlePost()
        {
            _articlePostList = _postContext.ArticlePostRepository.Get().OrderByDescending(x => x.PostID).ToList();
             return _articlePostList;
        }
        public List<ArticlePost> getUserArticlePost()
        {
            List<ArticlePost> _articlePostList = new List<ArticlePost>();

            _articlePostList.Add(new ArticlePost());

            return _articlePostList;
        }
    }
}
