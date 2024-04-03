namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);
            string Ag = txtAg.Text;
            string Cc = txtCc.Text;
            double Saldo = 100;

            Conta c1 = new Conta(valor, Saldo);

            {
                if (txtChave.Text == "123.456.789-10")
                    lblFrase.Text = "Obrigado Jonielson: Servi�o efetuado";

                else
                    MessageBox.Show("Conta n�o identificada");
            }

            String gb = groupBox1.Controls.OfType<RadioButton>
                ().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            if (gb == "Dep�sito")
                Saldo = c1.Deposito(valor, Saldo);
            else if (gb == "Saque")
                Saldo = c1.Saque(valor);
            else if (gb == "Transfer�ncia")
                Saldo = c1.transfer�ncia(valor);
            else
                MessageBox.Show(" Saldo: " + Saldo);

            MessageBox.Show(" Saldo: " + Saldo);


        }
    }
}