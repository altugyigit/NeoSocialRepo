using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSocial.Database.Models
{
   public partial class ArticlePost


    {

       public ArticlePost() {

           this.Post_Like_Count = 0;
   
   
   }



        public int PostID { get; set; }
        public string PostHeader { get; set; }
        public string PostContent { get; set; }
        public string PostDate { get; set; }
        public int PostLikeCount { get; set; }
        public int PostCommentID { get; set; }
        public int PostOwnerID { get; set; }
    }
}
