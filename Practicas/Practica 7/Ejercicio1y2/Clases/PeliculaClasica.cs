namespace Clases;

public class PeliculaClasica :Pelicula, IVendible
{
    public override void  SeAlquila(Persona p) => Console.WriteLine("Alquilando pelicula clasica a persona.");
    public override void SeDevuelve(Persona p) => Console.WriteLine("Pelicula clasica devuelta por persona."); 

    public void SeVende(Persona p) => Console.WriteLine("Vendiendo pelicula clasica a persona");
}
