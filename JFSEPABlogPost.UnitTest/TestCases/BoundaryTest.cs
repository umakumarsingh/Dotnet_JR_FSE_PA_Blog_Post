using JFSEPABlogPost.Controllers;
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
        private Mock<IBlogPostRepository> blogPostRepoMock;
        private BlogController blogController;
        public BoundaryTest()
        {
            blogPostRepoMock = new Mock<IBlogPostRepository>();
            blogController = new BlogController(blogPostRepoMock.Object);
        }
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
    }
}
