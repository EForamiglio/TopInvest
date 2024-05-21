using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TopInvest.DAO;
using TopInvest.Models;

namespace TopInvest.Controllers
{
    public class FixoController : Controller
    {
        public IActionResult Index()
        {
            if (!HelperController.VerificaUserLogado(HttpContext.Session))
                return RedirectToAction("Index", "Login");

            ViewBag.Logado = HelperController.VerificaUserLogado(HttpContext.Session);
            ViewBag.NomeUser = HelperController.PreencheNomeUser(HttpContext.Session);
            ViewBag.Adm = HelperController.VerificaUserAdm(HttpContext.Session);

            RendaFixaDAO dao = new RendaFixaDAO();

            return View("index", dao.Listagem());
        }

        public IActionResult ObtemDadosConsultaAvancada(string descricao)
        {
            try
            {
                RendaFixaDAO dao = new RendaFixaDAO();
                if (string.IsNullOrEmpty(descricao))
                    descricao = "";

                var lista = dao.ConsultaDescricao(descricao);
                return PartialView("pvFixo", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }

        public IActionResult EfetuaAplicacao(int fixaId, float valor)
        {
            try
            {
                if (valor <= 0)
                    throw new Exception("Valor não preenchido!!");

                RendaFixaDAO dao = new RendaFixaDAO();

                var aplicacao = dao.Consulta(fixaId);

                var fixo = new FixoViewModel();
                fixo.RendaFixaId = fixaId;
                fixo.ClientId = Convert.ToInt32(HelperController.RetronaIdUser(HttpContext.Session));
                fixo.Duracao = aplicacao.Duracao.ToString();
                fixo.RendimentoFinal = (valor * aplicacao.Rentabilidade) * aplicacao.Duracao;
                fixo.Valor = valor;

                FixoDAO fixoDAO = new FixoDAO();
                fixoDAO.Insert(fixo);

                AdicionaNaCarteiraFixa(fixo, aplicacao);

                return Json(new { msg = "Sucesso na aplicação de " + valor + " em " + aplicacao.Descricao });
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }

        private void AdicionaNaCarteiraFixa(FixoViewModel fixo, RendaFixaViewModel renda)
        {
            fixo.Descricao = renda.Descricao;
            fixo.Rentabilidade = renda.Rentabilidade.ToString();

            List<FixoViewModel> carteiraAtual = ObtemCarteiraFixaNaSession();

            if (carteiraAtual != null)
            {
                carteiraAtual.Add(fixo);
                string carteiraJson = JsonConvert.SerializeObject(carteiraAtual);
                HttpContext.Session.SetString("carteiraFixa", carteiraJson);
            }
            else
            {
                List<FixoViewModel> novaCarteira = new List<FixoViewModel>();
                novaCarteira.Add(fixo);
                string carteiraJson = JsonConvert.SerializeObject(novaCarteira);
                HttpContext.Session.SetString("carteiraFixa", carteiraJson);
            }
        }

        private List<FixoViewModel> ObtemCarteiraFixaNaSession()
        {
            List<FixoViewModel> cateira = new List<FixoViewModel>();
            string carteiraJson = HttpContext.Session.GetString("carteiraFixa");
            if (carteiraJson != null)
                cateira = JsonConvert.DeserializeObject<List<FixoViewModel>>(carteiraJson);
            return cateira;
        }
    }
}
