using JFSEPABlogPost.BusinessLayer.Interfaces;
using JFSEPABlogPost.BusinessLayer.ViewModel;
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
        /// <summary>
        /// Creating Referance object of IBlogPostRepository and Injecting in BlogPostServies Constructor
        /// </summary>
        private readonly IBlogPostRepository _blogPostRepository;

        public BlogPostServies(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        /// <summary>
        /// Add a new comment on blog post by calling Repository Commnet method
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comments"></param>
        /// <returns></returns>
        public async Task<Comments> Comments(int postId, Comments comments)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add a new Blog Post by calling Repository Create method
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns></returns>
        public async Task<BlogPost> Create(BlogPost blogPost)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all comment on blog post by calling Repository GetAllComments method
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Comments>> GetAllComments(int postId)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get all BlogPost by calling Repository GetAllPost method
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<BlogPost>> GetAllPost()
        {
            var result = _blogPostRepository.GetAllPost();
            return result;
        }
        /// <summary>
        /// get all Comments by calling Repository GetAllPostComment method
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CommentPostViewModel>> GetAllPostComment()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// get post by postId by calling Repository GetAllPostComment method
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<BlogPost> GetPostById(int postId)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
