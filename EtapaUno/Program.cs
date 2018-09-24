using System;

namespace EtapaUno
{
    class Program
    {
		static void Main(string[] args)
		{
            
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


            

        }
    }
}
