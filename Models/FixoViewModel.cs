namespace TopInvest.Models
{
    public class FixoViewModel : PadraoViewModel
    {
        public float Valor { get; set; }
        public string Duracao { get; set; }
        public float RendimentoFinal { get; set; }
        public int ClientId { get; set; }
        public int RendaFixaId { get; set; }

        public string Descricao { get; set; }
        public string Rentabilidade { get; set; }
    }
}
