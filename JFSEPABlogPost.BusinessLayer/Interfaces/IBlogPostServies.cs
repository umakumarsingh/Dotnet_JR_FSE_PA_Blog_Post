using JFSEPABlogPost.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JFSEPABlogPost.BusinessLayer.Interfaces
{
    public interface IBlogPostServies
    {
        //List of method to perform all related operation
        Task<bool> Create(BlogPost blogPost);
        BlogPost GetPostById(int postId);
        Task<IEnumerable<BlogPost>> GetAllPost();
        Task<IEnumerable<Comments>> GetAllComments(int postId);
        Task<bool> Comments(int postId, Comments comments);
    }
}
