#pragma checksum "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc6582224de9cc019432ba0847698923116553d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Categories), @"mvc.1.0.view", @"/Views/Home/Categories.cshtml")]
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
#line 1 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\_ViewImports.cshtml"
using NorthwindApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\_ViewImports.cshtml"
using NorthwindApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc6582224de9cc019432ba0847698923116553d3", @"/Views/Home/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06011417caa3137a55c427e21fe7ab52941f4828", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NorthwindApp.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
  
    ViewData["Title"] = "Categories";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View</h1>\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Boris_Makeev\source\local_repos\NorthwindApp\NorthwindApp\Views\Home\Categories.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NorthwindApp.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591