using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Humano : Mamifero
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento Razonable");
        }
        public override bool EsHerviboro()
        {
            return false;
        }
    }
}
