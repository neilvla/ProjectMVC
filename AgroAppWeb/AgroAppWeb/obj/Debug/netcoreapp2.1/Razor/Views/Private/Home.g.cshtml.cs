#pragma checksum "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c0076c43075adcff0857eaf5889784531150c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Private_Home), @"mvc.1.0.view", @"/Views/Private/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Private/Home.cshtml", typeof(AspNetCore.Views_Private_Home))]
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
#line 1 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\_ViewImports.cshtml"
using AgroAppWeb.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c0076c43075adcff0857eaf5889784531150c1", @"/Views/Private/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a78bb435eafae314621407119ab47809185ae6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Private_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Home.cshtml"
  
    ViewData["Title"] = "Home";
    Layout = "~/Views/Structure/_PrivateLayout.cshtml";

#line default
#line hidden
            BeginContext(97, 199, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-sm-4\">\r\n        <h2>This is main title</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 296, "\"", 343, 1);
#line 11 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Home.cshtml"
WriteAttributeValue("", 303, Url.Action("Dashboard_1", "Dashboards"), 303, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(344, 399, true);
            WriteLiteral(@">This is</a>
            </li>
            <li class=""active"">
                <strong>Breadcrumb</strong>
            </li>
        </ol>
    </div>
    <div class=""col-sm-8"">
        <div class=""title-action"">
            <a href="""" class=""btn btn-primary"">This is action area</a>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">

    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
