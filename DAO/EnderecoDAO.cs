using System;
using System.Data;
using System.Data.SqlClient;
using TopInvest.Models;

namespace TopInvest.DAO
{
    public class EnderecoDAO : PadraoDAO<EnderecoViewModel>
    {
        protected override SqlParameter[] CriaParametros(EnderecoViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[6];
            parametros[0] = new SqlParameter("id", model.Id);
            parametros[1] = new SqlParameter("estado", model.Estado);
            parametros[2] = new SqlParameter("cidade", model.Cidade);
            parametros[3] = new SqlParameter("rua", model.Rua);
            parametros[4] = new SqlParameter("numero", model.Numero);
            parametros[5] = new SqlParameter("cep", model.Cep);
            return parametros;
        }

        protected override EnderecoViewModel MontaModel(DataRow registro)
        {
            EnderecoViewModel endereco = new EnderecoViewModel();
            endereco.Id = Convert.ToInt32(registro["id"]);
            endereco.Estado = registro["estado"].ToString();
            endereco.Cidade = registro["cidade"].ToString();
            endereco.Rua = registro["rua"].ToString();
            endereco.Numero = registro["numero"].ToString();
            endereco.Cep = registro["cep"].ToString();
            return endereco;
        }

        protected override void SetTabela()
        {
            Tabela = "endereco";
        }
    }
}
