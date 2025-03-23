#pragma checksum "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "261ddaabdbb0ee5e6f4448d5d426584aff22bdf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditProfile), @"mvc.1.0.view", @"/Views/Account/EditProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261ddaabdbb0ee5e6f4448d5d426584aff22bdf3", @"/Views/Account/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565b9f3241d9e0501a2e3fbdb432799bfb7e291a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
  
    ViewData["Title"] = "EditProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"min-h-screen flex items-center justify-center bg-gray-50\">\r\n    <div class=\"bg-white p-8 rounded-lg shadow-md w-full max-w-lg\">\r\n        <h1 class=\"text-3xl font-bold text-center text-gray-800 mb-6\">Edit Your Profile</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
         if (ViewBag.SuccessMessage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-green-500 text-center mb-4\">");
#nullable restore
#line 11 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
                                                  Write(ViewBag.SuccessMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
         if (ViewBag.ErrorMessage != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-red-500 text-center mb-4\">");
#nullable restore
#line 15 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
                                                Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "261ddaabdbb0ee5e6f4448d5d426584aff22bdf36024", async() => {
                WriteLiteral("\r\n        <!-- Name Input -->\r\n        <div>\r\n            <label class=\"block text-gray-700 font-medium\">Name</label>\r\n            <input type=\"text\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 789, "\"", 808, 1);
#nullable restore
#line 22 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
WriteAttributeValue("", 797, Model.Name, 797, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                   class=""w-full px-4 py-2 border border-gray-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"" />
        </div>

        <!-- Phone Input -->
        <div>
            <label class=""block text-gray-700 font-medium"">Phone</label>
            <input type=""text"" name=""Phone""");
                BeginWriteAttribute("value", " value=\"", 1134, "\"", 1154, 1);
#nullable restore
#line 29 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
WriteAttributeValue("", 1142, Model.Phone, 1142, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                   class=""w-full px-4 py-2 border border-gray-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"" />
        </div>

        <!-- Address Input -->
        <div>
            <label class=""block text-gray-700 font-medium"">Address</label>
            <input type=""text"" name=""Address""");
                BeginWriteAttribute("value", " value=\"", 1486, "\"", 1508, 1);
#nullable restore
#line 36 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
WriteAttributeValue("", 1494, Model.Address, 1494, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                   class=""w-full px-4 py-2 border border-gray-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"" />
        </div>
        <div>
            <label class=""block text-gray-700 font-medium"">Password</label>
            <input type=""text"" name=""Password""");
                BeginWriteAttribute("value", " value=\"", 1808, "\"", 1831, 1);
#nullable restore
#line 41 "C:\Users\saswa\source\repos\LandscapeWebApp\LandscapeWebApp\Views\Account\EditProfile.cshtml"
WriteAttributeValue("", 1816, Model.Password, 1816, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                   class=""w-full px-4 py-2 border border-gray-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500"" />
        </div>
        


        <!-- Save Button -->
        <button type=""submit""
                class=""w-full bg-blue-500 text-white font-bold py-2 px-4 rounded-lg hover:bg-blue-600 transition duration-300"">
            Save Changes
        </button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <!-- Back to Dashboard -->\r\n        <p class=\"mt-4 text-center text-gray-600\">\r\n            <a href=\"/Account/Dashboard\" class=\"text-blue-500 hover:underline\">Back to Dashboard</a>\r\n        </p>\r\n    </div>\r\n</div>\r\n");
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
