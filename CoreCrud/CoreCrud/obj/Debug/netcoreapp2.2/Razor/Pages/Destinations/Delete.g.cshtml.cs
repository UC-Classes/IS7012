#pragma checksum "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cdef7130b2a6610467fa156349aed1300803d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreCrud.Pages.Destinations.Pages_Destinations_Delete), @"mvc.1.0.razor-page", @"/Pages/Destinations/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Destinations/Delete.cshtml", typeof(CoreCrud.Pages.Destinations.Pages_Destinations_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cdef7130b2a6610467fa156349aed1300803d00", @"/Pages/Destinations/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70be34fe23130313fbdf16acefe8f2e4f5da9be3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Destinations_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
  
    ViewData["Title"] = "Delete a Destination";

#line default
#line hidden
            BeginContext(113, 365, true);
            WriteLiteral(@"    <img src=""https://www.centcom.mil/Portals/6/Official_CENTCOM_Seal.png?ver=2016-07-26-155712-367"" alt=""CENTCOM"" width=""100"" height=""100"" />
    <h1 class=""display-4"">Delete a CENTCOM Destination</h1>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Destination</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
            EndContext();
            BeginContext(479, 56, false);
#line 16 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.TripName));

#line default
#line hidden
            EndContext();
            BeginContext(535, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(597, 52, false);
#line 19 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.TripName));

#line default
#line hidden
            EndContext();
            BeginContext(649, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(710, 57, false);
#line 22 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.LeaveDate));

#line default
#line hidden
            EndContext();
            BeginContext(767, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(829, 53, false);
#line 25 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.LeaveDate));

#line default
#line hidden
            EndContext();
            BeginContext(882, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(943, 58, false);
#line 28 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1063, 54, false);
#line 31 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.ReturnDate));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1178, 61, false);
#line 34 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.NationalParks));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1301, 57, false);
#line 37 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.NationalParks));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1419, 57, false);
#line 40 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.DiveSites));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1538, 53, false);
#line 43 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.DiveSites));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1652, 54, false);
#line 46 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1768, 50, false);
#line 49 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1879, 56, false);
#line 52 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination.Location));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1997, 64, false);
#line 55 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Destination.Location.CountryName));

#line default
#line hidden
            EndContext();
            BeginContext(2061, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2099, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdef7130b2a6610467fa156349aed1300803d0011591", async() => {
                BeginContext(2119, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2129, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7cdef7130b2a6610467fa156349aed1300803d0011984", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 60 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreCrud\CoreCrud\Pages\Destinations\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Destination.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2177, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2260, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cdef7130b2a6610467fa156349aed1300803d0013927", async() => {
                    BeginContext(2282, 12, true);
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
                BeginContext(2298, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2311, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreCrud.Pages.Destinations.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreCrud.Pages.Destinations.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoreCrud.Pages.Destinations.DeleteModel>)PageContext?.ViewData;
        public CoreCrud.Pages.Destinations.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
