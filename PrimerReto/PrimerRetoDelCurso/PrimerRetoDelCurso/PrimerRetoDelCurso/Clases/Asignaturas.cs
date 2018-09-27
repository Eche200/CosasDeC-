using System;
using System.Collections.Generic;

namespace PrimerRetoDelCurso.Clases
{
    public class Asignaturas
    {

		public string nombreDeLaMateria { get; set; }
		public string profesor{ get; set; }
		public List<Evaluaciones> evaluacionesDeAlumnos{ get; set; }




        public Asignaturas()
        {
        }
    }
}
