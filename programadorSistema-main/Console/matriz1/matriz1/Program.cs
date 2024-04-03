using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 2];
            numeros[0, 0] = 1;
            numeros[0, 1] = 2;
            numeros[1, 0] = 10;
            numeros[1, 1] = 20;
            numeros[2, 0] = 100;
            numeros[2, 1] = 200;

            int[,] numeros2 = new int[3, 2]
                { {9, 8}, 
                  {7, 6}, 
                  {5, 4}
                };
            int[,] resultado = new int[3, 2];
            //Console.WriteLine(numeros[2, 0]);
            //Console.WriteLine(numeros[2, 1]);
            //Escrever a matriz numeros
            for (int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 2; c++)
                {
                    Console.Write(numeros[l, c]);
                    Console.Write("\t");
                }
                Console.WriteLine();//mudar de linha
            }
            //Escrever a matriz numeros2
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(numeros2[l, c]);
                    Console.Write("\t");
                }
                Console.WriteLine();//mudar de linha
            }
            //Calcular e Escrever a matriz resultado
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    resultado[l,c] = numeros[l, c] + numeros2[l,c];
                    Console.Write(resultado[l, c]);
                    Console.Write("\t");
                }
                Console.WriteLine();//mudar de linha
            }
        }
    }
}
