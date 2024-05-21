using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using TopInvest.Models;

namespace TopInvest.DAO
{
    public class FixoDAO
    {
        public virtual int Insert(FixoViewModel fixo)
        {
            SqlParameter[] p = {
                new SqlParameter("id", fixo.Id),
                new SqlParameter("valor", fixo.Valor),
                new SqlParameter("duracao", fixo.Duracao),
                new SqlParameter("rendimentoFinal", fixo.RendimentoFinal),
                new SqlParameter("clientId", fixo.ClientId),
                new SqlParameter("rendaFixaId", fixo.RendaFixaId),
            };

            return HelperDAO.ExecutaProc("spInsert_Fixo", p, true);
        }

        public List<FixoViewModel> CarregaCarteira(int id)
        {
            SqlParameter[] p = {
                new SqlParameter("clientId", id),
            };

            var tabela = HelperDAO.ExecutaProcSelect("spCarregaCarteiraFixa", p);
            var lista = new List<FixoViewModel>();

            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));
            return lista;
        }

        private FixoViewModel MontaModel(DataRow registro)
        {
            FixoViewModel fixo = new FixoViewModel();
            fixo.Id = Convert.ToInt32(registro["id"]);
            fixo.Valor = Convert.ToInt64(registro["valor"]);
            fixo.Duracao = registro["duracao"].ToString();
            fixo.RendimentoFinal = Convert.ToInt64(registro["rendimentoFinal"]);
            fixo.ClientId = Convert.ToInt32(registro["clientId"]);
            fixo.RendaFixaId = Convert.ToInt32(registro["rendaFixaId"]);
            fixo.Descricao = registro["descricao"].ToString();
            fixo.Rentabilidade = registro["rentabilidade"].ToString();

            return fixo;
        }
    }
}
