namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            

            double n1 = Convert.ToDouble(txtNum1.Text);
            double n2 = Convert.ToDouble(txtNum2.Text);
            Calculadora c1 = new Calculadora(n1, n2);

            double resultado;

            String operacao = gbOperacao.Controls.OfType<RadioButton>
                ().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            if (operacao == "Soma")
                resultado = c1.soma(n1, n2);
            else if (operacao == "Subtração")
               resultado = c1.subtracao(n1, n2);
            else if (operacao == "Multiplicação")
                resultado = c1.multiplicacao(n1, n2);
            else
                resultado = c1.divisao(n1, n2);

            txtResultado.Text = Convert.ToString(resultado);
        }
    }
}