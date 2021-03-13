#pragma checksum "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ffc690599550a6d885f1b2a4522994d70a33950"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp;

#line default
#line hidden
#line 2 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\_ViewImports.cshtml"
using NewsWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ffc690599550a6d885f1b2a4522994d70a33950", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611b239ef6ae9b32b4cba408aa5ed3a1ffee7262", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Latest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";
    var posts = ViewData["relatedPost"] as IEnumerable<Post>;
    var latest = ViewData["latest"] as IEnumerable<Post>;



#line default
#line hidden
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row my-5\">\r\n        <div class=\"col-md-8\">\r\n            <div class=\"shadow-sm p-3\">\r\n                <h3 class=\"my-5\">");
#line 15 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                            Write(Model.Name);

#line default
#line hidden
            WriteLiteral("</h3>\r\n                <hr />\r\n                <div class=\"time text-dark\">\r\n                    Published On\r\n                    <i class=\"fas fa-clock\"></i> ");
#line 19 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                                            Write(Model.CreatedDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            WriteLiteral("\r\n                </div>\r\n                <hr />\r\n");
#line 22 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                 if (Model.Picture != null)
                {

#line default
#line hidden
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ffc690599550a6d885f1b2a4522994d70a339505260", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 755, "~/uploads/", 755, 10, true);
#line 24 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
AddHtmlAttributeValue("", 765, Model.Picture, 765, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 25 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                }

#line default
#line hidden
            WriteLiteral("                <hr />\r\n");
#line 27 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                 foreach (var item in Model.PostCategories)
                {

#line default
#line hidden
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 930, "\"", 971, 2);
            WriteAttributeValue("", 937, "/posts/postbycat/", 937, 17, true);
#line 29 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 954, item.Category.Id, 954, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"category\">\r\n                            <span>\r\n                                ");
#line 32 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                           Write(item.Category.Name);

#line default
#line hidden
            WriteLiteral("\r\n                            </span>\r\n                        </div>\r\n                    </a>\r\n");
#line 36 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                }

#line default
#line hidden
            WriteLiteral("                ");
#line 37 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
           Write(Html.Raw(Model.Content));

#line default
#line hidden
            WriteLiteral("\r\n\r\n                <div class=\"tag-wrapper my-5\">\r\n\r\n");
#line 41 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                     foreach (var item in Model.PostTags)
                    {

#line default
#line hidden
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 1428, "\"", 1464, 2);
            WriteAttributeValue("", 1435, "/posts/postbytag/", 1435, 17, true);
#line 43 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1452, item.Tag.Id, 1452, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" class=\"tag\">\r\n                            # ");
#line 44 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                         Write(item.Tag.Name);

#line default
#line hidden
            WriteLiteral("\r\n                        </a>\r\n");
#line 46 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                    }

#line default
#line hidden
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ffc690599550a6d885f1b2a4522994d70a339509726", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 52 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = latest;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-12 my-4\">\r\n            <div class=\"cat-title\"> Related News    </div>\r\n        </div>\r\n");
#line 58 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
         foreach (var post in posts)
        {


#line default
#line hidden
            WriteLiteral("            <div class=\"col-md-4 my-4\">\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1972, "\"", 2002, 2);
            WriteAttributeValue("", 1979, "/posts/details/", 1979, 15, true);
#line 63 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
WriteAttributeValue("", 1994, post.Id, 1994, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card shadow-sm h-100 border-0\">\r\n");
#line 65 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                         if (post.Picture != null)
                        {

#line default
#line hidden
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ffc690599550a6d885f1b2a4522994d70a3395012416", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2188, "~/uploads/", 2188, 10, true);
#line 67 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
AddHtmlAttributeValue("", 2198, post.Picture, 2198, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 68 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ffc690599550a6d885f1b2a4522994d70a3395014132", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#line 72 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"

                        }

#line default
#line hidden
            WriteLiteral("                    <div class=\"card-body\">\r\n                        ");
#line 75 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                   Write(post.Name);

#line default
#line hidden
            WriteLiteral("\r\n                        <div class=\"time text-dark\">\r\n                           \r\n                            <i class=\"fas fa-clock\"></i> ");
#line 78 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
                                                    Write(Model.CreatedDate.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#line 84 "C:\Users\Dell\Desktop\bca4thsem_dotnetcore_mvc_web_app\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
