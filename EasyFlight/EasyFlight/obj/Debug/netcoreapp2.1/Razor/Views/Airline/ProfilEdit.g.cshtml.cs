#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\ProfilEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6866dd38391f2f8ca4753e6f62638951953c1695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airline_ProfilEdit), @"mvc.1.0.view", @"/Views/Airline/ProfilEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Airline/ProfilEdit.cshtml", typeof(AspNetCore.Views_Airline_ProfilEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6866dd38391f2f8ca4753e6f62638951953c1695", @"/Views/Airline/ProfilEdit.cshtml")]
    public class Views_Airline_ProfilEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.Models.Airline>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\ProfilEdit.cshtml"
  
    ViewData["Title"] = "ProfilEdit";

#line default
#line hidden
            BeginContext(83, 176, true);
            WriteLiteral("\r\n<p>Informacije Aviokompanije</p>\r\n<form method=\"post\">\r\n<div class=\"form-group\">\r\n    <label for=\"name\">Naziv</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 259, "\"", 308, 1);
#line 11 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\ProfilEdit.cshtml"
WriteAttributeValue("", 267, Html.DisplayFor(modelItem => Model.Name), 267, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(309, 137, true);
            WriteLiteral(">\r\n\r\n</div>\r\n<div class=\"form-group\">\r\n    <label for=\"opis\">Opis</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Description\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 446, "\"", 502, 1);
#line 16 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\ProfilEdit.cshtml"
WriteAttributeValue("", 454, Html.DisplayFor(modelItem => Model.Description), 454, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(503, 137, true);
            WriteLiteral(">\r\n\r\n</div>\r\n<div class=\"form-group\">\r\n    <label for=\"adresa\">Adresa</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"Address\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 640, "\"", 692, 1);
#line 21 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\ProfilEdit.cshtml"
WriteAttributeValue("", 648, Html.DisplayFor(modelItem => Model.Address), 648, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(693, 100, true);
            WriteLiteral(">\r\n\r\n</div>\r\n<button type=\"submit\" class=\"btn btn-primary\" value=\"Update\">Update</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFlight.Models.Airline> Html { get; private set; }
    }
}
#pragma warning restore 1591
