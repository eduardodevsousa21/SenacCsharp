using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO1
{
    public class Calculadora
    {
        //atributos ou propriedades
        private double n1;
        private double n2;
        private double resultado;
        private string operador;

        //CONSTRUTOR
        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public Calculadora()
        {

        }

        //métodos
        //get(para ler a informação) e set(para inserir informação)
        public double getN1()
        {
            return this.n1;
        }
        public void setN1(double n1)
        {
            this.n1 = n1;
        }

        public double getN2()
        {
            return this.n2;
        }
        public void setN2(double n2)
        {
            this.n2 = n2;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        public void setResultado(double res)
        {
            this.resultado = res;
        }

        public string getOperador()
        {
            return this.operador;
        }
        public void setOperador(string operador)
        {
            this.operador = operador;
        }
        public double somar()
        {
            this.resultado = this.n1 + this.n2;
            return this.resultado;
        }

        public double subtrair()
        {
            this.resultado = this.n1 - this.n2;
            return this.resultado;
        }

        public double multiplicar()
        {
            this.resultado = this.n1 * this.n2;
            return this.resultado;
        }

        public double dividir()
        {
            this.resultado = this.n1 / this.n2;
            return this.resultado;
        }
    }
}
