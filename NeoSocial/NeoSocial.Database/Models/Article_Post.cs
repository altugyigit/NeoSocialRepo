using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSocial.Database.Models
{
   public partial class Article_Post
    {
        public int Post_ID { get; set; }
        public string Post_Header { get; set; }
        public string Post_Content { get; set; }
        public string Post_Date { get; set; }
        public int Post_Like_Count { get; set; }
        public int Post_Comment_ID { get; set; }
        public int Post_Owner_ID { get; set; }
    }
}
