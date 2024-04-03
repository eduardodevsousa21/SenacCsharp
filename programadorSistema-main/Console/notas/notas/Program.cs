using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] notas = new int[4, 4]
            {
                {8,9,10,10 },
                {5,4,8,10 },
                {8,6,10,10 },
                {7,9,7,10 }
            };
            int cont = 0;
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (notas[l, c] > 7)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine("Notas > 7: " + cont);
        }
    }
}
