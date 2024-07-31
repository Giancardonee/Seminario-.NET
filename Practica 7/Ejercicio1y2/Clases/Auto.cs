namespace Clases;

public class Auto : IVendible, ILavable, IReciclable
{
    public void SeVende(Persona p) => Console.WriteLine("Vendiendo auto a persona");
    public void SeLava() => Console.WriteLine("Lavando auto");
    public void SeSeca() => Console.WriteLine("Secando auto");
    public void SeRecicla() => Console.WriteLine("Reciclando auto"); 
    
}
