namespace Clases;

public class Libro : IAlquilable, IReciclable
{
    public void SeAlquila(Persona p) => Console.WriteLine("Alquilando libro a persona"); 
    public void SeDevuelve(Persona p) => Console.WriteLine("Libro devuelto por persona");
    public void SeRecicla() => Console.WriteLine("Reciclando libro");
    
}
