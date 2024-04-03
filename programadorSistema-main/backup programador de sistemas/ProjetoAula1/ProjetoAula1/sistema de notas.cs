using static System.Net.Mime.MediaTypeNames;

namespace ProjetoAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);
            double Num3 = Convert.ToDouble(txtNum3.Text);

            double media = (Num1 + Num2 + Num3) / 3;

            if (media >= 7)
                txtmedia.Text = "Aprovado";
            if (media < 7 && media >= 4)
            {
                txtmedia.Text = "Recuperação";
                txtRecuperacao.Enabled = true;
            }
            if (media < 4)
                txtmedia.Text = "Reprovado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            txtmedia.Text = "";
            txtRecuperacao.Text = "";
            txtFinal.Text = "";
        }

        private void btnRecuperação_Click(object sender, EventArgs e)
        {
            double NR = Convert.ToDouble(txtRecuperacao.Text);
            if (NR >= 7)
                txtFinal.Text = "Aprovado";
            else txtFinal.Text = "Reprovado";
        }
    }
}