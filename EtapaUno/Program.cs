using System;

namespace EtapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
           var instanciaDeEscuela = new Escuela();


           instanciaDeEscuela.Nombre = "San Cristobal";
           instanciaDeEscuela.AnoDeCreacion = 1950;
           instanciaDeEscuela.PaisDeLaEscuela = "Argentina";

           Console.WriteLine("Nombre del colegio: " + instanciaDeEscuela.Nombre + "\nAño de creacion de la escuela: " + 
           instanciaDeEscuela.AnoDeCreacion + "\nPais de origen de la escuela: " + instanciaDeEscuela.PaisDeLaEscuela);


        }
    }
}
