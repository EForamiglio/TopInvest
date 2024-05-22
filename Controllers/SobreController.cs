using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TopInvest.Controllers
{
    public class SobreController : Controller
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
