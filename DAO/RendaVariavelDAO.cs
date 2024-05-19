using System;
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
    }
}
