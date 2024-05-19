using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace TopInvest.Models
{
    public class EnderecoViewModel : PadraoViewModel
    {
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
    }
}
