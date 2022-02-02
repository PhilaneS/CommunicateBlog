using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communicate.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string PostContents { get; set; }
        public List<PostTag> PostTags { get; set; }
        public List<PostCategory> PostCategories { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
