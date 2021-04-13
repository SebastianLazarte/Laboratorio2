using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Cocodrilo : Reptil
    {
        public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
        {

        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento basico de Cocodrilo");
        }
        public virtual void Desgarrar()
        {
            Console.WriteLine("Desgarrando");
        }

    }
}
