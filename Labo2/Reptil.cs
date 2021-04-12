using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Reptil : Animal
    {

        private String NombreReptil;
        public Reptil(String nombre)
        {
            NombreReptil = nombre;
        }

        public void PonerHuevos()
        {
            Console.WriteLine("Poniendo huevos");

        }
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del reptil es:" + NombreReptil);
        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento Basico");
        }
    }
}
