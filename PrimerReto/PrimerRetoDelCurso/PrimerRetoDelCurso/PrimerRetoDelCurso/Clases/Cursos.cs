using System;
using System.Collections.Generic;

namespace PrimerRetoDelCurso.Clases
{
    public class Cursos
    {
		public string nombreDelCurso{ get; set; }
		public string division{ get; set; }
		public List<Asignaturas> asignatura{ get; set; }
		public List<Alumnos> alumnado { get; set; }
  



		public Cursos( )
        {
			
            
        }



    }
}
