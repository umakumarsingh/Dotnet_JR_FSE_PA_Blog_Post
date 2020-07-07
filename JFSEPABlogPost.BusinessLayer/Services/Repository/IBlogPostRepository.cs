using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFSEPABlogPost.Models.Interfaces
{
    public interface IBlogPostRepository
    {
        Task<bool> Create(BlogPost blogPost);
        BlogPost GetPostById(int postId);
        Task<IEnumerable<BlogPost>> GetAllPost();
        Task<IEnumerable<Comments>> GetAllComments(int postId);
        Task<bool> Comments(int postId, Comments comments);
    }
}
