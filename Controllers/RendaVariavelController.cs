using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using System;
using System.IO;
using TopInvest.DAO;
using TopInvest.Models;

namespace TopInvest.Controllers
{
    public class RendaVariavelController : PadraoController<RendaVariavelViewModel>
    {
        public RendaVariavelController()
        {
            DAO = new RendaVariavelDAO();
            GeraProximoId = true;
            ExigeAdm = true;
        }

        public byte[] ConvertImageToByte(IFormFile file)
        {
            if (file != null)
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    return ms.ToArray();
                }
            else
                return null;
        }

        protected override void ValidaDados(RendaVariavelViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.Sigla))
                ModelState.AddModelError("Sigla", "Preencha a sigla.");
            //Imagem será obrigatio apenas na inclusão.
            //Na alteração iremos considerar a que já estava salva.
            if (model.Imagem == null && operacao == "I")
                ModelState.AddModelError("Imagem", "Escolha uma imagem.");
            if (model.Imagem != null && model.Imagem.Length / 1024 / 1024 >= 2)
                ModelState.AddModelError("Imagem", "Imagem limitada a 2 mb.");
            if (ModelState.IsValid)
            {
                //na alteração, se não foi informada a imagem, iremos manter a que já estava salva.
                if (operacao == "A" && model.Imagem == null)
                {
                    RendaVariavelViewModel renda = DAO.Consulta(model.Id);
                    model.ImagemEmByte = renda.ImagemEmByte;
                }
                else
                {
                    model.ImagemEmByte = ConvertImageToByte(model.Imagem);
                }
            }
        }

        public IActionResult ObtemDadosConsultaAvancada(string sigla, float preco)
        {
            try
            {
                RendaVariavelDAO dao = new RendaVariavelDAO();
                if (string.IsNullOrEmpty(sigla))
                    sigla = "";

                var lista = dao.ConsultaFiltro(sigla, preco);
                return PartialView("pvGridAcoes", lista);
            }
            catch (Exception erro)
            {
                return Json(new { erro = true, msg = erro.Message });
            }
        }
    }
}
