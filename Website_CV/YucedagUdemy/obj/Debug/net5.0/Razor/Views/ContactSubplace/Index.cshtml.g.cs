#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "55198488dcf3496bb4ae18179e00e00f7238db870a7ecb1230122498b8637fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContactSubplace_Index), @"mvc.1.0.view", @"/Views/ContactSubplace/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"55198488dcf3496bb4ae18179e00e00f7238db870a7ecb1230122498b8637fec", @"/Views/ContactSubplace/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ContactSubplace_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Contact>
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
#line 2 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
 using (Html.BeginForm("Index", "ContactSubplace", FormMethod.Post))
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\">Bana Ulaşın\'ı Düzenle</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55198488dcf3496bb4ae18179e00e00f7238db870a7ecb1230122498b8637fec4484", async() => {
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 14 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.HiddenFor(x => x.ContactId)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 15 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.Label("Başlık")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 16 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.TextBoxFor(x => x.Title, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 18 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.Label("Mail")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 19 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.TextBoxFor(x => x.Mail, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 21 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.Label("Telefon")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 22 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.TextBoxFor(x => x.Phone, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    ");
                Write(
#nullable restore
#line 24 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.Label("Açıklama")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    ");
                Write(
#nullable restore
#line 25 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
                     Html.TextAreaFor(x => x.Description, 10, 3, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                    <br />\r\n                    <button class=\"btn btn-primary\"> Bana Ulaş Metinlerini Güncelle </button>\r\n                ");
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
#line 32 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 33 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\ContactSubplace\Index.cshtml"
 await Component.InvokeAsync("ContactDetails")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Contact> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
