namespace biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text == "123.456.789-10")
                lblFrase.Text = "Bem Vindo Jonielson";
            
            else
                lblFrase.Text = "Conta não identificada";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Emprestimo el = new Emprestimo();

            el.cpf = txtCPF.Text;
            el.setCategoria(gbCategorias.Controls.OfType<RadioButton>()
                .SingleOrDefault(RadioButton => RadioButton.Checked).Text);
            el.nomeLivro = txtNomeLivro.Text;
            el.quantidade = Convert.ToInt32(txtQuantidade.Text);


            MessageBox.Show("Livro emprestado com Sucesso. " + "Categorias: " + el.getCategoria() + " Livro: " + el.nomeLivro);
        }
    }
}