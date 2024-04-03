namespace sorveteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Sabor = cbSabores.Text;
            double preco = 2.50;

            if (chbGranulado.Checked)
                preco = preco + 0.5;
            if (chbCalda.Checked)
                preco = preco + 1;
            if (chbCobertura.Checked)
                preco = preco + 1.5;

            txtPreco.Text = Convert.ToString(preco);

        }
    }
}