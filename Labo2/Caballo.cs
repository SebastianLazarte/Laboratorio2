using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public bool EsOlimpico()
        {
            return true;
        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
        public string TipoDeDeporte()
        {
            return "hipica";
        }
    }

}
