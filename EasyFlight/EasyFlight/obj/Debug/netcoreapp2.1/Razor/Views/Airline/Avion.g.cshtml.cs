#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eddcd8a8a11aec641acd85cf2c4d27c84d61416"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airline_Avion), @"mvc.1.0.view", @"/Views/Airline/Avion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Airline/Avion.cshtml", typeof(AspNetCore.Views_Airline_Avion))]
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
#line 1 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eddcd8a8a11aec641acd85cf2c4d27c84d61416", @"/Views/Airline/Avion.cshtml")]
    public class Views_Airline_Avion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
  
    ViewData["Title"] = "Avion";

#line default
#line hidden
            BeginContext(75, 115, true);
            WriteLiteral("\r\n<div>\r\n\r\n    <ul class=\"nav nav-pills nav-fill\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link \"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 190, "\'", 247, 1);
#line 10 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
WriteAttributeValue("", 197, Url.Action("Profil","Airline",new { id=Model.Id}), 197, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(248, 92, true);
            WriteLiteral(">Opis</a>\r\n\r\n        </li>\r\n\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 340, "\'", 397, 1);
#line 15 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
WriteAttributeValue("", 347, Url.Action("Letovi","Airline",new { id=Model.Id}), 347, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(398, 92, true);
            WriteLiteral(">Letovi</a>\r\n        </li>\r\n\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 490, "\'", 554, 1);
#line 19 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
WriteAttributeValue("", 497, Url.Action("DodatneUsluge","Airline",new { id=Model.Id}), 497, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(555, 36, true);
            WriteLiteral(">Dodatne Usluge</a>\r\n        </li>\r\n");
            EndContext();
#line 21 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
         if (Context.Session.GetString("Admin") != null)
        {

#line default
#line hidden
            BeginContext(660, 70, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 730, "\'", 797, 1);
#line 24 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
WriteAttributeValue("", 737, Url.Action("Destinacije", "Airline", new { id = Model.Id }), 737, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(798, 43, true);
            WriteLiteral(">Dodaj destinaciju</a>\r\n            </li>\r\n");
            EndContext();
            BeginContext(843, 77, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a class=\"nav-link active\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 920, "\'", 981, 1);
#line 28 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"
WriteAttributeValue("", 927, Url.Action("Avion", "Airline", new { id = Model.Id }), 927, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(982, 31, true);
            WriteLiteral(">Avion</a>\r\n            </li>\r\n");
            EndContext();
#line 30 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Avion.cshtml"

        }

#line default
#line hidden
            BeginContext(1026, 25, true);
            WriteLiteral("    </ul>\r\n\r\n\r\n</div>\r\n\r\n");
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
