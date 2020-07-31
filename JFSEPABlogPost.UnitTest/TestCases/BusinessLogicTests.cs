using JFSEPABlogPost.BusinessLayer.Interfaces;
using JFSEPABlogPost.BusinessLayer.Services;
using JFSEPABlogPost.Controllers;
using JFSEPABlogPost.Models;
using JFSEPABlogPost.Models.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JFSEPABlogPost.UnitTest.TestCases
{
    public class BusinessLogicTests
    {
        ///// <summary>
        ///// Creating Referance of all Service Interfaces and Mocking All Repository
        ///// </summary>
        private readonly IBlogPostServies _blogPostServMock;
        public readonly Mock<IBlogPostRepository> service = new Mock<IBlogPostRepository>();
        private BlogPost _post;
        private Comments _commnet;
        public BusinessLogicTests()
        {
            _blogPostServMock = new BlogPostServies(service.Object);
            _post = new BlogPost()
            {
                PostID = 10,
                Title = "Blog-Post-1",
                Description = "Blog-Post-1-Description",
                PostedDate = DateTime.Now
            };
            _commnet = new Comments()
            {
                CommId = 10,
                CommentMsg = "Blog-Post-1-Commnet",
                CommentedDate = DateTime.Now,
                PostID = 1
            };
        }
        static BusinessLogicTests()
        {
            if (!File.Exists("../../../../output_business_revised.txt"))
                try
                {
                    File.Create("../../../../output_business_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_business_revised.txt");
                File.Create("../../../../output_business_revised.txt").Dispose();
            }
        }
        
    }
}
