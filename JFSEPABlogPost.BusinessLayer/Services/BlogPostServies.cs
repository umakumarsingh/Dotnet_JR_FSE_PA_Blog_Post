using JFSEPABlogPost.BusinessLayer.Interfaces;
using JFSEPABlogPost.Models;
using JFSEPABlogPost.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JFSEPABlogPost.BusinessLayer.Services
{
    public class BlogPostServies : IBlogPostServies
    {
        //Creating field or referance of IBlogPostRepository
        private readonly IBlogPostRepository _blogPostRepository;

        /// <summary>
        /// Injecting IBlogPostRepository referance in constructor
        /// </summary>
        /// <param name="blogPostDbContext"></param>
        public BlogPostServies(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        /// <summary>
        /// Add new Commnet on BlogPosst and store inMemoryDb
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comments"></param>
        /// <returns>Comment object if create Comments show list</returns>
        public Task<bool> Comments(int postId, Comments comments)
        {
            var result = _blogPostRepository.Comments(postId, comments);
            return result;
        }

        /// <summary>
        /// Add new BlogPost and store in inMemory
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns>create new blogpost and return boolean</returns>
        public Task<bool> Create(BlogPost blogPost)
        {
            var result = _blogPostRepository.Create(blogPost);
            return result;
        }

        /// <summary>
        /// Get a BlogPost by post Id fron InMemoryDb and show
        /// </summary>
        /// <param name="postId"></param>
        /// <returns>a blog</returns>
        public Task<IEnumerable<Comments>> GetAllComments(int postId)
        {
            var result = _blogPostRepository.GetAllComments(postId);

            return result;
        }
        /// <summary>
        /// Get All List of Post
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<BlogPost>> GetAllPost()
        {
            var result = _blogPostRepository.GetAllPost();
            return result;
        }
        /// <summary>
        /// Get all Comments by PostId
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public BlogPost GetPostById(int postId)
        {
            var result = _blogPostRepository.GetPostById(postId);
            return result;
        }
    }
}
