#pragma checksum "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d10ccff9d100a96b9d91b04c42395c9b1d87ec25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Article__article), @"mvc.1.0.view", @"/Views/Home/Components/Article/_article.cshtml")]
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
#line 1 "D:\C# project\AboutCard\AboutCard_MVC\Views\_ViewImports.cshtml"
using AboutCard_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# project\AboutCard\AboutCard_MVC\Views\_ViewImports.cshtml"
using AboutCard_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d10ccff9d100a96b9d91b04c42395c9b1d87ec25", @"/Views/Home/Components/Article/_article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2578f25073e1e700c2af160a3c1386e97052a73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Components_Article__article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Articles>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    \r\n<section class=\"featured-section p-3 p-lg-5\">\r\n\t\t\t<div class=\"container\">\r\n\t\t\t\t<h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 8 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
                     foreach (var article in Model)
					  {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  <div class=\"col-md-6 mb-5\">\r\n\t\t\t\t\t\t<div class=\"card project-card\">\r\n\t\t\t\t\t\t\t<div class=\"row no-gutters\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-lg-4 card-img-holder\">\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d10ccff9d100a96b9d91b04c42395c9b1d87ec254248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 437, "~/assets/images/project/", 437, 24, true);
#nullable restore
#line 14 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
AddHtmlAttributeValue("", 461, article.Image, 461, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
AddHtmlAttributeValue("", 499, article.Name, 499, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 14 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
AddHtmlAttributeValue("", 521, article.Description, 521, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-lg-8\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t\t<h5 class=\"card-title\"><a href=\"project.html\" class=\"theme-link\">");
#nullable restore
#line 18 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
                                                                                                    Write(article.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n\t\t\t\t\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 19 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
                                                        Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t<p class=\"card-text\"><small class=\"text-muted\">مشتری: ");
#nullable restore
#line 20 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
                                                                                         Write(article.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n");
#nullable restore
#line 26 "D:\C# project\AboutCard\AboutCard_MVC\Views\Home\Components\Article\_article.cshtml"
					  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Articles>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591