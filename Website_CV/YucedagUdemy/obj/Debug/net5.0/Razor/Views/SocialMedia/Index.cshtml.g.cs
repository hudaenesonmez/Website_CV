#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fbf5ca9f43d009f86f8e8bb857bbf95745fe4ee9911025269bb486bf37b49c06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SocialMedia_Index), @"mvc.1.0.view", @"/Views/SocialMedia/Index.cshtml")]
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

#nullable disable
    ;
#nullable restore
#line 1 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fbf5ca9f43d009f86f8e8bb857bbf95745fe4ee9911025269bb486bf37b49c06", @"/Views/SocialMedia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SocialMedia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""card"">
    <!-- Card header -->
    <div class=""card-header border-0"">
        <h3 class=""mb-0"">Sosyal Medya Adresleri</h3>
    </div>
    <!-- Light table -->
    <div class=""table-responsive"">
        <table class=""table align-items-center table-flush"">
            <thead class=""thead-light"">
                <tr>
                    <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                    <th scope=""col"" class=""sort"" data-sort=""budget"">İsim</th>
                    <th scope=""col"">Sil</th>
                    <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                    <th scope=""col""></th>
                </tr>
            </thead>

            <tbody class=""list"">
");
#nullable restore
#line 27 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                    <tr>
                        <th scope=""row"">
                            <div class=""media align-items-center"">
                                <div class=""media-body"">

                                    <span class=""name mb-0 text-sm"">");
            Write(
#nullable restore
#line 34 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
                                                                     item.SocialMediaId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </th>\r\n\r\n                        <td class=\"budget\">");
            Write(
#nullable restore
#line 39 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
                                            item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1460, "\"", 1517, 2);
            WriteAttributeValue("", 1467, "/SocialMedia/DeleteSocialMedia/", 1467, 31, true);
            WriteAttributeValue("", 1498, 
#nullable restore
#line 41 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
                                                                     item.SocialMediaId

#line default
#line hidden
#nullable disable
            , 1498, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1586, "\"", 1641, 2);
            WriteAttributeValue("", 1593, "/SocialMedia/EditSocialMedia/", 1593, 29, true);
            WriteAttributeValue("", 1622, 
#nullable restore
#line 42 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
                                                                   item.SocialMediaId

#line default
#line hidden
#nullable disable
            , 1622, 19, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Güncelle</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\SocialMedia\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        <br />\r\n        <a href=\"/SocialMedia/AddSocialMedia/\" class=\"btn btn-primary\">Ekle</a>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591