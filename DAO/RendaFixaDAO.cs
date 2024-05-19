using System;
using System.Data;
using System.Data.SqlClient;
using TopInvest.Models;

namespace TopInvest.DAO
{
    public class RendaFixaDAO : PadraoDAO<RendaFixaViewModel>
    {
        protected override SqlParameter[] CriaParametros(RendaFixaViewModel model)
        {
            SqlParameter[] parametros =
           {
                new SqlParameter("id", model.Id),
                new SqlParameter("descricao", model.Descricao),
                new SqlParameter("rentabilidade", model.Rentabilidade),
            };
            return parametros;
        }

        protected override RendaFixaViewModel MontaModel(DataRow registro)
        {
            RendaFixaViewModel rFixa = new RendaFixaViewModel();
            rFixa.Id = Convert.ToInt32(registro["id"]);
            rFixa.Descricao = registro["Descricao"].ToString();
            rFixa.Rentabilidade = Convert.ToInt64(registro["Rentabilidade"]);

            return rFixa;
        }

        protected override void SetTabela()
        {
            Tabela = "RendaFixa";
        }
    }
}
