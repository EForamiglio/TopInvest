using Microsoft.AspNetCore.Mvc;
using TopInvest.DAO;
using TopInvest.Models;
using Microsoft.AspNetCore.Http;

namespace TopInvest.Controllers
{
    public class ClienteController : PadraoController<ClienteViewModel>
    {
        
        public ClienteController()
        {
            DAO = new ClienteDAO();
            GeraProximoId = true;
            ExigeAutenticacao = false;
        }
    }
}
