#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d14873689761f8d2b3dc3b48adb209d6b849adc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d14873689761f8d2b3dc3b48adb209d6b849adc", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.ViewModel.RegisterViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 37, true);
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(84, 2445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a15873fdf87461398619ae79ea14757", async() => {
                BeginContext(90, 376, true);
                WriteLiteral(@"

    <!-- LOGIN  -->
    <BR><BR><BR>
    <div class=""row justify-content-md-center"">

        <div class=""col-4"">

            <form method=""post"">
                <div class=""form-group"">
                    <label for=""login-password"">Name</label>
                    <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Name"">
                    ");
                EndContext();
                BeginContext(467, 46, false);
#line 17 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Account\Register.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(513, 1594, true);
                WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <label for=""surname"">Surname</label>
                    <input type=""text"" class=""form-control"" name=""Surname"" placeholder=""Surname"">
                </div>
                <div class=""form-group"">
                    <label for=""login-email"">Email address</label>
                    <input type=""email"" class=""form-control"" name=""Email"" placeholder=""Login email"">
                </div>
                <div class=""form-group"">
                    <label for=""login-password"">Password</label>
                    <input type=""password"" class=""form-control"" name=""Password"" placeholder=""Password"">
                </div>
                <div class=""form-group"">
                    <label for=""login-password"">ConfirmPassword</label>
                    <input type=""password"" class=""form-control"" name=""ConfirmPassword"" placeholder=""ConfirmPassword"">
                </div>


                <div class=""form-group"">");
                WriteLiteral(@"
                    <label for=""adress"">Adress</label>
                    <input type=""text"" class=""form-control"" name=""Address"" placeholder=""Adress"">
                </div>
                <div class=""form-group"">
                    <label for=""PhoneNumber"">Phone Number</label>
                    <input type=""text"" class=""form-control"" name=""PhoneNumber"" placeholder=""PhoneNumber"">
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Create"" class=""btn btn-success"" />
                </div>
");
                EndContext();
#line 48 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Account\Register.cshtml"
                 if (ViewBag.Message != null)
                {

#line default
#line hidden
                BeginContext(2173, 165, true);
                WriteLiteral("                    <script type=\"text/javascript\">\r\n                    window.onload = function () {\r\n                        /**/\r\n                        alert(\"");
                EndContext();
                BeginContext(2339, 15, false);
#line 53 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Account\Register.cshtml"
                          Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(2354, 82, true);
                WriteLiteral("\");\r\n                    /**/\r\n                };\r\n                    </script>\r\n");
                EndContext();
#line 57 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Account\Register.cshtml"
                }

#line default
#line hidden
                BeginContext(2455, 67, true);
                WriteLiteral("            </form>\r\n\r\n\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(2529, 10, true);
            WriteLiteral("\r\n</html>`");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFlight.ViewModel.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
