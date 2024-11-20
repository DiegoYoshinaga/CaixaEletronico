namespace ByteBank.CaixaEletronico
{
    public class SaldoEventArgs : EventArgs
    {
        public decimal Saldo { get; }

        public SaldoEventArgs(decimal saldo)
        {
            Saldo = saldo;
        }
    }
}
