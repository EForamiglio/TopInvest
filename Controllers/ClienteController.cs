using Microsoft.AspNetCore.Mvc;
using TopInvest.DAO;
using TopInvest.Models;
using Microsoft.AspNetCore.Http;
using System;

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

        public IActionResult Cadastrar(ClienteViewModel cliente, EnderecoViewModel endereco, string operacao)
        {
            try
            {
                using (var transacao = new System.Transactions.TransactionScope())
                {
                    EnderecoDAO enderecoDAO = new EnderecoDAO();
                    int enderecoId = enderecoDAO.Insert(endereco);
                    
                    ClienteDAO clienteDAO = new ClienteDAO();
                    cliente.NumConta = clienteDAO.GeraProximaConta();
                    cliente.EnderecoId = enderecoId;
                    cliente.flgAdm = false;

                    clienteDAO.Insert(cliente);

                    transacao.Complete();
                }
                HttpContext.Session.SetString("Logado", "true");
                return RedirectToAction("Index", "Home");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }

        }
    }
}
