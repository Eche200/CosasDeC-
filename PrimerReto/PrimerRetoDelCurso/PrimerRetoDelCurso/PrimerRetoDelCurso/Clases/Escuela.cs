using System;
using System.Collections.Generic;

namespace PrimerRetoDelCurso.Clases
{
    public class Escuela
    {
		public string nombreDeLaEscuela { get; set; }
		public string direccionDeLaEscuela { get; set; }
		public List<Cursos> cursos {  get;  set; }
		public Escuela(string nombreDeLaEscuela,string direccionDeLaEscuela)
        {
			this.nombreDeLaEscuela = nombreDeLaEscuela;
			this.direccionDeLaEscuela = direccionDeLaEscuela;
        }
        //esto anda
        // retorna 0 si esta bien , retorna -1 si esta mal los parametros
        //como parametro hay que pasar un objeto de tipo escuela
		public int generadorDeNuevoCurso(Escuela escuela ){
			int retorno = -1;
			if(escuela != null)
			{
				
                Console.WriteLine("Porfavor escriba el nombre del curso.\n");
                var nombreDelCurso = Console.ReadLine();
                Console.WriteLine("Porfavor escriba la division del curso.\n");
                var divisionDelCurso = Console.ReadLine();
                if(escuela.cursos == null)
                {
                    escuela.cursos = new List<Cursos>()
                    {
                        new Cursos(){ nombreDelCurso = nombreDelCurso ,
                            isEmpty = 0,
                            division = divisionDelCurso
						}
                    };
                }else
				{
                    escuela.cursos.Add(new Cursos()
                    {
                        nombreDelCurso = nombreDelCurso,
                        isEmpty = 0,
                        division = divisionDelCurso
                    });
                }
				retorno = 0;
			}
			return retorno;
		}
        //*****************************************

        public int listarCursos(Escuela escuela)
		{
			int retorno = 1;
			int i;
			if( escuela != null)
			{
				for (i = 0; i < escuela.cursos.Count; i++)
				{
					Console.WriteLine("\n" + i + " Curso: " + escuela.cursos[i].nombreDelCurso);
                    
                }
				retorno = 0;
			}

			return retorno;
		}
        /*************************************/




        
        //estoy aca
		public void showMenu(Escuela escuela)
		{
			int eleccionDeCurso;
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
					case "2":
						escuela.listarCursos(escuela);
                        Console.WriteLine("Porfavor ingrese el numero del curso que desea agregar alumnos.\n");
						eleccionDeCurso = Convert.ToInt32(Console.ReadLine());
						for (int i = 0; i < escuela.cursos.Count; i++)
						{
							if( i == eleccionDeCurso)
							{
								escuela.cursos[eleccionDeCurso].asignarAlumnosAlCurso(escuela , i);
								//Console.WriteLine("\nEl nombre del alumno es: " + escuela.cursos[eleccionDeCurso].alumnado[0].nombreDelAlumno);
								break;
                            }
                        }                  
						break;
                        
                    

				}
				Console.WriteLine("¿Quiere realizar alguna operacion mas?." +
				                  "<s/n>");
				respuesta = Console.ReadLine();
				respuesta = respuesta.ToLower();
			} while (respuesta == "s");







			//asi imprimo el nombre del curso
			 // Console.WriteLine(escuela.cursos[1].nombreDelCurso);

		}






    }
}
