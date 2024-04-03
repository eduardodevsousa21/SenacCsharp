using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progressaoAritmetica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int razao = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int cont = 1;
            int pa = n1;
            while(cont <= n)
            {
                Console.WriteLine(pa);
                pa = pa + razao;
                cont++;
            }
        }
    }
}
