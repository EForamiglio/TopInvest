#pragma checksum "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "292ddc46dfc2f74fa98ed052e253ff42f3690602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RendaFixa_Index), @"mvc.1.0.view", @"/Views/RendaFixa/Index.cshtml")]
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
#line 1 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\_ViewImports.cshtml"
using TopInvest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\_ViewImports.cshtml"
using TopInvest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292ddc46dfc2f74fa98ed052e253ff42f3690602", @"/Views/RendaFixa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb542381e2177a4c0c3ec77c800289f005d2841d", @"/Views/_ViewImports.cshtml")]
    public class Views_RendaFixa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RendaFixaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2 class=""text-center white-text"">Listagem de Rendas Fixas</h2>
</br>


<fieldset id=""areaFiltro"" class=""form-group"">
    <legend class=""white-text"">Filtro</legend>
    <div class=""row"">
        <div class=""col-lg-4 text-white"">
            Descrição<br />
            <input type=""text"" id=""descricao"" class=""form-control"" />
        </div>
        <div class=""col-lg-1"">
            <br />
            <input type=""button"" id=""btnFiltro"" class=""btn btn-success purple-color"" value=""Aplicar""
                   onclick=""aplicaFiltroConsultaAvancadaFixa()"" />
        </div>
    </div>
</fieldset>

<br />
<br />

<a href=""/rendaFixa/create"" class=""btn btn-success me-2 purple-color"">Novo Registro</a>
</br> </br>

<div id=""resultadoConsulta"" class=""table-responsive""> 

    <table class=""table"">
        <thead>
            <tr>
                <th class= ""white-text"" scope=""col"">Ações</th>
                <th class= ""white-text"" scope=""col"">Descrição</th>
                <th class= ""whi");
            WriteLiteral("te-text\" scope=\"col\">Duração</th>\r\n                <th class= \"white-text\" scope=\"col\">Rentabilidade</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
             foreach (var renda in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1404, "\"", 1439, 2);
            WriteAttributeValue("", 1411, "/rendaFixa/Edit?id=", 1411, 19, true);
#nullable restore
#line 46 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
WriteAttributeValue("", 1430, renda.Id, 1430, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary me-2\">Editar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1508, "\"", 1548, 3);
            WriteAttributeValue("", 1515, "javascript:apagarRenda(", 1515, 23, true);
#nullable restore
#line 47 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
WriteAttributeValue("", 1538, renda.Id, 1538, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1547, ")", 1547, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                    </td>\r\n                    <td class=\"text-white\">");
#nullable restore
#line 49 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
                                      Write(renda.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-white\">");
#nullable restore
#line 50 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
                                      Write(renda.Duracao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-white\">");
#nullable restore
#line 51 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
                                      Write(renda.Rentabilidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\RendaFixa\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n<script>\r\n    function apagarRenda(id) {\r\n        if (confirm(\'Confirma a exclusão do registro?\'))\r\n            location.href = \'/rendaFixa/Delete?id=\' + id;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RendaFixaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
