


using System.Collections.Generic;

public class Escuela
{


    
    public Escuela(){

    }

    public string nombre
    {
        get;set;
    }
    public int anoDeCreacion
    {
        get;set;
    }
    public string paisDeLaEscuela
    {
        get;set;
    }

    public TipoDeEscuelas tipoDeEscuelas
    {
        get;set;
    }

	//public Curso[] cursos { get; set; }
	public List<Curso> cursos { get; set; }


    public override string ToString(){


        return "Nombre del colegio: " + this.nombre + "\nAño de creacion de la escuela: " + 
            this.anoDeCreacion + "\nPais de origen de la escuela: " + this.paisDeLaEscuela +
             "\nEl tipo de la escuela es: " + this.tipoDeEscuelas;

    }









}
