using Microsoft.AspNetCore.Http;
using System;

namespace TopInvest.Models
{
    public class TradeViewModel : PadraoViewModel
    {
        public float Valor { get; set; }
	    public int Quantidade { get; set; }
	    public DateTime DataCompra { get; set; }
        public int ClienteId { get; set; }
        public int RendaVariavelId { get; set; }

        public string Sigla { get; set; }

        /// <summary>
        /// Imagem recebida do form pelo controller
        /// </summary>
        public IFormFile Imagem { get; set; }
        /// <summary>
        /// Imagem em bytes pronta para ser salva
        /// </summary>
        public byte[] ImagemEmByte { get; set; }
        /// <summary>
        /// Imagem usada para ser enviada ao form no formato para ser exibida
        /// </summary>
        public string ImagemEmBase64
        {
            get
            {
                if (ImagemEmByte != null)
                    return Convert.ToBase64String(ImagemEmByte);
                else
                    return string.Empty;
            }
        }
    }
}
