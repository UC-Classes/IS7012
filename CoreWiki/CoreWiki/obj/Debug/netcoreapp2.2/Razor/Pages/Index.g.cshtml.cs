#pragma checksum "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreWiki\CoreWiki\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c340cd384037046db7844b562225486a7b0fc5c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreWiki.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(CoreWiki.Pages.Pages_Index), null)]
namespace CoreWiki.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreWiki\CoreWiki\Pages\_ViewImports.cshtml"
using CoreWiki;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c340cd384037046db7844b562225486a7b0fc5c6", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47707e90384320186ebec9ea2ac07aa1df27304a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\source\repos\UC-Classes\IS7012\CoreWiki\CoreWiki\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 2628, true);
            WriteLiteral(@"
<h1>IS7012 - Homework assignment</h1>
<p><a href=""https://github.com/UC-Classes/IS7012/tree/master/CoreWiki"">https://github.com/UC-Classes/IS7012/tree/master/CoreWiki</a></p>
<p>As a result of the Wikipedia outage, this assignment will be based on ""Citizendium"". A similar, but different site that was not the target 
    of the cyber attacks. I had researched wiki pages and had my assignment planned out, but when I went to access the pages I found the outage 
    with Wikipedia. This means you will get the running up pages from ""Citizendium"".</p>
<p>The below are three physics pages. They were intended to be some of my favorite quantum mechanics equations and discoveries. Unfortunatly, 
    Heisenberg uncertainty principle was not avalible so we have a simple Measurement in quantum mechanics in it's place.</p>
<hr />
<table>
    <tbody>
    <thead>
        <tr>
            <th><strong>Site Name</strong></th>
            <th><strong>Github Link</strong></th>
            <th><strong>External Link");
            WriteLiteral(@"</strong></th>
        </tr>
    </thead>
        <tr>
            <td><strong><a href=""Bohr_radius"">Page 1 - Bohr's Radius</a></strong></td>
            <td><a href=""https://github.com/UC-Classes/IS7012/tree/master/CoreWiki/CoreWiki/Pages/Bohr_radius.cshtml/"">https://github.com/UC-Classes/IS7012/tree/master/CoreWiki/CoreWiki/Pages/Bohr_radius.cshtml/</a></td>
            <td><a href=""http://en.citizendium.org/wiki/Bohr_radius"">http://en.citizendium.org/wiki/Bohr_radius</a></td>
        </tr>
        <tr>
            <td><strong><a href=""Planck_constant"">Page 2 - Planck's Constant</a></strong></td>
            <td><a href=""https://github.com/UC-Classes/IS7012/tree/master/CoreWiki/CoreWiki/Pages/Planck_constant.cshtml/"">https://github.com/UC-Classes/IS7012/tree/master/CoreWiki/CoreWiki/Pages/Planck_constant.cshtml/</a></td>
            <td><a href=""http://en.citizendium.org/wiki/Planck%27s_constant"">http://en.citizendium.org/wiki/Planck%27s_constant</a></td>
        </tr>
        <tr>
           ");
            WriteLiteral(@" <td><strong><a href=""Measurement_in_quantum_mechanics"">Page 3 - Measurement in quantum mechanics</a></strong></td>
            <td><a href=""https://github.com/UC-Classes/IS7012/tree/master/CoreWiki/CoreWiki/Pages/Measurement_in_quantum_mechanics.cshtml"">https://github.com/UC-Classes/IS7012/tree/master/CoreWiki/CoreWiki/Pages/Measurement_in_quantum_mechanics.cshtml</a></td>
            <td><a href=""http://en.citizendium.org/wiki/Measurement_in_quantum_mechanics"">http://en.citizendium.org/wiki/Measurement_in_quantum_mechanics</a></td>
        </tr>
    </tbody>
</table>");
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
