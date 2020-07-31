using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JFSEPABlogPost.BusinessLayer.Interfaces;
using JFSEPABlogPost.Models;
using JFSEPABlogPost.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JFSEPABlogPost.Controllers
{
    public class BlogController : Controller
    {
        /// <summary>
        /// Creating referance of IBlogPostServies and injecting in Controller constructoe
        /// </summary>
        private readonly IBlogPostServies _blogPostServ;

        public BlogController(IBlogPostServies blogPostServ)
        {
            _blogPostServ = blogPostServ;
        }
        /// <summary>
        /// Get all post and show on Index page 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            IEnumerable<BlogPost> blogPosts = await _blogPostServ.GetAllPost();
            return View(blogPosts);
        }
        /// <summary>
        /// Create new blog post
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// Create new blogPost http post method
        /// </summary>
        /// <param name="blogPost"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,PostedDate")]BlogPost blogPost)
        {
            //Do code here
            return View();
        }
        /// <summary>
        /// Create new Comment on BlogPost
        /// </summary>
        /// <returns></returns>
        public IActionResult Comments()
        {
            return View();
        }
        /// <summary>
        /// Create new Comment on BlogPost
        /// </summary>
        /// <param name="postId"></param>
        /// <param name="comments"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Comments(int postId, Comments comments)
        {
            //Do code here
            return View();
        }
        /// <summary>
        /// get Comment on BlogPost by PostId
        /// </summary>
        /// <param name="postId"></param>
        /// <returns></returns>
        public async Task<IActionResult> BlogComments(int? postId)
        {
            //Do code here
            return View();
        }
        /// <summary>
        /// Get all Comment
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> PostBlogComments()
        {
            //Do code here
            return View();
        }

    }
}