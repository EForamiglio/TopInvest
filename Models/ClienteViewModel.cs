namespace TopInvest.Models
{
    public class ClienteViewModel : PadraoViewModel
    {
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public float Saldo { get; set; }
        public string NumConta { get; set; }
        public bool flgAdm { get; set; }
        public int EnderecoId { get; set; }
    }
}
