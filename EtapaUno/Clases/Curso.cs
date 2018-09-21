using System;

public class Curso
{
    public string identificadorDelCurso{get;set;}
    public string nombreDelCurso{get;set;}
    public TipoDeJornadas jornadaDelCurso{get;set;}



    public Curso(){
        identificadorDelCurso = Guid.NewGuid().ToString();
    }
        
}
