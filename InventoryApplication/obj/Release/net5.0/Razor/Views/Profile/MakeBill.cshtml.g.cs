#pragma checksum "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3736a7b97db88d344d7cc1661b1d12f7ee55310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MakeBill), @"mvc.1.0.view", @"/Views/Profile/MakeBill.cshtml")]
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
#line 1 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\_ViewImports.cshtml"
using InventoryApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\_ViewImports.cshtml"
using InventoryApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3736a7b97db88d344d7cc1661b1d12f7ee55310", @"/Views/Profile/MakeBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c30774534925ddac6bcaec96927044b594d12ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_MakeBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryApplication.ViewModel.BillGenerateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
  
    //ViewData["Title"] = "MakeBill";
    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"billContent\">\r\n    <h2 class=\"DevFontFormLabel\" style=\"margin-left:48%;\">,f\"VesV fcy</h2>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3736a7b97db88d344d7cc1661b1d12f7ee553104103", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 11 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-lg-12\">\r\n                    <div style=\"margin-left:85%;\"><label class=\"control-label \"><span class=\"DevFont\">ferh%</span> ");
#nullable restore
#line 14 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                                                                                              Write(Model.BillDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                    <label class=\"control-label\"><span class=\"DevFont\">fcy uks%</span> ");
#nullable restore
#line 15 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                                                                  Write(Model.BillNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </label>\r\n\r\n                </div>\r\n                <div class=\"form-group col-sm-12\">\r\n                    <label class=\"control-label\"> Id: ");
#nullable restore
#line 19 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                                 Write(Model.ProfileId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <br />\r\n                <div class=\"form-group col-sm-12\">\r\n                    <label class=\"control-label DevFont\"> uke% ");
#nullable restore
#line 23 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                                          Write(Model.ProfileName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                </div>\r\n                <div class=\"table-responsive\">\r\n                    <table class=\"table table-striped\"");
            BeginWriteAttribute("id", " id=\"", 1213, "\"", 1218, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <thead class=""bg-cyan"">
                            <tr>
                                <th>
                                    Id
                                </th>
                                <th>
                                    <span class=""DevFontNavBar"">izks&lt;DV</span> Id
                                </th>
                                <th class=""DevFontNavBar"">
                                    uke
                                </th>
                                <th class=""DevFontNavBar"">
                                    rkSy
                                </th>
                                <th class=""DevFontNavBar"">
                                    ek=k
                                </th>
                                <th class=""DevFontNavBar"">
                                    tEek
                                </th>
                            </tr>
                        </thead>
                        <t");
            WriteLiteral("body>\r\n");
#nullable restore
#line 50 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                             foreach (var item in Model.BillItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"DevFontTableRow\">\r\n                                        ");
#nullable restore
#line 54 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"DevFontTableRow\">\r\n                                        ");
#nullable restore
#line 57 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ProductId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"DevFontTableRow\">\r\n                                        ");
#nullable restore
#line 60 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 63 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 66 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
#nullable restore
#line 69 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                          
                                            var total = item.Quantity * item.Rate;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 71 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                             Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <label class=\"control-label\" style=\"margin-left:85%\"> Total: ");
#nullable restore
#line 79 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
                                                                            Write(Model.BillItems.Sum(i => i.Quantity * i.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input id=\"btnPrint\" type=\"button\" value=\"Print\" class=\"btn btn-primary\" onclick=\"printBill()\" />\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 89 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\MakeBill.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral(@"<script>
    function printBill() {
        var billContents = document.getElementById(""billContent"").innerHTML;
        var printablePage = window.open('', '', 'height=1000, width=1000');
        printablePage.document.write('<html><body><div style=""margin-right:10%;margin-left:10%; "">');
        printablePage.document.write('<link href=""/font/Fonts.css"" rel=""stylesheet"" type=""text/css"" />');
        printablePage.document.write('<link href=""/lib/bootstrap/dist/css/bootstrap.css"" rel=""stylesheet"" type=""text/css"" />');
        printablePage.document.write('<link href=""/lib/bootstrap/dist/css/bootstrap-grid.css"" rel=""stylesheet"" type=""text/css"" />');
        printablePage.document.write('<link href=""/lib/bootstrap/dist/css/bootstrap-reboot.css"" rel=""stylesheet"" type=""text/css"" />');
        printablePage.document.write(billContents);
        printablePage.document.write('</div></body></html>');
        printablePage.document.close();
        printablePage.focus();
        setTimeout(function () { ");
            WriteLiteral("printablePage.print(); }, 2000);\r\n        /*window.print();*/\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryApplication.ViewModel.BillGenerateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
