#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40b454b3dfcb5ebb1cd2ad6054e9400524568e466d24c2a55d202d053ccea326"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_ContactList), @"mvc.1.0.view", @"/Views/Contact/ContactList.cshtml")]
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
#line 1 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
 using EntityLayer.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"40b454b3dfcb5ebb1cd2ad6054e9400524568e466d24c2a55d202d053ccea326", @"/Views/Contact/ContactList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"787958262aadd210dddb2dcaab50a14c33d3fc73930321359c920451152ee33d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_ContactList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
  
    ViewData["Title"] = "ContactList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""card"">
    <!-- Card header -->
    <div class=""card-header border-0"">
        <h3 class=""mb-0"">Siteden Gelen İletişim Mesajlar</h3>
    </div>
    <!-- Light table -->
    <div class=""table-responsive"">
        <table class=""table align-items-center table-flush"">
            <thead class=""thead-light"">
                <tr>
                    <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                    <th scope=""col"" class=""sort"" data-sort=""budget"">Kimden</th>
                    <th scope=""col"" class=""sort"" data-sort=""status"">Tarih</th>
                    <th scope=""col"">Sil</th>
                    <th scope=""col"" class=""sort"" data-sort=""completion"">Mesajı Oku</th>
                    <th scope=""col""></th>
                </tr>
            </thead>

            <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
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
#line 35 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
                                                                     item.MessageId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                        </th>\r\n\r\n                        <td class=\"budget\">");
            Write(
#nullable restore
#line 40 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
                                            item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" </td>\r\n\r\n                        <td>\r\n                            <div class=\"d-flex align-items-center\">\r\n                                <span class=\"completion mr-2\">");
            Write(
#nullable restore
#line 44 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
                                                               item.Date

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                                <div>\r\n                                    \r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1918, "\"", 1963, 2);
            WriteAttributeValue("", 1925, "/Contact/DeleteMessage/", 1925, 23, true);
            WriteAttributeValue("", 1948, 
#nullable restore
#line 51 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
                                                             item.MessageId

#line default
#line hidden
#nullable disable
            , 1948, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2032, "\"", 2084, 2);
            WriteAttributeValue("", 2039, "/Contact/ContactMessageDetail/", 2039, 30, true);
            WriteAttributeValue("", 2069, 
#nullable restore
#line 52 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
                                                                    item.MessageId

#line default
#line hidden
#nullable disable
            , 2069, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Mesajı Oku</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "C:\Projeler\YucedagUdemy\YucedagUdemy\Views\Contact\ContactList.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        <br />\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591