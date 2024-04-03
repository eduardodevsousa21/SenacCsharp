using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1o número");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2o número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1 > num2) 
            {
                Console.WriteLine("O primeiro número é maior. " + num1);
            }
            else
            {
                Console.WriteLine("O segundo número é maior. " + num2);
            }
        }
    }
}
