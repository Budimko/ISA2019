#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24324f6aa91ec55e9dd3890bee6f4893976669d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airline_Destinacije), @"mvc.1.0.view", @"/Views/Airline/Destinacije.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Airline/Destinacije.cshtml", typeof(AspNetCore.Views_Airline_Destinacije))]
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
#line 1 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24324f6aa91ec55e9dd3890bee6f4893976669d3", @"/Views/Airline/Destinacije.cshtml")]
    public class Views_Airline_Destinacije : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.ViewModel.AirlineHomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
  
    ViewData["Title"] = "Destinacije";

#line default
#line hidden
            BeginContext(134, 120, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div>\r\n\r\n    <ul class=\"nav nav-pills nav-fill\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 254, "\'", 311, 1);
#line 15 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
WriteAttributeValue("", 261, Url.Action("Profil","Airline",new { id=Model.Id}), 261, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(312, 92, true);
            WriteLiteral(">Opis</a>\r\n\r\n        </li>\r\n\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 404, "\'", 461, 1);
#line 20 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
WriteAttributeValue("", 411, Url.Action("Letovi","Airline",new { id=Model.Id}), 411, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(462, 92, true);
            WriteLiteral(">Letovi</a>\r\n        </li>\r\n\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 554, "\'", 618, 1);
#line 24 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
WriteAttributeValue("", 561, Url.Action("DodatneUsluge","Airline",new { id=Model.Id}), 561, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(619, 36, true);
            WriteLiteral(">Dodatne Usluge</a>\r\n        </li>\r\n");
            EndContext();
#line 26 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
         if (Context.Session.GetString("Admin") != null)
        {

#line default
#line hidden
            BeginContext(724, 78, true);
            WriteLiteral("            <li class=\"nav-item \">\r\n                <a class=\"nav-link active\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 802, "\'", 869, 1);
#line 29 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"
WriteAttributeValue("", 809, Url.Action("Destinacije", "Airline", new { id = Model.Id }), 809, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(870, 43, true);
            WriteLiteral(">Dodaj destinaciju</a>\r\n            </li>\r\n");
            EndContext();
#line 31 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Destinacije.cshtml"

        }

#line default
#line hidden
            BeginContext(926, 552, true);
            WriteLiteral(@"    </ul>

    <BR><BR><Br>
</div>
<form method=""post"">
    <div class=""form-group"">
        <label for=""login-password"">Name</label>
        <input type=""text"" class=""form-control"" name=""Name"" placeholder=""Name"">

    </div>
    <div class=""form-group"">
        <label for=""surname"">Description</label>
        <input type=""text"" class=""form-control"" name=""Description"" placeholder=""Description"">
    </div>
    <div class=""form-group"">
        <input type=""submit"" value=""Create"" class=""btn btn-success"" />
    </div>
    

</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFlight.ViewModel.AirlineHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
