using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TopInvest.DAO;
using TopInvest.Models;

namespace TopInvest.Controllers
{
    public class TradeController : Controller
    {
        public IActionResult Index()
        {
            if (!HelperController.VerificaUserLogado(HttpContext.Session))
                return RedirectToAction("Index", "Login");

            ViewBag.Logado = HelperController.VerificaUserLogado(HttpContext.Session);
            ViewBag.NomeUser = HelperController.PreencheNomeUser(HttpContext.Session);
            ViewBag.Adm = HelperController.VerificaUserAdm(HttpContext.Session);

            RendaVariavelDAO dao = new RendaVariavelDAO();

            return View("index", dao.Listagem());
        }

        public IActionResult EfetuaCompra(int acaoId, int qtd)
        {
            try
            {
                if (qtd <= 0)
                    throw new Exception("Quantidade não preenchida");

                RendaVariavelDAO dao = new RendaVariavelDAO();

                var acao = dao.Consulta(acaoId);

                var trade = new TradeViewModel();
                trade.RendaVariavelId = acaoId;
                trade.ClienteId = Convert.ToInt32(HelperController.RetronaIdUser(HttpContext.Session));
                trade.DataCompra = DateTime.Today;
                trade.Quantidade = qtd;
                trade.Valor = acao.Preco * qtd;

                TradeDAO tradeDAO = new TradeDAO();
                tradeDAO.Insert(trade);

                AdicionaNaCarteiraVariavel(trade, acao);

                return Json(new {msg = "Sucesso na compra de " + qtd + " " + acao.Sigla });
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }

        private void AdicionaNaCarteiraVariavel(TradeViewModel trade, RendaVariavelViewModel renda)
        {
            trade.ImagemEmByte = renda.ImagemEmByte;
            trade.Sigla = renda.Sigla;

            List<TradeViewModel> carteiraAtual = ObtemCarteiraVariavelNaSession();

            if (carteiraAtual != null)
            {
                carteiraAtual.Add(trade);
                string carteiraJson = JsonConvert.SerializeObject(carteiraAtual);
                HttpContext.Session.SetString("carteira", carteiraJson);
            }
            else
            {
                List<TradeViewModel> novaCarteira = new List<TradeViewModel>();
                novaCarteira.Add(trade);
                string carteiraJson = JsonConvert.SerializeObject(novaCarteira);
                HttpContext.Session.SetString("carteira", carteiraJson);
            }
        }

        private List<TradeViewModel> ObtemCarteiraVariavelNaSession()
        {
            List<TradeViewModel> cateira = new List<TradeViewModel>();
            string carteiraJson = HttpContext.Session.GetString("carteira");
            if (carteiraJson != null)
                cateira = JsonConvert.DeserializeObject<List<TradeViewModel>>(carteiraJson);
            return cateira;
        }

        public IActionResult ObtemDadosConsultaAvancada(string sigla)
        {
            try
            {
                RendaVariavelDAO dao = new RendaVariavelDAO();
                if (string.IsNullOrEmpty(sigla))
                    sigla = "";

                var lista = dao.ConsultaSigla(sigla);
                return PartialView("pvTrade", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
    }
}
