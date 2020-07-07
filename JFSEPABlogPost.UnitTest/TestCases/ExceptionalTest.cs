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
        private Mock<IBlogPostRepository> blogPostRepoMock;
        private readonly BlogController blogController;

        public ExceptionalTest()
        {
            blogPostRepoMock = new Mock<IBlogPostRepository>();
            blogController = new BlogController(blogPostRepoMock.Object);
        }
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
        [Fact]
        public async Task CommentTest_ReturnsNotFound_WhenCommentDoesNotExist()
        {
            // Arrange
            var res = false;
            var postId = 12;
            blogPostRepoMock.Setup(repo => repo.GetAllComments(postId)).
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
            blogPostRepoMock.Verify(repo => repo.Create(objectsBlogPost), Times.Never());
            if (viewResult == Assert.IsType<ViewResult>(result))
                res = true;
            File.AppendAllText("../../../../output_exception_revised.txt",
                "CreateTest_Post_ReturnsCreateView_WhenModelStateIsInvalid="
                + res.ToString() + "\n");
        }
    }
}
