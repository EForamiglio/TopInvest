using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TopInvest.DAO;
using TopInvest.Models;

namespace TopInvest.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FazLogin(string usuario, string senha)
        {
            if (usuario == null || usuario == "" || senha == null || senha == "")
            {
                var erro = "Usuário ou senha inválidos!";
                return View("index", erro);
            }
            ClienteDAO dao = new ClienteDAO();

            var cliente = dao.ConsultaLogin(usuario, senha);

            if (cliente != null)
            {
                if (cliente.flgAdm == true)
                    HttpContext.Session.SetString("Adm", "true");

                HttpContext.Session.SetString("Logado", "true");
                HttpContext.Session.SetString("NomeUser", cliente.Nome);
                HttpContext.Session.SetString("UserId", cliente.Id.ToString());
                ViewBag.NomeUser = HelperController.PreencheNomeUser(HttpContext.Session);

                CarregaCarteiraVariavel(cliente.Id);
                CarregaCarteiraFixa(cliente.Id);

                return RedirectToAction("index", "Home");  
            }
            else
            {
                ViewBag.Erro = "Usuário ou senha inválidos!";
                return View("Index");
            }
        }
        public IActionResult LogOff()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        private void CarregaCarteiraVariavel(int clientId)
        {
            TradeDAO dao = new TradeDAO();

            var carteira = dao.CarregaCarteira(clientId);

            string carteiraJson = JsonConvert.SerializeObject(carteira);
            HttpContext.Session.SetString("carteira", carteiraJson);
        }

        private void CarregaCarteiraFixa(int clientId)
        {
            FixoDAO dao = new FixoDAO();

            var carteira = dao.CarregaCarteira(clientId);

            string carteiraJson = JsonConvert.SerializeObject(carteira);
            HttpContext.Session.SetString("carteiraFixa", carteiraJson);
        }

    }
}
