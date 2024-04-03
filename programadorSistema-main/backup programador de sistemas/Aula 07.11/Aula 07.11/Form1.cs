namespace Aula_07._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
         Carro el = new Carro();

            el.setMarca(txtMarca.Text);
            el.setAno(Convert.ToInt32(txtAno.Text));
            el.setCor(txtCor.Text);


            MessageBox.Show("Carro de Marca " + el.getMarca() + " Ano " + el.getAno() + " Cor " + el.getCor());
        }
    }
}