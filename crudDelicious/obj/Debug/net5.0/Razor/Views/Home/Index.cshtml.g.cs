#pragma checksum "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a203f6daaf8e379ee4c57005f788fd6f26bcda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/_ViewImports.cshtml"
using crudDelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/_ViewImports.cshtml"
using crudDelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a203f6daaf8e379ee4c57005f788fd6f26bcda", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa92d938eb857e4246bc0d14483e2c7c10e9aab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to CRUDelicious</h1>\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2>Check out some recent dishes!</h2>\r\n            <ul>\r\n");
#nullable restore
#line 11 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml"
                 foreach(Dish d in ViewBag.AllDishes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li><a");
            BeginWriteAttribute("href", " href=\"", 352, "\"", 383, 2);
            WriteAttributeValue("", 359, "/dishes/single/", 359, 15, true);
#nullable restore
#line 13 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml"
WriteAttributeValue("", 374, d.DishId, 374, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml"
                                                      Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> by ");
#nullable restore
#line 13 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml"
                                                                     Write(d.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/crudDelicious/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <a href=\"/dishes/new\">Add a Dish</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
