using Microsoft.AspNetCore.Mvc;

namespace TopInvest.Controllers
{
    public class BrokerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
