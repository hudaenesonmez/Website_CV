#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\Statistics2\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0f644d36da222231b601876ac6edc2f99a5d4520249b68b50df47d697f507776"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Statistics2_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Statistics2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0f644d36da222231b601876ac6edc2f99a5d4520249b68b50df47d697f507776", @"/Views/Shared/Components/Statistics2/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Statistics2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Öğrendiklerim</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
            Write(
#nullable restore
#line 9 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\Statistics2\Default.cshtml"
                                              ViewBag.SkillCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h2>
                            
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Akademide Öğrendiklerim</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-codepen text-primary ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Mesajlar</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
            Write(
#nullable restore
#line 28 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\Statistics2\Default.cshtml"
                                              ViewBag.MessageCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h2>
                            
                        </div>
                        <h6 class=""text-muted font-weight-normal""> Son 1 Ayda Gelen Mesajlar</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-wallet-travel text-danger ml-auto""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-4 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h5>Becerilerim</h5>
                <div class=""row"">
                    <div class=""col-8 col-sm-12 col-xl-8 my-auto"">
                        <div class=""d-flex d-sm-block d-md-flex align-items-center"">
                            <h2 class=""mb-0"">");
            Write(
#nullable restore
#line 47 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\Statistics2\Default.cshtml"
                                              ViewBag.SkillCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h2>
                            
                        </div>
                        <h6 class=""text-muted font-weight-normal"">Becerilerim</h6>
                    </div>
                    <div class=""col-4 col-sm-12 col-xl-4 text-center text-xl-right"">
                        <i class=""icon-lg mdi mdi-monitor text-success ml-auto""></i>
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