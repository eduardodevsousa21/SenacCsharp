using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Emprestimo
    {
        public string cpf;
        private string categoria;
        public string nomeLivro;
        public int    quantidade;

        public void setCategoria(String cate)
        {
            this.categoria = cate;
        }
        public string getCategoria()
        {
            return this.categoria;
        }
    }
}
