#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234930e455fa60f390899431a00788aafe0c9f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Edit.cshtml", typeof(AspNetCore.Views_User_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234930e455fa60f390899431a00788aafe0c9f80", @"/Views/User/Edit.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EasyFlight.Models.User>>
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(48, 35, true);
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(83, 447, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55b98bfdca87410dad3d6e1d1001766e", async() => {
                BeginContext(89, 434, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">

    <title>Registracija</title>
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
            BeginContext(530, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(536, 6094, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ad169a0c8b4caa92600c7ef1a27faf", async() => {
                BeginContext(542, 1668, true);
                WriteLiteral(@"

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">


                <BR><BR><BR>

                <h2>Pretraga</h2>
                <nav>
                    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                        <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-home"" role=""tab""
                           aria-controls=""nav-home"" aria-selected=""true"">Profil</a>
                        <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-profile"" role=""tab""
                           aria-controls=""nav-profile"" aria-selected=""false"">Prijatelji</a>
                        <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" role=""tab""
                           aria-controls=""nav-contact"" aria-selected=""false"">Rezervacije</a>
                        <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" rol");
                WriteLiteral(@"e=""tab""
                           aria-controls=""nav-contact"" aria-selected=""false"">Informacije</a>
                    </div>
                </nav>
                <div class=""tab-content"" id=""nav-tabContent"">

                    <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">

                        <!-- AVIOKOMPANJIJA PRETRAGA -->


                        <BR><BR><BR>
                                <div class=""row justify-content-md-center"">

                                    <div class=""col-4"">

                                        <form method=""post"">
");
                EndContext();
#line 53 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
                BeginContext(2331, 261, true);
                WriteLiteral(@"                                                <div class=""form-group"">
                                                    <label for=""name"">Name</label>
                                                    <input type=""text"" class=""form-control"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=", 2592, "", 2639, 1);
#line 57 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 2599, Html.DisplayFor(modelItem => item.Name), 2599, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2639, 331, true);
                WriteLiteral(@">

                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""surname"">Surname</label>
                                                    <input type=""text"" class=""form-control"" name=""Surname""");
                EndContext();
                BeginWriteAttribute("value", " value=", 2970, "", 3020, 1);
#line 62 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 2977, Html.DisplayFor(modelItem => item.Surname), 2977, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3020, 338, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""login-email"">Email address</label>
                                                    <input type=""email"" class=""form-control"" name=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=", 3358, "", 3406, 1);
#line 66 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 3365, Html.DisplayFor(modelItem => item.Email), 3365, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3406, 342, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""login-password"">Password</label>
                                                    <input type=""password"" class=""form-control"" name=""Password""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3748, "\"", 3799, 1);
#line 70 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 3756, Html.DisplayFor(modelItem => item.Address), 3756, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3800, 59, true);
                WriteLiteral(">\r\n                                                </div>\r\n");
                EndContext();
                BeginContext(3861, 268, true);
                WriteLiteral(@"                                                <div class=""form-group"">
                                                    <label for=""adress"">Adress</label>
                                                    <input type=""text"" class=""form-control"" name=""Address""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4129, "\"", 4180, 1);
#line 75 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 4137, Html.DisplayFor(modelItem => item.Address), 4137, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4181, 341, true);
                WriteLiteral(@">
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""PhoneNumber"">PhoneNumber</label>
                                                    <input type=""text"" class=""form-control"" name=""PhoneNumber""");
                EndContext();
                BeginWriteAttribute("value", " value=", 4522, "", 4576, 1);
#line 79 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 4529, Html.DisplayFor(modelItem => item.PhoneNumber), 4529, 47, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4576, 204, true);
                WriteLiteral(">\r\n                                                </div>\r\n                                                <div>\r\n                                                    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 4780, "", 4825, 1);
#line 82 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
WriteAttributeValue("", 4787, Html.DisplayFor(modelItem => item.Id), 4787, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4825, 59, true);
                WriteLiteral(">\r\n                                                </div>\r\n");
                EndContext();
                BeginContext(4886, 112, true);
                WriteLiteral("                                                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n");
                EndContext();
#line 86 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"

                                            }

#line default
#line hidden
                BeginContext(5047, 101, true);
                WriteLiteral("\r\n                                        </form>\r\n\r\n\r\n\r\n                                    </div>\r\n");
                EndContext();
#line 94 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
                                     if (ViewBag.Message != null)
                                    {

#line default
#line hidden
                BeginContext(5254, 434, true);
                WriteLiteral(@"                                        <script type=""text/javascript"">
                                            window.onload = function () {

                                                /**/
                                                alert(""ViewBag.Message"");
                                                /**/

                                            };
                                        </script>
");
                EndContext();
#line 105 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Edit.cshtml"
                                    }

#line default
#line hidden
                BeginContext(5727, 896, true);
                WriteLiteral(@"

                                </div>


                    </div>

                    
                </div>







            </div>
        </div>
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
            BeginContext(6630, 12, true);
            WriteLiteral("\r\n</html>`\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EasyFlight.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591