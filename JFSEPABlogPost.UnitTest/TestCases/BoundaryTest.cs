using JFSEPABlogPost.BusinessLayer.Interfaces;
using JFSEPABlogPost.BusinessLayer.Services;
using JFSEPABlogPost.Controllers;
using JFSEPABlogPost.Models;
using JFSEPABlogPost.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JFSEPABlogPost.UnitTest.TestCases
{
    public class BoundaryTest
    {
        ///// <summary>
        ///// Creating Referance of all Service Interfaces and Mocking All Repository
        ///// </summary>
        private readonly IBlogPostServies _blogPostServMock;
        public readonly Mock<IBlogPostRepository> service = new Mock<IBlogPostRepository>();
        private BlogPost _post;
        private Comments _commnet;
        public BoundaryTest()
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
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static BoundaryTest()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Test Post Id is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_ValidatePostID()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.Create(_post)).ReturnsAsync(_post);
            var result = await _blogPostServMock.Create(_post);

            if (result.PostID >= 1 && result.PostID <= 350000)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestFor_ValidatePostID=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Test Comment Id Is valid or not
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_ValidateCommentId()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.Comments(_commnet.PostID,_commnet)).ReturnsAsync(_commnet);
            var result = await _blogPostServMock.Comments(_commnet.PostID, _commnet);

            if (result.CommId >= 1 && result.CommId <= 350000)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestFor_ValidateCommentId=" + res + "\n");
            return res;
        }
    }
}
