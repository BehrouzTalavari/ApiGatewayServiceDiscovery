#pragma checksum "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b772289ff89ed0910480069349a3dce6da44f20a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grants_Index), @"mvc.1.0.view", @"/Views/Grants/Index.cshtml")]
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
#line 1 "G:\Projects\IdentityServer\IDP\IDP\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b772289ff89ed0910480069349a3dce6da44f20a", @"/Views/Grants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006d45f54c892aa41ae6f574ad35634ca97cf035", @"/Views/_ViewImports.cshtml")]
    public class Views_Grants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrantsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Revoke", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"grants-page\">\n    <div class=\"lead\">\n        <h1>Client Application Permissions</h1>\n        <p>Below is the list of applications you have given permission to and the resources they have access to.</p>\n    </div>\n\n");
#nullable restore
#line 9 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
     if (Model.Grants.Any() == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-sm-8\">\n                <div class=\"alert alert-info\">\n                    You have not given access to any applications\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 18 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
    }
    else
    {
        foreach (var grant in Model.Grants)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\n                <div class=\"card-header\">\n                    <div class=\"row\">\n                        <div class=\"col-sm-8 card-title\">\n");
#nullable restore
#line 27 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                             if (grant.ClientLogoUrl != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 897, "\"", 923, 1);
#nullable restore
#line 29 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
WriteAttributeValue("", 903, grant.ClientLogoUrl, 903, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 30 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <strong>");
#nullable restore
#line 31 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                               Write(grant.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                        </div>\n\n                        <div class=\"col-sm-2\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b772289ff89ed0910480069349a3dce6da44f20a5693", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" name=\"clientId\"");
                BeginWriteAttribute("value", " value=\"", 1221, "\"", 1244, 1);
#nullable restore
#line 36 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
WriteAttributeValue("", 1229, grant.ClientId, 1229, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                <button class=\"btn btn-danger\">Revoke Access</button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n                \n                <ul class=\"list-group list-group-flush\">\n");
#nullable restore
#line 44 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                     if (grant.Description != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\n                            <label>Description:</label> ");
#nullable restore
#line 47 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                                   Write(grant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </li>   \n");
#nullable restore
#line 49 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"list-group-item\">\n                        <label>Created:</label> ");
#nullable restore
#line 51 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                           Write(grant.Created.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </li>\n");
#nullable restore
#line 53 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                     if (grant.Expires.HasValue)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\n                            <label>Expires:</label> ");
#nullable restore
#line 56 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                               Write(grant.Expires.Value.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </li>\n");
#nullable restore
#line 58 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                     if (grant.IdentityGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\n                            <label>Identity Grants</label>\n                            <ul>\n");
#nullable restore
#line 64 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.IdentityGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 66 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 67 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                        </li>\n");
#nullable restore
#line 70 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                     if (grant.ApiGrantNames.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\">\n                            <label>API Grants</label>\n                            <ul>\n");
#nullable restore
#line 76 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                 foreach (var name in grant.ApiGrantNames)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>");
#nullable restore
#line 78 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 79 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\n                        </li>\n");
#nullable restore
#line 82 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\n            </div>\n");
#nullable restore
#line 85 "G:\Projects\IdentityServer\IDP\IDP\Views\Grants\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrantsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
