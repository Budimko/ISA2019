#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212f53fbca8b2860dff49d1034d666131c4a93d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UrediLet), @"mvc.1.0.view", @"/Views/Admin/UrediLet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UrediLet.cshtml", typeof(AspNetCore.Views_Admin_UrediLet))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212f53fbca8b2860dff49d1034d666131c4a93d7", @"/Views/Admin/UrediLet.cshtml")]
    public class Views_Admin_UrediLet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.ViewModel.ReservationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
  
    ViewData["Title"] = "UrediLet";

#line default
#line hidden
            BeginContext(94, 289, true);
            WriteLiteral(@"
<h2>UrediLet</h2>


<div>

    <div class=""plane"">
        <div class=""cockpit"">
            <h1>Please select a seat</h1>
        </div>
        <div class=""exit exit--front fuselage"">

        </div>
        <form method=""post"">
            <ol class=""cabin fuselage"">

");
            EndContext();
#line 21 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                 for (int j = 0; j < 10; j++)
                {

#line default
#line hidden
            BeginContext(449, 23, true);
            WriteLiteral("                    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 472, "\"", 499, 2);
            WriteAttributeValue("", 480, "row1", 480, 4, true);
#line 23 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
WriteAttributeValue(" ", 484, "row--" + j, 485, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(500, 56, true);
            WriteLiteral(">\r\n                        <ol class=\"seats\" type=\"A\">\r\n");
            EndContext();
#line 25 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                             for (int i = 0; i < 6; i++)
                            {
                                string[] seats = new string[] { "A", "B", "C", "D", "E", "F" };


#line default
#line hidden
            BeginContext(744, 146, true);
            WriteLiteral("                            <li class=\"seat dropdown\">\r\n                                    <input class=\"seat-cb dropdown-toggle\" type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 890, "\"", 916, 1);
#line 30 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
WriteAttributeValue("", 897, (j +1)+ seats[i], 897, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(917, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(920, 60, false);
#line 30 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                                                                                                                  Write(@Model.seats.ElementAt(j * 6 + i).Occupide ? "disabled" : "");

#line default
#line hidden
            EndContext();
            BeginContext(981, 5, true);
            WriteLiteral(" id=\"");
            EndContext();
            BeginContext(988, 16, false);
#line 30 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                                                                                                                                                                                      Write((j +1)+ seats[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1005, 109, true);
            WriteLiteral("\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"true\" />\r\n                                <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1114, "\"", 1139, 1);
#line 31 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
WriteAttributeValue("", 1120, (j+1) + seats[i], 1120, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1140, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1143, 18, false);
#line 31 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                                                             Write((j + 1) + seats[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1162, 69, true);
            WriteLiteral("</label>\r\n                                <div class=\"dropdown-menu \"");
            EndContext();
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1231, "\"", 1268, 1);
#line 32 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
WriteAttributeValue("", 1249, (j+1) + seats[i], 1249, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1269, 505, true);
            WriteLiteral(@" x-placement=""bottom-start"" style=""position: absolute; transform: translate3d(0px, 13px, 0px); top: 0px; left: 0px; will-change: transform;"">
                                    <a class=""dropdown-item"" href=""#"">Omoguci Rezervaciju</a>
                                    <a class=""dropdown-item"" href=""#"">Onemoguci Rezervaciju</a>
                                    <a class=""dropdown-item"" href=""#"">Something else here</a>
                                </div>
                            </li>
");
            EndContext();
#line 38 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                            }

#line default
#line hidden
            BeginContext(1805, 58, true);
            WriteLiteral("                        </ol>\r\n                    </li>\r\n");
            EndContext();
#line 41 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Admin\UrediLet.cshtml"
                }

#line default
#line hidden
            BeginContext(1882, 4807, true);
            WriteLiteral(@"            </ol>
            <button type=""submit"">Rezervisi let</button>

            <div class=""exit exit--back fuselage"">

            </div>
        </form>
    </div>
    <BR><BR>


    <style type=""text/css"" media=""screen"">

        *, *:before, *:after {
            box-sizing: border-box;
        }

        html {
            font-size: 16px;
        }

        .plane {
            margin: 20px auto;
            max-width: 300px;
        }

        .cockpit {
            height: 250px;
            position: relative;
            overflow: hidden;
            text-align: center;
            border-bottom: 5px solid #d8d8d8;
        }

            .cockpit:before {
                content: """";
                display: block;
                position: absolute;
                top: 0;
                left: 0;
                height: 500px;
                width: 100%;
                border-radius: 50%;
                border-right: 5px solid #d8d8d8;
       ");
            WriteLiteral(@"         border-left: 5px solid #d8d8d8;
            }

            .cockpit h1 {
                width: 60%;
                margin: 100px auto 35px auto;
            }

        .exit {
            position: relative;
            height: 50px;
        }

            .exit:before, .exit:after {
                content: ""EXIT"";
                font-size: 14px;
                line-height: 18px;
                padding: 0px 2px;
                font-family: ""Arial Narrow"", Arial, sans-serif;
                display: block;
                position: absolute;
                background: green;
                color: white;
                top: 50%;
                transform: translate(0, -50%);
            }

            .exit:before {
                left: 0;
            }

            .exit:after {
                right: 0;
            }

        .fuselage {
            border-right: 5px solid #d8d8d8;
            border-left: 5px solid #d8d8d8;
        }

        ol {
");
            WriteLiteral(@"            list-style: none;
            padding: 0;
            margin: 0;
        }

        .seats {
            display: flex;
            flex-direction: row;
            flex-wrap: nowrap;
            justify-content: flex-start;
        }

        .seat {
            display: flex;
            flex: 0 0 14.28571%;
            padding: 5px;
            position: relative;
        }

            .seat:nth-child(3) {
                margin-right: 14.28571%;
            }

            .seat input[type=checkbox] {
                position: absolute;
                opacity: 0;
            }

                .seat input[type=checkbox]:checked + label {
                    background: #bada55;
                    -webkit-animation-name: rubberBand;
                    animation-name: rubberBand;
                    animation-duration: 300ms;
                    animation-fill-mode: both;
                }

                .seat input[type=checkbox]:disabled + label {
    ");
            WriteLiteral(@"                background: #ddd;
                    text-indent: -9999px;
                    overflow: hidden;
                }

                    .seat input[type=checkbox]:disabled + label:after {
                        content: ""X"";
                        text-indent: 0;
                        position: absolute;
                        top: 4px;
                        left: 50%;
                        transform: translate(-50%, 0%);
                    }

                    .seat input[type=checkbox]:disabled + label:hover {
                        box-shadow: none;
                        cursor: not-allowed;
                    }

            .seat label {
                display: block;
                position: relative;
                width: 100%;
                text-align: center;
                font-size: 14px;
                font-weight: bold;
                line-height: 1.5rem;
                padding: 4px 0;
                background: #f42536;
     ");
            WriteLiteral(@"           border-radius: 5px;
                animation-duration: 300ms;
                animation-fill-mode: both;
            }

                .seat label:before {
                    content: """";
                    position: absolute;
                    width: 75%;
                    height: 75%;
                    top: 1px;
                    left: 50%;
                    transform: translate(-50%, 0%);
                    background: rgba(255, 255, 255, .4);
                    border-radius: 3px;
                }

                .seat label:hover {
                    cursor: pointer;
                    box-shadow: 0 0 0px 2px #5c6aff;
                }

        ");
            EndContext();
            BeginContext(6690, 1064, true);
            WriteLiteral(@"@-webkit-keyframes rubberBand {
            0% {
                -webkit-transform: scale3d(1, 1, 1);
                transform: scale3d(1, 1, 1);
            }

            30% {
                -webkit-transform: scale3d(1.25, 0.75, 1);
                transform: scale3d(1.25, 0.75, 1);
            }

            40% {
                -webkit-transform: scale3d(0.75, 1.25, 1);
                transform: scale3d(0.75, 1.25, 1);
            }

            50% {
                -webkit-transform: scale3d(1.15, 0.85, 1);
                transform: scale3d(1.15, 0.85, 1);
            }

            65% {
                -webkit-transform: scale3d(0.95, 1.05, 1);
                transform: scale3d(0.95, 1.05, 1);
            }

            75% {
                -webkit-transform: scale3d(1.05, 0.95, 1);
                transform: scale3d(1.05, 0.95, 1);
            }

            100% {
                -webkit-transform: scale3d(1, 1, 1);
                transform: scale3d(1, 1, 1");
            WriteLiteral(");\r\n            }\r\n        }\r\n\r\n        ");
            EndContext();
            BeginContext(7755, 1204, true);
            WriteLiteral(@"@keyframes rubberBand {
            0% {
                -webkit-transform: scale3d(1, 1, 1);
                transform: scale3d(1, 1, 1);
            }

            30% {
                -webkit-transform: scale3d(1.25, 0.75, 1);
                transform: scale3d(1.25, 0.75, 1);
            }

            40% {
                -webkit-transform: scale3d(0.75, 1.25, 1);
                transform: scale3d(0.75, 1.25, 1);
            }

            50% {
                -webkit-transform: scale3d(1.15, 0.85, 1);
                transform: scale3d(1.15, 0.85, 1);
            }

            65% {
                -webkit-transform: scale3d(0.95, 1.05, 1);
                transform: scale3d(0.95, 1.05, 1);
            }

            75% {
                -webkit-transform: scale3d(1.05, 0.95, 1);
                transform: scale3d(1.05, 0.95, 1);
            }

            100% {
                -webkit-transform: scale3d(1, 1, 1);
                transform: scale3d(1, 1, 1);
    ");
            WriteLiteral("        }\r\n        }\r\n\r\n        .rubberBand {\r\n            -webkit-animation-name: rubberBand;\r\n            animation-name: rubberBand;\r\n        }\r\n    </style>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyFlight.ViewModel.ReservationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
