#pragma checksum "C:\Users\tranv\OneDrive\Desktop\OracleDoAn\Oracle\Oracle\Views\Notification\AddNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a7d97f9e9c504373909396e2289e44679501a87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AddNew), @"mvc.1.0.view", @"/Views/Notification/AddNew.cshtml")]
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
#line 1 "C:\Users\tranv\OneDrive\Desktop\OracleDoAn\Oracle\Oracle\Views\_ViewImports.cshtml"
using Oracle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tranv\OneDrive\Desktop\OracleDoAn\Oracle\Oracle\Views\_ViewImports.cshtml"
using Oracle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a7d97f9e9c504373909396e2289e44679501a87", @"/Views/Notification/AddNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a37f3655ab78eabbd8f617174bd4620c723472aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_AddNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#nullable restore
#line 1 "C:\Users\tranv\OneDrive\Desktop\OracleDoAn\Oracle\Oracle\Views\Notification\AddNew.cshtml"
  
    ViewData["Title"] = "AddNew";
    Layout = "~/Views/Shared/_Main_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""col-md-8"">
            <div class=""card"">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title"">New Notification</h4>
                    <p class=""card-category"">Fill your message</p>
                </div>
                <div class=""card-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a7d97f9e9c504373909396e2289e44679501a873935", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-md-9"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Title</label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Published Date</label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label>Detail</label>
                           ");
                WriteLiteral(@"         <div class=""form-group"">
                                        <label class=""bmd-label-floating"">Your message</label>
                                        <textarea class=""form-control"" rows=""5""></textarea>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <button type=""submit"" class=""btn btn-primary pull-right"">Post</button>
                        <div class=""clearfix""></div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
