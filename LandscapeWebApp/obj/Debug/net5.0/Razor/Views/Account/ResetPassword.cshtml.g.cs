#pragma checksum "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b04a72a26ccadd98a16dab9a8d506fca9d89aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPassword), @"mvc.1.0.view", @"/Views/Account/ResetPassword.cshtml")]
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
#line 1 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\_ViewImports.cshtml"
using LandscapeWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\_ViewImports.cshtml"
using LandscapeWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b04a72a26ccadd98a16dab9a8d506fca9d89aa", @"/Views/Account/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565b9f3241d9e0501a2e3fbdb432799bfb7e291a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
  
    ViewData["Title"] = "Reset Password";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex justify-center items-center h-screen bg-gray-100\">\r\n    <div class=\"w-full max-w-md bg-white shadow-md rounded-lg p-8\">\r\n        <h1 class=\"text-2xl font-bold mb-6\">Reset Password</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
         if (ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-red-500\">");
#nullable restore
#line 11 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
         if (ViewBag.SuccessMessage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-green-500\">");
#nullable restore
#line 15 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
                                 Write(ViewBag.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\ResetPassword.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93b04a72a26ccadd98a16dab9a8d506fca9d89aa5606", async() => {
                WriteLiteral(@"
            <div class=""mb-4"">
                <label class=""block text-gray-700"">Email</label>
                <input type=""email"" name=""email"" class=""w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-400"" required />
            </div>

            <div class=""mb-4"">
                <label class=""block text-gray-700"">New Password</label>
                <input type=""password"" name=""password"" class=""w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-400"" required />
            </div>

            <div class=""mb-4"">
                <label class=""block text-gray-700"">Confirm Password</label>
                <input type=""password"" name=""confirmPassword"" class=""w-full px-4 py-2 border rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-400"" required />
            </div>

            <button type=""submit"" class=""w-full bg-blue-500 text-white py-2 rounded-lg hover:bg-blue-600"">Reset Password</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
