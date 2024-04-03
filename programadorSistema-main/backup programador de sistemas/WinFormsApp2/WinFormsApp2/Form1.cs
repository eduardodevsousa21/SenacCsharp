namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);

            if (lado1 == lado2 && lado1 == lado3)
                txtTipo.Text = "Equilátero";

            if ((lado1 == lado2 && lado1 != lado3) ||
                (lado1 != lado2 && lado1 == lado3)
                || (lado2 == lado3 && lado2 != lado1))
                txtTipo.Text = "Isóceles";

            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                txtTipo.Text = "Escaleno";

           // Ler 3 notas 
           // aprovado ->=7
           // Recuperação -7 e >=4
           // Reprovado <4




        }
    }
}