using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar um objeto
            Aluno a1 = new Aluno();
            Console.WriteLine("Digite a 1a nota:");
            a1.nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2a nota:");
            a1.nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 3a nota:");
            a1.nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sua média é:" + a1.media(a1.nota1, a1.nota2, a1.nota3));
        }
    }
}
