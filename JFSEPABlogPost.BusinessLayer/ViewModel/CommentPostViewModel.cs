using JFSEPABlogPost.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JFSEPABlogPost.BusinessLayer.ViewModel
{
    public class CommentPostViewModel
    {
        public BlogPost BlogPost { get; set; }
        public IEnumerable<Comments> Comments { get; set; }
    }
}
