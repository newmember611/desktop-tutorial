#pragma checksum "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dae02bc7f701baef8fa7799d5ca7e9d475fff11e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Shop), @"mvc.1.0.view", @"/Views/Home/Shop.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\_ViewImports.cshtml"
using DoAn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae02bc7f701baef8fa7799d5ca7e9d475fff11e", @"/Views/Home/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a83c55cd82221897cc1898333fffa30a9b06739", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoAn.Areas.Admin.Models.DienThoaiModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""header-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""user-menu"">
                    <ul style=""text-align:justify"">
                        <li class=""col-md-3"" style=""text-align:center"">");
#nullable restore
#line 22 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                                                  Write(Html.ActionLink("SAMSUNG", "Shop", "Home", new { MaDT = "SAM" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"col-md-3\" style=\"text-align:center\">");
#nullable restore
#line 23 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                                                  Write(Html.ActionLink("IPHONE", "Shop", "Home", new { MaDT = "APP" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"col-md-3\" style=\"text-align:center\">");
#nullable restore
#line 24 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                                                  Write(Html.ActionLink("NOKIA", "Shop", "Home", new { MaDT = "NOK" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"col-md-3\" style=\"text-align:center\">");
#nullable restore
#line 25 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                                                  Write(Html.ActionLink("OPPO", "Shop", "Home", new { MaDT = "OPP" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div> \r\n\r\n\r\n<div class=\"single-product-area\">\r\n    <div class=\"zigzag-bottom\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n\r\n");
#nullable restore
#line 41 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-3 col-sm-6\">\r\n                    <div class=\"single-shop-product\">\r\n                        <div class=\"product-upper\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dae02bc7f701baef8fa7799d5ca7e9d475fff11e6226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1650, "~/ImgDT/", 1650, 8, true);
#nullable restore
#line 46 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
AddHtmlAttributeValue("", 1658, Html.DisplayFor(modelItem => item.Hinh), 1658, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <h2><a");
            BeginWriteAttribute("href", " href=\"", 1771, "\"", 1778, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.TenDongDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                        <div class=\"product-carousel-price\">\r\n");
#nullable restore
#line 50 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                             if (item.GiaKM != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ins>");
#nullable restore
#line 52 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                Write(Html.DisplayFor(modelItem => item.GiaKM));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins> <del>");
#nullable restore
#line 52 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 53 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ins class=\"ful\">");
#nullable restore
#line 56 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.DonGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins>\r\n");
#nullable restore
#line 57 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <div class=""product-option-shop"">
                            <a class=""add_to_cart_button"" data-quantity=""1"" data-product_sku="""" data-product_id=""70"" rel=""nofollow"" href=""/canvas/shop/?add-to-cart=70"">Add to cart</a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 66 "D:\Nam3-HK1\ASP.NET\DoAn\desktop-tutorial\DoAnASP.NET25112020\DoAn\DoAn\Views\Home\Shop.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"            </div>

        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-pagination text-center"">
                    <nav>
                        <ul class=""pagination"">
                            <li>
                                <a href=""#"" aria-label=""Previous"">
                                    <span aria-hidden=""true"">&laquo;</span>
                                </a>
                            </li>
                            <li><a href=""#"">1</a></li>
                            <li><a href=""#"">2</a></li>
                            <li><a href=""#"">3</a></li>
                            <li><a href=""#"">4</a></li>
                            <li><a href=""#"">5</a></li>
                            <li>
                                <a href=""#"" aria-label=""Next"">
                                    <span aria-hidden=""true"">&raquo;</span>
                                </a>
                            </li>
                    ");
            WriteLiteral("    </ul>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoAn.Areas.Admin.Models.DienThoaiModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
