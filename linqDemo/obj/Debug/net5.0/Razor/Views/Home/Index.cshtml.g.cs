#pragma checksum "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f7c4f713f1388f5937e38fcc0d16abf842fbca1"
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
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/_ViewImports.cshtml"
using linqDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/_ViewImports.cshtml"
using linqDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f7c4f713f1388f5937e38fcc0d16abf842fbca1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84cc0ef7ef55fe3aef1a08a4e4975d5729dc48a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1>All Pets</h1>
    <table class=""table table-striped"">
        <tr>
            <td>Name</td>
            <td>Species</td>
            <td>Breed</td>
            <td>Age</td>
            <td>Loves Cuddles</td>
        </tr>
");
#nullable restore
#line 15 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
          
            foreach(Pet p in ViewBag.AllPets)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.LoveCuddle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

    <h1>All Cats</h1>
    <table class=""table table-striped"">
        <tr>
            <td>Name</td>
            <td>Species</td>
            <td>Breed</td>
            <td>Age</td>
            <td>Loves Cuddles</td>
        </tr>
");
#nullable restore
#line 38 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
          
            foreach(Pet p in ViewBag.AllCats)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 42 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.LoveCuddle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 48 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

    <h1>All Cuddlers</h1>
    <table class=""table table-striped"">
        <tr>
            <td>Name</td>
            <td>Species</td>
            <td>Breed</td>
            <td>Age</td>
            <td>Loves Cuddles</td>
        </tr>
");
#nullable restore
#line 61 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
          
            foreach(Pet p in ViewBag.Cuddles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 65 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 69 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.LoveCuddle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 71 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

    <h1>All Labs</h1>
    <table class=""table table-striped"">
        <tr>
            <td>Name</td>
            <td>Species</td>
            <td>Breed</td>
            <td>Age</td>
            <td>Loves Cuddles</td>
        </tr>
");
#nullable restore
#line 84 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
          
            foreach(Pet p in ViewBag.AllLabs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 88 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 89 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 90 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 91 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 92 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.LoveCuddle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 94 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n    <h1>All Breeds</h1>\r\n    <h3>");
#nullable restore
#line 99 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
   Write(String.Join(", ", ViewBag.SelectBreed));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n    <h2>The first cat in the database was: ");
#nullable restore
#line 101 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                                      Write(ViewBag.FirstCat.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" the ");
#nullable restore
#line 101 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                                                                 Write(ViewBag.FirstCat.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <h1>All B Names</h1>\r\n    <table class=\"table table-striped\">\r\n        <tr>\r\n            <td>Name</td>\r\n            <td>Species</td>\r\n            <td>Breed</td>\r\n            <td>Age</td>\r\n            <td>Loves Cuddles</td>\r\n        </tr>\r\n");
#nullable restore
#line 112 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
          
            foreach(Pet p in ViewBag.BNames)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 116 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 117 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 118 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 119 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 120 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.LoveCuddle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 122 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

        <h1>All Pets over 20 who do not like cuddle</h1>
    <table class=""table table-striped"">
        <tr>
            <td>Name</td>
            <td>Species</td>
            <td>Breed</td>
            <td>Age</td>
            <td>Loves Cuddles</td>
        </tr>
");
#nullable restore
#line 135 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
          
            foreach(Pet p in ViewBag.TwentyNoCuddles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 139 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 140 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Species);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 141 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 142 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 143 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
                   Write(p.LoveCuddle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 145 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/linqDemo/Views/Home/Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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