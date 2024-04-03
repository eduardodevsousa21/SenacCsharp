using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calculadora
    {
        private double n1;
        private double n2;  

        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void setN1(double n)
        {
            this.n1 = n;
        }
        public double getN1()
        {
            return this.n1; 
        }
        public void setN2(double n)
        {
            this.n2 = n;
        }
        public double getN2()
        {
            return this.n2;
        }
        public double soma(double n1, double n2)
        {
            return n1 + n2;   
        }
        public double soma()
        {
            return this.n1 + this.n2;
        }
        public double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        public double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
        public double divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
