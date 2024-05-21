using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using TopInvest.Models;
using System;
using System.Drawing;

namespace TopInvest.DAO
{
    public class TradeDAO
    {
        public virtual int Insert(TradeViewModel trade)
        {
            SqlParameter[] p = {
                new SqlParameter("id", trade.Id),
                new SqlParameter("valor", trade.Valor),
                new SqlParameter("quantidade", trade.Quantidade),
                new SqlParameter("dataCompra", trade.DataCompra),
                new SqlParameter("clientId", trade.ClienteId),
                new SqlParameter("rendaVariavelId", trade.RendaVariavelId),
            };

            return HelperDAO.ExecutaProc("spInsert_Trade", p, true);
        }

        public List<TradeViewModel> CarregaCarteira(int id)
        {
            SqlParameter[] p = {
                new SqlParameter("clientId", id),
            };

            var tabela = HelperDAO.ExecutaProcSelect("spCarregaCarteiraVariavel", p);
            var lista = new List<TradeViewModel>();

            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));
            return lista;
        }

        private TradeViewModel MontaModel(DataRow registro)
        {
            TradeViewModel trade = new TradeViewModel();
            trade.Id = Convert.ToInt32(registro["id"]);
            trade.Valor = Convert.ToInt64(registro["valor"]);
            trade.Quantidade = Convert.ToInt32(registro["quantidade"]);
            trade.DataCompra = Convert.ToDateTime(registro["dataCompra"]);
            trade.ClienteId = Convert.ToInt32(registro["clientId"]);
            trade.RendaVariavelId = Convert.ToInt32(registro["rendaVariavelId"]);
            trade.Sigla = registro["sigla"].ToString();
            trade.RendaVariavelId = Convert.ToInt32(registro["rendaVariavelId"]);

            if (registro["imgIcone"] != DBNull.Value)
                trade.ImagemEmByte = registro["imgIcone"] as byte[];

            return trade;
        }
    }
}
