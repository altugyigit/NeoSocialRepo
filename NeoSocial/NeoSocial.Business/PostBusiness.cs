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
        bool insertArticlePost(ArticlePost articlePost);
        List<ArticlePost> getAllArticlePost();
        List<ArticlePost> getUserArticlePost(int ownerUserId);
    }
    public class PostBusiness : IPostBusiness
    {
        PostContext _postContext;
        List<ArticlePost> _articlePostList;

        public PostBusiness()
        {

            _postContext = new PostContext(new DbContextFactory());   

        }

        public bool insertArticlePost(ArticlePost articlePost)
        {
            try
            {
                _postContext.ArticlePostRepository.Create(articlePost);
                _postContext.Commit();

                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }

            
        }

        public List<ArticlePost> getAllArticlePost()
        {
            _articlePostList = _postContext.ArticlePostRepository.Get().OrderByDescending(x => x.PostID).ToList();
             return _articlePostList;
        }

        public List<ArticlePost> getUserArticlePost(int ownerUserId)
        {
            _articlePostList = _postContext.ArticlePostRepository.Filter(a => a.PostOwnerID == ownerUserId).OrderByDescending(x => x.PostID).ToList();

            return _articlePostList;
        }
    }
}
