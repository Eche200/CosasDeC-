using System;
using System.Collections.Generic;
using EtapaUno.App;

namespace EtapaUno
{
    class Program
    {
		static void Main(string[] args)
		{

			var motorEscuela = new EscuelaMotor();
			motorEscuela.inicializar();

			/*
             * array 
			var escuelas = new Escuela();

			escuelas.cursos = new Curso[] {
			    new Curso() { nombreDelCurso = "Programacion" },
			    new Curso() { nombreDelCurso = "laboratorio" },
                new Curso() { nombreDelCurso = "SPD" }
			};

            


			foreach (var i in escuelas.cursos)
			{
				Console.WriteLine(i.nombreDelCurso + "\n");
				
			}


            */




			/*
             * arrayList/colecciones
             */



            // agrego cosas a un arraylist
			//escuelas.cursos.Add(new Curso() { nombreDelCurso = "carpinteria" });
			// borro todo
			//escuelas.cursos.Clear();

            //asi borro un elemento de la lista , haciendo una consulta tna compleja como yo quiera con && o ||
			//escuelas.cursos.RemoveAll((cur) => cur.nombreDelCurso == "carpinteria");

			/*foreach (var i in escuelas.cursos)
            {
                Console.WriteLine(i.nombreDelCurso + "\n");

            }*/


        }
    }
}
