using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar vetor respostas
            string[] respostas = new string[3];
            //Criar vetor gabarito
            string[] gabarito = new string[3] {"a", "c", "d"};
            //Escrever as questões
            Console.WriteLine("1. Qual opção contém um comando " +
                "de estrutura de repetição:");
            Console.WriteLine("a. for");
            Console.WriteLine("b. int numero");
            Console.WriteLine("c. if");
            Console.WriteLine("d. new string[3]");
            Console.Write("Resposta: ");
            respostas[0] = Console.ReadLine();

            Console.WriteLine("2. Qual a última posição do vetor: " +
                "string[] respostas = new string[3];");
            Console.WriteLine("a. 0");
            Console.WriteLine("b. 1");
            Console.WriteLine("c. 2");
            Console.WriteLine("d. 3");
            Console.Write("Resposta: ");
            respostas[1] = Console.ReadLine();

            Console.WriteLine("3. Para que server o while:");
            Console.WriteLine("a. armazenar dados");
            Console.WriteLine("b. instânciar classes");
            Console.WriteLine("c. declarar variável");
            Console.WriteLine("d. estrutura de repetição");
            Console.Write("Resposta: ");
            respostas[2] = Console.ReadLine();
            //a cada questão coletar a resposta
            //verifica quantas respostas estão corretas
            int cont = 0;
            for(int i = 0; i < respostas.Length; i++)
            {
                if (respostas[i] == gabarito[i])
                {
                    cont++;
                }
            }
            //informar quantas respostas estão corretas
            Console.WriteLine("Você acertou " +  cont + " questões.");
        }
    }
}
