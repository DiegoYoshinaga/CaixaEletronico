using Newtonsoft.Json;
using RestSharp;
using System.Text;

namespace ByteBank.CaixaEletronico
{
    public class WebApiClient
    {
        private const string BaseUrl = "http://localhost:5024";
        private readonly RestClient _client;
        private const int LarguraExtrato = 65;

        public WebApiClient()
        {
            _client = new RestClient(BaseUrl);
        }

        // Método assíncrono para obter o saldo de uma conta
        public async Task<decimal> GetSaldoAsync(string agencia, string conta)
        {
            var request = new RestRequest($"ContaBancaria/{agencia}/{conta}", Method.Get);
            var response = await _client.ExecuteAsync<decimal>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        // Método assíncrono para realizar saque
        public async Task<string> SacarAsync(string agencia, string conta, decimal valor)
        {
            var request = new RestRequest($"ContaBancaria/sacar/{agencia}/{conta}", Method.Post);
            request.AddJsonBody(JsonConvert.SerializeObject(valor));

            var response = await _client.ExecuteAsync<string>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        // Método assíncrono para realizar depósito
        public async Task<string> DepositarAsync(string agencia, string conta, decimal valor)
        {
            var request = new RestRequest($"ContaBancaria/depositar/{agencia}/{conta}", Method.Post);
            request.AddJsonBody(JsonConvert.SerializeObject(valor));

            var response = await _client.ExecuteAsync<string>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        // Método assíncrono para obter o extrato de transações
        public async Task<string> GetExtratoAsync(string agencia, string conta)
        {
            var request = new RestRequest($"ContaBancaria/extrato/{agencia}/{conta}", Method.Get);
            var response = await _client.ExecuteAsync<ExtratoBancario>(request);

            if (response.IsSuccessful)
            {
                ExtratoBancario extratoBancario = response.Data;

                var stringBuilder = new StringBuilder();
                ImprimirCabecalho(stringBuilder);
                foreach (var item in extratoBancario.ItensExtrato)
                {
                    ImprimirItemExtrato(stringBuilder, item);
                }

                ImprimirSaldo(stringBuilder, extratoBancario.Saldo);
                return stringBuilder.ToString();
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }
        }

        private void ImprimirCabecalho(StringBuilder stringBuilder)
        {
            var imprimirSeparador = (StringBuilder sb) =>
                sb.AppendLine(new string('=', LarguraExtrato));

            imprimirSeparador(stringBuilder);
            stringBuilder.AppendLine(string.Format("{0,-20} {1,-25} {2,18}", "Data/Hora", "Descrição", "Valor (R$)"));
            imprimirSeparador(stringBuilder);
        }

        private void ImprimirItemExtrato(StringBuilder stringBuilder, ItemExtrato item)
        {
            stringBuilder.AppendLine(item.ToString());
        }

        private void ImprimirSaldo(StringBuilder stringBuilder, decimal saldo)
        {
            stringBuilder.AppendLine(new string('=', LarguraExtrato));
            string valor = saldo.ToString("N2").PadLeft(18);
            stringBuilder.AppendLine(string.Format("{0,-20} {1,-25} {2,18}", string.Empty, "Saldo", valor));
            stringBuilder.AppendLine(new string('=', LarguraExtrato));
        }
    }

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
