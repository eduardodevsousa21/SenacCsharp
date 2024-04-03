using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Jogador
    {
        public int energia = 100;
        public bool vivo = true;

        public Jogador() 
        {
            
        }

        public int getEnergia()
        {
            return this.energia;
        }

        public void setEnergia(int energia)
        {
            this.energia = energia;
        }
    }
}
