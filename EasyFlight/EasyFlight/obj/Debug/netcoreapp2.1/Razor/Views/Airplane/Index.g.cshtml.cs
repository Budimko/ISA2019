#pragma checksum "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be1169e951ef8a85ba147b965b0377e4b877e77f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Airplane_Index), @"mvc.1.0.view", @"/Views/Airplane/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Airplane/Index.cshtml", typeof(AspNetCore.Views_Airplane_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be1169e951ef8a85ba147b965b0377e4b877e77f", @"/Views/Airplane/Index.cshtml")]
    public class Views_Airplane_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyFlight.ViewModel.AirlineHomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 223, true);
            WriteLiteral("<div class=\"plane\">\r\n    <div class=\"cockpit\">\r\n        <h1>Please select a seat</h1>\r\n    </div>\r\n    <div class=\"exit exit--front fuselage\">\r\n\r\n    </div>\r\n    <form method=\"post\">\r\n        <ol class=\"cabin fuselage\">\r\n\r\n");
            EndContext();
#line 12 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
             for (int j = 0; j < 10; j++)
            {

#line default
#line hidden
            BeginContext(331, 19, true);
            WriteLiteral("                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 350, "\"", 377, 2);
            WriteAttributeValue("", 358, "row1", 358, 4, true);
#line 14 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
WriteAttributeValue(" ", 362, "row--" + j, 363, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(378, 52, true);
            WriteLiteral(">\r\n                    <ol class=\"seats\" type=\"A\">\r\n");
            EndContext();
#line 16 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
                         for (int i = 0; i < 6; i++)
                        {
                            string[] seats = new string[] { "A", "B", "C", "D", "E", "F" };
                            var disabled = @Model.seats.ElementAt(j * 6 + i).Disabled;

                            

#line default
#line hidden
            BeginContext(722, 89, true);
            WriteLiteral("<li class=\"seat\">\r\n                                <input class=\"seat-cb\" type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 811, "\"", 837, 1);
#line 22 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
WriteAttributeValue("", 818, (j +1)+ seats[i], 818, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(838, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(841, 60, false);
#line 22 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
                                                                                              Write(@Model.seats.ElementAt(j * 6 + i).Occupide ? "disabled" : "");

#line default
#line hidden
            EndContext();
            BeginContext(902, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(905, 26, false);
#line 22 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
                                                                                                                                                              Write(disabled ? "disabled" : "");

#line default
#line hidden
            EndContext();
            BeginContext(932, 5, true);
            WriteLiteral(" id=\"");
            EndContext();
            BeginContext(939, 16, false);
#line 22 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
                                                                                                                                                                                                Write((j +1)+ seats[i]);

#line default
#line hidden
            EndContext();
            BeginContext(956, 44, true);
            WriteLiteral("\" />\r\n                                <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1000, "\"", 1025, 1);
#line 23 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
WriteAttributeValue("", 1006, (j+1) + seats[i], 1006, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1026, "\"", 1067, 1);
#line 23 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
WriteAttributeValue("", 1034, disabled ? "text-warning" : "", 1034, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1068, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1071, 18, false);
#line 23 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
                                                                                                       Write((j + 1) + seats[i]);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 47, true);
            WriteLiteral("</label>\r\n\r\n                            </li>\r\n");
            EndContext();
#line 26 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1164, 50, true);
            WriteLiteral("                    </ol>\r\n                </li>\r\n");
            EndContext();
#line 29 "C:\Users\MB\Desktop\ISA2019\EasyFlight\EasyFlight\Views\Airplane\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1229, 4280, true);
            WriteLiteral(@"        </ol>
        

        <div class=""exit exit--back fuselage"">

        </div>
        <button type=""submit"" class=""btn btn-primary"" value=""Update"">Update</button>
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
            border-left: 5px solid #d8d8d8;
        }

        .cockpit h1 {
         ");
            WriteLiteral(@"   width: 60%;
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
        list-style: none;
        padding: 0;
        margin: 0;
    }

    .seats {
        display: flex;
        flex-direction: row;
        flex-wrap: nowrap;
        justify-content: flex-start;
    }
");
            WriteLiteral(@"
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
                background: #ddd;
                text-indent: -9999px;
                overflow: hidden;
            }

                .seat input[type=checkbox]:disabled + label:after {
                    content: ""X"";
                    text-indent: 0;
                    position: absolute;
                    top: 4px;
        ");
            WriteLiteral(@"            left: 50%;
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
            border-radius: 5px;
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
        ");
            WriteLiteral("        border-radius: 3px;\r\n            }\r\n\r\n            .seat label:hover {\r\n                cursor: pointer;\r\n                box-shadow: 0 0 0px 2px #5c6aff;\r\n            }\r\n\r\n    ");
            EndContext();
            BeginContext(5510, 944, true);
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
            transform: scale3d(1, 1, 1);
        }
    }

    ");
            EndContext();
            BeginContext(6455, 1052, true);
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
        }
    }

    .rubberBand {
        -webkit-animation-name: rubberBand;
        animation-name: rubb");
            WriteLiteral("erBand;\r\n    }\r\n</style>\r\n\r\n");
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
