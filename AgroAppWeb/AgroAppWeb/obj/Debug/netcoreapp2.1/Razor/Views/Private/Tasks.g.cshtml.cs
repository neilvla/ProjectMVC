#pragma checksum "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2326ba1707cb7739a00b82d303d4493fa9f3c7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Private_Tasks), @"mvc.1.0.view", @"/Views/Private/Tasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Private/Tasks.cshtml", typeof(AspNetCore.Views_Private_Tasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2326ba1707cb7739a00b82d303d4493fa9f3c7d1", @"/Views/Private/Tasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a78bb435eafae314621407119ab47809185ae6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Private_Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Task>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TaskForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
  
    ViewData["Title"] = "Tasks";
    Layout = "~/Views/Structure/_PrivateLayout.cshtml";

#line default
#line hidden
            BeginContext(136, 199, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-sm-4\">\r\n        <h2>This is main title</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 335, "\"", 382, 1);
#line 12 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
WriteAttributeValue("", 342, Url.Action("Dashboard_1", "Dashboards"), 342, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(383, 823, true);
            WriteLiteral(@">This is</a>
            </li>
            <li class=""active"">
                <strong>Breadcrumb</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Tareas</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div class=""row"" style=""padding-bottom: 20px;"">
                        <div class=""col-md-12"">
                            ");
            EndContext();
            BeginContext(1206, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1b2f49fc7fe442caa27cb179fa4f518", async() => {
                BeginContext(1255, 7, true);
                WriteLiteral("Agregar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1266, 853, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row"">
                        <table class=""table table-striped table-bordered table-hover mydataTables"">
                            <thead>
                                <tr>
                                    <th>
                                        Nombre
                                    </th>
                                    <th>
                                        Descripción
                                    </th>
                                    <th>
                                        Fecha de Creación
                                    </th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 55 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                 if (Model != null)
                                {
                                    

#line default
#line hidden
#line 57 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(2312, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2457, 9, false);
#line 61 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2466, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2618, 16, false);
#line 64 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2634, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2786, 36, false);
#line 67 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                           Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2822, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2973, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32abd87c45b44e2283b2377fe276a541", async() => {
                BeginContext(3053, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                                                                                          WriteLiteral(item.Id);

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
            BeginContext(3083, 50, true);
            WriteLiteral("\r\n                                                ");
            EndContext();
            BeginContext(3133, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d11be06a52c3406fbf1ed0514dc10a9f", async() => {
                BeginContext(3211, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                                                                                        WriteLiteral(item.Id);

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
            BeginContext(3242, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 74 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                    }

#line default
#line hidden
#line 74 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Tasks.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(3416, 180, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591