using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora();
            Console.WriteLine("Digite o 1o número:");
            c1.setN1(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o 2o número:");
            c1.setN2( Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite o operador:");
            c1.setOperador(Console.ReadLine());
            //c1.resultado = c1.n1 + c1.n2;

            switch (c1.getOperador()) {
                case "+":
                    Console.WriteLine(c1.somar()); break;
                case "-":
                    Console.WriteLine(c1.subtrair()); break;
                case "*":
                    Console.WriteLine(c1.multiplicar()); break;
                case "/":
                    Console.WriteLine(c1.dividir()); break;
                default:
                    Console.WriteLine("Operador inválido"); 
                    break;
            }
                
            
        }
    }
}
