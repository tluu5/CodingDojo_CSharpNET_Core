#pragma checksum "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2207bfd8acd179587d2cbb719900c5bf504825d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2207bfd8acd179587d2cbb719900c5bf504825d0", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
  
    ViewData["Title"] = "Dishes Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <div class=""text-center"">
        <a href=""/"">Chefs</a> | <a href=""/dishes"">Dishes</a>
        <br>
        <a href=""/dishes/new"">Add a Dish</a>
        <h1>Yum, take a look at our tasty dishes!</h1>
    </div>
    <div class=""row"">
        <table class=""table table-striped"">
            <tr>
                <td>Name</td>
                <td>Chef</td>
                <td>Tastiness</td>
                <td>Calories</td>
            </tr>
");
#nullable restore
#line 20 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
              
                foreach (Dish a in ViewBag.AllDishes)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 24 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
                       Write(a.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 25 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
                       Write(a.Worker.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
                                           Write(a.Worker.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 26 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
                       Write(a.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 27 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
                       Write(a.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 29 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/ChefsNDishes/Views/Home/Dishes.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n</div>");
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
