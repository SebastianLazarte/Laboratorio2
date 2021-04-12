using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Mamifero : Animal
    {
        private String NombreMamifero;
        public Mamifero(String nombre)
        {
            NombreMamifero = nombre;
        }

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se cuiden solas");

        }
        public override void GetNombre()
        {
            Console.WriteLine("El nombre del mamifero es:" + NombreMamifero);
        }
        public override void Pensar()
        {
            Console.WriteLine("Pensamiento Basico");
        }
        public virtual bool EsHerviboro()
        {
            return true;
        }
    }
}
