#pragma checksum "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/Home/Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85b287d321600c359f68aeb140f3a104e35ca65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/_ViewImports.cshtml"
using Dojo_Survey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/_ViewImports.cshtml"
using Dojo_Survey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d85b287d321600c359f68aeb140f3a104e35ca65", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ed4ca7fa680a67fd7545b033ec5b81acc9d95f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dojo_Survey_Index>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1><u>Submitted Info</u></h1>\n<h3>Name: ");
#nullable restore
#line 3 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/Home/Results.cshtml"
     Write(Model.Your_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>Dojo Location: ");
#nullable restore
#line 4 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/Home/Results.cshtml"
              Write(Model.Dojo_Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>Favorite Language: ");
#nullable restore
#line 5 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/Home/Results.cshtml"
                  Write(Model.Favorite_Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<h3>Comment ");
#nullable restore
#line 6 "/Users/brianluu/Desktop/CodingDojo_CSharpNET_Core/Dojo_Survey/Views/Home/Results.cshtml"
       Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n<input type=\"button\" class=\"btn btn-lg btn-success\" onclick=\"location.href=\'/\'\" value=\"Go Back\"/>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dojo_Survey_Index> Html { get; private set; }
    }
}
#pragma warning restore 1591
