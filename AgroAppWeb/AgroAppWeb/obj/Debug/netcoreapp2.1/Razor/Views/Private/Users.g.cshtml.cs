#pragma checksum "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "024af651d52db4797a0b2dfbdc565ac799a4b710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Private_Users), @"mvc.1.0.view", @"/Views/Private/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Private/Users.cshtml", typeof(AspNetCore.Views_Private_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"024af651d52db4797a0b2dfbdc565ac799a4b710", @"/Views/Private/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a78bb435eafae314621407119ab47809185ae6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Private_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Structure/_PrivateLayout.cshtml";

#line default
#line hidden
            BeginContext(138, 199, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-sm-4\">\r\n        <h2>This is main title</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 337, "\"", 384, 1);
#line 13 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
WriteAttributeValue("", 344, Url.Action("Dashboard_1", "Dashboards"), 344, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(385, 825, true);
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
                    <h5>Usuarios</h5>
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
            BeginContext(1210, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24e82ca054484cfe97b7419802f0c4c3", async() => {
                BeginContext(1259, 7, true);
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
            BeginContext(1270, 1255, true);
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
                                        Apellido
                                    </th>
                                    <th>
                                        Email
                                    </th>
                                    <th>
                                        Tipo de Usuario
                                    </th>
                                    <th>
                                        Foto
                                    </th>
                                    <th>
                                ");
            WriteLiteral("        Fecha de Creación\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 65 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                 if (Model != null)
                                {
                                    

#line default
#line hidden
#line 67 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(2718, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2839, 9, false);
#line 71 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2848, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2976, 13, false);
#line 74 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                   Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2989, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3117, 10, false);
#line 77 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3127, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3255, 18, false);
#line 80 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                   Write(item.UserType.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3273, 150, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <img class=\"img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3423, "\"", 3501, 1);
#line 83 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
WriteAttributeValue("", 3429, Url.Content("~/StaticFiles/agroappresource/images/users/" + item.Image), 3429, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3502, 176, true);
            WriteLiteral(" alt=\"Image\" style=\"width: 48px; height: 48px\" />\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3679, 36, false);
#line 86 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                   Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(3715, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3842, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46424dcae4d141e0a9d2ab4ed7253a01", async() => {
                BeginContext(3922, 26, true);
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
#line 89 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
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
            BeginContext(3952, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3994, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04ac75007afb4bde9389a53fe99cd90a", async() => {
                BeginContext(4072, 27, true);
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
#line 90 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
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
            BeginContext(4103, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 93 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                    }

#line default
#line hidden
#line 93 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Private\Users.cshtml"
                                     
                                }

#line default
#line hidden
            BeginContext(4261, 178, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591