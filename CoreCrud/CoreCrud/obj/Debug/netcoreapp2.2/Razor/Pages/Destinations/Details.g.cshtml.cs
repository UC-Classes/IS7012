#pragma checksum "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fda55df817103fc6f4eb5fc54a564ea1c0f3a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreCrud.Pages.Destinations.Pages_Destinations_Details), @"mvc.1.0.razor-page", @"/Pages/Destinations/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Destinations/Details.cshtml", typeof(CoreCrud.Pages.Destinations.Pages_Destinations_Details), null)]
namespace CoreCrud.Pages.Destinations
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\_ViewImports.cshtml"
using CoreCrud;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fda55df817103fc6f4eb5fc54a564ea1c0f3a91", @"/Pages/Destinations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70be34fe23130313fbdf16acefe8f2e4f5da9be3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Destinations_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(101, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Destination</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(234, 56, false);
#line 15 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.TripName));

#line default
#line hidden
            EndContext();
            BeginContext(290, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(352, 52, false);
#line 18 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.TripName));

#line default
#line hidden
            EndContext();
            BeginContext(404, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(465, 57, false);
#line 21 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.LeaveDate));

#line default
#line hidden
            EndContext();
            BeginContext(522, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 53, false);
#line 24 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.LeaveDate));

#line default
#line hidden
            EndContext();
            BeginContext(637, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(698, 58, false);
#line 27 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(756, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(818, 54, false);
#line 30 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(872, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(933, 61, false);
#line 33 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.NationalParks));

#line default
#line hidden
            EndContext();
            BeginContext(994, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1056, 57, false);
#line 36 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.NationalParks));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1174, 57, false);
#line 39 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.DiveSites));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1293, 53, false);
#line 42 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.DiveSites));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1407, 54, false);
#line 45 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1523, 50, false);
#line 48 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(1573, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1634, 56, false);
#line 51 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1752, 55, false);
#line 54 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination.Location.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1807, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1854, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fda55df817103fc6f4eb5fc54a564ea1c0f3a9110665", async() => {
                BeginContext(1912, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Details.cshtml"
                           WriteLiteral(Model.Destination.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1920, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1928, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fda55df817103fc6f4eb5fc54a564ea1c0f3a9113023", async() => {
                BeginContext(1950, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1966, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreCrud.Pages.Destinations.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreCrud.Pages.Destinations.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreCrud.Pages.Destinations.DetailsModel>)PageContext?.ViewData;
        public CoreCrud.Pages.Destinations.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591