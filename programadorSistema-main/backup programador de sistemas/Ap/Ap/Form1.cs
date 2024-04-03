namespace Ap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //calcular AN e inserir no txtAn
            double A1 = Convert.ToDouble(txtA1.Text);
            double N = Convert.ToDouble(txtN.Text);
            double R = Convert.ToDouble(txtR.Text);
            double cont = 1;
            double termoAtual = A1;
            double An = A1 + (N - 1) * R;
            txtAn.Text = An.ToString();
            //Crie a lista da PA e inserir no lbllista
            while(cont <= N)
            {
                lblLista.Text += termoAtual.ToString();
                if (cont < N)
                    lblLista.Text += ", ";
                termoAtual += R;
                cont++;
            }
        }

        private void btnPG_Click(object sender, EventArgs e)
        {
            double A1 = Convert.ToDouble(txtA1.Text);
            double N = Convert.ToDouble(txtN.Text);
            double R = Convert.ToDouble(txtR.Text);
            double cont = 1;
            double termoAtual = A1;
            double Sn = A1 + (N - 1) * R / N - 1;
            txtAn.Text = Sn.ToString();
            while(cont <= N)
            {
                lblLista.Text += termoAtual.ToString();
                if (cont < N)
                    lblLista.Text += ", ";
                termoAtual += R;
                cont++;
            }
        }
    }
}