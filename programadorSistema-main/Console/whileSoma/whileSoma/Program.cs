using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números");
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            int soma = 0;
            while(cont <=  n)
            {
                Console.WriteLine("Digite um número:");
                int resposta = Convert.ToInt32(Console.ReadLine());
                soma = soma + resposta;
                cont++;
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}
