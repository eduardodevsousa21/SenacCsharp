using System.Data;
using System.Data.SqlClient;

namespace Bnco_de_dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarTollTip();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                string strconn = ("Data Source=SOB38648L1B1\\SQLEXPRESS; " +
                    "Initial Catalog=Senac;Integrated Security=true");
                SqlConnection conn = new SqlConnection(strconn);

                String sql = "INSERT INTO Aluno(nome, mae, data_de_nascimento, pai, cpf) " +
                    "VALUES(@nome, @mae, @data_de_nascimento, @pai, @cpf)";

                try
                {
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                    comando.Parameters.Add(new SqlParameter("@mae", txtMae.Text));
                    comando.Parameters.Add(new SqlParameter("@data_de_nascimento", dtpData.Text));
                    comando.Parameters.Add(new SqlParameter("@pai", txtPai.Text));
                    comando.Parameters.Add(new SqlParameter("@cpf", txtCpf.Text));

                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Aluno Cadastrado com Sucesso!",
                         " cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Não foi possivel cadastrar", " Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio r = new Relatorio();
            r.Show();
        }
        
        private void ConfigurarTollTip()
        {
            toolTip1.AutoPopDelay = 10000;
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipTitle = "Dica";
            toolTip1.ToolTipIcon = ToolTipIcon.Info;

            toolTip1.SetToolTip(txtNome, "informe o nome do aluno.");
            toolTip1.SetToolTip(txtMae, "informe o nome da mãe do aluno.");
            toolTip1.SetToolTip(txtPai, "informe o nome do pai do aluno.");
            toolTip1.SetToolTip(txtCpf, "informe o CPF do aluno.");
            toolTip1.SetToolTip(dtpData, "informe a data de nascimento do aluno.");
        }

        private bool VerificarCampos()
        {
            bool preenchido = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            if (txtNome.Text.Trim().Equals(""))
            {
                errorProvider1.SetError(txtNome, "Campo obrigatório!");
                preenchido = false;
            }
            if (txtMae.Text.Trim().Equals(""))
            {
                errorProvider2.SetError(txtMae, "Campo obrigatório!");
                preenchido = false;
            }
            if (txtCpf.Text.Trim().Equals(""))
            {
                errorProvider3.SetError(txtCpf, "Campo obrigatório!");
                preenchido = false;
            }
            if (preenchido)
                return true;
            else 
                return false;
        }

    }
}