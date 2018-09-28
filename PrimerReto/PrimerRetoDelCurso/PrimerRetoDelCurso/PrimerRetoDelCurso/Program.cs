using System;
using PrimerRetoDelCurso.Clases;

namespace PrimerRetoDelCurso
{
    class Program
    {
        static void Main(string[] args)
        {
			var escuela = new Escuela("Normal 8", "San juan 2643");

			escuela.showMenu(escuela);
        }
    }
}
