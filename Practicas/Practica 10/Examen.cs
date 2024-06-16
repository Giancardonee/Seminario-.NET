namespace Practica10;

public class Examen
{
    public int alumnoId {get; set;}

    public double nota {get; set;}
    public int cursoId {get; set;}

    public Examen (int alumnoId, double nota, int cursoId)
    {
        this.alumnoId = alumnoId;
        this.nota = nota;
        this.cursoId = cursoId;
    }
}
