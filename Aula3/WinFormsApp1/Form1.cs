namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal saldo = 100;
        public Form1()
        {
            InitializeComponent();
            Atualizar();
        }

        private void Atualizar()
        {
            txtSaldo.Text = saldo.ToString("C");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            saldo += 10;

            Atualizar();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            saldo -= 5;
            Atualizar();
        }
    }
}