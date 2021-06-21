#pragma checksum "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f169a9d371e70d39b0ce19f4943a7d72609781fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
#line 1 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
using Spice.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f169a9d371e70d39b0ce19f4943a7d72609781fd", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d11972dba3ccf0da976b184cdef3b810ef5472", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Spice.TagHelpers.PageLinkTagHelper __Spice_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container shadow p-3 bg-white"">
    <div class=""row"">
        <div class=""col-6"">
            <h2 class=""text-info"">Order History</h2>
        </div>
        <div class=""col-6 text-right"">
            
        </div>
    </div>
    <br />
    <div>
");
#nullable restore
#line 18 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if (Model.Orders.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>");
#nullable restore
#line 22 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 23 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 24 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 25 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                   Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Total Items</th>\r\n                    <th></th>\r\n                </tr>\r\n");
#nullable restore
#line 30 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                 foreach (var item in Model.Orders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 33 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 35 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.PickupTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 38 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                       Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            <button type=\"submit\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 41 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                           Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                <span class=\"far fa-list-alt\"></span> Details\r\n                            </button>\r\n");
#nullable restore
#line 44 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                             if (item.OrderHeader.Status == StaticDetails.StatusSubmitted || item.OrderHeader.Status == StaticDetails.StatusInProcess || item.OrderHeader.Status == StaticDetails.StatusCompleted || item.OrderHeader.Status == StaticDetails.StatusReady)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"submit\" class=\"btn btn-info anchorStatus\" data-id=\"");
#nullable restore
#line 46 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                            Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                                    <span class=\"far fa-clock\"></span> Status\r\n                                </button>\r\n");
#nullable restore
#line 49 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f169a9d371e70d39b0ce19f4943a7d72609781fd11456", async() => {
            }
            );
            __Spice_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Spice.TagHelpers.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Spice_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 54 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Spice_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Spice_TagHelpers_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Spice_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Spice_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Spice_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <br />\r\n");
#nullable restore
#line 57 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No Place order first.</p>\r\n");
#nullable restore
#line 61 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-contered modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class=""modal-title"">Order Details</h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myModelContent"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""myOrderModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-contered modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light justify-content-center"">
                <h5 class");
            WriteLiteral(@"=""modal-title"">Order Status</h5>
            </div>
            <div class=""modal-body justify-content-center"" id=""myOrderModalContent"">

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" style=""width:20%"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        var PostBackUrl = ""/Customer/Order/GetOrderDetails"";
        var OrderStatusURL = '/Customer/Order/GetOrderStatus';
        $(function () {
            $("".anchorDetail"").click(function () {
                var $buttonClicked = $(this);
                var id = $buttonClicked.attr(""data-id"");
                $.ajax({
                    type: ""GET"",
                    url: PostBackUrl,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    catch: false,
                    dataType: ""html"",
                    success: function (data) {
                        $(""#myModelContent"").html(data);
                        $(""#myModal"").modal(""show"");
                    },
                    error: function (jqXHR, error, errorThrown) {
                        console.log(jqXHR);
                        if (jqXHR.status && jqXHR.status == 500)
                            alert(jqXHR.responseText)");
                WriteLiteral(@";
                        else
                            alert(""Dynamic content load failed"");
                    }
                });
            });
            $("".anchorStatus"").click(function () {
                var $buttonClicked = $(this);
                var id = $buttonClicked.attr(""data-id"");
                $.ajax({
                    type: ""GET"",
                    url: OrderStatusURL,
                    contentType: ""application/json; charset=utf-8"",
                    data: { ""Id"": id },
                    catch: false,
                    dataType: ""html"",
                    success: function (data) {
                        $(""#myOrderModalContent"").html(data);
                        $(""#myOrderModal"").modal(""show"");
                    },
                    error: function (jqXHR, error, errorThrown) {
                        console.log(jqXHR);
                        if (jqXHR.status && jqXHR.status == 500)
                            alert(jqXHR.response");
                WriteLiteral("Text);\r\n                        else\r\n                            alert(\"Dynamic content load failed\");\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
