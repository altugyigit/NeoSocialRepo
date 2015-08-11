using System;
using System.Collections.Generic;

namespace NeoSocial.Models
{
    public class ArticlePostWeb
    {
        public int PostID { get; set; }
        public string PostHeader { get; set; }
        public string PostContent { get; set; }
        public string PostDate { get; set; }
        public int PostOwnerID { get; set; }
        public int PostLikeCount { get; set; }
        public int PostCommentID { get; set; }
    }
}
