#pragma checksum "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ef88423af9bf5278eb52ec8d5b3201724c6554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Structure__Navigation), @"mvc.1.0.view", @"/Views/Structure/_Navigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Structure/_Navigation.cshtml", typeof(AspNetCore.Views_Structure__Navigation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ef88423af9bf5278eb52ec8d5b3201724c6554", @"/Views/Structure/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a78bb435eafae314621407119ab47809185ae6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Structure__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Private", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Phases", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Stages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tasks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Illnesses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Controlsequence", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
  
    EntityLayer.Administrator a = (EntityLayer.Administrator)ViewData["admin"];

#line default
#line hidden
            BeginContext(88, 337, true);
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <span>
                        <img alt=""image"" id=""imgUser"" class=""img-circle""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 425, "\"", 500, 1);
#line 10 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 431, Url.Content("~/StaticFiles/agroappresource/images/users/" + a.Image), 431, 69, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(501, 343, true);
            WriteLiteral(@" onerror=""this.onerror=null;this.src='../images/user_default.jpg';"" />
                    </span>
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""clear"">
                            <span class=""block m-t-xs"">
                                <strong class=""font-bold"">");
            EndContext();
            BeginContext(845, 6, false);
#line 15 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
                                                     Write(a.Name);

#line default
#line hidden
            EndContext();
            BeginContext(851, 295, true);
            WriteLiteral(@"</strong>
                            </span> <span class=""text-muted text-xs block"">Administrador <b class=""caret""></b></span>
                        </span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"">
                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1146, "\"", 1187, 1);
#line 20 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 1153, Url.Action("Profile", "AppViews"), 1153, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1188, 48, true);
            WriteLiteral(">Perfil</a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1236, "\"", 1278, 1);
#line 21 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 1243, Url.Action("Contacts", "AppViews"), 1243, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1279, 51, true);
            WriteLiteral(">Contactos</a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1330, "\"", 1368, 1);
#line 22 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 1337, Url.Action("Inbox", "Mailbox"), 1337, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1369, 99, true);
            WriteLiteral(">Correo</a></li>\r\n                        <li class=\"divider\"></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1468, "\"", 1504, 1);
#line 24 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 1475, Url.Action("Login", "Pages"), 1475, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1505, 203, true);
            WriteLiteral(">Cerrar Sesión</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"logo-element\">\r\n                    IN+\r\n                </div>\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1708, "\"", 1771, 1);
#line 31 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 1716, Html.IsSelected(controller: "Private", action: "Home"), 1716, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1772, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(1791, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bbf7d28b973405194166549e05b5fdd", async() => {
                BeginContext(1837, 91, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Inicio</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(1932, 36, true);
            WriteLiteral("\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1968, "\"", 2032, 1);
#line 34 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 1976, Html.IsSelected(controller: "Private", action: "Users"), 1976, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2033, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2052, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6349a26998c04f929487ec2ed8badf43", async() => {
                BeginContext(2099, 93, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Usuarios</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2196, 36, true);
            WriteLiteral("\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2232, "\"", 2297, 1);
#line 37 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 2240, Html.IsSelected(controller: "Private", action: "Phases"), 2240, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2298, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2317, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7eb150d803247a2be050025c651fe12", async() => {
                BeginContext(2365, 90, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Fases</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2459, 36, true);
            WriteLiteral("\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2495, "\"", 2560, 1);
#line 40 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 2503, Html.IsSelected(controller: "Private", action: "Stages"), 2503, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2561, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2580, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94ab24b67984094a5ebe0bad6a34e5e", async() => {
                BeginContext(2628, 91, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Etapas</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2723, 36, true);
            WriteLiteral("\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2759, "\"", 2823, 1);
#line 43 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 2767, Html.IsSelected(controller: "Private", action: "Tasks"), 2767, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2824, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(2843, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b1b7dd3d6174afc8f7a65077b6fda05", async() => {
                BeginContext(2890, 91, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Tareas</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2985, 36, true);
            WriteLiteral("\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3021, "\"", 3089, 1);
#line 46 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 3029, Html.IsSelected(controller: "Private", action: "Illnesses"), 3029, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3090, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(3109, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e19e00ae656148ec860220c764db0548", async() => {
                BeginContext(3160, 90, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Males</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3254, 36, true);
            WriteLiteral("\r\n            </li>\r\n            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3290, "\"", 3364, 1);
#line 49 "F:\Tesis\AgroApp-Tesis\AgroAppWebSite\AgroAppWeb\AgroAppWeb\Views\Structure\_Navigation.cshtml"
WriteAttributeValue("", 3298, Html.IsSelected(controller: "Private", action: "ControlSequence"), 3298, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3365, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(3384, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b33b81e34154935bd708a9bb61ad3c3", async() => {
                BeginContext(3441, 105, true);
                WriteLiteral("<i class=\"fa fa-diamond\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Secuencia de Control</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3550, 54, true);
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</nav>");
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
