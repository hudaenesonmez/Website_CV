#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f76bc9b347c2ee04fc97b3f5f7c31e6b5509ab10262071a4eb32fd4acaf39563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_AddSocialMedia), @"mvc.1.0.view", @"/Views/SocialMedia/AddSocialMedia.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\_ViewImports.cshtml"
using YucedagUdemy

#nullable disable
    ;
#nullable restore
#line 2 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\_ViewImports.cshtml"
using YucedagUdemy.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f76bc9b347c2ee04fc97b3f5f7c31e6b5509ab10262071a4eb32fd4acaf39563", @"/Views/SocialMedia/AddSocialMedia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SocialMedia_AddSocialMedia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.SocialMedia>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
  
    ViewData["Title"] = "AddSocialMedia";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Sosyal Medya Ağı Ekle</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
 using (Html.BeginForm("AddSocialMedia", "SocialMedia", FormMethod.Post))
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\">Sosyal Medya Ağı Ekle</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76bc9b347c2ee04fc97b3f5f7c31e6b5509ab10262071a4eb32fd4acaf395634574", async() => {
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 16 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
                     Html.Label("Adı")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 17 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
                     Html.TextBoxFor(x => x.Name, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 19 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
                     Html.Label("URL")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 20 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
                     Html.TextBoxFor(x => x.Url, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 22 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
                     Html.Label("Görsel URL")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 23 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
                     Html.TextBoxFor(x => x.IconUrl, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    <br />\r\n                    <button class=\"btn btn-primary\"> Ekle</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 31 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\AddSocialMedia.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("<a href=\"/SocialMedia/Index/\" class=\"btn btn-danger\" style=\"width: 125px\">Geri Dön</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.SocialMedia> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
