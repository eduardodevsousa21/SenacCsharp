using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_07._11
{
    internal class Carro
    {
        public String marca;
        public String cor;
        public int ano;

        public void setMarca(String marc)
        {
            this.marca = marc;
        }
        public String getMarca()
        {
            return this.marca;
        }
        public void setCor(String c)
        {
            this.cor = c;
        }
        public String getCor()
        {
            return this.cor;
        }
        public void setAno(Int32 a)
        {
            this.ano = a;
        }
        public Int32 getAno()
        {
            return this.ano;
        }

    }
}
