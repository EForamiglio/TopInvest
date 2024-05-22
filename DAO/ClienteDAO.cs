using System;
using System.Data;
using System.Data.SqlClient;
using TopInvest.Models;

namespace TopInvest.DAO
{
    public class ClienteDAO : PadraoDAO<ClienteViewModel>
    {
        protected override void SetTabela()
        {
            Tabela = "Cliente";
            NomeSpListagem = "spListaClientes";
        }

        protected override SqlParameter[] CriaParametros(ClienteViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[8];
            parametros[0] = new SqlParameter("id", model.Id);
            parametros[1] = new SqlParameter("nome", model.Nome);
            parametros[2] = new SqlParameter("senha", model.Senha);
            parametros[3] = new SqlParameter("saldo", model.Saldo);
            parametros[4] = new SqlParameter("numConta", model.NumConta);
            parametros[5] = new SqlParameter("flgAdm", model.flgAdm);
            parametros[6] = new SqlParameter("idEndereco", model.EnderecoId);
            parametros[7] = new SqlParameter("usuario", model.Usuario);
            return parametros;
        }

        protected override ClienteViewModel MontaModel(DataRow registro)
        {
            ClienteViewModel cliente = new ClienteViewModel();
            cliente.Id = Convert.ToInt32(registro["id"]);
            cliente.Nome = registro["nome"].ToString();
            cliente.Usuario = registro["usuario"].ToString();
            cliente.Senha = registro["senha"].ToString();
            cliente.Saldo = Convert.ToInt64(registro["saldo"]);
            cliente.NumConta = Convert.ToInt32(registro["numConta"]);
            cliente.flgAdm = Convert.ToBoolean(registro["flgAdm"]);
            cliente.EnderecoId = Convert.ToInt32(registro["idEndereco"]);

            if (registro["cidade"] != DBNull.Value && registro["estado"] != DBNull.Value)
                cliente.EstadoCidade = registro["cidade"].ToString() + " - " + registro["estado"].ToString();
            return cliente;
        }

        private ClienteViewModel MontaModelConsulta(DataRow registro)
        {
            ClienteViewModel cliente = new ClienteViewModel();
            cliente.Id = Convert.ToInt32(registro["id"]);
            cliente.Nome = registro["nome"].ToString();
            cliente.Usuario = registro["usuario"].ToString();
            cliente.Senha = registro["senha"].ToString();
            cliente.Saldo = Convert.ToInt64(registro["saldo"]);
            cliente.NumConta = Convert.ToInt32(registro["numConta"]);
            cliente.flgAdm = Convert.ToBoolean(registro["flgAdm"]);
            cliente.EnderecoId = Convert.ToInt32(registro["idEndereco"]);

            return cliente;
        }

        private ClienteViewModel MontaModelCompleta(DataRow registro)
        {
            ClienteViewModel cliente = new ClienteViewModel();
            cliente.Id = Convert.ToInt32(registro["id"]);
            cliente.Nome = registro["nome"].ToString();
            cliente.Usuario = registro["usuario"].ToString();
            cliente.Senha = registro["senha"].ToString();
            cliente.Saldo = Convert.ToInt64(registro["saldo"]);
            cliente.NumConta = Convert.ToInt32(registro["numConta"]);
            cliente.flgAdm = Convert.ToBoolean(registro["flgAdm"]);
            cliente.EnderecoId = Convert.ToInt32(registro["idEndereco"]);
            cliente.Estado = registro["estado"].ToString();
            cliente.Cidade = registro["cidade"].ToString();
            cliente.Rua = registro["rua"].ToString();
            cliente.Numero = registro["numero"].ToString();
            cliente.Cep = registro["cep"].ToString();
            cliente.Bairro = registro["bairro"].ToString();

            return cliente;
        }

        public ClienteViewModel ConsultaLogin(string usuario, string senha)
        {
            DataTable tabela = HelperDAO.ExecutaProcSelect("spConsultaLogin", CriaParametrosLogin(usuario, senha));
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModelConsulta(tabela.Rows[0]);
        }

        private SqlParameter[] CriaParametrosLogin(string usuario, string senha)
        {
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("usuario", usuario);
            parametros[1] = new SqlParameter("senha", senha);
            return parametros;
        }

        public int GeraProximaConta()
        {
            var tabela = HelperDAO.ExecutaProcSelect("spProximaConta", null);
            return Convert.ToInt32(tabela.Rows[0][0]);
        }

        public override ClienteViewModel Consulta(int id)
        {
            var p = new SqlParameter[]
            {
                new SqlParameter("clienteId", id),
            };
            var tabela = HelperDAO.ExecutaProcSelect("spConsultaClienteCompleto", p);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaModelCompleta(tabela.Rows[0]);
        }
    }
}
