using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bnco_de_dados
{
    public partial class Relatorio : Form
    {
        string id;
        public Relatorio()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38648L1B1\\SQLEXPRESS;" +
                "Initial Catalog=Senac;Integrated Security=true");
            string data = dtpNascimento.Text;
            string command = $"select * from dbo.Aluno where data_de_nascimento like '{data}'";

            SqlDataAdapter da = new SqlDataAdapter(command, sql);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvLista.DataSource = dt;   

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38648L1B1\\SQLEXPRESS;" +
               "Initial Catalog=Senac;Integrated Security=true");
            string data = "%/" + cbData.Text + "/%";
            string command = $"select * from dbo.Aluno where " +
                $"data_de_nascimento like '{data}'";
            SqlDataAdapter da = new SqlDataAdapter(command, sql);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvLista.DataSource = dt;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            id = dgvLista.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvLista.CurrentRow.Cells[1].Value.ToString();
            txtMae.Text = dgvLista.CurrentRow.Cells[2].Value.ToString();
            dtpNascimento.Text = dgvLista.CurrentRow.Cells[3].Value.ToString();
            txtPai.Text = dgvLista.CurrentRow.Cells[4].Value.ToString();
            txtCpf.Text = dgvLista.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=SOB38648L1B1\\SQLEXPRESS;" +
                "Initial Catalog=Senac;Integrated Security=true");

            SqlCommand command = new SqlCommand("update Aluno SET nome = @nome, mae = @mae," +
                "Data_de_nascimento = @data_de_nascimento, pai = @pai, cpf = @cpf where id=@id", conn);

            command.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(id)));
            command.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            command.Parameters.Add(new SqlParameter("@mae", txtMae.Text));
            command.Parameters.Add(new SqlParameter("@data_de_nascimento", dtpNascimento.Text));
            command.Parameters.Add(new SqlParameter("@pai", txtPai.Text));
            command.Parameters.Add(new SqlParameter("@cpf", txtCpf.Text));
            
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Alteração realizada com sucesso!", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB38648L1B1\\SQLEXPRESS;" +
               "Initial Catalog=Senac;Integrated Security=true");

            SqlCommand command = new SqlCommand("Delete from Aluno where id=@id", sql);
            int id = Convert.ToInt32(dgvLista.CurrentRow.Cells[0].Value);

            try
            {
                command.Parameters.Add(new SqlParameter("@id", id));

                sql.Open();
                command.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Registro deletado!", "Controle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
