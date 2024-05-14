using System.Data;

namespace Banco_de_talentos
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnconf_Click(object sender, EventArgs e)
        {
            string usuario = tbxusuaio.Text;
            string senha = tbxsenha.Text;
            if(usuario == "" || senha == "")
            {
                MessageBox.Show("Usuario e ou senha invalido");
                tbxusuaio.Focus();
                return;
            }
            string sql = "SELECT * FROM t_usuarios WHERE usuario = '" + usuario + "' AND senha = '" + senha + "'";
            dt = Banco.consulta(sql);
            if(dt.Rows.Count == 1)
            {
                drashboard d = new drashboard(dt.Rows[0].ItemArray[1].ToString());
                d.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

