#pragma checksum "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb092a2810addac5aa5a269a74eef830cf44042b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rate_Edit), @"mvc.1.0.view", @"/Views/Rate/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb092a2810addac5aa5a269a74eef830cf44042b", @"/Views/Rate/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99ce66177cc9deaa46207a228f1c4991caa94ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Rate_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Edit Review</h1>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb092a2810addac5aa5a269a74eef830cf44042b3715", async() => {
                WriteLiteral("\n    <div class=\"mb-3\">\n        <label for=\"exampleInputEmail1\" class=\"form-label\">Name</label>\n        <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 226, "\"", 245, 1);
#nullable restore
#line 6 "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Edit.cshtml"
WriteAttributeValue("", 234, Model.Name, 234, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        <div id=\"name\" class=\"form-text\"></div>\n    </div>\n    <div class=\"mb-3\">\n        <label class=\"form-label\">Review</label>\n        <input type=\"text\" class=\"form-control\" id=\"review\" name=\"content\"");
                BeginWriteAttribute("value", " value=\"", 453, "\"", 475, 1);
#nullable restore
#line 11 "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Edit.cshtml"
WriteAttributeValue("", 461, Model.Content, 461, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n    </div>\n    <br />\n    <div class=\"btn-toolbar\" role=\"toolbar\" aria-label=\"Toolbar with button groups\">\n        <div class=\"btn-group me-2\" role=\"group\" aria-label=\"First group\"");
                BeginWriteAttribute("value", " value =\"", 658, "\"", 679, 1);
#nullable restore
#line 15 "/Users/hodamar/Projects/web_chat/web_chat/Views/Rate/Edit.cshtml"
WriteAttributeValue("", 667, Model.Score, 667, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            <button type=""button"" class=""btn btn-primary"" name=""score"" value=""1"">1</button>
            <button type=""button"" class=""btn btn-primary"" name=""score"" value=""2"">2</button>
            <button type=""button"" class=""btn btn-primary"" name=""score"">3</button>
            <button type=""button"" class=""btn btn-primary"" name=""score"">4</button>
            <button type=""button"" class=""btn btn-primary"" name=""score"">5</button>
        </div>
    </div>
    <div id=""submit"">
        <button type=""submit"" class=""btn btn-primary"">Submit</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
