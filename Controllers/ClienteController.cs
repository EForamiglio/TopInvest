using Microsoft.AspNetCore.Mvc;
using TopInvest.DAO;
using TopInvest.Models;
using Microsoft.AspNetCore.Http;
using System;
using Newtonsoft.Json;

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

        public IActionResult Cadastro()
        {
            ViewBag.operacao = "I";
            return View(new ClienteViewModel());
        }

        public IActionResult Cadastrar(ClienteViewModel cliente, EnderecoViewModel endereco, string operacao)
        {
            try
            {
                if (!ValidaDadosVazio(cliente, endereco))
                {
                    ViewBag.operacao = "I";
                    ViewBag.erro = "Campos faltando!!!";
                    return View("form");
                }
                int clienteId = 0;
                using (var transacao = new System.Transactions.TransactionScope())
                {
                    EnderecoDAO enderecoDAO = new EnderecoDAO();
                    int enderecoId = enderecoDAO.Insert(endereco);

                    ClienteDAO clienteDAO = new ClienteDAO();
                    cliente.NumConta = clienteDAO.GeraProximaConta();
                    cliente.EnderecoId = enderecoId;

                    clienteId = clienteDAO.Insert(cliente);

                    transacao.Complete();
                }
                HttpContext.Session.SetString("Logado", "true");
                HttpContext.Session.SetString("UserId", clienteId.ToString());

                if (cliente.flgAdm)
                    HttpContext.Session.SetString("Adm", "true");

                HttpContext.Session.SetString("NomeUser", cliente.Nome);

                CarregaCarteiraVariavel(clienteId);

                return RedirectToAction("Index", "Home");
            }
            catch (Exception erro)
            {
                return RedirectToAction("Index", "LogOff");
            }

        }

        private void CarregaCarteiraVariavel(int clientId)
        {
            TradeDAO dao = new TradeDAO();

            var carteira = dao.CarregaCarteira(clientId);

            string carteiraJson = JsonConvert.SerializeObject(carteira);
            HttpContext.Session.SetString("carteira", carteiraJson);
        }

        public bool ValidaDadosVazio(ClienteViewModel cliente, EnderecoViewModel endereco)
        {
            if (cliente == null || cliente.Usuario == null || cliente.Usuario == "" || cliente.Nome == null || cliente.Nome == "" || cliente.Senha == null || cliente.Senha == "")
            {
                return false;
            }
            if (endereco == null || endereco.Estado == null || endereco.Estado == "" || endereco.Cidade == null || endereco.Cidade == ""
                || endereco.Bairro == null || endereco.Bairro == "" || endereco.Cep == null || endereco.Cep == "")
            {
                return false;
            }

            return true;
        }
    }
}
