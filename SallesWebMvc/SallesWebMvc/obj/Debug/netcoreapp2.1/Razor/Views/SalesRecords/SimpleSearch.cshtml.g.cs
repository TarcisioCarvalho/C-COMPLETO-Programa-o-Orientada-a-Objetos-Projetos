#pragma checksum "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc0e4dab2322fdcb29343b25d32c9c85be0367b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\_ViewImports.cshtml"
using SallesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\_ViewImports.cshtml"
using SallesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc0e4dab2322fdcb29343b25d32c9c85be0367b", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c133fc5a2174abf951c3484b533785c9c9faeb", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SallesWebMvc.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 21, true);
            WriteLiteral("Skip to content\r\n\r\n\r\n");
            EndContext();
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Simple Search";

#line default
#line hidden
            BeginContext(125, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(132, 17, false);
#line 10 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(149, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(238, 664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc0e4dab2322fdcb29343b25d32c9c85be0367b5335", async() => {
                BeginContext(290, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 505, "", 532, 1);
#line 18 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 512, ViewData["minDate"], 512, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(532, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 736, "", 763, 1);
#line 22 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 743, ViewData["maxDate"], 743, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(763, 132, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(902, 136, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(1039, 43, false);
#line 31 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 215, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1298, 38, false);
#line 38 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1416, 40, false);
#line 41 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1536, 42, false);
#line 44 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1658, 53, false);
#line 47 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1711, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1791, 42, false);
#line 50 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1913, 46, false);
#line 53 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.SaleStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 95, true);
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 58 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2119, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2204, 37, false);
#line 62 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2333, 39, false);
#line 65 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2464, 46, false);
#line 68 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2510, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2602, 57, false);
#line 71 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2751, 41, false);
#line 74 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2792, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2884, 45, false);
#line 77 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SaleStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2929, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 80 "C:\Users\tarci\Documents\C-COMPLETO-Programa-o-Orientada-a-Objetos-Projetos\SallesWebMvc\SallesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(3008, 62, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SallesWebMvc.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591