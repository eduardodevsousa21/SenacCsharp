using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace categoria
{
    internal class Program
    {
        static string categoria(int idade)
        {
            if (idade >= 5 && idade <= 7)
                return "Sua categoria é Infantil A";
            else if (idade >= 8 && idade <= 10)
                return "Sua categoria é Infantil B";
            else if (idade >= 11 && idade <= 13)
                return "Sua categoria é Juvenil A";
            else if (idade >= 14 && idade <= 17)
                return "Sua categoria é Juvenil B";
            else
                return "Sua categoria é Adulto";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(categoria(idade));
        }
    }
}
