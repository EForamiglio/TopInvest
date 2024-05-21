using System;
using System.Collections.Generic;
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
                new SqlParameter("duracao", model.Duracao),
                new SqlParameter("rentabilidade", model.Rentabilidade),
            };
            return parametros;
        }

        protected override RendaFixaViewModel MontaModel(DataRow registro)
        {
            RendaFixaViewModel rFixa = new RendaFixaViewModel();
            rFixa.Id = Convert.ToInt32(registro["id"]);
            rFixa.Descricao = registro["Descricao"].ToString();
            rFixa.Duracao = Convert.ToInt32(registro["Duracao"]);
            rFixa.Rentabilidade = Convert.ToInt64(registro["Rentabilidade"]);

            return rFixa;
        }

        protected override void SetTabela()
        {
            Tabela = "RendaFixa";
        }

        public List<RendaFixaViewModel> ConsultaDescricao(string descricao)
        {
            SqlParameter[] p = {
                new SqlParameter("descricao", descricao),
            };

            var tabela = HelperDAO.ExecutaProcSelect("spConsultaDescricao", p);
            var lista = new List<RendaFixaViewModel>();

            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));
            return lista;
        }
    }
}
