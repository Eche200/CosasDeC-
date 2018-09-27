using System;
using System.Collections.Generic;

namespace EtapaUno.App
{
    public class EscuelaMotor
    {

		public Escuela escuela { get; set; }



        


        public EscuelaMotor()
        {
			
        }


        public void inicializar()
		{
			var escuelas = new Escuela();
			escuelas.cursos = new List<Curso>(){
                new Curso() { nombreDelCurso = "programacion"},
                new Curso() { nombreDelCurso = "programacion2"},
                new Curso() { nombreDelCurso = "programacion3"}

            };
		    	
		}



    }
}
