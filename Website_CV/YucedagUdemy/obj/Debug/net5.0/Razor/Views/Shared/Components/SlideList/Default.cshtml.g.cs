#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\SlideList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f8c18f5521d93d88086bbff84403c5cfe33e84a66019bde364969fd891cc390a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SlideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SlideList/Default.cshtml")]
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
#line 1 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\SlideList\Default.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f8c18f5521d93d88086bbff84403c5cfe33e84a66019bde364969fd891cc390a", @"/Views/Shared/Components/SlideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SlideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portofolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-6 col-xl-4 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Projeler Önizleme</h4>
            <div class=""owl-carousel owl-theme full-width owl-carousel-dash portfolio-carousel"" id=""owl-carousel-basic"">
");
#nullable restore
#line 9 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\SlideList\Default.cshtml"
                foreach(var item in Model)
               {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <div class=\"item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 474, "\"", 494, 1);
            WriteAttributeValue("", 480, 
#nullable restore
#line 12 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\SlideList\Default.cshtml"
                               item.ImageUrl

#line default
#line hidden
#nullable disable
            , 480, 14, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 495, "\"", 501, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n");
#nullable restore
#line 14 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Shared\Components\SlideList\Default.cshtml"
               }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"            </div>
            <div class=""d-flex py-4"">
                <div class=""preview-list w-100"">
                    <div class=""preview-item p-0"">
                  
                        <div class=""preview-item-content d-flex flex-grow"">
                            <div class=""flex-grow"">
                                <div class=""d-flex d-md-block d-xl-flex justify-content-between"">
                                    <h6 class=""preview-subject"">Projeler</h6>
                                    <p class=""text-muted text-small""></p>
                                </div>
                                <p class=""text-muted"">Geliştirilen Projelerin Önizlemesi</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <div class=""progress progress-md portfolio-progress"">
                <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 90%"" aria-valuenow=");
            WriteLiteral("\"90\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portofolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591