using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TopInvest.Models;

namespace TopInvest.Controllers
{
    public class AtivosController : Controller
    {
        public IActionResult Index()
        {
            if (!HelperController.VerificaUserLogado(HttpContext.Session))
                return RedirectToAction("Index", "Login");

            ViewBag.Logado = HelperController.VerificaUserLogado(HttpContext.Session);
            ViewBag.NomeUser = HelperController.PreencheNomeUser(HttpContext.Session);
            ViewBag.Adm = HelperController.VerificaUserAdm(HttpContext.Session);
            ViewBag.Fixos = ObtemCarteiraFixaNaSession();

            return View("index", ObtemCarteiraVariavelNaSession());
        }

        private List<TradeViewModel> ObtemCarteiraVariavelNaSession()
        {
            List<TradeViewModel> cateira = new List<TradeViewModel>();
            string carteiraJson = HttpContext.Session.GetString("carteira");
            if (carteiraJson != null)
            {
                cateira = JsonConvert.DeserializeObject<List<TradeViewModel>>(carteiraJson);
                return cateira;
            }
            return new List<TradeViewModel>();
        }

        private List<FixoViewModel> ObtemCarteiraFixaNaSession()
        {
            List<FixoViewModel> cateira = new List<FixoViewModel>();
            string carteiraJson = HttpContext.Session.GetString("carteiraFixa");
            if (carteiraJson != null)
            {
                cateira = JsonConvert.DeserializeObject<List<FixoViewModel>>(carteiraJson);
                return cateira;
            }
            return new List<FixoViewModel>();
        }
    }
}
