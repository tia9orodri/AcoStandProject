#pragma checksum "C:\ti2Server\AcoStandProject\AcoStand\Views\Favoritos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b66039fb77d773b0f2ac9544922d77dd1cedd97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Favoritos_Index), @"mvc.1.0.view", @"/Views/Favoritos/Index.cshtml")]
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
#line 1 "C:\ti2Server\AcoStandProject\AcoStand\Views\_ViewImports.cshtml"
using AcoStand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ti2Server\AcoStandProject\AcoStand\Views\_ViewImports.cshtml"
using AcoStand.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b66039fb77d773b0f2ac9544922d77dd1cedd97", @"/Views/Favoritos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a5dabaaef3b3817c653188a44858797894e6702", @"/Views/_ViewImports.cshtml")]
    public class Views_Favoritos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AcoStand.Models.Favoritos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\ti2Server\AcoStandProject\AcoStand\Views\Favoritos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Favoritos</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\ti2Server\AcoStandProject\AcoStand\Views\Favoritos\Index.cshtml"
           Write(Html.ActionLink("Categoria", "Index", new { sortOrder = ViewBag.ordernarCategoria, currentFilter = ViewBag.CurrentFilter }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\ti2Server\AcoStandProject\AcoStand\Views\Favoritos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 21 "C:\ti2Server\AcoStandProject\AcoStand\Views\Favoritos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Artigo.Categoria.Designacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\ti2Server\AcoStandProject\AcoStand\Views\Favoritos\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AcoStand.Models.Favoritos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
