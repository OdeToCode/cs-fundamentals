#pragma checksum "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afac4df24688cb8a3ce4fd2126be9532b6664e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Employees.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Employees.Web.Pages.Pages_Index), null)]
namespace Employees.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\_ViewImports.cshtml"
using Employees.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afac4df24688cb8a3ce4fd2126be9532b6664e37", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21b9719e1a4c21bcbdd133fe520f2eff654f5ad", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 55, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(127, 14, false);
#line 8 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
                     Write(Model.Greeting);

#line default
#line hidden
            EndContext();
            BeginContext(141, 75, true);
            WriteLiteral("</h1>\r\n    <div>\r\n        The total number of employees in the database is ");
            EndContext();
            BeginContext(217, 23, false);
#line 10 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
                                                    Write(Model.Employees.Count());

#line default
#line hidden
            EndContext();
            BeginContext(240, 71, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        And the employees are:\r\n        <ul>\r\n");
            EndContext();
#line 15 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
             foreach (var employee in Model.Employees)
            {

#line default
#line hidden
            BeginContext(382, 20, true);
            WriteLiteral("                <li>");
            EndContext();
            BeginContext(403, 18, false);
#line 17 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
               Write(employee.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(421, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(423, 17, false);
#line 17 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
                                   Write(employee.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(440, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\github\cs-fundamentals\Employees\Employees.Web\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(462, 144, true);
            WriteLiteral("       </ul>\r\n</div>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
