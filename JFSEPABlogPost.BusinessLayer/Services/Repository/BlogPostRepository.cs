using JFSEPABlogPost.BusinessLayer.ViewModel;
using JFSEPABlogPost.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JFSEPABlogPost.Models
{
    public class BlogPostRepository : IBlogPostRepository
    {
        /// <summary>
        /// Creating Referance object of DbContext and Injecting in Repository Constructor
        /// </summary>
        private readonly BlogPostDbContext _blogPostDbContext;
        public BlogPostRepository(BlogPostDbContext blogPostDbContext)
        {
            _blogPostDbContext = blogPostDbContext;
        }
        /// <summary>
        /// Add a new comment on blog post.
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comments"></param>
        /// <returns></returns>
        public async Task<Comments> Comments(int postId, Comments comments)
        {
            if(comments.PostID == postId)
            {
                _blogPostDbContext.CommentsMsg.Add(comments);
            }
             await _blogPostDbContext.SaveChangesAsync();
            return comments;
        }
        /// <summary>
        /// Create New Blog Post
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns></returns>
        public async Task<BlogPost> Create(BlogPost blogPost)
        {
            //var success = false;

            _blogPostDbContext.BlogPosts.Add(blogPost);

            var numberOfItemsCreated = await _blogPostDbContext.SaveChangesAsync();

            //if (numberOfItemsCreated == 1)
            //    success = true;

            return blogPost;
        }
        /// <summary>
        /// Get Post By Id passed by user
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<BlogPost> GetPostById(int postId)
        {
            var result = await _blogPostDbContext.BlogPosts
                                 .Where(x => x.PostID == postId)
                                 .FirstOrDefaultAsync();
            return result;
        }
        /// <summary>
        /// Get all post from InMemoryDb
        /// </summary>
        /// <returns>All Blog Post as a List</returns>
        public async Task<IEnumerable<BlogPost>> GetAllPost()
        {
            var user = await _blogPostDbContext.BlogPosts.
                OrderByDescending(x => x.PostedDate).ToListAsync();
            return user;
        }
        /// <summary>
        /// Get All Commments from InMemoryDb
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Comments>> GetAllComments(int postId)
        {
            var allcomments = await _blogPostDbContext.CommentsMsg.OrderByDescending(x => x.CommentedDate)
                .Where(c => c.PostID == postId).ToListAsync();
            return allcomments;
        }
        /// <summary>
        /// Get All Commnet 
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<CommentPostViewModel>> GetAllPostComment()
        {
            var viewModels = (from e in _blogPostDbContext.BlogPosts
                select new CommentPostViewModel
                {
                    BlogPost = e,
                    Comments = e.Comments,
                }).ToListAsync();
            return await viewModels;
        }
        /// <summary>
        /// Get All Commnet based on PostId
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<ICollection<CommentPostViewModel>> GetAllPostCommentById(int postId)
        {
            var viewModels = (from e in _blogPostDbContext.BlogPosts.Where(p => p.PostID == postId)
                              select new CommentPostViewModel
                              {
                                  BlogPost = e,
                                  Comments = e.Comments,
                              }).ToListAsync();
            return await viewModels;
        }
    }
}
