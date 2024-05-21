using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TopInvest.Models;
using Microsoft.AspNetCore.Http;

namespace TopInvest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (!HelperController.VerificaUserLogado(HttpContext.Session))
               return RedirectToAction("Index", "Login");

            ViewBag.Logado = HelperController.VerificaUserLogado(HttpContext.Session);
            ViewBag.NomeUser = HelperController.PreencheNomeUser(HttpContext.Session);
            ViewBag.Adm = HelperController.VerificaUserAdm(HttpContext.Session);
            return View();
        }

    }
}
