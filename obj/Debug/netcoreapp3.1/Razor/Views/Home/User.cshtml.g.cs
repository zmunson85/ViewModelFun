#pragma checksum "C:\Users\Owner\OneDrive\Desktop\Dojo_Assignments\csharp\vmf\Views\Home\User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8f988b83a53448dfd9b26587645b431d0fcefee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_User), @"mvc.1.0.view", @"/Views/Home/User.cshtml")]
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
#line 1 "C:\Users\Owner\OneDrive\Desktop\Dojo_Assignments\csharp\vmf\Views\_ViewImports.cshtml"
using vmf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\OneDrive\Desktop\Dojo_Assignments\csharp\vmf\Views\_ViewImports.cshtml"
using vmf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8f988b83a53448dfd9b26587645b431d0fcefee", @"/Views/Home/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0693634a3083c6cd8f2f90f2d9e27cc060963546", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_User : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"user\">\r\n\r\n    <h3 style=\"text-align: center;\">Here is a User!</h3>\r\n    <p class=\"userName\" style=\"font-size: 42px; text-align: center;\">");
#nullable restore
#line 4 "C:\Users\Owner\OneDrive\Desktop\Dojo_Assignments\csharp\vmf\Views\Home\User.cshtml"
                                                                Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\Owner\OneDrive\Desktop\Dojo_Assignments\csharp\vmf\Views\Home\User.cshtml"
                                                                                        Write(ViewBag.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>");
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
