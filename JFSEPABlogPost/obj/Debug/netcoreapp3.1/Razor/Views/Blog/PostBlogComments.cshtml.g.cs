#pragma checksum "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f124ee4cac5c8e9e88e05f682d1ded51bd842e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_PostBlogComments), @"mvc.1.0.view", @"/Views/Blog/PostBlogComments.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\_ViewImports.cshtml"
using JFSEPABlogPost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\_ViewImports.cshtml"
using JFSEPABlogPost.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f124ee4cac5c8e9e88e05f682d1ded51bd842e6", @"/Views/Blog/PostBlogComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd89fee87222245e0754d2ccadf11fcc40c10234", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_PostBlogComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JFSEPABlogPost.BusinessLayer.ViewModel.CommentPostViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
  
    ViewData["Title"] = "PostBlogComments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>PostBlogComments</h1>\r\n\r\n");
#nullable restore
#line 8 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
 foreach (var vm in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Post Title </h1>\r\n");
#nullable restore
#line 11 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
   Write(vm.BlogPost.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 13 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
             foreach (var ele in vm.Comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 15 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
               Write(ele.CommentMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 18 "D:\IIHT\JFSEPABlogPostwithInMemory\Blog\JFSEPABlogPost\Views\Blog\PostBlogComments.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JFSEPABlogPost.BusinessLayer.ViewModel.CommentPostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
