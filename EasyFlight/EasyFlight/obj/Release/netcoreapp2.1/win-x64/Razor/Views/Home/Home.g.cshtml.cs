#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b0b50a80cacdd03ef84fa602ab784ff4f41504"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b0b50a80cacdd03ef84fa602ab784ff4f41504", @"/Views/Home/Home.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.ViewModel.HomeViewModel>
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
            BeginContext(44, 10, true);
            WriteLiteral("<html>\r\n\r\n");
            EndContext();
            BeginContext(54, 4141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad30a560fde84ea6b962902ce8cd8062", async() => {
                BeginContext(60, 3802, true);
                WriteLiteral(@"


    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">


                <BR><BR><BR>

                <h2>Pretraga</h2>
                <nav>
                    <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                        <a class=""nav-item nav-link active"" id=""nav-home-tab"" data-toggle=""tab"" href=""#nav-home"" role=""tab""
                           aria-controls=""nav-home"" aria-selected=""true"">Aviokompanjia</a>
                        <a class=""nav-item nav-link"" id=""nav-profile-tab"" data-toggle=""tab"" href=""#nav-profile"" role=""tab""
                           aria-controls=""nav-profile"" aria-selected=""false"">Hotel</a>
                        <a class=""nav-item nav-link"" id=""nav-contact-tab"" data-toggle=""tab"" href=""#nav-contact"" role=""tab""
                           aria-controls=""nav-contact"" aria-selected=""false"">Rent a car</a>
                    </div>
                </nav>
                <div class=""tab-content"" id=""nav-tabContent""");
                WriteLiteral(@">

                    <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">

                        <!-- AVIOKOMPANJIJA PRETRAGA -->

                        <BR>



                        <form action=""https://localhost:44300/Home/Flights"">
                            <div class=""form-row"">
                                <div class=""form-group col-md-2"">
                                    <label for=""let-start"">Polazak</label>
                                    <input name=""DepartureTime"" class=""span2 form-control"" size=""16"" type=""date"" value="""" id=""let-start"" data-date="""">
                                </div>
                                <div class=""form-group col-md-2"">
                                    <label for=""let-end"">Dolazak</label>
                                    <input name=""LandingTime"" class=""span3 form-control"" size=""16"" type=""date"" value="""" id=""let-end"" data-date="""">
                                </div>

   ");
                WriteLiteral(@"                             <div class=""form-group col-md-3"">
                                    <label for=""let-od"">Od</label>
                                    <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""From"" placeholder=""From"">
                                </div>

                                <div class=""form-group col-md-3"">
                                    <label for=""let-do"">Do</label>
                                    <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""To"" placeholder=""To"">
                                </div>

                                <div class=""form-group col-md-2"">
                                    <label for=""br-putnika"">Vrsta puta</label>
                                    <select name=""Type"" id=""br-putnika"" class=""form-control"">
                                        <option selected>Round Trup</option>
                                        <option>One Wey</option>
     ");
                WriteLiteral(@"                                   <option>Multi City</option>
                                    </select>
                                </div>

                            </div>


                            <button type=""submit"" value=""Flight"" class=""btn btn-primary"">Pretraži</button>
                        </form>


                    </div>

                    <div class=""tab-pane fade"" id=""nav-profile"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">Hotel not implement</div>
                    <div class=""tab-pane fade"" id=""nav-contact"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">Rent a car  not implement</div>
                </div>







            </div>
        </div>
");
                EndContext();
#line 86 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Home\Home.cshtml"
         if (ViewBag.Message != null)
        {

#line default
#line hidden
                BeginContext(3912, 157, true);
                WriteLiteral("            <script type=\"text/javascript\">\r\n                    window.onload = function () {\r\n                        /**/\r\n                        alert(\"");
                EndContext();
                BeginContext(4070, 15, false);
#line 91 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Home\Home.cshtml"
                          Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(4085, 74, true);
                WriteLiteral("\");\r\n                    /**/\r\n                };\r\n            </script>\r\n");
                EndContext();
#line 95 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Home\Home.cshtml"
        }

#line default
#line hidden
                BeginContext(4170, 18, true);
                WriteLiteral("    </div>\r\n\r\n\r\n\r\n");
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
            BeginContext(4195, 25, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFlight.ViewModel.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
