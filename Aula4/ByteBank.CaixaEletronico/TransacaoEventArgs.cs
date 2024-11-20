namespace ByteBank.CaixaEletronico
{
    public class TransacaoEventArgs : SaldoEventArgs
    {
        public decimal ValorTransacao { get; }

        public TransacaoEventArgs(decimal saldo, decimal valorTransacao) : base(saldo)
        {
            ValorTransacao = valorTransacao;
        }
    }
}
