#pragma checksum "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41e110c43c86fd8bd08a568c742ef655425959f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artigos_Index), @"mvc.1.0.view", @"/Views/Artigos/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\_ViewImports.cshtml"
using AcoStand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\_ViewImports.cshtml"
using AcoStand.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41e110c43c86fd8bd08a568c742ef655425959f7", @"/Views/Artigos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5dabaaef3b3817c653188a44858797894e6702", @"/Views/_ViewImports.cshtml")]
    public class Views_Artigos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<AcoStand.Models.Artigos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Artigos</h1>\r\n");
            WriteLiteral("<p>\r\n");
#nullable restore
#line 12 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
     if (User.IsInRole("Admin")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41e110c43c86fd8bd08a568c742ef655425959f74163", async() => {
                WriteLiteral("Novo Artigo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            WriteLiteral("            <th>\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.ActionLink("Categoria", "Index", new { sortOrder = ViewBag.ordenarCategoria, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.ActionLink("Preço", "Index", new { sortOrder = ViewBag.ordenarPreco, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.ActionLink("Nome do Utilizador", "Index", new { sortOrder = ViewBag.ordenarUtilizador, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.ActionLink("Título", "Index", new { sortOrder = ViewBag.ordenarTitulo, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Descrição\r\n            </th>\r\n\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
             if (User.IsInRole("Admin")) {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                   Write(Html.ActionLink("Validado", "Index", new { sortOrder = ViewBag.ordenarValidado, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                ");
#nullable restore
#line 47 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria.Designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("€\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dono.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
#nullable restore
#line 77 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
             if (User.IsInRole("Administrator"))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n                        ");
#nullable restore
#line 81 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Validado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                ");
#nullable restore
#line 83 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n");
#nullable restore
#line 86 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                 if (User.IsInRole("User"))
                {
                    if (User.Identity.Name == item.Dono.Username || User.IsInRole("Admin"))
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 91 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                       Write(Html.ActionLink("Editar", "Edit", new { id = item.IdArtigo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br />\r\n                            ");
#nullable restore
#line 93 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                       Write(Html.ActionLink("Eliminar", "Delete", new { id = item.IdArtigo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <br />\r\n                            ");
#nullable restore
#line 95 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                       Write(Html.ActionLink("Detalhes", "Details", new { id = item.IdArtigo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 96 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                               
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 101 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                       Write(Html.ActionLink("Detalhes", "Details", new { id = item.IdArtigo }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 102 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                               
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                }\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 108 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n\r\n");
            WriteLiteral("Page ");
#nullable restore
#line 114 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
 Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 114 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\Frederico Riachos\Source\Repos\AcoStandProject\AcoStand\Views\Artigos\Index.cshtml"
Write(Html.PagedListPager(Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<AcoStand.Models.Artigos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
