using JFSEPABlogPost.Controllers;
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
        private Mock<IBlogPostRepository> blogPostRepoMock;
        private readonly BlogController blogController;
        public BusinessLogicTests()
        {
            blogPostRepoMock = new Mock<IBlogPostRepository>();
            blogController = new BlogController(blogPostRepoMock.Object);
        }
        static BusinessLogicTests()
        {
            if (!File.Exists("../../../../output_BusinessLogic_revised.txt"))
                try
                {
                    File.Create("../../../../output_BusinessLogic_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_BusinessLogic_revised.txt");
                File.Create("../../../../output_BusinessLogic_revised.txt").Dispose();
            }
        }
        
    }
}
