#pragma checksum "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5cb411e7c0260bf55df94ba080d0ec3187363bb561f9394c991096aee847f2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producer_Index), @"mvc.1.0.view", @"/Views/Producer/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\ProjectUdm\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets

#nullable disable
    ;
#nullable restore
#line 2 "E:\ProjectUdm\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5cb411e7c0260bf55df94ba080d0ec3187363bb561f9394c991096aee847f2f8", @"/Views/Producer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"924b32b195cd0d020d2c3ebf6479a56dd20515b4821bcb9688b1ebb23a4f7f55", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Producer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
  
    ViewData["Title"] = "List Producer";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
            Write(
#nullable restore
#line 14 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                         Html.DisplayNameFor(Model => Model.ProfilePictureURL)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th>");
            Write(
#nullable restore
#line 15 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                         Html.DisplayNameFor(Model=>Model.FullName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th>");
            Write(
#nullable restore
#line 16 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                         Html.DisplayNameFor(Model => Model.Bio)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 21 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                 foreach(var producer in Model)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                  <tr class=\"text-center\">\r\n                    <td class=\"align-middle\">\r\n                        <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 901, "\"", 934, 1);
            WriteAttributeValue("", 907, 
#nullable restore
#line 25 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                                                          producer.ProfilePictureURL

#line default
#line hidden
#nullable disable
            , 907, 27, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 935, "\"", 959, 1);
            WriteAttributeValue("", 941, 
#nullable restore
#line 25 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                                                                                            producer.FullName

#line default
#line hidden
#nullable disable
            , 941, 18, false);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:100px; max-height:100px\"/>\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
            Write(
#nullable restore
#line 28 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                         Html.DisplayFor(producelModel=>producer.FullName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(";\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
            Write(
#nullable restore
#line 31 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                         Html.DisplayFor(producerModel=>producer.Bio)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@";
                    </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""> <i class=""bi bi-pencil-square""></i> Edit</a> |
                            <a class=""btn btn-outline-info""> <i class=""bi bi-eye""></i> Detail</a> |
                            <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i> Delete</a>
                        </td>
                    </tr>
");
#nullable restore
#line 39 "E:\ProjectUdm\eTickets\eTickets\Views\Producer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("               \r\n                   \r\n            </tbody>\r\n   \r\n</table>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
