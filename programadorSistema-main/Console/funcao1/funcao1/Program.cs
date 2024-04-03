using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcao1
{
    internal class Program
    {
        static int Somar(int a, int b)
        {
            return a + b;
        }
        static int Subtrair(int a, int b)
        {
            return a - b;
        }
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        static double Dividir(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            string op = "";
            do
            {
                Console.WriteLine("Digite o 1o número:");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o 2o número:");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escolha um operador:");
                Console.WriteLine("1.Somar 2.Subtrair 3.Multiplicar 4.Dividir 5.Sair");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine(Somar(x, y));
                        break;
                    case "2":
                        Console.WriteLine(Subtrair(x, y));
                        break;
                    case "3":
                        Console.WriteLine(Multiplicar(x, y));
                        break;
                    case "4":
                        Console.WriteLine(Dividir(x, y));
                        break;
                    case "5":
                        op = "Sair";
                        break;
                    default:
                        Console.WriteLine("Operador inválido");
                        break;
                }
            } while (op != "Sair");
        }

        

    }
}
