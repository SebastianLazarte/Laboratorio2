using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Lagartija : Reptil
    {
        public Lagartija(String nombreLagartija) : base(nombreLagartija)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento basico de lagartija");
        }

    }
}
