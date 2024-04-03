using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgSenac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //configuração 1o jogador
            int vidaJ1 = 10;
            int ataqueJ1 = 5;
            int defesaJ1 = 3;
            int defesaJ1T = defesaJ1;//
            //configuração 2o jogador
            int vidaJ2 = 6;
            int ataqueJ2 = 4;
            int defesaJ2 = 4;
            int defesaJ2T = defesaJ2;//
            //inicio da repetição
            while (vidaJ1 > 0 && vidaJ2 > 0)
            {
                //ação do jogador 1
                string acao = "";
                do
                {
                    Console.WriteLine("-- Jogador 1 --");
                    Console.WriteLine("1. Ataque 2.Defesa");
                    acao = Console.ReadLine();
                } while (acao != "1" && acao != "2");
                //verificar ação
                if(acao == "1")
                {
                    //se ataque calcular poder de ataque
                    //calcular fator aleatório (1 a 10)
                    Random numAleatorio = new Random();
                    int fAleatorio = numAleatorio.Next(50, 151);
                    int ataqueJ1T = (ataqueJ1 * fAleatorio) / 100;
                    //Console.WriteLine("aleatorio " + fAleatorio);
                    Console.WriteLine("ataque temporario " + ataqueJ1T);
                    //verificar se poder de ataque J1 > Defesa J2
                    //depois mudar para defesaJ2T
                    if( ataqueJ1T > defesaJ2T)//
                    {
                        //Se sim, diminuir vida
                        vidaJ2 = vidaJ2 - (ataqueJ1T - defesaJ2T);//
                        Console.WriteLine("vidaJ2 " + vidaJ2);
                    }
                    else
                    {
                        Console.WriteLine("Ataque falhou");
                    }
                }
                //se defesa calcular o poder de defesa
                else
                {
                    Random numAleatorio = new Random();
                    int fAleatorio = numAleatorio.Next(100, 151);
                    defesaJ1T = (defesaJ1 * fAleatorio) / 100;
                    //Console.WriteLine("aleatorio " + fAleatorio);
                    Console.WriteLine("defesa temporario " + defesaJ1T);
                }

                //defesaJ2 volta para o padrão
                defesaJ2T = defesaJ2;
                //ação do jogador 2
                if (vidaJ2 > 0)
                {
                    acao = "";
                    do
                    {
                        Console.WriteLine("-- Jogador 2 --");
                        Console.WriteLine("1. Ataque 2.Defesa");
                        acao = Console.ReadLine();
                    } while (acao != "1" && acao != "2");
                    //verificar ação
                    if (acao == "1")
                    {
                        //se ataque calcular poder de ataque
                        //calcular fator aleatório (1 a 10)
                        Random numAleatorio = new Random();
                        int fAleatorio = numAleatorio.Next(50, 151);
                        int ataqueJ2T = (ataqueJ2 * fAleatorio) / 100;
                        //Console.WriteLine("aleatorio " + fAleatorio);
                        Console.WriteLine("ataque temporario " + ataqueJ2T);
                        //verificar se poder de ataque J1 > Defesa J2
                        //depois mudar para defesaJ2T
                        if (ataqueJ2T > defesaJ1T)//
                        {
                            //Se sim, diminuir vida
                            vidaJ1 = vidaJ1 - (ataqueJ2T - defesaJ1T);//
                            Console.WriteLine("vidaJ1 " + vidaJ1);
                        }
                        else
                        {
                            Console.WriteLine("Ataque falhou");
                        }
                    }
                    //se defesa calcular o poder de defesa
                    else
                    {
                        Random numAleatorio = new Random();
                        int fAleatorio = numAleatorio.Next(100, 151);
                        defesaJ2T = (defesaJ2 * fAleatorio) / 100;
                        //Console.WriteLine("aleatorio " + fAleatorio);
                        Console.WriteLine("defesa temporario " + defesaJ2T);
                    }
                }
                //defesaJ1T volta para o padrão
                defesaJ1T = defesaJ1;
            }
            if(vidaJ1 <= 0)
            {
                Console.WriteLine("O jogador 2 venceu!");
            }
            else
            {
                Console.WriteLine("O jogador 1 venceu!");
            }
        }
    }
}
