#pragma checksum "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bf81e741e5f254b225711f4fc9ae47510f1916d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RendaVariavel_Index), @"mvc.1.0.view", @"/Views/RendaVariavel/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bf81e741e5f254b225711f4fc9ae47510f1916d", @"/Views/RendaVariavel/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb542381e2177a4c0c3ec77c800289f005d2841d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RendaVariavel_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RendaVariavelViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Listagem de Ações</h2>\r\n</br>\r\n<a href=\"/RendaVariavel/create\">Novo Registro</a>\r\n<table class=\"table table-responsive\">\r\n    <tr>\r\n        <th>Ações</th>\r\n        <th>Sigla</th>\r\n        <th>Preço</th>\r\n        <th>Icone</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
     foreach (var renda in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 426, "\"", 465, 2);
            WriteAttributeValue("", 433, "/RendaVariavel/Edit?id=", 433, 23, true);
#nullable restore
#line 19 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
WriteAttributeValue("", 456, renda.Id, 456, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 497, "\"", 536, 3);
            WriteAttributeValue("", 504, "javascript:apagarAcao(", 504, 22, true);
#nullable restore
#line 20 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
WriteAttributeValue("", 526, renda.Id, 526, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 535, ")", 535, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n            </td>\r\n            <td>");
#nullable restore
#line 22 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
           Write(renda.Sigla);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
           Write(renda.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img id=\"imgPreview\"");
            BeginWriteAttribute("src", " src=\"", 693, "\"", 743, 2);
            WriteAttributeValue("", 699, "data:image/jpeg;base64,", 699, 23, true);
#nullable restore
#line 25 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
WriteAttributeValue("", 722, renda.ImagemEmBase64, 722, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"\r\n                width=\"50\">\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "D:\Erik\Materia Facul\Sem5\LP1\N1-2bim\TopInvest\Views\RendaVariavel\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<script>\r\n    function apagarAcao(id) {\r\n        if (confirm(\'Confirma a exclusão do registro?\'))\r\n            location.href = \'/rendaVariavel/Delete?id=\' + id;\r\n    }\r\n</script>\r\n");
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
