namespace ByteBank.WebApi.Models
{
    public class ContaCorrente
    {
        public string Agencia { get; set; }
        public string Conta { get; set; }
        public decimal Saldo { get; set; }
        public DateTime UltimoAcesso { get; set; }

        public ContaCorrente(string agencia, string conta, decimal saldo, DateTime ultimoAcesso)
        {
            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
            UltimoAcesso = ultimoAcesso;
        }

        public override string ToString()
        {
            return $"Agência: {Agencia}, Conta: {Conta}, Saldo: {Saldo:C}, Último Acesso: {UltimoAcesso}";
        }
    }
}