#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f60dac42edcdeb61926a69c723296364e046a5b96cbf617f3a4fe33e6595f3e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Dashboard/Index.cshtml")]
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
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f60dac42edcdeb61926a69c723296364e046a5b96cbf617f3a4fe33e6595f3e5", @"/Areas/Writer/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e81768843398fd53631da76235c7609d2b1e1695adfaa07fec63f3f3f2381278", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-xl-6 col-md-6\">\r\n        <div class=\"card card-stats\">\r\n            <h1>Merhaba ");
            Write(
#nullable restore
#line 9 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
                         ViewBag.N

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@" !</h1>
            <h4>Asp.Net Core Yazar Panelindesin. Duyuruları Okumak İçin <span class=""text-primary""><a href=""/Writer/Default/Index/"">Hemen Tıkla !</a></span></h4>
        </div>
    </div>
    <div class=""col-xl-6 col-md-6"">
        <div class=""card card-stats"">
            <h1>Tarih</h1>
            <h3>");
            Write(
#nullable restore
#line 16 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
                 DateTime.Today.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h3>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-xl-3 col-md-6"">
        <div class=""card card-stats"">
            <!-- Card body -->
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col"">
                        <h5 class=""card-title text-uppercase text-muted mb-0"">Hava Durumu</h5>
                        <span class=""h2 font-weight-bold mb-0"" id=""city-name"">Istanbul, TR</span>
                        <div class=""mt-2"">
                            <span class=""h3 font-weight-bold"" id=""temperature"">");
            Write(
#nullable restore
#line 31 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                ViewBag.w

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@" °C</span>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <div class=""icon icon-shape bg-gradient-blue text-white rounded-circle shadow"">
                            <i class=""ni ni-umbrella-13""></i>
                        </div>
                    </div>
                </div>   
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card card-stats"">
            <!-- Card body -->
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col"">
                        <h5 class=""card-title text-uppercase text-muted mb-0"">Mesajlar</h5>
                        <span class=""h2 font-weight-bold mb-0"">Gelen</span>
                        <div class=""mt-2"">
                            <span class=""h3 font-weight-bold"">");
            Write(
#nullable restore
#line 52 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                               ViewBag.d1

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <div class=""icon icon-shape bg-gradient-green text-white rounded-circle shadow"">
                            <i class=""ni ni-email-83""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card card-stats"">
            <!-- Card body -->
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col"">
                        <h5 class=""card-title text-uppercase text-muted mb-0"">Duyurular</h5>
                        <span class=""h2 font-weight-bold mb-0"">Tümü</span>
                        <div class=""mt-2"">
                            <span class=""h3 font-weight-bold"">");
            Write(
#nullable restore
#line 73 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                               ViewBag.d2

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <div class=""icon icon-shape bg-gradient-purple text-white rounded-circle shadow"">
                            <i class=""ni ni-bell-55""></i>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6"">
        <div class=""card card-stats"">
            <!-- Card body -->
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col"">
                        <h5 class=""card-title text-uppercase text-muted mb-0"">Üye Sayısı</h5>
                        <span class=""h2 font-weight-bold mb-0"">Toplam</span>
                        <div class=""mt-2"">
                            <span class=""h3 font-weight-bold"">");
            Write(
#nullable restore
#line 94 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                               ViewBag.d3

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</span>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <div class=""icon icon-shape bg-gradient-yellow text-white rounded-circle shadow"">
                            <i class=""ni ni-chart-bar-32""></i>
                        </div>
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
