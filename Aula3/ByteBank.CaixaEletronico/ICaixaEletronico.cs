namespace ByteBank.CaixaEletronico
{
    public interface ICaixaEletronico
    {
        void Depositar(decimal valor);
        void Sacar(decimal valor);
        decimal Saldo();
        string Extrato();

        event SaldoInsuficienteEventHandler OnSaldoInsuficiente;
    }
}
