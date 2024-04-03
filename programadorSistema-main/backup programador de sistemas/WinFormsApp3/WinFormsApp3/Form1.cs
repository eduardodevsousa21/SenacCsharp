namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double media = nota1 + nota2 + nota3;

            txtResultado.Text = Convert.ToString(media);

            if (media >= 7)
            {
                Console.WriteLine("aprovado com media " + media);

            }
            else
            {
                Console.WriteLine("reprovado com media " + media);
            }

        }

    }
}
