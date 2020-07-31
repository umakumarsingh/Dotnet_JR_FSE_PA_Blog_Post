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
    public class ExceptionalTest
    {
        ///// <summary>
        ///// Creating Referance of all Service Interfaces and Mocking All Repository
        ///// </summary>
        private readonly IBlogPostServies _blogPostServMock;
        public readonly Mock<IBlogPostRepository> service = new Mock<IBlogPostRepository>();
        private Mock<IBlogPostServies> blogPostServMock;
        private readonly BlogController blogController;
        private BlogPost _post;
        private Comments _commnet;
        public ExceptionalTest()
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
                PostID = 10
            };
            blogPostServMock = new Mock<IBlogPostServies>();
            blogController = new BlogController(blogPostServMock.Object);
        }
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTest()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }
        /// <summary>
        /// Return Not Found when comment is not exists
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CommentTest_ReturnsNotFound_WhenCommentDoesNotExist()
        {
            // Arrange
            var res = false;
            var postId = 12;
            blogPostServMock.Setup(repo => repo.GetAllComments(postId)).
                Returns(Task.FromResult<IEnumerable<Comments>>(null));

            // Act
            var result = await blogController.BlogComments(postId);
            
            // Assert
            var viewResult = Assert.IsType<NotFoundResult>(result);

            if (viewResult != null)
                res = true;
            File.AppendAllText("../../../../output_exception_revised.txt",
                "CommentTest_ReturnsNotFound_WhenCommentDoesNotExist="
                + res.ToString() + "\n");

        }
        /// <summary>
        /// Create a Blog Post if Model State is Invalid return on create post view
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task CreateTest_Post_ReturnsCreateView_WhenModelStateIsInvalid()
        {
            // Arrange
            var res = false;
            var objectsBlogPost = new BlogPost { Title = "mock article 1", Description = "Hi", PostedDate = DateTime.Now };

           blogController.ModelState.AddModelError("Description", "This field is required");

            // Act
            var result = await blogController.Create(objectsBlogPost);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.Equal(objectsBlogPost, viewResult.ViewData.Model);
            blogPostServMock.Verify(repo => repo.Create(objectsBlogPost), Times.Never());
            if (viewResult == Assert.IsType<ViewResult>(result))
                res = true;
            File.AppendAllText("../../../../output_exception_revised.txt",
                "CreateTest_Post_ReturnsCreateView_WhenModelStateIsInvalid="
                + res.ToString() + "\n");
        }
        /// <summary>
        /// Test for create new Post
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_CreateNewBlogPost()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.Create(_post)).ReturnsAsync(_post);
            var result = await _blogPostServMock.Create(_post);
            if(_post == result)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFor_CreateNewBlogPost=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Create new Commnet on blog post
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_CreateNew_CommentonPost()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.Comments(_post.PostID, _commnet)).ReturnsAsync(_commnet);
            var result = await _blogPostServMock.Comments(_post.PostID, _commnet);
            if (_commnet == result)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFor_CreateNew_CommentonPost=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get All Blog Post form the InMemoryDb
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_GetAll_BlogPost()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.GetAllPost());
            var result = await _blogPostServMock.GetAllPost();
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFor_GetAll_BlogPost=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get All Commnet Based on PostId
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_GetAll_BlogPost_Comment()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.GetAllComments(_post.PostID));
            var result = await _blogPostServMock.GetAllComments(_post.PostID);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFor_GetAll_BlogPost_Comment=" + res + "\n");
            return res;
        }
        /// <summary>
        /// Get a blogPost By PostId
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestFor_Get_BlogPostById()
        {
            //Arrange
            var res = false;
            //Act
            service.Setup(repo => repo.GetPostById(_post.PostID));
            var result = await _blogPostServMock.GetPostById(_post.PostID);
            if (result != null)
            {
                res = true;
            }
            //Asert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestFor_Get_BlogPostById=" + res + "\n");
            return res;
        }
    }
}
