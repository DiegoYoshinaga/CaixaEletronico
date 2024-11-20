namespace ByteBank.WebApi.Models
{
    public class ItemExtrato
    {
        public ItemExtrato(string agencia, string conta, char tipo, string descricao, decimal valor, DateTime data)
        {
            Agencia = agencia;
            Conta = conta;
            Sinal = tipo == 'C' ? SinalOperacao.Credito : SinalOperacao.Debito;
            Descricao = descricao;
            Valor = valor;
            Data = data;
        }

        public string Agencia { get; set; }
        public string Conta { get; set; }
        public string Descricao { get; set; }
        public SinalOperacao Sinal { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            string data = Data.ToString("dd/MM/yyyy HH:mm:ss");
            string descricao = Descricao.Length > 50 ? Descricao.Substring(0, 50) : Descricao;
            string valor = (Valor * (int)Sinal).ToString("N2").PadLeft(18);

            return string.Format("{0,-20} {1,-25} {2}", data, descricao, valor);
        }
    }
}