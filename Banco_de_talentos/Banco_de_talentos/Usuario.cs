using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_talentos
{
    internal class Usuario
    {
        private string usuario = "dudu";
        private string senha = "231478";
        


        public string getusuario() {  return this.usuario; } 
        public void setusuario(string usuario)
        {
            this.usuario = usuario;
        }
        public string getsenha()
        {
            return this.senha;
        }
        public void setsenha(string senha)
        {
            this.senha = senha;
        }
    }
}
