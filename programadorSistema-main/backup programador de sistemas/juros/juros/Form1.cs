namespace juros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(txtTempo.Text);
            double[] montante = new double[t];
            double juros;
            montante[0] = Convert.ToDouble(txtCapital.Text);

            for (int i = 1; i < montante.Length; i++)
            {
                juros = montante[i - 1] * Convert.ToDouble(txtCapital.Text);
                montante[i] = montante[i - 1] + juros;
            }
            for (int i = 0; i < montante.Length; i++)
            {
                lblResultado.Text += Convert.ToString(montante[i] + "; ");
            }
        }
    }
}