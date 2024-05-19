using Microsoft.AspNetCore.Mvc;
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
        }
    }
}
