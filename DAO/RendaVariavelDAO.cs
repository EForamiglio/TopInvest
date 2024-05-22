using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TopInvest.Models;

namespace TopInvest.DAO
{
    public class RendaVariavelDAO : PadraoDAO<RendaVariavelViewModel>
    {
        protected override SqlParameter[] CriaParametros(RendaVariavelViewModel model)
        {
            object imgByte = model.ImagemEmByte;
            if (imgByte == null)
                imgByte = DBNull.Value;

            SqlParameter[] parametros =
            {
                new SqlParameter("id", model.Id),
                new SqlParameter("sigla", model.Sigla),
                new SqlParameter("preco", model.Preco),
                new SqlParameter("ultimoPreco", model.UltimoPreco),
                new SqlParameter("imgIcone", imgByte)
            };
            return parametros;

        }

        protected override RendaVariavelViewModel MontaModel(DataRow registro)
        {
            RendaVariavelViewModel rVariavel = new RendaVariavelViewModel();
            rVariavel.Id = Convert.ToInt32(registro["id"]);
            rVariavel.Sigla = registro["sigla"].ToString();
            rVariavel.Preco = Convert.ToInt64(registro["preco"]);
            rVariavel.UltimoPreco = Convert.ToInt64(registro["ultimoPreco"]);

            if (registro["imgIcone"] != DBNull.Value)
                rVariavel.ImagemEmByte = registro["imgIcone"] as byte[];

            return rVariavel;
        }

        protected override void SetTabela()
        {
            Tabela = "RendaVariavel";
        }

        public List<RendaVariavelViewModel> ConsultaFiltro(string sigla, float preco)
        {
            SqlParameter[] p = {
                new SqlParameter("sigla", sigla),
                new SqlParameter("preco", preco),
            };

            var tabela = HelperDAO.ExecutaProcSelect("spConsultaSigla", p);
            var lista = new List<RendaVariavelViewModel>();

            foreach (DataRow dr in tabela.Rows)
                lista.Add(MontaModel(dr));
            return lista;
        }
    }
}
