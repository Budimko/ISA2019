#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4623c903e2b27a33fe2a6c2307d89304c218a212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airline_Letovi), @"mvc.1.0.view", @"/Views/Airline/Letovi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Airline/Letovi.cshtml", typeof(AspNetCore.Views_Airline_Letovi))]
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
#line 1 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4623c903e2b27a33fe2a6c2307d89304c218a212", @"/Views/Airline/Letovi.cshtml")]
    public class Views_Airline_Letovi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.ViewModel.AirlineHomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
  
    ViewData["Title"] = "Letovi";

#line default
#line hidden
            BeginContext(131, 110, true);
            WriteLiteral("<div>\r\n    <ul class=\"nav nav-pills nav-fill\">\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 241, "\'", 303, 1);
#line 11 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
WriteAttributeValue("", 248, Url.Action("Profil", "Airline", new { id = Model.Id }), 248, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(304, 101, true);
            WriteLiteral(">Profil</a>\r\n\r\n        </li>\r\n\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link active\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 405, "\'", 467, 1);
#line 16 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
WriteAttributeValue("", 412, Url.Action("Letovi", "Airline", new { id = Model.Id }), 412, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(468, 92, true);
            WriteLiteral(">Letovi</a>\r\n        </li>\r\n\r\n        <li class=\"nav-item\">\r\n            <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 560, "\'", 629, 1);
#line 20 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
WriteAttributeValue("", 567, Url.Action("DodatneUsluge", "Airline", new { id = Model.Id }), 567, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(630, 36, true);
            WriteLiteral(">Dodatne Usluge</a>\r\n        </li>\r\n");
            EndContext();
#line 22 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
         if (Context.Session.GetString("Admin") != null)
        {

#line default
#line hidden
            BeginContext(735, 70, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a class=\"nav-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 805, "\'", 872, 1);
#line 25 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
WriteAttributeValue("", 812, Url.Action("Destinacije", "Airline", new { id = Model.Id }), 812, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(873, 37, true);
            WriteLiteral(">Destinacije</a>\r\n            </li>\r\n");
            EndContext();
#line 27 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"



        }

#line default
#line hidden
            BeginContext(927, 54, true);
            WriteLiteral("\r\n\r\n    </ul>\r\n</div>\r\n<BR><BR><BR>\r\n        <div>\r\n\r\n");
            EndContext();
#line 38 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
             if (Context.Session.GetString("Admin") == null)
            {

#line default
#line hidden
            BeginContext(1058, 1961, true);
            WriteLiteral(@"                <h2>Pretraga leta</h2>
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

                        <div class=""form-group col-md-3"">
                            <label for=""let-od"">Od</label>
                            <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""From"" placeholder=""From"">
              ");
            WriteLiteral(@"          </div>

                        <div class=""form-group col-md-3"">
                            <label for=""let-do"">Do</label>
                            <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""To"" placeholder=""To"">
                        </div>

                        <div class=""form-group col-md-2"">
                            <label for=""br-putnika"">Vrsta puta</label>
                            <select name=""Type"" id=""br-putnika"" class=""form-control"">
                                <option selected>Round Trup</option>
                                <option>One Wey</option>
                                <option>Multi City</option>
                            </select>
                        </div>

                    </div>
                    <button type=""submit"" value=""Flight"" class=""btn btn-primary"">Pretraži</button>
                </form>
");
            EndContext();
#line 74 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
            }

#line default
#line hidden
            BeginContext(3034, 33, true);
            WriteLiteral("        </div>\r\n        <div>\r\n\r\n");
            EndContext();
#line 78 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
             if (Context.Session.GetString("Admin") != null)
            {

#line default
#line hidden
            BeginContext(3144, 3212, true);
            WriteLiteral(@"                <h2>Dodaj novi let u ponudu Aviokompanije</h2>
                <form method=""post"">
                    <div class=""form-row"">
                        <div class=""form-group col-md-2"">
                            <label for=""let-start"">Polazak</label>
                            <input name=""DepartureTime"" class=""span2 form-control"" size=""16"" type=""date"" value="""" id=""let-start"" data-date="""">
                        </div>
                        <div class=""form-group col-md-2"">
                            <label for=""let-end"">Dolazak</label>
                            <input name=""LandingTime"" class=""span3 form-control"" size=""16"" type=""date"" value="""" id=""let-end"" data-date="""">
                        </div>

                        <div class=""form-group col-md-2"">
                            <label for=""let-od"">Od</label>
                            <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""From"" placeholder=""From"">
                      ");
            WriteLiteral(@"  </div>

                        <div class=""form-group col-md-2"">
                            <label for=""let-do"">Do</label>
                            <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""To"" placeholder=""To"">
                        </div>

                        <div class=""form-group col-md-2"">
                            <label for=""br-putnika"">Vrsta puta</label>
                            <select name=""Type"" id=""br-putnika"" class=""form-control"">
                                <option selected>Round Trup</option>
                                <option>One Wey</option>
                                <option>Multi City</option>
                            </select>
                        </div>
                        <div class=""form-group col-md-2"">
                            <label for=""br-putnika"">Vrsta aviona</label>
                            <select name=""Airplain"" id=""br-putnika"" class=""form-control"">
                          ");
            WriteLiteral(@"      <option selected>boeing 777-200</option>
                                
                            </select>
                        </div>

                    </div>
                    <div class=""form-row"">

                        <div class=""form-group col-md-2"">
                            <label for=""let-od"">Cena</label>
                            <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""Price"" placeholder=""Cena"">
                        </div>
                        <div class=""form-group col-md-2"">
                            <label for=""let-od"">Distanca</label>
                            <input type=""text"" style=""text-transform:capitalize"" class=""form-control"" name=""Distance"" placeholder=""Distanca"">
                        </div>
                        <div class=""form-group col-md-2"">
                            <label for=""let-od"">Vreme trajanja leta</label>
                            <input type=""time"" style=""text-transform:c");
            WriteLiteral("apitalize\" class=\"form-control\" name=\"Time\" placeholder=\"Vreme trajanja leta\">\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 134 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                     if (ViewBag.Message != null)
                    {

#line default
#line hidden
            BeginContext(6430, 169, true);
            WriteLiteral("                        <script type=\"text/javascript\">\r\n                    window.onload = function () {\r\n                        /**/\r\n                        alert(\"");
            EndContext();
            BeginContext(6600, 15, false);
#line 139 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                          Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(6615, 86, true);
            WriteLiteral("\");\r\n                    /**/\r\n                };\r\n                        </script>\r\n");
            EndContext();
#line 143 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                    }

#line default
#line hidden
            BeginContext(6724, 128, true);
            WriteLiteral("                    <button type=\"submit\" value=\"Flight\" class=\"btn btn-primary\">Dodaj Let</button>\r\n\r\n                </form>\r\n");
            EndContext();
#line 147 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"

            }

#line default
#line hidden
            BeginContext(6869, 53, true);
            WriteLiteral("                <div>\r\n                    <BR><BR>\r\n");
            EndContext();
#line 151 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                     if (Context.Session.GetString("Admin") != null)
                    {

#line default
#line hidden
            BeginContext(7015, 204, true);
            WriteLiteral("                        <table class=\"table\">\r\n                            <thead>\r\n                                <tr>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(7220, 40, false);
#line 157 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(7260, 161, true);
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 163 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                                 foreach (var item in Model.flight)
                                {

#line default
#line hidden
            BeginContext(7525, 134, true);
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(7660, 40, false);
#line 168 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(7700, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(7840, 47, false);
#line 171 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TimeOfTrevel));

#line default
#line hidden
            EndContext();
            BeginContext(7887, 169, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <input type=\"hidden\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 8056, "", 8101, 1);
#line 174 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
WriteAttributeValue("", 8063, Html.DisplayFor(modelItem => item.Id), 8063, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8101, 142, true);
            WriteLiteral(">\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(8244, 71, false);
#line 178 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                                       Write(Html.ActionLink("Uredi let", "UrediLet", "Admin", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(8315, 94, true);
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                    </tr>\r\n");
            EndContext();
#line 182 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"
                                }

#line default
#line hidden
            BeginContext(8444, 72, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
            EndContext();
#line 185 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airline\Letovi.cshtml"

                    }

#line default
#line hidden
            BeginContext(8541, 30, true);
            WriteLiteral("                </div>\r\n\r\n\r\n\r\n");
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
