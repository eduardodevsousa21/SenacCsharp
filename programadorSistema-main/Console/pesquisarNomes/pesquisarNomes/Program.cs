using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesquisarNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10] { "Ada", "Ana", "Bia", "Eli", "João", "Pedro", "José", "Enzo", "Edu", "Vini" };
            Console.WriteLine("Digite um nome:");
            string nome = Console.ReadLine();
            string resultado = "Não achei!";
            for(int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nome)
                {
                    resultado = "Achei!";
                    break;
                }
            }
            Console.WriteLine(resultado);

        }
    }
}
