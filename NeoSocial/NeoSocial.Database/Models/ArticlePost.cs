using System;
using System.Collections.Generic;

namespace NeoSocial.Database.Models
{
    public partial class ArticlePost
    {
        public long PostID { get; set; }
        public string PostHeader { get; set; }
        public string PostContent { get; set; }
        public string PostDate { get; set; }
        public Nullable<int> PostLikeCount { get; set; }
        public Nullable<int> PostCommentID { get; set; }
        public Nullable<int> PostOwnerID { get; set; }
    }
}
