using System.Drawing;
using System;

namespace ByteBank.CaixaEletronico
{
    public partial class frmCaixaEletronico : Form
    {
        private readonly WebApiClient webApiClient;
        private const string NumeroAgencia = "007";
        private const string NumeroConta = "78901-2";

        public frmCaixaEletronico()
        {
            InitializeComponent();
            webApiClient = new WebApiClient();


            ImprimirLogo();

            btnSacar.Click += async (sender, e) =>
            {
                if (decimal.TryParse(txtValor.Text, out decimal valorSaque))
                {
                    var resposta = await webApiClient.SacarAsync(NumeroAgencia, NumeroConta, valorSaque);
                    WriteToConsole(resposta);
                }
                else
                {
                    WriteToConsole("Valor inválido!");
                }
                txtValor.Text = string.Empty;
            };

            btnDepositar.Click += async (sender, e) =>
            {
                if (decimal.TryParse(txtValor.Text, out decimal valorDeposito))
                {
                    var resposta = await webApiClient.DepositarAsync(NumeroAgencia, NumeroConta, valorDeposito);
                    WriteToConsole(resposta);
                }
                else
                {
                    WriteToConsole("Valor inválido!");
                }
                txtValor.Text = string.Empty;
            };

            btnSaldo.Click += async (sender, e) =>
            {
                decimal saldo = await webApiClient.GetSaldoAsync(NumeroAgencia, NumeroConta);
                WriteToConsole($"Saldo atual: {saldo:C}");
            };

            btnExtrato.Click += async (sender, e) =>
            {
                string extrato = await webApiClient.GetExtratoAsync(NumeroAgencia, NumeroConta);
                WriteToConsole(extrato);
            };

        }

        private void ImprimirLogo()
        {
            txtConsole.Text =
            "▒█▀▀█ █░░█ ▀▀█▀▀ █▀▀ ▒█▀▀█ █▀▀█ █▀▀▄ █░█\r\n" +
            "▒█▀▀▄ █▄▄█ ░░█░░ █▀▀ ▒█▀▀▄ █▄▄█ █░░█ █▀▄\r\n" +
            "▒█▄▄█ ▄▄▄█ ░░▀░░ ▀▀▀ ▒█▄▄█ ▀░░▀ ▀░░▀ ▀░▀\r\n";
            txtConsole.SelectionStart = txtConsole.TextLength;
            txtConsole.ScrollToCaret();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CaixaEletronico_OnSaldoInsuficiente(object sender, TransacaoEventArgs e)
        {
            WriteToConsole("Saldo insuficiente!");
        }

        private void CaixaEletronico_OnSaque(object sender, TransacaoEventArgs e)
        {
            string mensagem = $"Saque de {e.ValorTransacao:C} realizado com sucesso!";
            WriteToConsole(mensagem);
            txtValor.Text = string.Empty;
        }

        private void CaixaEletronico_OnDeposito(object sender, TransacaoEventArgs e)
        {
            string mensagem = $"Depósito de {e.ValorTransacao:C} realizado com sucesso!";
            WriteToConsole(mensagem);
            txtValor.Text = string.Empty;
        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtValor.Text += btn.Name.Last();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Location = new Point(btn.Location.X + 4, btn.Location.Y + 4);
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.Location = new Point(btn.Location.X - 4, btn.Location.Y - 4);
        }

        private void btnOperacao_Click(object sender, EventArgs e)
        {
            txtValor.Focus();
        }

        private void WriteToConsole(string mensagem)
        {
            txtConsole.Text += mensagem;
            txtConsole.Text += Environment.NewLine;
            txtConsole.SelectionStart = txtConsole.TextLength;
            txtConsole.ScrollToCaret();
        }
    }
}