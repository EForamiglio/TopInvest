using Microsoft.AspNetCore.Mvc;
using System;
using TopInvest.DAO;
using TopInvest.Models;

namespace TopInvest.Controllers
{
    public class RendaFixaController : PadraoController<RendaFixaViewModel>
    {
        public RendaFixaController()
        {
            DAO = new RendaFixaDAO();
            GeraProximoId = true;
            ExigeAdm = true;
        }

        public IActionResult ObtemDadosConsultaAvancada(string descricao, int duracao)
        {
            try
            {
                RendaFixaDAO dao = new RendaFixaDAO();
                if (string.IsNullOrEmpty(descricao))
                    descricao = "";

                var lista = dao.ConsultaFiltro(descricao, duracao);
                return PartialView("pvGridFixa", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
    }
}
