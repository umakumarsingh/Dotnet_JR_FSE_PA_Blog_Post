#pragma checksum "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fdc41fd813dc59582b38091bb3a1b58b31fe131"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogComments), @"mvc.1.0.view", @"/Views/Blog/BlogComments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/BlogComments.cshtml", typeof(AspNetCore.Views_Blog_BlogComments))]
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
#line 1 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\_ViewImports.cshtml"
using JFSEPABlogPost;

#line default
#line hidden
#line 2 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\_ViewImports.cshtml"
using JFSEPABlogPost.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fdc41fd813dc59582b38091bb3a1b58b31fe131", @"/Views/Blog/BlogComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4471893ea56bbf773a39d36a23059a536474d89c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JFSEPABlogPost.Models.Comments>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(85, 58, true);
            WriteLiteral("\n<h3 class=\"text-center text-uppercase\">Comments</h3>\n<p>\n");
            EndContext();
            BeginContext(234, 83, true);
            WriteLiteral("</p>\n<table class=\"table table-bordered\">\n    <thead>\n        <tr>\n            <th>");
            EndContext();
            BeginContext(318, 38, false);
#line 13 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
           Write(Html.DisplayNameFor(m => m.CommentMsg));

#line default
#line hidden
            EndContext();
            BeginContext(356, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(379, 41, false);
#line 14 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
           Write(Html.DisplayNameFor(m => m.CommentedDate));

#line default
#line hidden
            EndContext();
            BeginContext(420, 22, true);
            WriteLiteral("</th>\n            <th>");
            EndContext();
            BeginContext(443, 34, false);
#line 15 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
           Write(Html.DisplayNameFor(m => m.PostID));

#line default
#line hidden
            EndContext();
            BeginContext(477, 45, true);
            WriteLiteral("</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 19 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
         foreach (var post in Model)
        {

#line default
#line hidden
            BeginContext(569, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(607, 15, false);
#line 22 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
               Write(post.CommentMsg);

#line default
#line hidden
            EndContext();
            BeginContext(622, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(649, 18, false);
#line 23 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
               Write(post.CommentedDate);

#line default
#line hidden
            EndContext();
            BeginContext(667, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(694, 11, false);
#line 24 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
               Write(post.PostID);

#line default
#line hidden
            EndContext();
            BeginContext(705, 24, true);
            WriteLiteral("</td>\n            </tr>\n");
            EndContext();
#line 26 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
        }

#line default
#line hidden
            BeginContext(739, 52, true);
            WriteLiteral("    </tbody>\n</table>\n<button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 791, "\"", 859, 4);
            WriteAttributeValue("", 801, "location.href=\'", 801, 15, true);
#line 29 "D:\IIHT\Code_Clean_Up\BlogPost-master-clean-code\JFSEPABlogPost\Views\Blog\BlogComments.cshtml"
WriteAttributeValue("", 816, Url.Action("Index", "Blog"), 816, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 844, "\';return", 844, 8, true);
            WriteAttributeValue(" ", 852, "false;", 853, 7, true);
            EndWriteAttribute();
            BeginContext(860, 111, true);
            WriteLiteral(">Back To post</button>\n<script src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js\"></script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JFSEPABlogPost.Models.Comments>> Html { get; private set; }
    }
}
#pragma warning restore 1591
