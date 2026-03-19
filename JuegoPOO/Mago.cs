using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    public class Mago: Personaje
    {
        public Mago() : base ("Mago",80,18)
        { 
        }

        public override int Atacar()
        {
            return Ataque;
        }

            public override int Curar()
            {
                return 15; 
        }
    }
}
