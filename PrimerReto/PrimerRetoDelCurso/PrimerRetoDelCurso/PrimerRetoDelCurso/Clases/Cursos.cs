using System;
using System.Collections.Generic;

namespace PrimerRetoDelCurso.Clases
{
    public class Cursos
    {
		
		public int isEmpty;
		public string nombreDelCurso{ get; set; }
		public string division{ get; set; }
		public List<Asignaturas> asignatura{ get; set; }
		public List<Alumnos> alumnado { get; set; }
  



		public Cursos( )
        {
			
            
        }

        /*************************************************************/

        /*
         * le paso como parametro un objeto de tipo escuela , y el curso en
         * el cual quiere asignar un alumno
         * luego asigna al alumno a ese curso 
         * retorna 0 si esta bien , -1 si esta mal 
        */
		public int asignarAlumnosAlCurso (Escuela escuela , int cursoElegido)
		{
			int retorno = -1;         
			if( escuela.cursos != null)
			{
                Console.WriteLine("Porfavor escriba el nombre del alumno.\n");
                var nombreDelAlumno = Console.ReadLine();
                Console.WriteLine("Porfavor escriba el apellido del alumno.\n");
                var apellidoDelAlumno = Console.ReadLine();
                Console.WriteLine("Porfavor escriba el DNI del alumno.\n");
                var dniDelAlumno = Convert.ToInt32(Console.ReadLine());
                if (escuela.cursos[cursoElegido].alumnado == null)
                {
                    escuela.cursos[cursoElegido].alumnado = new List<Alumnos>()
                    {
                        new Alumnos()
                        {
                            nombreDelAlumno = nombreDelAlumno,
                            apellidoDelAlumno = apellidoDelAlumno,
                            dniDelAlumno = dniDelAlumno
                        }
                    };
                }
                else
                {
                    escuela.cursos[cursoElegido].alumnado.Add(new Alumnos()
                    {
                        nombreDelAlumno = nombreDelAlumno,
                        apellidoDelAlumno = apellidoDelAlumno,
                        dniDelAlumno = dniDelAlumno
                    });
                }
                retorno = 0;
            }         
            return retorno;
        }
        /******************/








    }
}
