namespace Practica10;

public class Curso 
{   
    static int contadorId = 0;
    public int cursoId { get; set; }
    public string titulo { get; set; }
    
    public Curso (string titulo)
    {
        this.cursoId = ++contadorId;
        this.titulo = titulo;   

    }
}
