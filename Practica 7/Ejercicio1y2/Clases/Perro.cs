namespace Clases;

public class Perro : IVendible, IAtendible, ILavable
{
    public void SeVende(Persona p) => Console.WriteLine("Vendiendo perro a persona");
    public void SeAtiende()=> Console.WriteLine("Atendiendo a perro");
    public void SeLava()=> Console.WriteLine("Lavando perro");
    public void SeSeca() => Console.WriteLine("Secando perro");
}
