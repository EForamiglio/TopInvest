#pragma checksum "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b1673bb9be65c4842ac739dbbdb0fbf16981eee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trade_pvTrade), @"mvc.1.0.view", @"/Views/Trade/pvTrade.cshtml")]
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
#line 1 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\_ViewImports.cshtml"
using TopInvest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\_ViewImports.cshtml"
using TopInvest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b1673bb9be65c4842ac739dbbdb0fbf16981eee", @"/Views/Trade/pvTrade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb542381e2177a4c0c3ec77c800289f005d2841d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Trade_pvTrade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RendaVariavelViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table mx-auto"">
    <thead>
        <tr>
            <th scope=""col"">Ícone</th>
            <th scope=""col"">Sigla</th>
            <th scope=""col"">Preço</th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 13 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml"
         foreach (var renda in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img id=\"imgPreview\"");
            BeginWriteAttribute("src", " src=\"", 424, "\"", 474, 2);
            WriteAttributeValue("", 430, "data:image/jpeg;base64,", 430, 23, true);
#nullable restore
#line 17 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml"
WriteAttributeValue("", 453, renda.ImagemEmBase64, 453, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"\r\n                         width=\"50\">\r\n                </td>\r\n                <td>");
#nullable restore
#line 20 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml"
               Write(renda.Sigla);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml"
               Write(renda.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 727, 3);
            WriteAttributeValue("", 690, "javascript:confirmarCompra(", 690, 27, true);
#nullable restore
#line 23 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml"
WriteAttributeValue("", 717, renda.Id, 717, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 726, ")", 726, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Comprar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\Trade\pvTrade.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RendaVariavelViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
