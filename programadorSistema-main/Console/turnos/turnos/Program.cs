using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva M ou V ou N");
            string turno = Console.ReadLine();
            if(turno == "M")
            {
                Console.WriteLine("Bom dia");
            }
            else
            {
                if(turno == "V")
                {
                    Console.WriteLine("Boa tarde");
                }
                else
                {
                    if(turno == "N")
                    {
                        Console.WriteLine("Boa noite");
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
            }
        }
    }
}
