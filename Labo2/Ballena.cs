using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2
{
    class Ballena : Mamifero
    {
        public Ballena(String nombreBallena) : base(nombreBallena)
        {

        }
        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
