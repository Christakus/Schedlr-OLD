#pragma checksum "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb8fa9fa289f74d711d7e869bc834e3d4468ac38"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb8fa9fa289f74d711d7e869bc834e3d4468ac38", @"/Pages/Dashboard.cshtml")]
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
            WriteLiteral(@" 's Dashboard</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""container"">
    <div class="" col-md-5 scrollBar"">
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
");
#nullable restore
#line 23 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                 for (int i = 0; i < Model.Shifts.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                                   Write(Model.Shifts[i].ShiftID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>N/A</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                       Write(Model.Shifts[i].ShiftRole);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                       Write(Model.Shifts[i].ShiftStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                       Write(Model.Shifts[i].ShiftEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\CBrew\Documents\Final Year Project\Schedlr\Schedlr\Schedlr\Pages\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!--  <script src=\"~/lib/moment.js/moment.min.js\"></script> -->\r\n");
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
