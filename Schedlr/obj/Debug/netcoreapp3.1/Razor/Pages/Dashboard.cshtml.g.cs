#pragma checksum "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b80796a7f5c4eb41b468a2874ebce20d1059142"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Schedlr.Pages.Pages_Dashboard), @"mvc.1.0.razor-page", @"/Pages/Dashboard.cshtml")]
namespace Schedlr.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\_ViewImports.cshtml"
using Schedlr;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b80796a7f5c4eb41b468a2874ebce20d1059142", @"/Pages/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f765b63f098575ace431be989d5fe0aa0bb7712b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> ");
#nullable restore
#line 6 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                      Write(Model.loggedEmployee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \'s Dashboard</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div class=\" shiftContainer\">\r\n\r\n\r\n    <div class=\" col-md-5 scrollBar\">\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
         for (int i = 0; i < Model.Shifts.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a href=""#"" data-toggle=""modal"" data-target=""#shift-modal"" style="" color: black;"">
                <div class=""card"" style="" border-style: groove ;"" onclick=""ShowShiftInfo()"">
                    <div class=""card-title"" style="" background-color: black; color: white;"">Date: N/A - ");
#nullable restore
#line 20 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                                                                                                   Write(Model.Shifts[i].ShiftRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"card-body cardHover\" style=\"text-align: center; \">\r\n\r\n                        <p>");
#nullable restore
#line 23 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                      Write(Model.Shifts[i].ShiftStart);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 23 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                                                    Write(Model.Shifts[i].ShiftEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 29 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        <!--
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">Day & Date</th>
                        <th scope=""col"">Role</th>
                        <th scope=""col"">Start</th>
                        <th scope=""col"">Finish</th>
                    </tr>
                </thead>
                <tbody>
                    for (int i = 0; i < Model.Shifts.Count; i++)
                    {
                        <tr>
                            <th scope=""row"">Model.Shifts[i].ShiftID</th>
                            <td>N/A</td>
                            <td>model.Shifts[i].ShiftRole</td>
                            <td>model.Shifts[i].ShiftStart</td>
                            <td>Model.Shifts[i].ShiftEnd</td>

                        </tr>
                    }
                </tbody>
            </table>
        -->
    </div>
    <div class=""col-md-4""");
            WriteLiteral(@">
        <div class=""modal fade"" id=""shift-modal"">
            <div class=""modal-dialog modal-dialog-scrollable"">
                <div class=""model-content"">
                    <div class=""model-header"">
                        <h2> Title</h2>

                    </div>
                    <div class=""modal-body"">
                        What is your name?

                    </div>
                    <div class=""modal-footer"">
                        <input class=""btn btn-primary"" data-dismiss=""modal"" value=""Close"" />

                    </div>
                    <div>

                    </div>
                </div>


            </div>
        </div>
    </div>

</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

            <script>
                function ShowShiftInfo() {
                    $(document).ready(function () {
                        $(""shift-modal"").modal('show');
                    });
                }

            </script>
            <!--  <script src=""~/lib/moment.js/moment.min.js""></script> -->
        ");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Schedlr.Pages.DashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Schedlr.Pages.DashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Schedlr.Pages.DashboardModel>)PageContext?.ViewData;
        public Schedlr.Pages.DashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
