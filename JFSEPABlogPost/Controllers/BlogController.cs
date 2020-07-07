using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JFSEPABlogPost.Models;
using JFSEPABlogPost.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JFSEPABlogPost.Controllers
{
    public class BlogController : Controller
    {
        //Creating field or referance of IBlogPostRepository
        private readonly IBlogPostRepository _blogPostRepository;

        /// <summary>
        /// Injecting IBlogPostRepository referance in Controller constructor
        /// </summary>
        /// <param name="blogPostRepository"></param>
        public BlogController(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        /// <summary>
        /// Show all Post on index page after page load
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            IEnumerable<BlogPost> blogPosts = await _blogPostRepository.GetAllPost();
            return View(blogPosts);
        }
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Create new post and store in InMemoryDb
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,PostedDate")]BlogPost blogPost)
        {
            //do code here
            return View();
        }
        public IActionResult Comments()
        {
            return View();
        }
        /// <summary>
        /// Create new comment on Post
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comments"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Comments(int postId, Comments comments)
        {
            //do code here
            return View();
        }
        /// <summary>
        /// Get All comments belongs to a post by postid
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<IActionResult> BlogComments(int? postId)
        {
            //do code here
            return View();
        }
    }
}