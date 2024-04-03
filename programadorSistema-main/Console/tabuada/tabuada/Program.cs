using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Digite um número.");
                int n = Convert.ToInt32(Console.ReadLine());
                int cont = 0;
                while (cont <= 10)
                {
                    int produto = n * cont;
                    Console.WriteLine(produto);
                    cont++;//incrementar cont = cont + 1;
                }
                Console.WriteLine("Deseja continuar: Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Não")
                {
                    continuar = false;
                }
            }
        }
    }
}
