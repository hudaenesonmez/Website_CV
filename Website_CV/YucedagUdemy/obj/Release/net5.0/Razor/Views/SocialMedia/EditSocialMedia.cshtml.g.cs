#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc42c161c5360b22f1a463c3384db22978c4516d3f44fe04d3494f3e37cfc20e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_EditSocialMedia), @"mvc.1.0.view", @"/Views/SocialMedia/EditSocialMedia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fc42c161c5360b22f1a463c3384db22978c4516d3f44fe04d3494f3e37cfc20e", @"/Views/SocialMedia/EditSocialMedia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SocialMedia_EditSocialMedia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.SocialMedia>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
  
    ViewData["Title"] = "EditSocialMedia";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Sosyal Medya</h3>\r\n</div>\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n           \r\n");
#nullable restore
#line 15 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                 using (Html.BeginForm("EditSocialMedia", "SocialMedia", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 17 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.HiddenFor(x => x.SocialMediaId)

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 18 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.Label("Adı")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 19 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.TextBoxFor(x => x.Name, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                    <br />\r\n");
            Write(
#nullable restore
#line 21 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.Label("URL")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 22 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.TextBoxFor(x => x.Url, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                    <br />\r\n");
            Write(
#nullable restore
#line 24 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.Label("Görsel URL")

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 25 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"
                     Html.TextBoxFor(x => x.IconUrl, new { @class = "form-control" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("                    <br />\r\n                    <br />\r\n                    <button class=\"btn btn-primary\"> Güncelle</button>\r\n");
#nullable restore
#line 29 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\EditSocialMedia.cshtml"

                }

#line default
#line hidden
#nullable disable

            WriteLiteral("          \r\n            <br />\r\n            <a href=\"/SocialMedia/Index/\" class=\"btn btn-danger\" style=\"width: 125px\">Geri Dön</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
