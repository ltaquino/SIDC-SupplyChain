#pragma checksum "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3b9d8d480c1289302d2231b2923ee95d127e302"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User__ViewAll), @"mvc.1.0.view", @"/Areas/Admin/Views/User/_ViewAll.cshtml")]
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
#line 1 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
using SIDCSupplyChain.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b9d8d480c1289302d2231b2923ee95d127e302", @"/Areas/Admin/Views/User/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aff81ee7fae56724aa0d185337a9438df85b890", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_User__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-profile rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 75px;width:75px;object-fit: cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default-user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right:16px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\" id=\"userTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
           Write(localizer["User"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
           Write(localizer["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
           Write(localizer["Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width:10%\">\r\n                ");
#nullable restore
#line 16 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
           Write(localizer["Actions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 26 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                         if (@user.ProfilePicture != null && user.ProfilePicture.Length > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm\" style=\" max-width: 80px;margin-right: 20px;\">\r\n                                <img class=\"img-profile rounded-circle\" style=\"height: 75px;width:75px;object-fit: cover;\"");
            BeginWriteAttribute("src", " src=\"", 985, "\"", 1058, 2);
            WriteAttributeValue("", 991, "data:image/*;base64,", 991, 20, true);
#nullable restore
#line 29 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
WriteAttributeValue("", 1011, Convert.ToBase64String(@user.ProfilePicture), 1011, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 31 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                        }
                        else

                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-sm\" style=\"max-width:80px; margin-right: 20px;\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e3b9d8d480c1289302d2231b2923ee95d127e30211157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 38 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm\">\r\n                            <a>\r\n                                ");
#nullable restore
#line 41 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                            <br>\r\n                            <small>\r\n                                ");
#nullable restore
#line 45 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                           Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </small>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n                <td>\r\n                    <a>\r\n                        ");
#nullable restore
#line 52 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                   Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <br>\r\n                    <small>\r\n");
#nullable restore
#line 56 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                         if (user.EmailConfirmed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-success\">");
#nullable restore
#line 58 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                         Write(localizer["Email Confirmed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-danger\">");
#nullable restore
#line 62 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                        Write(localizer["Email Not Confirmed"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 63 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </small>\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 67 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                     if (user.IsActive)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-success\">");
#nullable restore
#line 69 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                     Write(localizer["Active"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 70 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-danger\">");
#nullable restore
#line 73 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                    Write(localizer["Deactivated"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 74 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </td>
                <td>
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default dropdown-toggle"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Action
                        </button>
                        <div class=""dropdown-menu shadow animated--grow-in"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3b9d8d480c1289302d2231b2923ee95d127e30218090", async() => {
                WriteLiteral("\r\n                                <i class=\"fas fa-user\"></i> ");
#nullable restore
#line 83 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                       Write(localizer["Profile"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                                                                       WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3b9d8d480c1289302d2231b2923ee95d127e30221153", async() => {
                WriteLiteral("\r\n                                <i class=\"fas fa-wrench\"></i> ");
#nullable restore
#line 86 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                         Write(localizer["Manage Roles"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
                                                                                                            WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 92 "D:\Work\SIDC\LSE 2021\Practices\AspNet\SIDCSupplyChain\SIDCSupplyChain.Web\Areas\Admin\Views\User\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\"#userTable\").DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591