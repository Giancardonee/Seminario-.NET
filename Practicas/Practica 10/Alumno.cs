namespace Practica10;
public class Alumno 
{
    public static int contadorId=0; 
    public int idAlumno {get; private set;}
    public string nombre {get; set;}    

    public Alumno (string nombre)
    {
        this.nombre = nombre;
        idAlumno = ++contadorId;
    }

    
}
