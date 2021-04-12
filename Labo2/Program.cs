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

            IMamiferosTerrestres ImiCaballo = Potro;
            ISaltoConPatas ImiCaballoSalto = Potro;

            //Polimorfismo
            Animal[] almacenAnimales = new Animal[5];
            almacenAnimales[0] = Potro;
            almacenAnimales[1] = Juancho;
            almacenAnimales[2] = Kong;
            almacenAnimales[3] = Godzilla;
            Console.WriteLine("Nombres y tipo de pensamiento");
            for (int i=0;i<4;i++)
            {
                almacenAnimales[i].GetNombre();
                almacenAnimales[i].Pensar();
                Console.WriteLine("\n");
            }


          

            myWally.Nadar();

            Console.WriteLine("Numero de patas: "+ ImiCaballo.NumeroPatas());
            Console.WriteLine("Numero de patas en el salto: " + ImiCaballoSalto.NumeroPatas());

 
            
       
            Juan.Respirar();
            Juan.GetNombre();
          
            Console.WriteLine(Juan.EsHerviboro());
            Console.WriteLine(Kong.EsHerviboro());
        }
   
    }
}
