#pragma checksum "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5a6aa442b19b862e6e70ab212f8ff94ccaee75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Index), @"mvc.1.0.view", @"/Views/Bill/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5a6aa442b19b862e6e70ab212f8ff94ccaee75", @"/Views/Bill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c30774534925ddac6bcaec96927044b594d12ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryApplication.ViewModel.BillIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
  
    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styling", async() => {
                WriteLiteral("\r\n    <style>\r\n        #navigationBill {\r\n            background-color: silver;\r\n            color: black;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral(@"<h3 class=""DevFontFormLabel""style=""margin-left:46%; font-weight:bold"">
    fcy fooj.k
</h3>
<hr>
<div class=""table-responsive "">
    <table class=""table"" id=""dataTableImplement"">
        <thead class=""bg-cyan"">
            <tr>
                <th>
                    Id
                </th>
                <th>
                    <span class=""DevFontNavBar"">izksQkby</span> Id
                </th>
                <th class=""DevFontNavBar"">
                    uke
                </th>
                <th class=""DevFontNavBar"">
                    ferh
                </th>

                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 41 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
             foreach (var item in Model.Bills)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProfileId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"DevFontTableRow\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Profile.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.BillDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 59 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
                   Write(Html.ActionLink("Print", "Print", new { id = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Bill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryApplication.ViewModel.BillIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
