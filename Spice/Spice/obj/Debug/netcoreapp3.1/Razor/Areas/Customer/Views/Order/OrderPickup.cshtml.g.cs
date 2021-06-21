#pragma checksum "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c0954f9141a73bf65a704edd687252ae03e203"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderPickup), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderPickup.cshtml")]
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
#line 2 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
using Spice.Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c0954f9141a73bf65a704edd687252ae03e203", @"/Areas/Customer/Views/Order/OrderPickup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6d11972dba3ccf0da976b184cdef3b810ef5472", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderPickup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Spice.TagHelpers.PageLinkTagHelper __Spice_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
  
    ViewData["Title"] = "OrderPickup";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c0954f9141a73bf65a704edd687252ae03e2035400", async() => {
                WriteLiteral(@"
    <div class=""container shadow p-3 bg-white rounded"">
        <h2 class=""text-info"">Order Ready for Pickup: </h2>
        <div class=""container border border-secondary"">
            <div class=""row container py-2"">
                <div class=""col-11"">
                    <div class=""row"">
                        <div class=""col-4"">
                            ");
#nullable restore
#line 15 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.Editor("searchName", new { htmlAttributes = new { @class = "form-control", @placeholder = "Name..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            ");
#nullable restore
#line 18 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.Editor("searchPhone", new { htmlAttributes = new { @class = "form-control", @placeholder = "Phone..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-4\">\r\n                            ");
#nullable restore
#line 21 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.Editor("searchEmail", new { htmlAttributes = new { @class = "form-control", @placeholder = "Email..." } }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-1"">
                    <button type=""submit"" class=""btn btn-info form-control"">
                        <span class=""fas fa-search""></span>
                    </button>
                </div>
            </div>
        </div>
        <br />
        <div>
");
#nullable restore
#line 34 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
             if (Model.Orders.Count() > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <table class=\"table table-striped border\">\r\n                    <tr class=\"table-secondary\">\r\n                        <th>");
#nullable restore
#line 38 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 39 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 40 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 41 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.PickupTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 42 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                       Write(Html.DisplayNameFor(m => m.Orders[0].OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                        <th>Total Items</th>\r\n                        <th></th>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                     foreach (var item in Model.Orders)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 49 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 50 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 52 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.PickupTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 53 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 54 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                           Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 57 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                                                                                               Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-toggle=\"modal\">\r\n                                    <span class=\"far fa-list-alt\"></span> Details\r\n                                </button>\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </table>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c0954f9141a73bf65a704edd687252ae03e20312921", async() => {
                }
                );
                __Spice_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::Spice.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__Spice_TagHelpers_PageLinkTagHelper);
#nullable restore
#line 65 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
__Spice_TagHelpers_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Spice_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 65 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
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
                WriteLiteral("\r\n                <br />\r\n");
#nullable restore
#line 68 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>No new pickup orders in database.</p>\r\n");
#nullable restore
#line 72 "E:\DotNetProject\Spice\Spice\Areas\Customer\Views\Order\OrderPickup.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog-contered modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header bg-success text-light"">
                <div class=""col-10 offset-1"">
                    <center>
                        <h5 class=""modal-title"">Order Details</h5>
                    </center>
                </div>
                <div class=""col-1"">
                    <button type=""button"" class=""float-right btn-outline-secondary close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span");
            BeginWriteAttribute("class", " class=\"", 4401, "\"", 4409, 0);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-body justify-content-center\" id=\"myModelContent\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var PostBackUrl = ""/Customer/Order/GetOrderDetails"";
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
                            alert(jqXHR.responseText);
                        else
                            alert");
                WriteLiteral("(\"Dynamic content load failed\");\r\n                    }\r\n                });\r\n            });\r\n\r\n        });\r\n    </script>\r\n");
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