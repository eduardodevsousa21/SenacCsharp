using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace tabuadaDecrescente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            do
            {
                var rg = new Regex(@"^[0-9]+$");
                //expressão composta apenas por números
                 string textoN = "";
                do
                {
                    Console.WriteLine("Digite um número:");
                    textoN = Console.ReadLine();
                } while (!rg.IsMatch(textoN));
                int n = Convert.ToInt32(textoN);

                do
                {
                    Console.WriteLine("Digite o número inicial:");
                    textoN = Console.ReadLine();
                } while (!rg.IsMatch(textoN));
                int n1 = Convert.ToInt32(textoN);

                do
                {
                    Console.WriteLine("Digite o número final:");
                    textoN = Console.ReadLine();
                } while (!rg.IsMatch(textoN) || Convert.ToInt32(textoN) > n1);
                int n2 = Convert.ToInt32(textoN);

                while(n1 >= n2)
                {
                    Console.WriteLine(n + " X " + n1 + " = " + (n*n1));
                    n1--;
                }
                Console.WriteLine("Digite 0 para sair:");
                string sair = Console.ReadLine();
                if(sair == "0")
                {
                    continua = false;
                }
                

            }while (continua);
        }
    }
}
