#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae06a1473ee06b3f7fc655657d8e3a5c03d86037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae06a1473ee06b3f7fc655657d8e3a5c03d86037", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 43, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n\r\n\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(77, 516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f75ddecdebb478fa9e88b858e1d6d33", async() => {
                BeginContext(83, 503, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

    <link rel=""stylesheet"" href=""css/datepicker.css"">

    <title>EasyFlight</title>
");
                EndContext();
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
            EndContext();
            BeginContext(593, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(595, 3734, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfca1e7647ca4b57aeefd1a724aec0e5", async() => {
                BeginContext(601, 1262, true);
                WriteLiteral(@"
    <div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">

                    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                        <a class=""navbar-brand"" href=""/"">Easy Flight</a>
                        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse""
                                data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                                aria-expanded=""false"" aria-label=""Toggle navigation"">
                            <span class=""navbar-toggler-icon""></span>
                        </button>

                        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">

                            <ul class=""navbar-nav mr-auto"">

                                <li class=""nav-item active"">
                                    <a class=""nav-link"" href=""https://localhost:44300/Airline/Index"">Aviokompanije</a>
               ");
                WriteLiteral("                 </li>\r\n                                <li class=\"nav-item active\">\r\n                                    <a class=\"nav-link\" href=\"/\">Početna</a>\r\n                                </li>\r\n                            </ul>\r\n");
                EndContext();
#line 46 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                             if (Context.Session.GetString("Test") != null || (Context.Session.GetString("Admin") != null))
                            {
                                if (Context.Session.GetString("Test") != null)
                                {

#line default
#line hidden
                BeginContext(2134, 74, true);
                WriteLiteral("                                    <a class=\"nav-link\" href=\"User/Index\">");
                EndContext();
                BeginContext(2209, 33, false);
#line 50 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                                                                     Write(Context.Session.GetString("Test"));

#line default
#line hidden
                EndContext();
                BeginContext(2242, 261, true);
                WriteLiteral(@"</a>
                                    <form action=""https://localhost:44300/Account/Logout"">
                                        <a class=""nav-link"" href=""https://localhost:44300/Account/Logout"">Logout</a>
                                    </form>
");
                EndContext();
#line 54 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"

                                }
                                if (Context.Session.GetString("Admin") != null)
                                {

#line default
#line hidden
                BeginContext(2656, 74, true);
                WriteLiteral("                                    <a class=\"nav-link\" href=\"User/Index\">");
                EndContext();
                BeginContext(2731, 34, false);
#line 58 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                                                                     Write(Context.Session.GetString("Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(2765, 261, true);
                WriteLiteral(@"</a>
                                    <form action=""https://localhost:44300/Account/Logout"">
                                        <a class=""nav-link"" href=""https://localhost:44300/Account/Logout"">Logout</a>
                                    </form>
");
                EndContext();
#line 62 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"

                                }

                            }
                            else
                            {


#line default
#line hidden
                BeginContext(3163, 222, true);
                WriteLiteral("                                <a class=\"nav-link\" href=\"https://localhost:44300/Account/Login\">Login</a>\r\n                                <a class=\"nav-link\" href=\"https://localhost:44300/Account/Register\">Register</a>\r\n");
                EndContext();
#line 71 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
                BeginContext(3416, 177, true);
                WriteLiteral("                        </div>\r\n                    </nav>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(3594, 12, false);
#line 92 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3606, 716, true);
                WriteLiteral(@"
    </div>


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
");
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
            BeginContext(4329, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591