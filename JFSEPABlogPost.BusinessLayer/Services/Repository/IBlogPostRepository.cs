using JFSEPABlogPost.BusinessLayer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFSEPABlogPost.Models.Interfaces
{
    public interface IBlogPostRepository
    {
        Task<BlogPost> Create(BlogPost blogPost);
        Task<BlogPost> GetPostById(int postId);
        Task<IEnumerable<BlogPost>> GetAllPost();
        Task<IEnumerable<Comments>> GetAllComments(int postId);
        Task<Comments> Comments(int postId, Comments comments);
        Task<ICollection<CommentPostViewModel>> GetAllPostComment();
        Task<ICollection<CommentPostViewModel>> GetAllPostCommentById(int postId);
    }
}
