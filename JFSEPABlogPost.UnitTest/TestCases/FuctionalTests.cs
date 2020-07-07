using JFSEPABlogPost.Controllers;
using JFSEPABlogPost.Models;
using JFSEPABlogPost.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace JFSEPABlogPost.UnitTest.TestCases
{
    public class FuctionalTests
    {
        private Mock<IBlogPostRepository> blogPostRepoMock;
        private readonly BlogController blogController;
        public FuctionalTests()
        {
            blogPostRepoMock = new Mock<IBlogPostRepository>();
            blogController = new BlogController(blogPostRepoMock.Object);
        }
        static FuctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }
        [Fact]
        public async Task CreateTest_Post_AddsBlogPostToRepository_AndRedirectsToIndex()
        {
            var res = false;
            // Arrange
            var objectsBlogPost = new BlogPost { Title = "mock article 1", Description = "Hi", PostedDate = DateTime.Now }; 

            // Act
            var result = await blogController.Create(objectsBlogPost);
            
            // Assert
            blogPostRepoMock.Verify(repo => repo.Create(objectsBlogPost));
            var viewResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", viewResult.ActionName);
            if(viewResult.ActionName == "Index")
            res = true;
            File.AppendAllText("../../../../output_revised.txt",
                "CreateTest_Post_AddsBlogPostToRepository_AndRedirectsToIndex="
                + res.ToString() + "\n");
        }

        [Fact]
        public async Task IndexTest_ReturnsViewWithBlogPostList()
        {
            // Arrange
            var res = false;
            IEnumerable<BlogPost> objectsList = new List<BlogPost>
            {
                new BlogPost { Title = "mock article 1", Description="Hi", PostedDate=DateTime.Now },
                new BlogPost { Title = "mock article 2", Description="Hi", PostedDate=DateTime.Now }
            };
            blogPostRepoMock.Setup(repo => repo.GetAllPost()).Returns(Task.FromResult(objectsList));

            // Act
            var result = await blogController.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<BlogPost>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
            if (model.Count() == 2)
                res = true;
            File.AppendAllText("../../../../output_revised.txt",
                "IndexTest_ReturnsViewWithBlogPostList="
                + res.ToString() + "\n");

        }
        [Fact]
        public async Task CommentTest_ReturnsDetailsView_WhenCommentExists()
        {
            // Arrange
            var postId = 1;
            var res = false;
            IEnumerable<Comments> objectsList = new List<Comments>
            {
                new Comments { CommentMsg = "mock article 1", PostID=1, CommentedDate=DateTime.Now },
                new Comments { CommentMsg = "mock article 2", PostID=2, CommentedDate =DateTime.Now }
            };
            blogPostRepoMock
                .Setup(repo => repo.GetAllComments(postId))
                .Returns(Task.FromResult(objectsList));

            // Act
            var result = await blogController.BlogComments(postId);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Comments>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
            if (model.Count() == 2)
                res = true;
            File.AppendAllText("../../../../output_revised.txt",
                "CommentTest_ReturnsDetailsView_WhenCommentExists="
                + res.ToString() + "\n");
        }
        [Fact]
        public async Task CommentTest_ReturnsViewWithCommentList()
        {
            // Arrange
            var postId = 1;
            var res = false;
            IEnumerable<Comments> objectsList = new List<Comments>
            {
                new Comments { CommentMsg = "mock commeted 1", PostID=1, CommentedDate=DateTime.Now },
                new Comments { CommentMsg = "mock commeted 2", PostID=2, CommentedDate=DateTime.Now }
            };
            blogPostRepoMock
                .Setup(repo => repo.GetAllComments(postId))
                .Returns(Task.FromResult(objectsList));

            // Act
            var result = await blogController.BlogComments(postId);
            
            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Comments>>(viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
            if (model.Count() == 2)
                res = true;
            File.AppendAllText("../../../../output_revised.txt",
                "CommentTest_ReturnsViewWithCommentList="
                + res.ToString() + "\n");
        }
        [Fact]
        public async Task CommentTest_Post_AddsCommentsToRepository_AndRedirectsToIndex()
        {
            // Arrange
            var postId = 1;
            var res = false;
            var objectsComments = new Comments { CommentMsg = "mock article 1", CommentedDate = DateTime.Now, PostID = 1 };
            //blogPostRepoMock.Setup(repo => repo.Create(objectsBlogPost)).Returns(Task.CompletedTask);

            // Act
            var result = await blogController.Comments(postId, objectsComments);
            
            // Assert
            blogPostRepoMock.Verify(repo => repo.Comments(postId, objectsComments));
            var viewResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", viewResult.ActionName);
            if (viewResult.ActionName == "Index")
                res = true;
            File.AppendAllText("../../../../output_revised.txt",
                "CommentTest_Post_AddsCommentsToRepository_AndRedirectsToIndex="
                + res.ToString() + "\n");
        }
    }
}

