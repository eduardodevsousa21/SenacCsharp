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
            //Pegaremos o texto digitado na caixa de texto (txtUsu�rio)
            //Concatenar a "Bem Vindo" com o Texto de txtUsu�rio
            //no lbltexto
            lblTexto.Text = "Bem-Vindo " + txtusuario.Text;
        }
    }
}