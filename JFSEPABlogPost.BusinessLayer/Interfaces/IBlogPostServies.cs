using JFSEPABlogPost.BusinessLayer.ViewModel;
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
        Task<BlogPost> Create(BlogPost blogPost);
        Task<BlogPost> GetPostById(int postId);
        Task<IEnumerable<BlogPost>> GetAllPost();
        Task<IEnumerable<Comments>> GetAllComments(int postId);
        Task<Comments> Comments(int postId, Comments comments);
        Task<IEnumerable<CommentPostViewModel>> GetAllPostComment();
    }
}
