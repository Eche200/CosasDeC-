using System;

namespace Escuela
{

    class Escuela
    {
        public string nombre;
        public string direccion;
        public int anoDeCreacion;

        public void SonarTimbre()
        {
            Console.WriteLine("suena el timbre");

            Console.WriteLine("Nombre de la escuela: " + this.nombre + ".\nDireccion de la escuela: " 
            + this.direccion + ".\nAño De Creacion de la escuela: " + this.anoDeCreacion + "." );
        }




    }


    class Program
    {
        static void Main(string[] args)
        {

            var instanciaDeEscuela = new Escuela();

            instanciaDeEscuela.nombre= "Normal 8";
            instanciaDeEscuela.direccion= "San juan y jujuy";
            instanciaDeEscuela.anoDeCreacion= 1918;
            
            instanciaDeEscuela.SonarTimbre();
            
        }
    }
}
