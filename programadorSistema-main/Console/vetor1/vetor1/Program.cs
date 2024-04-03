using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo[] nomeDoArray = new tipo[tamanho_do_array];
            int[] numeros = new int[5];
            int soma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o  "+ (i + 1) + "o numero: " + numeros[i]);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = 0; j < numeros.Length; j++)
            {
                Console.WriteLine("numero ["+j+"]" + numeros[j]);
            }
            for(int i = 0;i < numeros.Length;i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine("Soma: " + soma);
        }
    }
}
