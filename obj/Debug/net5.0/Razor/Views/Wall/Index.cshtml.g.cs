#pragma checksum "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2981739249b8a8503a18203031783232783b5d14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wall_Index), @"mvc.1.0.view", @"/Views/Wall/Index.cshtml")]
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
#line 2 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2981739249b8a8503a18203031783232783b5d14", @"/Views/Wall/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5264f25e4b5df22fd55262c675ade6d5b4868c68", @"/Views/_ViewImports.cshtml")]
    public class Views_Wall_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
  
    ViewData["Title"] = "Wall";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        background-color: #fff;
        border-radius: 5px;
        box-shadow: 0px 0px 5px 0px rgba(0,0,0,0.1);
    }

    .card-body {
        display: flex;
        justify-content: center;
        align-items: center;
        height: 300px; /* set the height of the card holder */
        overflow: hidden;
    }

    .card-body img {
        width: 100%;
        height: 100%;
        object-fit: cover;
    }
</style>

    <div class=""row"">
");
#nullable restore
#line 31 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6 offset-md-3\">\n                <div class=\"card my-3\">\n                    <div class=\"card-header\">\n                        <div class=\"d-flex align-items-center\">\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        </div>\n                    </div>\n                    <div class=\"card-body p-0\" id=\"image\">\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1056, "\"", 1073, 1);
#nullable restore
#line 41 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
WriteAttributeValue("", 1062, item.Image, 1062, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\">\n                    </div>\n                    <div class=\"card-footer\">\n                        <small class=\"text-muted\">");
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n                    </div>\n                    <p class=\"cat-photo-post-comment\">\n                        ");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
                   Write(Html.Raw(Regex.Replace(item.Comments, @"#(\w+)", "<a href=\"/Wall/FilterByHashtag?hashtag=$1\">#$1</a>")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n\n                </div>\n            </div>\n");
#nullable restore
#line 52 "C:\Users\Administrator\Desktop\Catstagram\Views\Wall\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
