#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0977f1e5754791719be4b22d8b0af13b5938357"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0977f1e5754791719be4b22d8b0af13b5938357", @"/Views/Shared/_Layout.cshtml")]
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
            BeginContext(34, 45, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n\r\n\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(79, 661, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82544b934aa24a2dbfb95aa8d4c7914c", async() => {
                BeginContext(85, 415, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

");
                EndContext();
                BeginContext(690, 43, true);
                WriteLiteral("    \r\n\r\n\r\n\r\n    <title>EasyFlight</title>\r\n");
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
            BeginContext(740, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(742, 3833, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8116881e8594726a70d2972035f2935", async() => {
                BeginContext(748, 1262, true);
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
#line 50 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                             if (Context.Session.GetString("Test") != null || (Context.Session.GetString("Admin") != null))
                            {
                                if (Context.Session.GetString("Test") != null)
                                {

#line default
#line hidden
                BeginContext(2281, 98, true);
                WriteLiteral("                                    <a class=\"nav-link\" href=\"https://localhost:44300/User/Index\">");
                EndContext();
                BeginContext(2380, 33, false);
#line 54 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                                                                                             Write(Context.Session.GetString("Test"));

#line default
#line hidden
                EndContext();
                BeginContext(2413, 261, true);
                WriteLiteral(@"</a>
                                    <form action=""https://localhost:44300/Account/Logout"">
                                        <a class=""nav-link"" href=""https://localhost:44300/Account/Logout"">Logout</a>
                                    </form>
");
                EndContext();
#line 58 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"

                                }
                                if (Context.Session.GetString("Admin") != null)
                                {

#line default
#line hidden
                BeginContext(2827, 98, true);
                WriteLiteral("                                    <a class=\"nav-link\" href=\"https://localhost:44300/User/Index\">");
                EndContext();
                BeginContext(2926, 34, false);
#line 62 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                                                                                             Write(Context.Session.GetString("Admin"));

#line default
#line hidden
                EndContext();
                BeginContext(2960, 261, true);
                WriteLiteral(@"</a>
                                    <form action=""https://localhost:44300/Account/Logout"">
                                        <a class=""nav-link"" href=""https://localhost:44300/Account/Logout"">Logout</a>
                                    </form>
");
                EndContext();
#line 66 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"

                                }

                            }
                            else
                            {


#line default
#line hidden
                BeginContext(3358, 222, true);
                WriteLiteral("                                <a class=\"nav-link\" href=\"https://localhost:44300/Account/Login\">Login</a>\r\n                                <a class=\"nav-link\" href=\"https://localhost:44300/Account/Register\">Register</a>\r\n");
                EndContext();
#line 75 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
                BeginContext(3611, 179, true);
                WriteLiteral("                        </div>\r\n                    </nav>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    <div>\r\n\r\n        ");
                EndContext();
                BeginContext(3791, 12, false);
#line 97 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3803, 721, true);
                WriteLiteral(@"
    </div>


    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.4.1.min.js""
            integrity=""sha256-CSXorXvZcTkaix6Yvo6HppcZGetbYMGWSFlBw8HfCJo=""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
    ");
                EndContext();
                BeginContext(4525, 41, false);
#line 108 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(4566, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(4575, 11, true);
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
