using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int cont = 0; cont <= 10;  cont++)
            {
                int produto = n * cont;
                Console.WriteLine(n + " X " + cont + " = " + produto);
            }
        }
    }
}
