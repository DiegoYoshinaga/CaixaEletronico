namespace ByteBank.WebApi.Models
{
    public class ExtratoBancario
    {
        public ExtratoBancario(IEnumerable<ItemExtrato> itensExtrato, decimal saldo)
        {
            ItensExtrato = itensExtrato;
            Saldo = saldo;
        }

        public IEnumerable<ItemExtrato> ItensExtrato { get; set; } = new List<ItemExtrato>();
        public decimal Saldo { get; set; }
    }
}