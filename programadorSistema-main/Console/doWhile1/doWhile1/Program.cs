using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace doWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario = "";
            string senha = "";
            var rg = new Regex(@" ");
            do
            {
                Console.WriteLine("Digite o usuário:");
                usuario = Console.ReadLine();
            } while (usuario.Length == 0 || rg.IsMatch(usuario));
            do
            {
                Console.WriteLine("Digite a senha:");
                senha = Console.ReadLine();
            } while (senha.Length < 6);
        }
    }
}
