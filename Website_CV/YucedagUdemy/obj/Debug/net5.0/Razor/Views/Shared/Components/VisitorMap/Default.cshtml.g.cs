#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\VisitorMap\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0fb1de8dc32e95fdc0222a90788161ba6094676df61a102d8884fcd9dec7ace3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VisitorMap_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0fb1de8dc32e95fdc0222a90788161ba6094676df61a102d8884fcd9dec7ace3", @"/Views/Shared/Components/VisitorMap/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_VisitorMap_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Ziyaret Edenler</h4>
                <div class=""row"">
                    <div class=""col-md-5"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <tbody>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-tr""></i>
                                        </td>
                                        <td>Türkiye</td>
                                        <td class=""text-right""> 1500 </td>
                                        <td class=""text-right font-weight-medium""> 56.35% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <");
            WriteLiteral(@"i class=""flag-icon flag-icon-de""></i>
                                        </td>
                                        <td>Almanya</td>
                                        <td class=""text-right""> 800 </td>
                                        <td class=""text-right font-weight-medium""> 33.25% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-it""></i>
                                        </td>
                                        <td>İtalya</td>
                                        <td class=""text-right""> 760 </td>
                                        <td class=""text-right font-weight-medium""> 15.45% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-gb""></i>
  ");
            WriteLiteral(@"                                      </td>
                                        <td>Birleşik Krallık</td>
                                        <td class=""text-right""> 450 </td>
                                        <td class=""text-right font-weight-medium""> 25.00% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-ro""></i>
                                        </td>
                                        <td>Romanya</td>
                                        <td class=""text-right""> 620 </td>
                                        <td class=""text-right font-weight-medium""> 10.25% </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <i class=""flag-icon flag-icon-br""></i>
                                 ");
            WriteLiteral(@"       </td>
                                        <td>Brezilya</td>
                                        <td class=""text-right""> 230 </td>
                                        <td class=""text-right font-weight-medium""> 75.00% </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""col-md-7"">
                        <div id=""audience-map"" class=""vector-map""></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
