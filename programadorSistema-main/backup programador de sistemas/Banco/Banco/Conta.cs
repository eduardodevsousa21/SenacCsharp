using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        private double Saldo;
        private double Valor;
        private string Ag;
        private string Cc;
        private double Chave;

        public Conta (double saldo, double valor, string ag, string cc, double chave)
        {
            this.Saldo = saldo;
            this.Valor = valor;
            this.Ag = ag;
            this.Cc = cc;
            this.Chave = chave;
        }

        public Conta(double valor, double saldo)
        {
            Valor = valor;
            Saldo = saldo;
        }

        public double Deposito(double Valor, double Saldo)
        {
            this.Saldo = this.Saldo + Valor;
            return this.Saldo;
        }
        public double Saque(double Valor)
        {
            if (this.Saldo > Valor)
            {
                this.Saldo = this.Saldo - Valor;
                return this.Saldo;  
            }
            else
                return 0;
        }
        public double transferência(double Valor)
        {
          this.Saque(Valor);
            return this.Saldo;
        }
        public double Saldo1(double Saldo)
        {
            return Saldo;
        }
    }
}
