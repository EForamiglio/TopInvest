namespace TopInvest.Models
{
    public class ClienteViewModel : PadraoViewModel
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public float Saldo { get; set; }
        public int NumConta { get; set; }
        public bool flgAdm { get; set; }
        public int EnderecoId { get; set; }

        public string EstadoCidade { get; set; }

        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Numero { get; set; }
    }
}
