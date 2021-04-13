using System;

namespace Labo2
{
    class Program
    {

        static void Main(string[] args)
        {
            Caballo Potro = new Caballo("Henry");

            Humano Juancho = new Humano("Juancho");

            Gorila Kong = new Gorila("Kong");

            Ballena myWally = new Ballena("Wally");

            Lagartija Godzilla = new Lagartija("Godzilla");

            Humano Juan = new Humano("Juan");

            //Principio de sustitucion de Liskov
            Mamifero Persona = new Mamifero("Sebas");

            Humano Sebas = new Humano("Sebastian");
      
            Persona = Sebas;
            Persona.GetNombre();
            Console.WriteLine("Es vegetariano?");
            Persona.EsHerviboro();


            Animal[] almacenAnimales = new Animal[5];
            almacenAnimales[0] = Potro;
            almacenAnimales[1] = Juancho;
            almacenAnimales[2] = Kong;
            almacenAnimales[3] = Godzilla;
            //Polimorfismo
            Console.WriteLine("Nombres y tipo de pensamiento:::");
            for (int i=0;i<4;i++)
            {
                almacenAnimales[i].GetNombre();
                almacenAnimales[i].Pensar();
                Console.WriteLine("\n");
            }


            //Usando las interfaces
            IMamiferosTerrestres ImiCaballo = Potro;
            ISaltoConPatas ImiCaballoSalto = Potro;
            Console.WriteLine("Numero de patas: "+ ImiCaballo.NumeroPatas());
            Console.WriteLine("Numero de patas en el salto: " + ImiCaballoSalto.NumeroPatas());


           
            //Herencia
            Juan.Respirar();
            Juan.GetNombre();
          
            Console.WriteLine(Juan.EsHerviboro());
            Console.WriteLine(Kong.EsHerviboro());
        }
   
    }
}
