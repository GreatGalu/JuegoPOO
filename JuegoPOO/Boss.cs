using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    public class Boss : Personaje
    {
        public Boss() : base("Boss", 150, 20)
        {
        }
        public override int Atacar()
        {
            return Ataque;
        }
        public override int Curar()
        {
            return 20;
        }
    }
}
