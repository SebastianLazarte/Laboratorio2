using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Gorila : Mamifero, IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de Trepar ");
        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
        public int NumeroPatas()
        {
            return 2;
        }
    }
}
