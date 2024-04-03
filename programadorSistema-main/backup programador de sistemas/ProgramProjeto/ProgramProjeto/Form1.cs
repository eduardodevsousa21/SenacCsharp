namespace ProgramProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            //Pegaremos o texto digitado na caixa de texto (txtUsuário)
            //Concatenar a "Bem Vindo" com o Texto de txtUsuário
            //no lbltexto
            lblTexto.Text = "Bem-Vindo " + txtusuario.Text;
        }
    }
}