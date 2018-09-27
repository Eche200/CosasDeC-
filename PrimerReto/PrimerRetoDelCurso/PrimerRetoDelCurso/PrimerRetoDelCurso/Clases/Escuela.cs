using System;
using System.Collections.Generic;

namespace PrimerRetoDelCurso.Clases
{
    public class Escuela
    {


		public string nombreDeLaEscuela { get; set; }
		public string direccionDeLaEscuela { get; set; }
		public List<Cursos> curso {  get;  set; }


        

		public Escuela()
        {
			
        }


		public void imprimirNombre(){
			Console.WriteLine(this.nombreDeLaEscuela);
            
		}


        
		public int generadorDeNuevoCurso(Escuela escuela){
			int retorno = 0;
            
            
			Console.WriteLine("Porfavor escriba el nombre del curso.\n");
			var nombreDelCurso = Console.ReadLine();
			escuela.curso = new List<Cursos>()
			{
				new Cursos(){ nombreDelCurso = nombreDelCurso}
			};




			return retorno;
		}

        //estoy aca
		public void showMenu()
		{
			var escuela = new Escuela();
			string respuesta = "s";
			Console.WriteLine("Bienvenido al programa de gestion escolar.\n");
			do
			{
				Console.WriteLine("¿Que operacion dese realizar?\n" +
				                  "1-Crear un curso nuevo.\n" +
				                  "2-Asignar Alumnos a un curso.\n" +
				                  "3-Asignar Materias a un curso.\n" +
				                  "4-Insertar notas en una materia.");

				var opcion = Console.ReadLine();

				switch (opcion)
				{
					case "1":
						generadorDeNuevoCurso(escuela);
						break;





				}
				Console.WriteLine("¿Quiere realizar alguna operacion mas?." +
				                  "<s/n>");
				respuesta = Console.ReadLine();
				respuesta = respuesta.ToLower();
			} while (respuesta == "s");

			Console.WriteLine(escuela.curso[0].nombreDelCurso);


		}






    }
}
