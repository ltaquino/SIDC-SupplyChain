#pragma checksum "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4852c183e680d29e2a8a0c82b746eda42d41fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Catalog_Views_Brand__ViewAll), @"mvc.1.0.view", @"/Areas/Catalog/Views/Brand/_ViewAll.cshtml")]
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
#line 1 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using SIDCSupplyChain.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using SIDCSupplyChain.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using SIDCSupplyChain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using SIDCSupplyChain.Application.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
using SIDCSupplyChain.Web.Areas.Catalog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4852c183e680d29e2a8a0c82b746eda42d41fc", @"/Areas/Catalog/Views/Brand/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aff81ee7fae56724aa0d185337a9438df85b890", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Catalog_Views_Brand__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BrandViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brand", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OnPostDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return jQueryModalDelete(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<table id=\"brandTable\" class=\"table table-striped\" width=\"100%\" cellspacing=\"0\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>Tax</th>\r\n            <th>Description</th>\r\n");
#nullable restore
#line 10 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Delete)).Result.Succeeded
             || (AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Edit)).Result.Succeeded)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>Actions</th>\r\n");
#nullable restore
#line 14 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 19 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
         foreach (var brand in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
           Write(brand.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 34 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Delete)).Result.Succeeded || (AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Edit)).Result.Succeeded)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <td text-right"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Action
                        </button>
                        <div class=""dropdown-menu shadow animated--grow-in"">
");
#nullable restore
#line 42 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Edit)).Result.Succeeded)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1735, "\"", 1821, 4);
            WriteAttributeValue("", 1745, "jQueryModalGet(\'/catalog/brand/OnGetCreateOrEdit?id=", 1745, 52, true);
#nullable restore
#line 44 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
WriteAttributeValue("", 1797, brand.Id, 1797, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1806, "\',\'Edit", 1806, 7, true);
            WriteAttributeValue(" ", 1813, "Brand\')", 1814, 8, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\"><i class=\"fas fa-pencil-alt\"></i>  Edit</a>\r\n");
#nullable restore
#line 45 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"

                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                             if ((AuthorizationService.AuthorizeAsync(User, Permissions.Brands.Delete)).Result.Succeeded)

                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4852c183e680d29e2a8a0c82b746eda42d41fc11575", async() => {
                WriteLiteral("\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2333, "\"", 2388, 3);
                WriteAttributeValue("", 2340, "javascript:$(\'#form_delete_", 2340, 27, true);
#nullable restore
#line 51 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
WriteAttributeValue("", 2367, brand.Id, 2367, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2376, "\').submit();", 2376, 12, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"dropdown-item\"><i class=\"fas fa-trash-alt\"></i>  Delete</a>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2121, "form_delete_", 2121, 12, true);
#nullable restore
#line 50 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
AddHtmlAttributeValue("", 2133, brand.Id, 2133, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                                                                                                                                                     WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </td>\r\n");
#nullable restore
#line 57 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 59 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Catalog\Views\Brand\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#brandTable\").DataTable();\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BrandViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
