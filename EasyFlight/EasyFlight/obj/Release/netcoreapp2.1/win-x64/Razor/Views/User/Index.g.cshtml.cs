#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e750f1bcacb3836c934dd4d871956d6b3e0c37fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 2 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e750f1bcacb3836c934dd4d871956d6b3e0c37fb", @"/Views/User/Index.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 197, true);
            WriteLiteral("<div>\r\n\r\n    <ul class=\"nav nav-pills nav-fill\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\" href=\"https://localhost:44300/User/Index\">Informacije </a>\r\n\r\n        </li>\r\n");
            EndContext();
#line 10 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
         if (Context.Session.GetString("Test") != null)
        {

#line default
#line hidden
            BeginContext(331, 159, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" href=\"https://localhost:44300/User/SpisakPrijatelja\">Prijatelji</a>\r\n            </li>\r\n");
            EndContext();
#line 15 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(515, 323, true);
            WriteLiteral(@"    </ul>

</div>


<BR><BR><BR>
<div class=""row justify-content-md-center"">

    <div class=""col-8 offset-2"">

        <form action=""/User/Edit"">

            <div class=""form-group"">
                <label for=""login-password"">Name</label>
                <input type=""text"" class=""form-control"" name=""Name""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 838, "\"", 887, 1);
#line 31 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 846, Html.DisplayFor(modelItem => Model.Name), 846, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("readonly", " readonly=\"", 888, "\"", 906, 1);
#line 31 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 899, true, 899, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(907, 187, true);
            WriteLiteral(">\r\n\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"surname\">Surname</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Surname\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1094, "\"", 1146, 1);
#line 36 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1102, Html.DisplayFor(modelItem => Model.Surname), 1102, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("readonly", " readonly=\"", 1147, "\"", 1165, 1);
#line 36 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1158, true, 1158, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1166, 194, true);
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"login-email\">Email address</label>\r\n                <input type=\"email\" class=\"form-control\" name=\"Email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1360, "\"", 1410, 1);
#line 40 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1368, Html.DisplayFor(modelItem => Model.Email), 1368, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("readonly", " readonly=\"", 1411, "\"", 1429, 1);
#line 40 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1422, true, 1422, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1430, 198, true);
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"login-password\">Password</label>\r\n                <input type=\"password\" class=\"form-control\" name=\"Password\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1628, "\"", 1681, 1);
#line 44 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1636, Html.DisplayFor(modelItem => Model.Password), 1636, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("readonly", " readonly=\"", 1682, "\"", 1700, 1);
#line 44 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1693, true, 1693, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 185, true);
            WriteLiteral(">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"adress\">Adress</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"Address\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1886, "\"", 1938, 1);
#line 49 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1894, Html.DisplayFor(modelItem => Model.Address), 1894, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("readonly", " readonly=\"", 1939, "\"", 1957, 1);
#line 49 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 1950, true, 1950, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1958, 197, true);
            WriteLiteral(">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"PhoneNumber\">PhoneNumber</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"PhoneNumber\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2155, "\"", 2211, 1);
#line 53 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 2163, Html.DisplayFor(modelItem => Model.PhoneNumber), 2163, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("readonly", " readonly=\"", 2212, "\"", 2230, 1);
#line 53 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 2223, true, 2223, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2231, 96, true);
            WriteLiteral(">\r\n            </div>\r\n            <div>\r\n                <input type=\"hidden\" id=\"Id\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 2327, "", 2373, 1);
#line 56 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
WriteAttributeValue("", 2334, Html.DisplayFor(modelItem => Model.Id), 2334, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2373, 138, true);
            WriteLiteral(">\r\n            </div>\r\n\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\" value=\"Update\">Update</button>\r\n\r\n        </form>\r\n\r\n");
            EndContext();
#line 64 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
         if (ViewBag.Message != null)
        {

#line default
#line hidden
            BeginContext(2561, 147, true);
            WriteLiteral("            <script type=\"text/javascript\">\r\n                window.onload = function () {\r\n\r\n                    /**/\r\n                    alert(\"");
            EndContext();
            BeginContext(2709, 15, false);
#line 70 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
                      Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(2724, 76, true);
            WriteLiteral("\");\r\n                    /**/\r\n\r\n                };\r\n            </script>\r\n");
            EndContext();
#line 75 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2811, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFlight.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
