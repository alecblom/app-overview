#pragma checksum "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\Shared\_FooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf0d38ea958d329bb600289aa859cb421e41120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FooterPartial), @"mvc.1.0.view", @"/Views/Shared/_FooterPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FooterPartial.cshtml", typeof(AspNetCore.Views_Shared__FooterPartial))]
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
#line 1 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\_ViewImports.cshtml"
using AppOverview;

#line default
#line hidden
#line 2 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\_ViewImports.cshtml"
using AppOverview.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf0d38ea958d329bb600289aa859cb421e41120", @"/Views/Shared/_FooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c94d6bc9266fcd39bf26990d0266d340a81f087", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 796, true);
            WriteLiteral(@"<div class=""text-center container"">
    <div class=""row"">
        <div class=""col-md-8 footer-item"">
            <h5 class=""footer-item-title"">Not sure if a product is installed?</h5>
            <div class=""footer-item-content"">
                <p>Click <a class=""footer-item-link"" style=""text-decoration: underline;"" href=""#"" target=""_blank"">here</a> to get an overview of your installed products</p>
            </div>
         </div>
        <div class=""col-md-4 footer-item"">
            <h5 class=""footer-item-title"">Require support?</h5>
            <div class=""footer-item-content"">
                <p class=""m-0""><a class=""footer-item-link text-uppercase"" href=""#"" target=""_blank"">COMPANY NAME</a></p>
                <p class=""m-0""><a class=""footer-item-link text-uppercase""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 796, "\"", 838, 2);
            WriteAttributeValue("", 803, "callto:", 803, 7, true);
#line 13 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\Shared\_FooterPartial.cshtml"
WriteAttributeValue("", 810, @ViewData["SupportPhone"], 810, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(839, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(841, 24, false);
#line 13 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\Shared\_FooterPartial.cshtml"
                                                                                                                Write(ViewData["SupportPhone"]);

#line default
#line hidden
            EndContext();
            BeginContext(865, 83, true);
            WriteLiteral("</a></p>\r\n                <p class=\"m-0\"><a class=\"footer-item-link text-uppercase\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 948, "\"", 990, 2);
            WriteAttributeValue("", 955, "mailto:", 955, 7, true);
#line 14 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\Shared\_FooterPartial.cshtml"
WriteAttributeValue("", 962, @ViewData["SupportEmail"], 962, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(991, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(993, 24, false);
#line 14 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\Shared\_FooterPartial.cshtml"
                                                                                                                Write(ViewData["SupportEmail"]);

#line default
#line hidden
            EndContext();
            BeginContext(1017, 124, true);
            WriteLiteral("</a></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <hr />\r\n    <p style=\"color: #aaa\">\r\n        Copyright &copy; ");
            EndContext();
            BeginContext(1142, 17, false);
#line 20 "C:\Users\Alec\Source\Repos\app-overview\AppOverview\Views\Shared\_FooterPartial.cshtml"
                    Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 31, true);
            WriteLiteral(" Company Name\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
