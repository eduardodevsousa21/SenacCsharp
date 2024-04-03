using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco1
{
    internal class Banco1
    {
        public double saque(double > valor) {
            if (this.saldo > valor)
            {
                this.saldo = this.saldo - valor;
                return this.saldo;
            }
            else
                return 0; 
        
       }
        piblic double deposito(double valor)
        {
            this.saldo=this. saldo+ valor
        }
        
}
