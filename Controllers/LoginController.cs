using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopInvest.DAO;

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
            ClienteDAO dao = new ClienteDAO();

            var cliente = dao.ConsultaLogin(usuario, senha);

            if (cliente != null)
            {
                if (cliente.flgAdm == true)
                    HttpContext.Session.SetString("Adm", "true");

                HttpContext.Session.SetString("Logado", "true");
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
    }
}
