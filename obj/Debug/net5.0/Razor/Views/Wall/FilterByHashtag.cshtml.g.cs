#pragma checksum "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01b5ed60ed8c75e07d7587df8b14d5f9e3e20e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wall_FilterByHashtag), @"mvc.1.0.view", @"/Views/Wall/FilterByHashtag.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\Catstagram\Views\_ViewImports.cshtml"
using Catstagram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\Catstagram\Views\_ViewImports.cshtml"
using Catstagram.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01b5ed60ed8c75e07d7587df8b14d5f9e3e20e5", @"/Views/Wall/FilterByHashtag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5264f25e4b5df22fd55262c675ade6d5b4868c68", @"/Views/_ViewImports.cshtml")]
    public class Views_Wall_FilterByHashtag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2 style=\"text-align: center\">Posts with hashtag: #");
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
                                               Write(ViewBag.Hashtag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
 if (Model.Count > 0)
{
    foreach (var post in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>

            <div class=""col-md-6 offset-md-3"">
                <div class=""card my-3"">
                    <div class=""card-header"">
                        <div class=""d-flex align-items-center"">
                            <h5 class=""mb-0"">");
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
                                        Write(Html.DisplayFor(modelItem => post.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-body p-0\" id=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 670, "\"", 687, 1);
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
WriteAttributeValue("", 676, post.Image, 676, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\">\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n                        <small class=\"text-muted\">");
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
                                             Write(Html.DisplayFor(modelItem => post.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                    <p class=\"cat-photo-post-comment\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
                   Write(Html.Raw(Regex.Replace(post.Comments, @"#(\w+)", "<a href=\"/Wall/FilterByHashtag?hashtag=$1\">#$1</a>")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
    }
}

else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No posts found.</p>\r\n");
#nullable restore
#line 38 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\FilterByHashtag.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
