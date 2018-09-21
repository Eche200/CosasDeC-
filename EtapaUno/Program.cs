using System;

namespace EtapaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            var instanciaDeEscuela = new Escuela();


            instanciaDeEscuela.nombre = "San Cristobal";
            instanciaDeEscuela.anoDeCreacion = 1950;
            instanciaDeEscuela.paisDeLaEscuela = "Argentina";
            instanciaDeEscuela.tipoDeEscuelas = TipoDeEscuelas.secundaria;
            

            var cursoUno = new Curso();
            cursoUno.nombreDelCurso = "Programacion 1";

            var cursoDos = new Curso();
            cursoDos.nombreDelCurso = "Sistemas Operativos";

            var cursoTres = new Curso();
            cursoTres.nombreDelCurso = "Laboratorio 1";


            Console.WriteLine(instanciaDeEscuela);
            Console.WriteLine("===========================");
            Console.WriteLine("\n" + cursoUno.nombreDelCurso + "=>" + cursoUno.identificadorDelCurso);
            Console.WriteLine("\n" + cursoDos.nombreDelCurso + "=>" + cursoUno.identificadorDelCurso);
            Console.WriteLine("\n" + cursoTres.nombreDelCurso + "=>" + cursoUno.identificadorDelCurso);

        }
    }
}
