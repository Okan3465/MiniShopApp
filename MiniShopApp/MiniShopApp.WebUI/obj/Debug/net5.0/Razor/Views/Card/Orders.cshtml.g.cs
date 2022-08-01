#pragma checksum "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "004e0c4802493bb850e1d803ab3ad2a855d43923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Card_Orders), @"mvc.1.0.view", @"/Views/Card/Orders.cshtml")]
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
#line 2 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"004e0c4802493bb850e1d803ab3ad2a855d43923", @"/Views/Card/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35c9e85769d47bd0cf7187da04d9af312a57049f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Card_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderListModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("20"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h6 class=\"display-4\">Orders</h6>\n<hr />\n");
#nullable restore
#line 4 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-sm table-bordered\">\n        <thead>\n            <tr class=\"table-danger\">\n                <th colspan=\"2\">Order Number: #");
#nullable restore
#line 9 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                          Write(order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | Order Date: ");
#nullable restore
#line 9 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                                           Write(order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>Price</th>\n                <th>Quantity</th>\n                <th>Total</th>\n            </tr>\n        </thead>\n\n        <tbody>\n");
#nullable restore
#line 17 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
             foreach (var orderItem in order.OrderItems)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td width=\"25\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "004e0c4802493bb850e1d803ab3ad2a855d439236664", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 617, "~/img/", 617, 6, true);
#nullable restore
#line 21 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
AddHtmlAttributeValue("", 623, orderItem.ImageUrl, 623, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                    <td>");
#nullable restore
#line 23 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                   Write(orderItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td width=\"100\">");
#nullable restore
#line 24 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                               Write(orderItem.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td width=\"20\">");
#nullable restore
#line 25 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                              Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td width=\"150\">");
#nullable restore
#line 26 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                Write((orderItem.Price*orderItem.Quantity).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 28 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <table class=\"table table-sm table-bordered mb-3\">\n        <tfoot>\n            <tr>\n                <td colspan=\"2\"><span class=\"text-danger\">Customer Name: </span>");
#nullable restore
#line 34 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                                           Write(order.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                                                            Write(order.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td rowspan=\"4\" width=\"150\">Total: ");
#nullable restore
#line 35 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                              Write(order.TotalPrice().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td><span class=\"text-danger\">Customer Address: </span>");
#nullable restore
#line 39 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                                  Write(order.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><span class=\"text-danger\">Customer City: </span>");
#nullable restore
#line 40 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                               Write(order.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td><span class=\"text-danger\">Customer Phone: </span>");
#nullable restore
#line 44 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                                Write(order.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><span class=\"text-danger\">Customer Email: </span>");
#nullable restore
#line 45 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                                Write(order.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n\n            <tr>\n                <td><span class=\"text-danger\">Order Status: </span>");
#nullable restore
#line 49 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                              Write(order.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><span class=\"text-danger\">Payment Type: </span>");
#nullable restore
#line 50 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
                                                              Write(order.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n\n        </tfoot>\n    </table>\n");
#nullable restore
#line 55 "C:\Users\hp\Desktop\Web_6_Projects-Validation\Week_14\MiniShopApp\MiniShopApp.WebUI\Views\Card\Orders.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderListModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
