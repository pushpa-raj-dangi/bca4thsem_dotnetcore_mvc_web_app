#pragma checksum "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98dc57a22dc7db775f1a8921911a1209c61e5a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
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
#line 1 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98dc57a22dc7db775f1a8921911a1209c61e5a7", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611b239ef6ae9b32b4cba408aa5ed3a1ffee7262", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SideNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "All posts ";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d98dc57a22dc7db775f1a8921911a1209c61e5a74389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-4 offset-8""><input id=""input"" class=""form-control my-3"" type=""text"" placeholder=""Search Post...""></div>
                <table class=""table table-hover"">
                    <tr class=""table-active"">
                        <td>
                            Title
                        </td>
                        <td>
                            Categories
                        </td>
                        <td>
                            Tags
                        </td>
                    </tr>
                    <tbody id=""table"">
");
#nullable restore
#line 28 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
                         foreach (var post in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td class=\"action-table\">\r\n                                    ");
#nullable restore
#line 32 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
                               Write(post.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"action-link\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98dc57a22dc7db775f1a8921911a1209c61e5a76961", async() => {
                WriteLiteral(" Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
                                             WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("|\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1403, "\"", 1430, 2);
            WriteAttributeValue("", 1410, "/posts/Edit/", 1410, 12, true);
#nullable restore
#line 35 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
WriteAttributeValue("", 1422, post.Id, 1422, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1486, "\"", 1516, 2);
            WriteAttributeValue("", 1493, "/posts/Details/", 1493, 15, true);
#nullable restore
#line 36 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
WriteAttributeValue("", 1508, post.Id, 1508, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a>\r\n                                    </span>\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 41 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
                               Write(string.Join(", ", post.PostCategories.Select(p => p.Category.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 45 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"
                               Write(string.Join(", ", post.PostTags.Select(p => p.Tag.Name)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 49 "D:\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
