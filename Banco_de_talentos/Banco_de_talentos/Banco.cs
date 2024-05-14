using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Banco_de_talentos
{
    class Banco
    {
        //
        private static SQLiteConnection conexao;
        //metode conexao

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\..\\Banco\\banco.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }

            }
            catch (Exception ex) 
            {
                ConexaoBanco().Close();
                throw ex;
            }

        }
        public static DataTable ObterTodosCurriculos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "Select id, nome, telefone, " +
                        "dataNascimento as 'data de nascimento" +
                        "esolaridade, profissao1 as 'profissao1', " +
                        "profissao1 as 'profissao2', curso1 as 'curso1', " +
                        "curso2 as 'curso2' FROM t_curriculos";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }

            }
            catch(Exception ex)
            {
                ConexaoBanco().Close();
            }

        }
    }
}
