#pragma checksum "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6b58549c71239b638d4a3f3037f27540fb0546"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee6b58549c71239b638d4a3f3037f27540fb0546", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c30774534925ddac6bcaec96927044b594d12ee", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventoryApplication.ViewModel.ProfileIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
  
    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styling", async() => {
                WriteLiteral("\r\n    <style>\r\n        #navigationProfile {\r\n            background-color: silver;\r\n            color: black;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6b58549c71239b638d4a3f3037f27540fb05464726", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6b58549c71239b638d4a3f3037f27540fb05465785", async() => {
                WriteLiteral("\r\n    <h3 class=\"DevFontFormLabel\" style=\"margin-left:46%; font-weight:bold\">izksQkby</h3>\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6b58549c71239b638d4a3f3037f27540fb05466158", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </p>
    <div class=""table-responsive"">
        <table class=""table table-striped"" id=""dataTableImplement"">
            <thead class=""bg-cyan"">
                <tr>
                    <th>
                        Id
                    </th>
                    <th class=""DevFontNavBar"">
                        uke
                    </th>
                    <th class=""DevFontNavBar"">
                        Qksu
                    </th>
                    <th class=""DevFontNavBar"">
                        &lt;sxkuk
                    </th>
                    <th class=""DevFontNavBar"">
                        dEiuh
                    </th>
                    <th class=""DevFontNavBar"">
                        dk;Z
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 53 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                 if (Model.Profiles.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                     foreach (var item in Model.Profiles)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr class=\"DevFontTableRow\">\r\n                            <td>\r\n                                ");
#nullable restore
#line 59 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 62 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 65 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Contact));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 68 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 71 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td id=\"notUseDevFont\">\r\n                                ");
#nullable restore
#line 74 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.ActionLink("Sale", "Sale", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
#nullable restore
#line 75 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                     

                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"6\" class=\"text-center\">No Record Found!</td>\r\n                    </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Bishal Gautam\source\repos\InventoryApplication\InventoryApplication\Views\Profile\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryApplication.ViewModel.ProfileIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
