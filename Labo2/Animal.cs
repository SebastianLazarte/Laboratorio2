using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    abstract class Animal
    {
        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public abstract void GetNombre();
        public abstract void Pensar();
    }
}
