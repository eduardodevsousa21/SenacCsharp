namespace Cadrastro_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn = ("Data Source=DESKTOP-PT88MBV\\SQLEXPRESS02; "
               + "Initial Catalog=biblioteca;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);

            string sql ="INSERT INTO Cadrastro (entrada , data) " + "VALURES  ( @entrada , @data)"; 

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@nome", txtEntrada.Text));
                comando.Parameters.Add(new SqlParameter("@data", txtData.Text));

                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();   
                MessageBox.Show("Cadrastrado" , "Cadastro" , MessageBoxButtons.OK,  MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Não foi Possivel Cadrastro", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }


        }
    }
}