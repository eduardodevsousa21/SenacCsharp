using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPoo
{
    public class Aluno
    {
        public string nome;
        public int id;
        public DateTime dataNasc;
        public string turma;
        public string cpf;
        public double nota1;
        public double nota2;
        public double nota3;

        public double media(double n1, double n2, double n3)
        {
            this.nota1 = n1;
            this.nota2 = n2;
            this.nota3 = n3;
            return (this.nota1 + this.nota2 + this.nota3)/3;
        }
    }
}
