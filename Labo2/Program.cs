using System;

namespace Labo2
{
    class Program
    {
        //Clase Abstracta
        abstract class Animales
        {
            public void Respirar()
            {
                Console.WriteLine("Soy capaz de respirar");
            }
            public abstract void GetNombre();
            public abstract void Pensar();
        }
        
        interface IMamiferosTerrestres
        {
            int NumeroPatas();
        }

        interface IAnimalesYDeportes
        {
            string TipoDeDeporte();

            Boolean EsOlimpico();

        }
        interface ISaltoConPatas
        {
            int NumeroPatas();
 
            
        }
        class Mamiferos:Animales
        {
            private String NombreMamifero;
            public Mamiferos(String nombre)
            {
                NombreMamifero = nombre;
            }
            
            public void CuidarCrias()
            {
                Console.WriteLine("Cuido de mis crias hasta que se cuiden solas");

            }
            public override void GetNombre()
            {
                Console.WriteLine("El nombre del mamifero es:"+NombreMamifero);
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
        class Reptiles : Animales
        {
    
            private String NombreReptil;
            public Reptiles(String nombre)
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
        class Lagartija : Reptiles
        {
            public Lagartija(String nombreLagartija) : base(nombreLagartija)
            {
       
            }
            public override void Pensar()
            {
                Console.WriteLine("Pensamiento basico de lagartija");
            }

        }
        class Cocodrilo : Reptiles
        {
            public Cocodrilo(String nombreCocodrilo) : base(nombreCocodrilo)
            {

            }
            public override void Pensar()
            {
                Console.WriteLine("Pensamiento basico de Cocodrilo");
            }

        }
        class Ballena : Mamiferos
        {
            public Ballena (String nombreBallena) : base(nombreBallena)
            {

            }
            public void Nadar()
            {
                Console.WriteLine("Soy capaz de nadar");
            }
        }
        class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo)
            {

            }

            public bool EsOlimpico()
            {
                return true ;
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
        class Humano : Mamiferos
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
        class Gorila : Mamiferos, IMamiferosTerrestres
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
            Animales[] almacenAnimales = new Animales[5];
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
