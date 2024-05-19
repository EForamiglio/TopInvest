using Microsoft.AspNetCore.Http;
using System;
using System.Security.Policy;

namespace TopInvest.Models
{
    public class RendaFixaViewModel : PadraoViewModel
    {
        public string Descricao { get; set; }
	    public float Rentabilidade { get; set; }

    }
}
