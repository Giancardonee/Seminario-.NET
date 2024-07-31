namespace Clases;

public class Pelicula : IAlquilable
{
    public virtual void SeAlquila(Persona p) => Console.WriteLine("Alquilando pelicula a persona"); 
    public virtual void SeDevuelve(Persona p) => Console.WriteLine("Pelicula devuelta por persona");
}
