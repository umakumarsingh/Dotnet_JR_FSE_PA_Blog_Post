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
        //Creating field or object of dbcontext
        private readonly BlogPostDbContext _blogPostDbContext;

        /// <summary>
        /// Injecting DbContext in constructor
        /// </summary>
        /// <param name="blogPostDbContext"></param>
        public BlogPostRepository(BlogPostDbContext blogPostDbContext)
        {
            _blogPostDbContext = blogPostDbContext;
        }

        /// <summary>
        /// Add new Commnet on BlogPosst and store inMemoryDb
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comments"></param>
        /// <returns>Comment object if create Comments show list</returns>
        public Task<bool> Comments(int postId, Comments comments)
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add new BlogPost and store in inMemory
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns>create new blogpost and return boolean</returns>
        public async Task<bool> Create(BlogPost blogPost)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get a BlogPost by post Id fron InMemoryDb and show
        /// </summary>
        /// <param name="postId"></param>
        /// <returns>a blog</returns>
        public BlogPost GetPostById(int postId)
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All List of Post
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BlogPost>> GetAllPost()
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all Comments by PostId
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Comments>> GetAllComments(int postId)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
