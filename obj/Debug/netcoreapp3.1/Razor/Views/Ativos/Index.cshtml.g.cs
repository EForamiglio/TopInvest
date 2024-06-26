#pragma checksum "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9404184305edbf46c0cc65bc9bc3a000190a267a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ativos_Index), @"mvc.1.0.view", @"/Views/Ativos/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9404184305edbf46c0cc65bc9bc3a000190a267a", @"/Views/Ativos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb542381e2177a4c0c3ec77c800289f005d2841d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ativos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TradeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div id=""acoes"" class=""table-responsive"">
    <h3 class= ""white-text"">Carteira de Ações</h3>
    <table class=""table mx-auto"">
        <thead>
            <tr>
                <th class=""white-text"" scope=""col""></th>
                <th class=""white-text"" scope=""col"">Sigla</th>
                <th class=""white-text"" scope=""col"">Valor</th>
                <th class=""white-text"" scope=""col"">Quantidade</th>
                <th class=""white-text"" scope=""col"">DataCompra</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
             foreach (var trade in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <img id=\"imgPreview\"");
            BeginWriteAttribute("src", " src=\"", 720, "\"", 770, 2);
            WriteAttributeValue("", 726, "data:image/jpeg;base64,", 726, 23, true);
#nullable restore
#line 20 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
WriteAttributeValue("", 749, trade.ImagemEmBase64, 749, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\"\r\n                             width=\"50\">\r\n                    </td>\r\n                    <td class=\"white-text\">");
#nullable restore
#line 23 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                      Write(trade.Sigla);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"white-text\">");
#nullable restore
#line 24 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                      Write(trade.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"white-text\">");
#nullable restore
#line 25 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                      Write(trade.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"white-text\">");
#nullable restore
#line 26 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                      Write(trade.DataCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

</br></br></br></br>

<div id=""fixos"" class=""table-responsive"">
    <h3 class= ""white-text"">Aplicações</h3>
    <table class=""table mx-auto"">
        <thead>
            <tr>
                <th class= ""white-text"" scope=""col"">Descricao</th>
                <th class= ""white-text"" scope=""col"">Valor</th>
                <th class= ""white-text"" scope=""col"">Duracao</th>
                <th class= ""white-text"" scope=""col"">Rentabilidade</th>
                <th class= ""white-text"" scope=""col"">RendimentoFinal</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 48 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
             foreach (var fixo in ViewBag.Fixos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class= \"white-text\">");
#nullable restore
#line 51 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                       Write(fixo.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class= \"white-text\">R$ ");
#nullable restore
#line 52 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                          Write(fixo.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class= \"white-text\">");
#nullable restore
#line 53 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                       Write(fixo.Duracao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" meses</td>\r\n                    <td class= \"white-text\">");
#nullable restore
#line 54 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                       Write(fixo.Rentabilidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                    <td class= \"white-text\">R$ ");
#nullable restore
#line 55 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
                                          Write(fixo.RendimentoFinal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 57 "C:\Users\eloat\OneDrive\Documentos\Nova pasta\TopInvest\Views\Ativos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""resultadoConsulta"" class=""table-responsive"">
                
            </div>
        </div>
        <div class=""col-md-6"">
            <div id=""resultadoConsulta"" class=""table-responsive"">
                
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TradeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
