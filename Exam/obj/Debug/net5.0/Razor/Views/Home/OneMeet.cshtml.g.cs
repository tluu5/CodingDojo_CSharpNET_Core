#pragma checksum "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec0282a88ee143701346dc799c745e896d200737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OneMeet), @"mvc.1.0.view", @"/Views/Home/OneMeet.cshtml")]
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
#line 1 "/Users/brianluu/Desktop/Exam/Views/_ViewImports.cshtml"
using Exam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brianluu/Desktop/Exam/Views/_ViewImports.cshtml"
using Exam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec0282a88ee143701346dc799c745e896d200737", @"/Views/Home/OneMeet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2110cd27d8939d717276b40bc632c0f27945b210", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OneMeet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"text-center\">\n    <div class=\"text-center\">\n        <h1>Dojo Meet Up Center</h1>\n        <a href=\"/Dashboard\">Dashboard</a>\n        <a href=\"/Logout\">Log Out</a>\n    </div>\n    <h2>");
#nullable restore
#line 9 "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml"
   Write(ViewBag.Meet.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h2>Event Coordinator: ");
#nullable restore
#line 10 "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml"
                      Write(ViewBag.Meet.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h2>Description: ");
#nullable restore
#line 11 "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml"
                Write(ViewBag.Meet.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
            WriteLiteral("    <h2>Participants:</h2>\n");
#nullable restore
#line 18 "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml"
     foreach (Order a in ViewBag.Meet.GuestsList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>");
#nullable restore
#line 20 "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml"
       Write(a.Guest.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 21 "/Users/brianluu/Desktop/Exam/Views/Home/OneMeet.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meet> Html { get; private set; }
    }
}
#pragma warning restore 1591
