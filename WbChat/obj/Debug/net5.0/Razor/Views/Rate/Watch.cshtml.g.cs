#pragma checksum "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Watch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42889af17dbab8255b90c916ff1c5cc991095e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rate_Watch), @"mvc.1.0.view", @"/Views/Rate/Watch.cshtml")]
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
#line 1 "/Users/hodamar/Projects/web_chat/web_chat/Views/_ViewImports.cshtml"
using web_chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hodamar/Projects/web_chat/web_chat/Views/_ViewImports.cshtml"
using web_chat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42889af17dbab8255b90c916ff1c5cc991095e57", @"/Views/Rate/Watch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99ce66177cc9deaa46207a228f1c4991caa94ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Rate_Watch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <h2>");
#nullable restore
#line 4 "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Watch.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    <h4>");
#nullable restore
#line 5 "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Watch.cshtml"
   Write(Model.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4><h20>out of 5.</h20>\n    <p>");
#nullable restore
#line 6 "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Watch.cshtml"
  Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rate> Html { get; private set; }
    }
}
#pragma warning restore 1591