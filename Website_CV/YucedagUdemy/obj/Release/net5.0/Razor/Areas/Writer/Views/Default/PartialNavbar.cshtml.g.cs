#pragma checksum "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Default\PartialNavbar.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3e1b7c4e9d77aba4898fec579ebe44f022162d61e67c0063eb3588dc86f98f04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Default_PartialNavbar), @"mvc.1.0.view", @"/Areas/Writer/Views/Default/PartialNavbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3e1b7c4e9d77aba4898fec579ebe44f022162d61e67c0063eb3588dc86f98f04", @"/Areas/Writer/Views/Default/PartialNavbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e81768843398fd53631da76235c7609d2b1e1695adfaa07fec63f3f3f2381278", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Default_PartialNavbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-search navbar-search-light form-inline mr-sm-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-search-main"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<nav class=\"navbar navbar-top navbar-expand navbar-dark bg-primary border-bottom\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\">\r\n            <!-- Search form -->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e1b7c4e9d77aba4898fec579ebe44f022162d61e67c0063eb3588dc86f98f044180", async() => {
                WriteLiteral(@"
                <div class=""form-group mb-0"">
                    <div class=""input-group input-group-alternative input-group-merge"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text""><i class=""fas fa-search""></i></span>
                        </div>
                        <input class=""form-control"" placeholder=""Search"" type=""text"">
                    </div>
                </div>
                <button type=""button"" class=""close"" data-action=""search-close"" data-target=""#navbar-search-main"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <!-- Navbar links -->
            <ul class=""navbar-nav align-items-center  ml-md-auto "">
                <li class=""nav-item d-xl-none"">
                    <!-- Sidenav toggler -->
                    <div class=""pr-3 sidenav-toggler sidenav-toggler-dark"" data-action=""sidenav-pin"" data-target=""#sidenav-main"">
                        <div class=""sidenav-toggler-inner"">
                            <i class=""sidenav-toggler-line""></i>
                            <i class=""sidenav-toggler-line""></i>
                            <i class=""sidenav-toggler-line""></i>
                        </div>
                    </div>
                </li>
                <li class=""nav-item d-sm-none"">
                    <a class=""nav-link"" href=""#"" data-action=""search-show"" data-target=""#navbar-search-main"">
                        <i class=""ni ni-zoom-split-in""></i>
                    </a>
                </li>
                ");
            Write(
#nullable restore
#line 35 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Default\PartialNavbar.cshtml"
                 await Component.InvokeAsync("NotificationList")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
                <li class=""nav-item dropdown"">
                    <a class=""nav-link"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""ni ni-ungroup""></i>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-dark bg-default  dropdown-menu-right "">
                        <div class=""row shortcuts px-4"">
                            <a href=""#!"" class=""col-4 shortcut-item"">
                                <span class=""shortcut-media avatar rounded-circle bg-gradient-red"">
                                    <i class=""ni ni-calendar-grid-58""></i>
                                </span>
                                <small>Calendar</small>
                            </a>
                            <a href=""#!"" class=""col-4 shortcut-item"">
                                <span class=""shortcut-media avatar rounded-circle bg-gradient-orange"">
                               ");
            WriteLiteral(@"     <i class=""ni ni-email-83""></i>
                                </span>
                                <small>Email</small>
                            </a>
                            <a href=""#!"" class=""col-4 shortcut-item"">
                                <span class=""shortcut-media avatar rounded-circle bg-gradient-info"">
                                    <i class=""ni ni-credit-card""></i>
                                </span>
                                <small>Payments</small>
                            </a>
                            <a href=""#!"" class=""col-4 shortcut-item"">
                                <span class=""shortcut-media avatar rounded-circle bg-gradient-green"">
                                    <i class=""ni ni-books""></i>
                                </span>
                                <small>Reports</small>
                            </a>
                            <a href=""#!"" class=""col-4 shortcut-item"">
                                <span cla");
            WriteLiteral(@"ss=""shortcut-media avatar rounded-circle bg-gradient-purple"">
                                    <i class=""ni ni-pin-3""></i>
                                </span>
                                <small>Maps</small>
                            </a>
                            <a href=""#!"" class=""col-4 shortcut-item"">
                                <span class=""shortcut-media avatar rounded-circle bg-gradient-yellow"">
                                    <i class=""ni ni-basket""></i>
                                </span>
                                <small>Shop</small>
                            </a>
                        </div>
                    </div>
                </li>
            </ul>
            <ul class=""navbar-nav align-items-center  ml-auto ml-md-0 "">
                <li class=""nav-item dropdown"">
                    <a class=""nav-link pr-0"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        ");
            Write(
#nullable restore
#line 85 "C:\Projeler\YucedagUdemy\YucedagUdemy\Areas\Writer\Views\Default\PartialNavbar.cshtml"
                         await Component.InvokeAsync("NavbarProfile")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"
                    </a>
                    <div class=""dropdown-menu  dropdown-menu-right "">
                        <div class=""dropdown-header noti-title"">
                            <h6 class=""text-overflow m-0"">Welcome!</h6>
                        </div>
                        <a href=""#!"" class=""dropdown-item"">
                            <i class=""ni ni-single-02""></i>
                            <span>My profile</span>
                        </a>
                        <a href=""#!"" class=""dropdown-item"">
                            <i class=""ni ni-settings-gear-65""></i>
                            <span>Settings</span>
                        </a>
                        <a href=""#!"" class=""dropdown-item"">
                            <i class=""ni ni-calendar-grid-58""></i>
                            <span>Activity</span>
                        </a>
                        <a href=""#!"" class=""dropdown-item"">
                            <i class=""ni ni-support-16""></i>
      ");
            WriteLiteral(@"                      <span>Support</span>
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a href=""/Writer/Login/LogOut"" class=""dropdown-item"">
                            <i class=""ni ni-user-run""></i>
                            <span>Çıkış Yap</span>
                        </a>
                    </div>
                </li>
            </ul>
        </div>
    </div>
</nav>
");
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
