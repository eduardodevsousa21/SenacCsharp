namespace Auladia31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro c1 = new Carro();
            c1.marca  = txtMarca.Text;
            c1.modelo = txtModelo.Text;
            c1.ano    = Convert.ToInt32(txtAno.Text);

            lblFrase.Text = "Carro de marca " + c1.marca + " e modelo " + c1.modelo;

        }
    }
}